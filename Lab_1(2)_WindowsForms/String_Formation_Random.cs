using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2__WindowsForms
{
    partial class String
    {
        static Random random = new Random();
        public void RandomString(int size)
        #region
        {
            if (newList.Count != 0)
                newList.Clear();
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int j = 1; j <= size; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
                this.newList.Add(builder.ToString());
                builder.Clear();
            }
        }
       #endregion
    }
}
