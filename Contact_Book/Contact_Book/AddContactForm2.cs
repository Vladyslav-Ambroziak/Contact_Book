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
    public partial class AddContactForm2 : Form
    {
        public AddContactForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.PhoneNumber_TextBox.Text == "")
            {
                this.PhoneNumber_TextBox.BackColor = Color.FromArgb(255, 72, 72);
                this.PhoneNumber_TextBox.ForeColor = Color.FromArgb(255, 255, 255);
                Label warning = new Label();
                warning.Width = 200;
                warning.Name = "Warning_Not_PhoneNumber";
                warning.Text = "Enter phone number!";
                warning.ForeColor = Color.FromArgb(255, 0, 0);
                warning.Location = new Point(this.PhoneNumber_TextBox.Location.X + 5, this.PhoneNumber_TextBox.Location.Y + this.PhoneNumber_TextBox.Height);
                this.Controls.Add(warning);
                return;
            }
            else if (this.PhoneNumber_TextBox.BackColor == Color.FromArgb(255, 72, 72))
            {
                this.PhoneNumber_TextBox.BackColor = Color.FromArgb(255, 255, 255);
                this.PhoneNumber_TextBox.ForeColor = Color.FromArgb(0, 0, 0);
                this.Controls.RemoveByKey("Warning_Not_PhoneNumber");
            }
            using (MyApplicationContext context = new MyApplicationContext())
            {
                context.Contacts.Add(new Contact() { Id = 0, Name = this.Name_TextBox.Text, Surname = this.Surname_TextBox.Text, Birthday = this.Birthday_DateTimePicker.Value, PhoneNumber = this.PhoneNumber_TextBox.Text });
                context.SaveChanges();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
