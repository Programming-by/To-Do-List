using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

 

        private void btnAdd_Click(object sender, EventArgs e)
        {


            checkedListBox1.Items.Add(txtBox.Text);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            if (checkedListBox1.Items.Count == 0)
            {
                return;
            }
                checkedListBox1.Items.RemoveAt(0);
           
        }
    }
}
