using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Models
{
    public class MyFile
    {
        public string _id { get; set; }
        public int length { get; set; }
        public int chunkSize { get; set; }
        public DateTime uploadDate { get; set; }
        public string filename { get; set; }
        public string contentType { get; set; }
        public string fileUrl
        {
            get
            {
                return $"https://tempfileserver.onrender.com/files/{_id}/download";
            }
        }
    }
}
