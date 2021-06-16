using DownloadManager.UserControls;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Classes
{
    public class DownloadList
    {
        //Sınıfımızda Singleton desenini uyguluyorum.
        protected static DownloadList instance = null;
        static object _lock = new object();
        List<ucDownloader> downloads = null;
        private DownloadList()
        {
            downloads = new List<ucDownloader>();
        }
        public static DownloadList Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        instance = new DownloadList();
                    }
                }
                return instance;
            }
        }

        public void LoadDownloads()
        {
            //Veritabanından tüm download işlemleri yükleniyor.
            OleDbDataReader reader = Helper.ExecuteReader("select DownloadType, DownloadState, StartDate, EndDate, TempFileName, FileName, FileUrl, OutputPath,DownloadRate from Downloads");
            while (reader.Read())
            {
                ucDownloader downloader = new ucDownloader()
                {
                    DownloadType = (DOWNLOAD_TYPE)reader.GetInt32(0),
                    DownloadState = (DOWNLOAD_STATE)reader.GetInt32(1),
                    StartDate = reader.GetDateTime(2),
                    EndDate = reader.GetDateTime(3),
                    TempFileName = reader.GetString(4),
                    FileName = reader.GetString(5),
                    FileUrl = reader.GetString(6),
                    OutputPath = reader.GetString(7),
                    DownloadRate = reader.GetInt32(8)
                };
                downloads.Add(downloader);
                if (downloader.DownloadType == DOWNLOAD_TYPE.Old)
                {
                    //Eğer daha önce bir kısmı yüklenmiş bir download ise kaldığı yerden 
                    //indirme işlemini başlatıyorum.
                    downloader.Start();
                    //Eğer önceki download işlemi son olarak Pause modda bırakıldıysa
                    //download yüklenir yüklenmez hemen Pause ediyorum.
                    if (downloader.DownloadState == DOWNLOAD_STATE.Pause)
                    {
                        downloader.Pause();
                    }
                }
            }
            reader.Close();
        }

        public void Add(ucDownloader downloader)
        {
            //Mevcut Download işlemlerine yeni bir Download eklemek için bu metod çağrılır.
            downloads.Add(downloader);
            //Aynı download bilgilerini veritabanına da ekliyorum.
            Helper.ExecuteNonQuery(string.Format("insert into Downloads (DownloadType, DownloadState, StartDate, EndDate, TempFileName, FileName, FileUrl, OutputPath,DownloadRate) values({0},{1},'{2}','{3}','{4}','{5}','{6}','{7}',{8})", (int)downloader.DownloadType, (int)downloader.DownloadState, downloader.StartDate, downloader.EndDate, downloader.TempFileName, downloader.FileName, downloader.FileUrl, downloader.OutputPath, downloader.DownloadRate));
        }

        public void Save()
        {
            //Uygulama sonlandırılırken tüm downloadların mevcut durumlarını güncelliyorum.
            foreach (ucDownloader downloader in downloads)
            {
                //Eğer tamamlanmış bir download değilse kaldığı yerde download işlemini
                //sonradan devam etmek üzere sonlandırıyorum.
                if (downloader.DownloadType != DOWNLOAD_TYPE.Complated)
                    downloader.Cancel();
                //Download işleminin son durumunu veritabanında güncelliyorum.
                Helper.ExecuteNonQuery(string.Format("update Downloads set DownloadType={0},DownloadState={1} where FileName='{2}'", (int)downloader.DownloadType, (int)downloader.DownloadState, downloader.FileName));
            }
        }
        //Tamamlanan Download işlemlerini yüklüyorum.
        public List<ucDownloader> GetComplatedDownloads()
        {
            List<ucDownloader> complatedDownloads = new List<ucDownloader>();
            foreach (ucDownloader downloader in downloads)
            {
                if (downloader.DownloadType == DOWNLOAD_TYPE.Complated)
                    complatedDownloads.Add(downloader);
            }
            return complatedDownloads;
        }
        //Tamamlanmamış Download işlemlerini yüklüyorum.
        public List<ucDownloader> GetNotComplatedDownloads()
        {
            List<ucDownloader> notComplatedDownloads = new List<ucDownloader>();
            foreach (ucDownloader downloader in downloads)
            {
                if (downloader.DownloadType != DOWNLOAD_TYPE.Complated)
                    notComplatedDownloads.Add(downloader);
            }
            return notComplatedDownloads;
        }

    }
}
