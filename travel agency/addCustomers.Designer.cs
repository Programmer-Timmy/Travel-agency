﻿namespace travel_agency
{
    partial class addCustomers
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
            this.submit = new System.Windows.Forms.Button();
            this.Premium_member = new System.Windows.Forms.CheckBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.BackColor = System.Drawing.Color.RoyalBlue;
            this.submit.Location = new System.Drawing.Point(232, 327);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(339, 47);
            this.submit.TabIndex = 20;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Premium_member
            // 
            this.Premium_member.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Premium_member.AutoSize = true;
            this.Premium_member.Location = new System.Drawing.Point(232, 301);
            this.Premium_member.Name = "Premium_member";
            this.Premium_member.Size = new System.Drawing.Size(135, 20);
            this.Premium_member.TabIndex = 19;
            this.Premium_member.Text = "Premium member";
            this.Premium_member.UseVisualStyleBackColor = true;
            // 
            // Country
            // 
            this.Country.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Country.DisplayMember = "name";
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(232, 261);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(339, 24);
            this.Country.TabIndex = 18;
            this.Country.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Country";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.Location = new System.Drawing.Point(232, 205);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(339, 22);
            this.Email.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lastname";
            // 
            // Lastname
            // 
            this.Lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lastname.Location = new System.Drawing.Point(232, 148);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(339, 22);
            this.Lastname.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Firstname:";
            // 
            // Firstname
            // 
            this.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Firstname.Location = new System.Drawing.Point(232, 96);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(339, 22);
            this.Firstname.TabIndex = 11;
            // 
            // addCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Premium_member);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Firstname);
            this.Name = "addCustomers";
            this.Text = "addCustomers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox Premium_member;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Firstname;
    }
}