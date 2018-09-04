using System;
using System.Collections.Generic;
using System.Text;

namespace ADOCRUDApplication.Models
{
    public class SearchProperties
    {
        public string SearchValue { set; get; }
        public int CategoryID { set; get; }
        public int Min { set; get; }
        public int Max { set; get; }
    }
}
