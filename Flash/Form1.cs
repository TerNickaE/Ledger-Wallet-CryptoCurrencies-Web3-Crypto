using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int checkedCount = 0;

            if (guna2CheckBox1.Checked) checkedCount++;
            if (guna2CheckBox2.Checked) checkedCount++;
            if (guna2CheckBox3.Checked) checkedCount++;
            if (guna2CheckBox4.Checked) checkedCount++;
            if (guna2CheckBox5.Checked) checkedCount++;

            // Checkbox kontrolü
            if (checkedCount != 1)
            {
                MessageBox.Show("Please select crypto or only one");
                return;
            }

            // TextBox boş mu kontrolü
            if (string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                MessageBox.Show("Adress cannot be empty!");
                guna2TextBox2.Focus();
                return;
            }

            // Eğer her şey doğruysa
            Guna.UI2.WinForms.Guna2MessageDialog dialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            dialog.Text = "Sended";
            dialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            dialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            dialog.Show();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
