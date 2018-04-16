using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2__WindowsForms
{
    partial class String
    {
        public void LinqMax()
#region
        {
            RedirectListClear(this.redirectList);
            IEnumerable<string> request = from n in this.newList
                                          where n.Length == newList.Max(k => k.Length)
                                          select n;
            foreach (var s in request)
                this.redirectList.Add(s);
        }
        #endregion

        public void LinqMin()
#region
        {
            RedirectListClear(this.redirectList);
            IEnumerable<string> request = from n in this.newList
                                          where n.Length == newList.Min(k => k.Length)
                                          select n;
            foreach (var s in request)
                redirectList.Add(s);
        }
        #endregion
        public void LinqFirstChar()
#region
        {
            RedirectListClear(this.redirectList);
            IEnumerable<string> request = from n in this.newList
                                          where LinqContainCharP(n) == true
                                          select n;
            foreach (var s in request)
                this.redirectList.Add(s);
        }
        #endregion

        public bool LinqContainCharP(string str)
#region
        {
            bool k = false;
            if (str.Length > 0)
            {
                if (str.Contains("P"))
                    k = true;
            }
            return k;
        }
        #endregion
    }
}
