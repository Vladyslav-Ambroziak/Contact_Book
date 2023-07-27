namespace Contact_Book
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            addContactToolStripMenuItem = new ToolStripMenuItem();
            deleteContactToolStripMenuItem = new ToolStripMenuItem();
            updateListToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel7 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addContactToolStripMenuItem, deleteContactToolStripMenuItem, updateListToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(801, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addContactToolStripMenuItem
            // 
            addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            addContactToolStripMenuItem.Size = new Size(86, 20);
            addContactToolStripMenuItem.Text = "Add Contact";
            addContactToolStripMenuItem.Click += addContactToolStripMenuItem_Click;
            // 
            // deleteContactToolStripMenuItem
            // 
            deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            deleteContactToolStripMenuItem.Size = new Size(97, 20);
            deleteContactToolStripMenuItem.Text = "Delete Contact";
            deleteContactToolStripMenuItem.Click += deleteContactToolStripMenuItem_Click;
            // 
            // updateListToolStripMenuItem
            // 
            updateListToolStripMenuItem.Name = "updateListToolStripMenuItem";
            updateListToolStripMenuItem.Size = new Size(75, 20);
            updateListToolStripMenuItem.Text = "Update list";
            updateListToolStripMenuItem.Click += updateListToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 32);
            panel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label5);
            panel7.Location = new Point(628, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(169, 25);
            panel7.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 1);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 0;
            label5.Text = "Phone number";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label4);
            panel6.Location = new Point(498, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(124, 25);
            panel6.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 1);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 0;
            label4.Text = "Birthday";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(285, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 25);
            panel5.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 1);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 0;
            label3.Text = "Surname";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(77, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 25);
            panel4.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 1);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(68, 25);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 1);
            label1.Name = "label1";
            label1.Size = new Size(21, 19);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(801, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Contact Book";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addContactToolStripMenuItem;
        private ToolStripMenuItem deleteContactToolStripMenuItem;
        private ToolStripMenuItem updateListToolStripMenuItem;
        private Panel panel1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}