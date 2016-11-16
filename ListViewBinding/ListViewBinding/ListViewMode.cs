using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewBinding
{
    class ListViewMode
    {
        public ListViewMode()
        {
           
        }
        public ListViewMode(String btName)
        {
            this.BtName = btName;
        }
        public string BtName { get; set; }
        public static IEnumerable<ListViewMode> All { get; set; }
    

    }
}
