using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahnoorFinalvpl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btreg_Click(object sender, EventArgs e)
        {
            

                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtfull.Text) || string.IsNullOrWhiteSpace(txtpass.Text) || string.IsNullOrWhiteSpace(txtpho.Text) || string.IsNullOrWhiteSpace(txtadd.Text) || checkBox1.Checked == false)
                { MessageBox.Show("Info missing"); }
                else
                {
                    user user = new user(txtpass.Text, txtfull.Text, txtname.Text, txtpho.Text, txtadd.Text);
                    user.AddUserToList(user);
                    MessageBox.Show("Registration Successful ");

                    MessageBox.Show("Please login to your account");


                }

            }

        private void btlog_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtuser.Text) && string.IsNullOrWhiteSpace(txtpassw.Text))
            {
                MessageBox.Show("Enter Login Credentials");
            }
          
           else if (txtuser.Text !=txtname.Text || txtpassw.Text != txtpass.Text)
            {
                MessageBox.Show("Incorrect Username or Password");
                
            }
            else
            {
                MessageBox.Show("Login Successful");
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Please tick the checkbox");
            }
        }
    }
}
