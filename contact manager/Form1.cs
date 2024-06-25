using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbDetails.Checked = true;
            rbMale.Checked = true;
        }

        private void Details_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDetails.Checked)
            {
                listView1.View = View.Details;
                return;
            }

            if (rbLargeIcon.Checked)
            {
                listView1.View = View.LargeIcon;
                return;
            }

            if (rbSmallIcom.Checked)
            {
                listView1.View = View.SmallIcon;
                return;
            }

            if (rbTile.Checked)
            {
                listView1.View = View.Tile;
                return;
            }

            if (rbList.Checked)
            {
                listView1.View = View.List;
                return;
            }
        }

        private bool CheckIfTextBoxesEmpty()
        {
            return ((string.IsNullOrWhiteSpace(txtID.Text))
                && (string.IsNullOrWhiteSpace(txtName.Text))
                && (string.IsNullOrWhiteSpace(txtPhone.Text))
                && (string.IsNullOrWhiteSpace(txtEmail.Text))
                && (string.IsNullOrWhiteSpace(txtCity.Text)));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckIfTextBoxesEmpty()) return;

            ListViewItem item = new ListViewItem(txtID.Text.Trim());

            if (rbMale.Checked) item.ImageIndex = 0;

            else item.ImageIndex = 1;

            item.SubItems.Add(txtName.Text.Trim());
            item.SubItems.Add(numericUpDown1.Value.ToString());
            item.SubItems.Add(txtPhone.Text.Trim());
            item.SubItems.Add(txtEmail.Text.Trim());
            item.SubItems.Add(txtCity.Text.Trim());

            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCity.Clear();
        }


        //Note: All Validating Not necessary...

        private void ValidateTextBox(TextBox textBox, CancelEventArgs e, string ErrorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, ErrorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtID, e, "ID is Required");
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtName, e, "Name is Required");
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtPhone, e, "Phone is Required");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtEmail, e, "Email is Required");
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtCity, e, "City is Required");
        }
        //

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Delete This Contact",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listView1.Items.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }      
    }
}
