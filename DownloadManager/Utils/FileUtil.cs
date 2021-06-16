using DownloadManager.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Utils
{
    public class FileUtil
    {
        public static string GenerateFileNameIfExist(string outputPath,string fileName,string tempExtension,DOWNLOAD_TYPE downType)
        {
            //ucDownloader'dan gelen bilgilere göre geçici dosya adı ürettim.
            string generatedFileName=string.Format(@"{0}\{1}.{2}",outputPath,
                fileName,tempExtension);
            //Eğer bu isimde bir geçici dosya varsa ve 
            //bu yeni bir indirme işlemi ise yeni bir dosya ismi üretmeliyim.
            if(File.Exists(generatedFileName)&&downType==DOWNLOAD_TYPE.New)
            {
                for (int i = 0; i < 20; i++)
                {
                    generatedFileName = string.Format(@"{0}\{1}_{2}.{3}",  outputPath,fileName , i, tempExtension);
                    if (!File.Exists(generatedFileName))
                        break;
                }
            }
            return generatedFileName;
        }
    }
}
