using AppG2.Controller;
using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2.View
{
    public partial class frmLogin : Form
    {
        string pathUserFile;
        User user = null;

        public frmLogin()
        {
            InitializeComponent();
            this.pathUserFile = Application.StartupPath + @"\Data\users.txt";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = UserService.getLogin(pathUserFile, txtUserName.Text, txtPassword.Text);
            if (user == null)
            {
                var rs = MessageBox.Show("Thông tin đăng nhập không đúng.",
                "Thông Báo",
                MessageBoxButtons.OK);
            } else
            {
                var frmContact = new frmContacts(user.id);
                frmContact.Show();
                this.Hide();
            }
        }
    }
}
