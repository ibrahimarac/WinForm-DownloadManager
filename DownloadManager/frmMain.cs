using DownloadManager.Classes;
using DownloadManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //TreeView'in düğümlerini açıyorum.
            treeMenu.ExpandAll();
            DownloadList.Instance.LoadDownloads();
        }

        private void treeMenu_DoubleClick(object sender, EventArgs e)
        {
            //TreeView'in nodlarının Tag özelliklerine aşağıdaki metinleri atadım. 
            //Böylece hangi değerin seçili olduğunu anlayabiliyorum.

            switch (treeMenu.SelectedNode.Tag.ToString())
            {
                case "new":
                    frmNewDownload frm = new frmNewDownload();
                    frm.ShowDialog();
                    break;
                case "complated":
                    tblMainContainer.Controls.Remove(tblMainContainer.GetControlFromPosition(1, 0));
                    ucComplatedDownloads complated = new ucComplatedDownloads();
                    tblMainContainer.Controls.Add(complated, 1, 0);
                    break;
                case "notcomplated":
                    tblMainContainer.Controls.Remove(tblMainContainer.GetControlFromPosition(1, 0));
                    ucNotComplatedDownloads notcomplated = new ucNotComplatedDownloads();
                    tblMainContainer.Controls.Add(notcomplated, 1, 0);
                    break;
                case "settings":
                    //Projenin Ayarlar kısmı henüz tamamlanmamıştır.
                    MessageBox.Show("Ayarlar menüsü henüz hazır değil.");
                    break;
                default:
                    break;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form kapatılırken mevcut Download bilgilerini kaydediyorum.
            DownloadList.Instance.Save();
        }
    }
}
