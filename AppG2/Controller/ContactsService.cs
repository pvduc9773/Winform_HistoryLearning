using AppG2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Controller
{
    class ContactsService
    {
        private static List<Contacts> sortContacts(List<Contacts> contacts)
        {
            for (int i = 0; i < contacts.Count-1; i++)
            {
                for (int j = i+1; j < contacts.Count; j++)
                {
                    if (contacts[i].key.ToUpper().CompareTo(contacts[j].key.ToUpper()) > 0)
                    {
                        Contacts temp = contacts[i];
                        contacts[i] = contacts[j];
                        contacts[j] = temp;
                    }
                }
            }
            return contacts;
        }

        public static List<Contacts> getContacts(string pathContactsFileName)
        {
            if (File.Exists(pathContactsFileName))
            {
                List<Contacts> contacts = new List<Contacts>();
                var lines = File.ReadAllLines(pathContactsFileName);
                foreach (var line in lines)
                {
                    if (!line.Equals(""))
                    {
                        var rs = line.Split(new char[] { '#' });
                        Contacts contact = new Contacts
                        {
                            idContacts = rs[0],
                            name = rs[1],
                            phone = rs[2],
                            email = rs[3]
                        };
                        contacts.Add(contact);
                    }
                }
                contacts = sortContacts(contacts);
                return contacts;
            }
            else
            {
                return null;
            }
        }

        public static void deleteContacts(string pathContactsFileName, string id_contacts)
        {
            if (File.Exists(pathContactsFileName))
            {
                List<Contacts> contacts = new List<Contacts>();
                var lines = File.ReadAllLines(pathContactsFileName);
                foreach (var line in lines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Contacts contact = new Contacts
                    {
                        idContacts = rs[0],
                        name = rs[1],
                        phone = rs[2],
                        email = rs[3]
                    };
                    if (contact.idContacts != id_contacts)
                    {
                        contacts.Add(contact);
                    }
                }

                List<string> lineWrites = new List<string>();

                foreach (var contact in contacts)
                {
                    string lineWrite = contact.idContacts + "#"
                                      + contact.name + "#"
                                      + contact.phone + "#"
                                      + contact.email;
                    lineWrites.Add(lineWrite);
                }
                File.WriteAllLines(pathContactsFileName, lineWrites);
            }
        }

        public static void addNewContacts(string pathContactsFileName, string name, string phone, string email)
        {
            // Lấy danh sách Contacts trong file
            List<Contacts> contacts = new List<Contacts>();
            var lines = File.ReadAllLines(pathContactsFileName);
            foreach (var line in lines)
            {
                var rs = line.Split(new char[] { '#' });
                Contacts contact = new Contacts
                {
                    idContacts = rs[0],
                    name = rs[1],
                    phone = rs[2],
                    email = rs[3]
                };
                contacts.Add(contact);
            }

            // Lấy id lớn nhất
            var maxId = 0;
            foreach (var ct in contacts)
            {
                if (Int32.Parse(ct.idContacts) > maxId)
                {
                    maxId = Int32.Parse(ct.idContacts);
                }
            }

            // Tạo Contacts mới
            var newContact = new Contacts();
            newContact.idContacts = (maxId + 1).ToString();
            newContact.name = name;
            newContact.phone = phone;
            newContact.email = email;

            // Thêm HistoryLearning mới vào trong danh sách
            contacts.Add(newContact);

            // Ghi lại vào file
            List<string> lineWrites = new List<string>();
            foreach (var contact in contacts)
            {
                string lineWrite = contact.idContacts + "#"
                                  + contact.name + "#"
                                  + contact.phone + "#"
                                  + contact.email;
                lineWrites.Add(lineWrite);
            }
            File.WriteAllLines(pathContactsFileName, lineWrites);
        }

        public static void updateContacts(string pathContactsFileName, string id, string name, string phone, string email)
        {
            // Lấy danh sách Contacts trong file
            List<Contacts> contacts = new List<Contacts>();
            var lines = File.ReadAllLines(pathContactsFileName);
            foreach (var line in lines)
            {
                var rs = line.Split(new char[] { '#' });
                Contacts contact = new Contacts
                {
                    idContacts = rs[0],
                    name = rs[1],
                    phone = rs[2],
                    email = rs[3]
                };
                contacts.Add(contact);
            }

            List<string> lineWrites = new List<string>();

            foreach (var ct in contacts)
            {
                if (ct.idContacts == id)
                {
                    ct.name = name;
                    ct.phone = phone;
                    ct.email = email;
                }

                string lineWrite = ct.idContacts + "#"
                                  + ct.name + "#"
                                  + ct.phone + "#"
                                  + ct.email;
                lineWrites.Add(lineWrite);
            }
            File.WriteAllLines(pathContactsFileName, lineWrites);
        }

        public static List<Contacts> getContactsWithKeyName(string pathContactsFileName, string keys)
        {
            if (File.Exists(pathContactsFileName))
            {
                List<Contacts> contacts = new List<Contacts>();
                var lines = File.ReadAllLines(pathContactsFileName);
                foreach (var line in lines)
                {
                    if (!line.Equals(""))
                    {
                        var rs = line.Split(new char[] { '#' });
                        var key = keys.ToUpper();
                        var name = rs[1].ToUpper();
                        var phone = rs[2].ToUpper();
                        if (name.Contains(key) || phone.Contains(key))
                        {
                            Contacts contact = new Contacts
                            {
                                idContacts = rs[0],
                                name = rs[1],
                                phone = rs[2],
                                email = rs[3]
                            };
                            contacts.Add(contact);
                        }
                    }
                }
                contacts = sortContacts(contacts);
                return contacts;
            }
            else
            {
                return null;
            }
        }

        public static List<Contacts> getContactsWithCharacters(string pathContactsFileName, string characters)
        {
            if (File.Exists(pathContactsFileName))
            {
                List<Contacts> contacts = new List<Contacts>();
                var lines = File.ReadAllLines(pathContactsFileName);
                foreach (var line in lines)
                {
                    if (!line.Equals(""))
                    {
                        var rs = line.Split(new char[] { '#' });
                        var keyContact = rs[1].Substring(0, 1).ToUpper();
                        if (keyContact.CompareTo(characters.ToUpper()) >= 0)
                        {
                            Contacts contact = new Contacts
                            {
                                idContacts = rs[0],
                                name = rs[1],
                                phone = rs[2],
                                email = rs[3]
                            };
                            contacts.Add(contact);
                        }
                    }
                }
                contacts = sortContacts(contacts);
                return contacts;
            }
            else
            {
                return null;
            }
        }
    }
}
