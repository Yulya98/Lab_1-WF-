using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab_1_2__WindowsForms
{
    public delegate void Comparator(bool valueForSortingOrder);
    public partial class String
    {
        public List<string> newList;
        public List<string> redirectList;
        public String()
        {
            this.newList = new List<string>();
            this.redirectList = new List<string>();
        }
        public static void RedirectListClear(List<string> obj)
        {
            if (obj.Count != 0)
                obj.Clear();
        }
    }
}

