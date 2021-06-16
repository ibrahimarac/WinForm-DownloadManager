using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Classes
{
    public class DownloadComplatedEventargs:EventArgs
    {
        string fileName;DateTime startDate;
        DateTime endDate;
        public DownloadComplatedEventargs(string fileName,DateTime startDate,DateTime endDate)
        {
            this.fileName = fileName;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        public string FileName
        {
            get { return fileName; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
        }
    }
}
