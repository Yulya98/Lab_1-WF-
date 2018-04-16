using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2__WindowsForms
{
    public partial class Form1 : Form
    {
        static String str = new String();
        Comparator dlegateForOrder = new Comparator(str.StringSorted);
        public Form1()
        {
            InitializeComponent();
        }
        // Button For Random
        #region
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                int size = Convert.ToInt32(textBox1.Text);
                str.RandomString(size);
            }
        }
        #endregion

        // Buttons For Sorted Functions
        #region
        private void button2_For_String_Direct_Sorted(object sender, EventArgs e)
        {
            if (CheckEmptyList())
                MessageBox.Show("Список пуст");
            else
            {
                dlegateForOrder(true);
                CallList_For_Linq_And_Direct_Sorting();
            }
        }

        private void button3_For_String_Reverse_Sorted(object sender, EventArgs e)
        {
            if (CheckEmptyList())
                MessageBox.Show("Список пуст");
            else
            {
                dlegateForOrder(false);
                CallList_Reverse();
            }
        }
        #endregion

        // Buttons For Linq Functions
        #region
        private void button4_Sorted_With_Max_Length_Value(object sender, EventArgs e)
        {
            if (CheckEmptyList())
                MessageBox.Show("Список пуст");
            else
            {
                str.LinqMax();
                CallList_For_Linq_And_Direct_Sorting();
            }
        }

        private void button5_button4_Sorted_With_Min_Length_Value(object sender, EventArgs e)
        {
            if (CheckEmptyList())
                MessageBox.Show("Список пуст");
            else
            {
                str.LinqMin();
                CallList_For_Linq_And_Direct_Sorting();
            }
        }

        private void button6_Sorted_On_Content_Char(object sender, EventArgs e)
        {
            if (CheckEmptyList())
                MessageBox.Show("Список пуст");
            else
            {
                str.LinqFirstChar();
                CallList_For_Linq_And_Direct_Sorting();
            }
        }
        #endregion

        // Method For Entry ViewLists
        #region
        public void CallList_For_Linq_And_Direct_Sorting()
        {
            if (listView1.Items != null)
            {
                listView1.Clear();
            }
            listView1.View = View.Details;
            listView1.Columns.Add("Strings", 83);
            foreach (string s in str.redirectList)
            {
                ListViewItem item = new ListViewItem(new[] { s });
                listView1.Items.Add(item);
            }
        }

        public void CallList_Reverse()
        {
            if (listView2.Items != null)
            {
                listView2.Clear();
            }
            listView2.View = View.Details;
            listView2.Columns.Add("Strings", 83);
            foreach (string s in str.redirectList)
            {
                ListViewItem item = new ListViewItem(new[] { s });
                listView2.Items.Add(item);
            }
        }
        #endregion

        // Method For Check List on empty
        #region
        public bool CheckEmptyList()
        {
            if (str.newList.Count == 0)
                return true;
            return false;
        }
        #endregion

        // Empty Elements
        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_For_Linq_And_Direct_Sortin(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

