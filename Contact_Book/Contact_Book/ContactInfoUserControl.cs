using Contact_Book.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Book
{
    public partial class ContactInfoUserControl : UserControl
    {
        public ContactInfoUserControl()
        {
            InitializeComponent();
        }
        public ContactInfoUserControl(int id, string name, string surname, DateTime birthday, string phone_number) : this()
        {
            this.Id_label.Text = id.ToString();
            this.Name_textBox.Text = name;
            this.Surname_textBox.Text = surname;
            this.Birthday_dateTimePicker.Value = birthday;
            this.PhoneNumber_textBox.Text = phone_number;
        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {
            using (MyApplicationContext context = new MyApplicationContext())
            {
                Contact OldContact = context.Contacts.FirstOrDefault(x => x.Id == int.Parse(this.Id_label.Text));
                OldContact.Name = this.Name_textBox.Text;
                context.Contacts.Update(OldContact);
                context.SaveChanges();
            }
        }
        private void Surname_textBox_TextChanged(object sender, EventArgs e)
        {
            using (MyApplicationContext context = new MyApplicationContext())
            {
                Contact OldContact = context.Contacts.FirstOrDefault(x => x.Id == int.Parse(this.Id_label.Text));
                OldContact.Surname = this.Surname_textBox.Text;
                context.Contacts.Update(OldContact);
                context.SaveChanges();
            }
        }
        private void Birthday_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            using (MyApplicationContext context = new MyApplicationContext())
            {
                Contact OldContact = context.Contacts.FirstOrDefault(x => x.Id == int.Parse(this.Id_label.Text));
                OldContact.Birthday = this.Birthday_dateTimePicker.Value;
                context.Contacts.Update(OldContact);
                context.SaveChanges();
            }
        }
        private void PhoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            using (MyApplicationContext context = new MyApplicationContext())
            {
                Contact OldContact = context.Contacts.FirstOrDefault(x => x.Id == int.Parse(this.Id_label.Text));
                OldContact.PhoneNumber = this.PhoneNumber_textBox.Text;
                context.Contacts.Update(OldContact);
                context.SaveChanges();
            }
        }
    }
}
