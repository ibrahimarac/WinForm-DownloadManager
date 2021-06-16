using DownloadManager.Classes;
using DownloadManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class frmNewDownload : Form
    {
        public frmNewDownload()
        {
            InitializeComponent();
            InitializeControls();
        }

        void InitializeControls()
        {
            //Properties'lerde saklanan varsayılan indirme hızının
            //açılır kutu içerisindeki hangi elemana karşılık geldiğini buluyorum.
            int downloadRate = Properties.Settings.Default.BufferLength;
            int selectedIndex = cmbDownloadRate.Items.IndexOf(downloadRate.ToString());
            //İlgili elemanın combobox içerisinden seçili hgale getirilmesini sağladım.
            cmbDownloadRate.SelectedIndex = selectedIndex;

            //Kayıt yeri default olarak Belgelerim\Downloads olarak ayarlanıyor
            string outputPath = string.Format(@"{0}\Downloads", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            //Metin kutusuna varsayılan kayıt yerini atıyoruz.
            txtOutputPath.Text = outputPath;
            //Eğer kayıt yerinde klasör yoksa oluştur (Downloads klasörü)
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
        }
        
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            //Eğer farklı bir klasör seçildiyse seçili yolun bilgisini
            //metin kutusunda görüntülüyorum.
            if (result == DialogResult.OK)
            {
                txtOutputPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        void CreateDownload()
        {
            ucDownloader downloader = new ucDownloader()
            {
                FileUrl = txtFileUrl.Text,
                OutputPath = txtOutputPath.Text,
                DownloadRate = Convert.ToInt32(cmbDownloadRate.SelectedItem.ToString())
            };
            
            downloader.Start();
            //Eğer download eklenirken Hemen Başlasın seçeneği işaretli değilse
            //download eklenmiş hazır beklemektedir. Pause durumuna geçirelim.
            if (!chcStart.Checked)
            {
                downloader.Pause();
            }
            DownloadList.Instance.Add(downloader);
        }

        private void btnAddDownload_Click(object sender, EventArgs e)
        {
            try
            {
                CreateDownload();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu! Hata : "+ex.Message);
            }

        }
    }
}
