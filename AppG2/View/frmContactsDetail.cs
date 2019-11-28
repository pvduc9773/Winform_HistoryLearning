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
    public partial class frmContactsDetail : Form
    {
        Contacts contact;
        string pathContactsDataFile;
        string idUser;

        public frmContactsDetail(string pathContactsDataFile, string idUser, Contacts contacts = null)
        {
            InitializeComponent();
            this.pathContactsDataFile = pathContactsDataFile;
            this.contact = contacts;
            this.idUser = idUser;

            if (contact != null)
            {
                // Chỉnh sửa quá trình học tập
                txtName.Text = contact.name;
                txtPhone.Text = contact.phone;
                txtEmail.Text = contact.email;
            }
            else
            {
                // Thêm mới quá trình học tập

            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (contact != null)
            {
                // Cập nhật
                ContactsService.updateContacts(pathContactsDataFile, contact.idContacts, txtName.Text.ToString(), txtPhone.Text.ToString(), txtEmail.Text.ToString(), idUser);
            }
            else
            {
                // Thêm mới
                ContactsService.addNewContacts(pathContactsDataFile, txtName.Text.ToString(), txtPhone.Text.ToString(), txtEmail.Text.ToString(), idUser);

            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;
        }
    }
}
