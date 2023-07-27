namespace Contact_Book
{
    partial class ContactInfoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Id_label = new Label();
            Name_textBox = new TextBox();
            Surname_textBox = new TextBox();
            PhoneNumber_textBox = new TextBox();
            Birthday_dateTimePicker = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Id_label);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(68, 25);
            panel1.TabIndex = 0;
            // 
            // Id_label
            // 
            Id_label.AutoSize = true;
            Id_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Id_label.Location = new Point(3, 1);
            Id_label.Name = "Id_label";
            Id_label.Size = new Size(21, 19);
            Id_label.TabIndex = 0;
            Id_label.Text = "Id";
            // 
            // Name_textBox
            // 
            Name_textBox.BorderStyle = BorderStyle.FixedSingle;
            Name_textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name_textBox.Location = new Point(77, 3);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(202, 25);
            Name_textBox.TabIndex = 1;
            Name_textBox.Text = "Name";
            Name_textBox.TextChanged += Name_textBox_TextChanged;
            // 
            // Surname_textBox
            // 
            Surname_textBox.BorderStyle = BorderStyle.FixedSingle;
            Surname_textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Surname_textBox.Location = new Point(285, 3);
            Surname_textBox.Name = "Surname_textBox";
            Surname_textBox.Size = new Size(207, 25);
            Surname_textBox.TabIndex = 2;
            Surname_textBox.Text = "Surname";
            Surname_textBox.TextChanged += Surname_textBox_TextChanged;
            // 
            // PhoneNumber_textBox
            // 
            PhoneNumber_textBox.BorderStyle = BorderStyle.FixedSingle;
            PhoneNumber_textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber_textBox.Location = new Point(628, 3);
            PhoneNumber_textBox.Name = "PhoneNumber_textBox";
            PhoneNumber_textBox.Size = new Size(169, 25);
            PhoneNumber_textBox.TabIndex = 4;
            PhoneNumber_textBox.Text = "Phone number";
            PhoneNumber_textBox.TextChanged += PhoneNumber_textBox_TextChanged;
            // 
            // Birthday_dateTimePicker
            // 
            Birthday_dateTimePicker.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Birthday_dateTimePicker.Format = DateTimePickerFormat.Short;
            Birthday_dateTimePicker.Location = new Point(498, 3);
            Birthday_dateTimePicker.Name = "Birthday_dateTimePicker";
            Birthday_dateTimePicker.Size = new Size(124, 25);
            Birthday_dateTimePicker.TabIndex = 5;
            Birthday_dateTimePicker.ValueChanged += Birthday_dateTimePicker_ValueChanged;
            // 
            // ContactInfoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Birthday_dateTimePicker);
            Controls.Add(PhoneNumber_textBox);
            Controls.Add(Surname_textBox);
            Controls.Add(Name_textBox);
            Controls.Add(panel1);
            Name = "ContactInfoUserControl";
            Size = new Size(801, 33);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Id_label;
        private TextBox Name_textBox;
        private TextBox Surname_textBox;
        private TextBox PhoneNumber_textBox;
        private DateTimePicker Birthday_dateTimePicker;
    }
}
