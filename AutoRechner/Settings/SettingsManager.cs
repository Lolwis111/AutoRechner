using AutoRechner.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRechner
{
    public class SettingsManager
    {
        public List<string> Users { get; }

        public bool Einberechnen { get; set; }

        public int SortByColumnCarSelect { get; set; }
        public int SortByColumnItemSelect { get; set; }

        public Address SellerAddress { get; set; }

        public SettingsManager()
        {
            Users = new List<string>();
            Einberechnen = true;
            SortByColumnCarSelect = -1;
            SortByColumnItemSelect = -1;
        }
    }
}
