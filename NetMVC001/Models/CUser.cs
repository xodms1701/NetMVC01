using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetMVC001.Models
{
    public class CUser
    {
        public int theUniqueID { get; set; }
        public string theID { get; set; }
        public string thePW { get; set; }

        public string theName { get; set; }
        public string theEmail { get; set; }
        public bool bSubscription { get; set; }

        public DateTime theDate { get; set; }
    }
}