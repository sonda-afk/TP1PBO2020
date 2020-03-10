using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembelian
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            user.Username = Convert.ToString(username);
            user.Password = Convert.ToString(password);

            if (username.Trim() == string.Empty || password.Trim() == string.Empty)
            {
                MessageBox.Show("Harap Lengkapi Username dan Password");
            }
            else
            {
                if (password == "pbo123")
                {
                    FrmHome frmHome = new FrmHome();
                    frmHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Maaf, Password Salah");
                }
            }
        }

    }
}
