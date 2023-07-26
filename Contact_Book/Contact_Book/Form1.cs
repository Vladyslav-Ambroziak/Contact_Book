namespace Contact_Book
{
    public partial class Form1 : Form
    {
        int y = 24;
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                ContactInfoUserControl item = new ContactInfoUserControl();
                item.Location = new Point(0, y);
                this.Controls.Add(item);
                y += 32;
            }

            DeleteContactForm3 form3 = new DeleteContactForm3();
            form3.Show();

            AddContactForm2 form2 = new AddContactForm2();
            form2.Show();
        }
    }
}