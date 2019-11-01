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

        public frmContacts()
        {
            InitializeComponent();
            pathContactsDataFile = Application.StartupPath + @"\Data\contacts.txt";
            bdsContacts.DataSource = null;
            dtgContacts.AutoGenerateColumns = false;

            contacts = ContactsService.getContacts(pathContactsDataFile);
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
            var f = new frmContactsDetail(pathContactsDataFile);
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Tiến hành nạp lại dữ liệu
                updateTable(ContactsService.getContacts(pathContactsDataFile));
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var ct = bdsContacts.Current as Contacts;
            if (ct != null)
            {
                var f = new frmContactsDetail(pathContactsDataFile, ct);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Tiến hành nạp lại dữ liệu
                    updateTable(ContactsService.getContacts(pathContactsDataFile));    
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
                updateTable(ContactsService.getContacts(pathContactsDataFile));
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
            updateTable(ContactsService.getContactsWithKeyName(pathContactsDataFile, txtSearch.Text.ToString()));
        }

        private void LinkA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "a"));
        }

        private void LinkD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "d"));
        }

        private void LinkG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "g"));
        }

        private void LinkJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "j"));
        }

        private void LinkM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "m"));
        }

        private void LinkP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "p"));
        }

        private void LinkS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "s"));

        }

        private void LinkW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "w"));
        }

        private void LinkZ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateTable(ContactsService.getContactsWithCharacters(pathContactsDataFile, "z"));
        }
    }
}
