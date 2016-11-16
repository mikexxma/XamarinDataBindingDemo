using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewBinding
{
    class ListViewDataManager
    {
        public static void getListViewItems()
        {

            List<ListViewMode> listViewItems = new List<ListViewMode>();
            listViewItems.Add(new ListViewMode("first"));
            listViewItems.Add(new ListViewMode("second"));
            listViewItems.Add(new ListViewMode("thrid"));
            ListViewMode.All = listViewItems;
          
        }
    }
}
