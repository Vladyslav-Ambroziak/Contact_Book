using Contact_Book.Sql;

namespace Contact_Book
{
    public partial class Form1 : Form
    {
        int index = 0;
        int y = 58;
        public Form1()
        {
            InitializeComponent();
            Load_Data_From_Database();
        }

        private void Load_Data_From_Database()
        {
            using (MyApplicationContext context = new MyApplicationContext())
            {
                foreach (Contact item1 in context.Contacts)
                {
                    ContactInfoUserControl item2 = new ContactInfoUserControl(item1.Id, item1.Name, item1.Surname, item1.Birthday, item1.PhoneNumber);
                    item2.Name = $"Contact_#{++index}";
                    item2.Location = new Point(0, y);
                    this.Controls.Add(item2);
                    y += 32;
                }
            }
            y = 58;
        }

        private void updateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (index != 0)
                this.Controls.RemoveByKey($"Contact_#{index--}");
            Load_Data_From_Database();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactForm2 addContact = new AddContactForm2();
            addContact.FormClosed += (e, sender) =>
            {
                while (index != 0)
                    this.Controls.RemoveByKey($"Contact_#{index--}");
                Load_Data_From_Database();
            };
            addContact.Show();
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContactForm3 deleteContact = new DeleteContactForm3();
            deleteContact.FormClosed += (e, sender) =>
            {
                while (index != 0)
                    this.Controls.RemoveByKey($"Contact_#{index--}");
                Load_Data_From_Database();
            };
            deleteContact.Show();
        }
    }
}