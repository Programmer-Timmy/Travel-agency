namespace travel_agency
{
    partial class addBooking
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
            this.Trip = new System.Windows.Forms.ComboBox();
            this.Customer = new System.Windows.Forms.ComboBox();
            this.Booking_Date = new System.Windows.Forms.DateTimePicker();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Trip
            // 
            this.Trip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trip.DisplayMember = "Destination";
            this.Trip.FormattingEnabled = true;
            this.Trip.Location = new System.Drawing.Point(149, 181);
            this.Trip.Name = "Trip";
            this.Trip.Size = new System.Drawing.Size(339, 24);
            this.Trip.TabIndex = 30;
            this.Trip.ValueMember = "Id";
            // 
            // Customer
            // 
            this.Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Customer.DisplayMember = "Firstname";
            this.Customer.FormattingEnabled = true;
            this.Customer.Location = new System.Drawing.Point(149, 129);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(339, 24);
            this.Customer.TabIndex = 29;
            this.Customer.ValueMember = "Id";
            // 
            // Booking_Date
            // 
            this.Booking_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Booking_Date.Location = new System.Drawing.Point(149, 238);
            this.Booking_Date.Name = "Booking_Date";
            this.Booking_Date.Size = new System.Drawing.Size(339, 22);
            this.Booking_Date.TabIndex = 28;
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.BackColor = System.Drawing.Color.RoyalBlue;
            this.submit.Location = new System.Drawing.Point(149, 295);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(339, 47);
            this.submit.TabIndex = 27;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Booking date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Trip";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Customer";
            // 
            // addBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.Trip);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Booking_Date);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addBooking";
            this.Text = "addBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Trip;
        private System.Windows.Forms.ComboBox Customer;
        private System.Windows.Forms.DateTimePicker Booking_Date;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}