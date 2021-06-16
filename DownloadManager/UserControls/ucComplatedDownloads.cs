using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DownloadManager.Classes;

namespace DownloadManager.UserControls
{
    public partial class ucComplatedDownloads : UserControl
    {
        //Tamamlanan Download'ları yükleyelim.
        void LoadComplatedDownloads()
        {
            List<ucDownloader> downloads = DownloadList.Instance.GetComplatedDownloads();
            foreach (ucDownloader item in downloads)
            {
                int index = listComplatedDownloads.Items.Count;
                //İlk eleman aşağıdaki gibi eklenir.
                listComplatedDownloads.Items.Add(item.FileUrl);                
                listComplatedDownloads.Items[index].SubItems.Add(item.StartDate.ToString());
                listComplatedDownloads.Items[index].SubItems.Add(item.EndDate.ToString());
                listComplatedDownloads.Items[index].SubItems.Add(item.DownloadRate.ToString());
                listComplatedDownloads.Items[index].SubItems.Add(item.OutputPath);
            }
        }
        public ucComplatedDownloads()
        {
            InitializeComponent();
            //Tamamlanan download'lar yükleniyor
            LoadComplatedDownloads();
        }
    }
}
