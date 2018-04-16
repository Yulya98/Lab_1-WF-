using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2__WindowsForms
{
    partial class String
    {
        public void StringSorted(bool valueForSortingOrder)
#region
        {
            RedirectListClear(this.redirectList);
            if (valueForSortingOrder)
            {
                this.newList.Sort();
                foreach (string str in newList)
                    redirectList.Add(str);
            }
            else
            {
                this.newList.Sort();
                this.newList.Reverse();
                foreach (string str in newList)
                    redirectList.Add(str);
            }
        }
#endregion
    }
}
