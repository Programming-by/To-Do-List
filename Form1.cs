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
            if (string.IsNullOrEmpty(txtBox.Text))
            {
              MessageBox.Show("You should add items first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            checkedListBox1.Items.Add(txtBox.Text);
            lblItemsCount.Text = checkedListBox1.Items.Count.ToString();
            txtBox.Text = "";
        }
        private void CheckAllItems(bool isChecked = false)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, isChecked);
            }
        }
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("List Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CheckAllItems(true);
        }
        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("List Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CheckAllItems(false);
        }
        private void btnDeleteFirstItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("List Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            checkedListBox1.Items.RemoveAt(0);
            lblItemsCount.Text = checkedListBox1.Items.Count.ToString();
        }
        private void btnDeleteLastItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("List Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            checkedListBox1.Items.RemoveAt(checkedListBox1.Items.Count - 1);
            lblItemsCount.Text = checkedListBox1.Items.Count.ToString();
        }
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("List Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkedListBox1.CheckedItems.Count != 1)
            {
                MessageBox.Show("You have to check one item only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           int i = checkedListBox1.CheckedIndices[0];
           checkedListBox1.Items.RemoveAt(i);
           lblItemsCount.Text = checkedListBox1.Items.Count.ToString();
        }
        private void btnDeleteAllItems_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("List Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            checkedListBox1.Items.Clear();
            lblItemsCount.Text= "0";

        }
        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBox , "text box can't be empty");
            } else
                errorProvider1.SetError(txtBox, "");
        }

    }
}
