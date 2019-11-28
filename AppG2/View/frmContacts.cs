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
    public partial class frmContacts : Form
    {
        List<Contacts> contacts;
        string pathContactsDataFile;
        string pathContactsDataFileImport;
        string idUser;

        public frmContacts(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            pathContactsDataFile = Application.StartupPath + @"\Data\contacts.txt";
            // pathContactsDataFileImport = Application.StartupPath + @"\Data\contacts.csv";

            bdsContacts.DataSource = null;
            dtgContacts.AutoGenerateColumns = false;

            contacts = ContactsService.getContacts(pathContactsDataFile, idUser);
            updateTable(contacts);
        }

        private void updateTable(List<Contacts> listContacts)
        {
            if (listContacts != null)
            {
                bdsContacts.DataSource = listContacts;
            }
            dtgContacts.DataSource = bdsContacts;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var f = new frmContactsDetail(pathContactsDataFile, idUser);
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Tiến hành nạp lại dữ liệu
                updateTable(ContactsService.getContacts(pathContactsDataFile, idUser));
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var ct = bdsContacts.Current as Contacts;
            if (ct != null)
            {
                var f = new frmContactsDetail(pathContactsDataFile, idUser, ct);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Tiến hành nạp lại dữ liệu
                    updateTable(ContactsService.getContacts(pathContactsDataFile, idUser));    
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn xóa dữ liệu này không ?",
                "Thông Báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                var contact = bdsContacts.Current as Contacts;
                ContactsService.deleteContacts(pathContactsDataFile, contact.idContacts);
                updateTable(ContactsService.getContacts(pathContactsDataFile, idUser));
            }
            else
            {

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DtgContacts_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            updateTable(ContactsService.getContactsWithKeyName(pathContactsDataFile, txtSearch.Text.ToString(), idUser));
        }

        private void LinkA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "a", idUser));
        }

        private void LinkD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "d", idUser));
        }

        private void LinkG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "g", idUser));
        }

        private void LinkJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "j", idUser));
        }

        private void LinkM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "m", idUser));
        }

        private void LinkP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "p", idUser));
        }

        private void LinkS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "s", idUser));

        }

        private void LinkW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "w", idUser));
        }

        private void LinkZ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "z", idUser));
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file import";
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var rs = MessageBox.Show("Import thành công.",
                "Thông Báo",
                MessageBoxButtons.OK);
                pathContactsDataFileImport = openFileDialog.FileName;
            }
            ContactsService.getImportContacts(pathContactsDataFileImport, pathContactsDataFile, idUser);
            updateTable(ContactsService.getContacts(pathContactsDataFile, idUser));
        }
    }
}
