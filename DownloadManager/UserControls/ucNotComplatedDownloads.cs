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
    public partial class ucNotComplatedDownloads : UserControl
    {
        //Tamamlanmayan Download'ları yükleyelim.
        void LoadNotComplatedDownloads()
        {
            List<ucDownloader> downloads = DownloadList.Instance.GetNotComplatedDownloads();
            foreach (ucDownloader item in downloads)
            {
                //Devam eden indirme işlemleri için Download için kullanılan controlüm yükleniyor
                flowNotComplatedDownloads.Controls.Add(item);
                item.Dock = DockStyle.Top;
            }
        }
        public ucNotComplatedDownloads()
        {
            InitializeComponent();
            //Tamamlanmayan download'lar yükleniyor
            LoadNotComplatedDownloads();
        }
    }
}
