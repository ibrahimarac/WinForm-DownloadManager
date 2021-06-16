using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using DownloadManager.Classes;
using System.Threading;
using DownloadManager.Properties;

namespace DownloadManager.UserControls
{
    public enum DOWNLOAD_TYPE
    {
        New, Old, Complated
    }
    public enum DOWNLOAD_STATE
    {
        Start, Pause
    }
    public partial class ucDownloader : UserControl
    {
        public ucDownloader()
        {
            InitializeComponent();
        }

        BackgroundWorker bwDownloader;
        string fileUrl, outputPath, fileName, tempFileName;
        DOWNLOAD_STATE downloadState;
        DOWNLOAD_TYPE downloadType;
        DateTime startDate, endDate;
        int downloadRate;
        //İndirme Hızı kaç byte'lık katarlar halinde olacak
        public int DownloadRate
        {
            get { return downloadRate; }
            set { downloadRate = value; }
        }
        //backgroundWorker'ın çalışmasını duraklatabilmek
        //ve kaldığı yerden tekrar devam edebilmesini sağlamak için kullanılacak
        //Başlangıçta aktif olmayacağından kurucuda true verildi.
        ManualResetEvent _lock = new ManualResetEvent(true);
        public DOWNLOAD_STATE DownloadState
        {
            get { return downloadState; }
            set { downloadState = value; }
        }
        public DOWNLOAD_TYPE DownloadType
        {
            get { return downloadType; }
            set { downloadType = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        //İndirilen dosyanın adresi "http://www.ubuntu.org/ubuntu.12.01.iso"
        //şeklindeyse "ubuntu.12.01.part"
        public string TempFileName
        {
            get { return tempFileName; }
            set
            {
                //UrlUtil sınıfına yazılan metod yardımıyla dosya adında yer alan 
                //"." lar kaldırılıyor.
                tempFileName = Utils.UrlUtil.GetFileNameWithoutDot(value);
            }
        }
        //İndirilen dosyanın adresi "http://www.ubuntu.org/ubuntu.12.01.iso"
        //şeklindeyse "ubuntu.12.01.iso"
        public string FileName
        {
            get { return fileName; }
            set
            {
                //UrlUtil sınıfına yazılan metod yardımıyla dosya adında yer alan 
                //"." lar kaldırılıyor.
                fileName = Utils.UrlUtil.GetFileNameWithoutDot(value);
            }
        }
        //Dosyanın kaydedileceği klasör kontrol ediliyor.
        //C:\Belgelerim\Downloads
        public string OutputPath
        {
            get { return outputPath; }
            set
            {
                if (Directory.Exists(value))
                    outputPath = value;
                else
                    throw new Exception("Verdiğiniz kayıt yeri geçerli değil!");
            }
        }
        //İndirme adresi kontrol ediliyor
        public string FileUrl
        {
            get
            {
                return fileUrl;
            }
            set
            {
                //Eğer url adresi uygun bir formatta ise
                if (Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute))
                {
                    fileUrl = value;
                }
                else
                {
                    throw new Exception("Verilen adres uygun bir url adresi değil!");
                }
            }
        }

        //İndirme işlemi için FileName, TempFileName hazırlanıyor
        public void InitializePath()
        {
            //FileUrl "http://www.ubuntu.org/ubuntu.12.01.iso" gibi birşey
            Uri uri = new Uri(FileUrl);
            //FileName üretiliyor.
            FileName = Path.GetFileName(uri.LocalPath);

            //TempFileName üretiliyor
            TempFileName = Utils.FileUtil.GenerateFileNameIfExist(this.OutputPath, Path.GetFileNameWithoutExtension(FileName), Properties.Settings.Default.TempExtension, this.DownloadType);
        }

        public void InitializeWorker()
        {
            //BackgroundWorker hazırlanıyor.
            bwDownloader = new BackgroundWorker();
            bwDownloader.DoWork += bwDownloader_DoWork;
            bwDownloader.ProgressChanged += bwDownloader_ProgressChanged;
            bwDownloader.RunWorkerCompleted += bwDownloader_RunWorkerCompleted;
            bwDownloader.WorkerReportsProgress = true;
            bwDownloader.WorkerSupportsCancellation = true;
        }

        FileStream fs = null;
        void bwDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            //Talep oluşturuluyor
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(FileUrl);
            //Alınan toplam byte miktarı
            long totalBytesReceived = 0;
            //Karşıdaki dosyanın toplam boyutu
            long contentLength = 0;
            //Eğer indirme işlemi devam eden bir indirme işlemi ise dosyayı Append modda açıyorum.
            if (DownloadType == DOWNLOAD_TYPE.Old)
            {
                //FileStream geçici dosya ile (part dosyası) ilişkilendiriliyor.
                fs = new FileStream(string.Format(@"{0}\{1}", this.OutputPath, this.TempFileName), FileMode.Append);
                totalBytesReceived = fs.Length;
                //Sunucudan cevap alınıyor
                contentLength = request.GetResponse().ContentLength;
                //Daha önce bu indirmenin bir kısmı tamamlandığı için
                //talebimi indirilmeyen kısmın başına konumlandırıyorum.
                request.AddRange(fs.Length);
            }
            else if (DownloadType == DOWNLOAD_TYPE.New)
            {
                //Yeni bir indirme işlemi ise
                fs = new FileStream(string.Format(@"{0}\{1}", this.OutputPath, this.TempFileName), FileMode.Create);
                //Artık indirme başladığına göre DownloadType'ı Old yapıyorum. Çünkü
                //artık bu indirme eski bir indirme olarak değerlendirilmelidir.
                DownloadType = DOWNLOAD_TYPE.Old;
            }
            //Aşağıdaki buffer boyutu kadarlık byte'lar halinde indirmeyi gerçekleştiriyorum.
            byte[] buffer = new byte[DownloadRate];
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            int openedBytesLength = 0;
            //Aşağıdaki while döngüsü ile her defasında response'dan
            //buffer kadarlık byte'lar çekiyorum.
            while ((openedBytesLength = responseStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                //Eğer download işlemi iptal edildiyse uygulama sonlandırılmaktadır.
                //FileStream kapatılıyor ve RunWorkerCompleted olayında download işleminin 
                //iptal edilebilmesini sağlıyoruz. aşağıdaki şartın sağlanabilmesi için
                //CancelAsync metodu worker üzerinden çağrılmalıdır.
                if (bwDownloader.CancellationPending)
                {
                    e.Cancel = true;
                    fs.Close();
                    break;
                }
                totalBytesReceived += openedBytesLength;
                fs.Write(buffer, 0, openedBytesLength);
                fs.Flush();
                //Burada set ettiğimiz değer aslında ProgressChanged olayında alacağımız değer olacak
                bwDownloader.ReportProgress(Convert.ToInt32((totalBytesReceived * 100) / response.ContentLength));
                _lock.WaitOne(Timeout.Infinite);
            }
        }

        void bwDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Eğer worker işlemi iptal edildiyse Complated metodu çalıştırılmasın. 
            //Aşağıdaki satır download işlemleri devam ederken uygulama kapatılırsa 
            //worker iptal edilecek ve true üretecektir. dosya açık kalmasın.
            if (e.Cancelled)
            {
                fs.Dispose();
                return;
            }
            //Download işlemi tamamlandığına göre stream kapatılabilir.
            fs.Close();
            //İndirilecek dosyanın gerçek uzatısı
            string realExtension = Path.GetExtension(this.FileUrl);
            //İndirilen dosyanın sahip olması gereken yol ve dosya adı bilgisi
            string newFilePath = string.Format(@"{0}\{1}{2}", this.OutputPath, this.TempFileName, realExtension);
            //Geçici dosyanın yol ve dosyaadı bilgisi
            string tempFilePath = string.Format(@"{0}\{1}", this.OutputPath, this.TempFileName);
            //Part uzantılı dosyayı aynı dizine gerçek uzantısı ile taşımış oldum.
            File.Move(tempFilePath, newFilePath);

            //Download işleminin bitiş tarihi set ediliyor
            this.EndDate = DateTime.Now;
            //Download işlemi Complated durumuna geçiriliyor
            this.DownloadType = DOWNLOAD_TYPE.Complated;

            OnDownloadComplated(new DownloadComplatedEventargs(this.FileName, this.StartDate, this.EndDate));
        }

        void bwDownloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 100)
                progressDownloader.Value = 100;
            else
                progressDownloader.Value = e.ProgressPercentage;
            lblPercentage.Text = "% " + progressDownloader.Value;
        }


        //Complated eventı için delegate ve event tanımlarımı yapıyorum.
        public delegate void DownloadComplatedHandler(object sender, DownloadComplatedEventargs e);
        public event DownloadComplatedHandler DownloadComplate;
        public virtual void OnDownloadComplated(DownloadComplatedEventargs e)
        {
            //Kullanıcı DownloadComplate olayına bir metod bağladıysa
            if (DownloadComplate != null)
            {
                DownloadComplate(this, e);
            }
        }
        public void Start()
        {
            //Eğer daha önceki bir indirme devam edecekse o zaman
            //Path ve Başlangıç tarihi zaten bellidir.
            //Yeni bir indirme için bu değerler belli değildir.
            if (this.DownloadType == DOWNLOAD_TYPE.New)
            {
                //TempFileName ve FileName bilgileri set ediliyor.
                InitializePath();
                //Download işleminin başlama zamanı ayarlanıyor.
                this.StartDate = DateTime.Now;
            }
            //Worker hazırlanıyor.
            InitializeWorker();
            //Dosyanın adı label'a yazılıyor
            lblFileName.Text = this.FileName;
            //Worker başlatılıyor.
            bwDownloader.RunWorkerAsync();
            //Buton Pause edilebilir duruma getiriliyor.
            btnPauseContinue.BackgroundImage = Resources.pause;
        }
        //Download işlemini duraklat.
        public void Pause()
        {
            //BackgroundWorker'ı duraklat
            _lock.Reset();
            this.DownloadState = DOWNLOAD_STATE.Pause;
            btnPauseContinue.BackgroundImage = Resources.play;
        }
        //Kaldığı yerden devam et.
        public void Continue()
        {
            //BackgroundWorker devam etsin
            _lock.Set();
            this.DownloadState = DOWNLOAD_STATE.Start;
            btnPauseContinue.BackgroundImage = Resources.pause;
        }
        //Download işlemini sonlandır.
        public void Cancel()
        {
            bwDownloader.CancelAsync();
        }

        private void btnPauseContinue_Click(object sender, EventArgs e)
        {
            if (this.DownloadState == DOWNLOAD_STATE.Pause)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
}
