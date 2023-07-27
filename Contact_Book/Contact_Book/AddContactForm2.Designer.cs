namespace Contact_Book
{
    partial class AddContactForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactForm2));
            Name_TextBox = new TextBox();
            PhoneNumber_TextBox = new TextBox();
            Surname_TextBox = new TextBox();
            label1 = new Label();
            Birthday_DateTimePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Name_TextBox
            // 
            Name_TextBox.Location = new Point(139, 76);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(199, 23);
            Name_TextBox.TabIndex = 0;
            // 
            // PhoneNumber_TextBox
            // 
            PhoneNumber_TextBox.Location = new Point(139, 155);
            PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            PhoneNumber_TextBox.Size = new Size(199, 23);
            PhoneNumber_TextBox.TabIndex = 1;
            // 
            // Surname_TextBox
            // 
            Surname_TextBox.Location = new Point(139, 114);
            Surname_TextBox.Name = "Surname_TextBox";
            Surname_TextBox.Size = new Size(199, 23);
            Surname_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 4;
            label1.Text = "Add Contact";
            // 
            // Birthday_DateTimePicker
            // 
            Birthday_DateTimePicker.Location = new Point(139, 199);
            Birthday_DateTimePicker.Name = "Birthday_DateTimePicker";
            Birthday_DateTimePicker.Size = new Size(199, 23);
            Birthday_DateTimePicker.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 7;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 8;
            label4.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 200);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 9;
            label5.Text = "Birthday";
            // 
            // button1
            // 
            button1.Location = new Point(30, 253);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 253);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddContactForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 294);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Birthday_DateTimePicker);
            Controls.Add(label1);
            Controls.Add(Surname_TextBox);
            Controls.Add(PhoneNumber_TextBox);
            Controls.Add(Name_TextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddContactForm2";
            Text = "Add Contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name_TextBox;
        private TextBox PhoneNumber_TextBox;
        private TextBox Surname_TextBox;
        private Label label1;
        private DateTimePicker Birthday_DateTimePicker;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}