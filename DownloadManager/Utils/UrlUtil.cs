using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Utils
{
    public class UrlUtil
    {
        //Kendisine gönderilen dosya adında yer alan noktaları kaldıran
        //ve yeni dosya adını üreten metod
        public static string GetFileNameWithoutDot(string path)
        {
            return
                string.Format("{0}{1}", Path.GetFileNameWithoutExtension(path).Replace(".", ""), Path.GetExtension(path));
        }
    }
}
