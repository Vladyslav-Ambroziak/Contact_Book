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
    public partial class DeleteContactForm3 : Form
    {
        public DeleteContactForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Id_For_Delete_TextBox.Text == "")
            {
                this.Controls.RemoveByKey("Warning_Not_Found_Id");
                this.Id_For_Delete_TextBox.BackColor = Color.FromArgb(255, 72, 72);
                this.Id_For_Delete_TextBox.ForeColor = Color.FromArgb(255, 255, 255);
                Label warning1 = new Label();
                warning1.Width = 200;
                warning1.Name = "Warning_Not_Enter_Id";
                warning1.Font = new Font(warning1.Font.FontFamily, 8);
                warning1.Text = "Enter id";
                warning1.ForeColor = Color.FromArgb(255, 0, 0);
                warning1.Location = new Point(this.Id_For_Delete_TextBox.Location.X + 5, this.Id_For_Delete_TextBox.Location.Y + this.Id_For_Delete_TextBox.Height);
                this.Controls.Add(warning1);
                return;
            }
            using (MyApplicationContext context = new MyApplicationContext())
            {
                if (context.Contacts.Any(x => x.Id == int.Parse(this.Id_For_Delete_TextBox.Text)))
                {
                    if (this.Id_For_Delete_TextBox.BackColor == Color.FromArgb(255, 72, 72))
                    {
                        this.Id_For_Delete_TextBox.BackColor = Color.FromArgb(255, 255, 255);
                        this.Id_For_Delete_TextBox.ForeColor = Color.FromArgb(0, 0, 0);
                        this.Controls.RemoveByKey("Warning_Not_Found_Id");
                        this.Controls.RemoveByKey("Warning_Not_Enter_Id");
                        this.Controls.RemoveByKey("Warning_Not_Enter_Id");
                    }
                    context.Contacts.Remove(context.Contacts.FirstOrDefault(x => x.Id == int.Parse(this.Id_For_Delete_TextBox.Text)));
                    context.SaveChanges();
                    this.Close();
                }
                else
                {
                    this.Controls.RemoveByKey("Warning_Not_Enter_Id");
                    this.Id_For_Delete_TextBox.BackColor = Color.FromArgb(255, 72, 72);
                    this.Id_For_Delete_TextBox.ForeColor = Color.FromArgb(255, 255, 255);
                    Label warning2 = new Label();
                    warning2.Width = 200;
                    warning2.Name = "Warning_Not_Found_Id";
                    warning2.Font = new Font(warning2.Font.FontFamily, 8);
                    warning2.Text = "Id doesn't exist!";
                    warning2.ForeColor = Color.FromArgb(255, 0, 0);
                    warning2.Location = new Point(this.Id_For_Delete_TextBox.Location.X + 5, this.Id_For_Delete_TextBox.Location.Y + this.Id_For_Delete_TextBox.Height);
                    this.Controls.Add(warning2);
                    return;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
