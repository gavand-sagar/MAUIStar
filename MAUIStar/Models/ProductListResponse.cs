using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Models
{
    public class ProductListResponse
    {
        public List<Product> Products { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
