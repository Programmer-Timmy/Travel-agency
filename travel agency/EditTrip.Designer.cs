namespace travel_agency.managers
{
    partial class EditTrip
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Duration_Days = new System.Windows.Forms.NumericUpDown();
            this.Min_Travelers = new System.Windows.Forms.NumericUpDown();
            this.Max_travelers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Trip_Type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Intensity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_Travelers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_travelers)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.BackColor = System.Drawing.Color.RoyalBlue;
            this.submit.Location = new System.Drawing.Point(353, 336);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(339, 47);
            this.submit.TabIndex = 20;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Min travelers";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Duration days";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date";
            // 
            // lable
            // 
            this.lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(350, 21);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(72, 16);
            this.lable.TabIndex = 12;
            this.lable.Text = "destination";
            // 
            // Destination
            // 
            this.Destination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Destination.Location = new System.Drawing.Point(353, 40);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(339, 22);
            this.Destination.TabIndex = 11;
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.Location = new System.Drawing.Point(353, 92);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(339, 22);
            this.Date.TabIndex = 21;
            // 
            // Duration_Days
            // 
            this.Duration_Days.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Duration_Days.Location = new System.Drawing.Point(353, 150);
            this.Duration_Days.Name = "Duration_Days";
            this.Duration_Days.Size = new System.Drawing.Size(339, 22);
            this.Duration_Days.TabIndex = 22;
            // 
            // Min_Travelers
            // 
            this.Min_Travelers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Min_Travelers.Location = new System.Drawing.Point(353, 205);
            this.Min_Travelers.Name = "Min_Travelers";
            this.Min_Travelers.Size = new System.Drawing.Size(173, 22);
            this.Min_Travelers.TabIndex = 23;
            // 
            // Max_travelers
            // 
            this.Max_travelers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Max_travelers.Location = new System.Drawing.Point(532, 205);
            this.Max_travelers.Name = "Max_travelers";
            this.Max_travelers.Size = new System.Drawing.Size(160, 22);
            this.Max_travelers.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Max travelers";
            // 
            // Country
            // 
            this.Country.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Country.DisplayMember = "name";
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(353, 258);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(339, 24);
            this.Country.TabIndex = 26;
            this.Country.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Trip type";
            // 
            // Trip_Type
            // 
            this.Trip_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trip_Type.DisplayMember = "name";
            this.Trip_Type.FormattingEnabled = true;
            this.Trip_Type.Location = new System.Drawing.Point(353, 306);
            this.Trip_Type.Name = "Trip_Type";
            this.Trip_Type.Size = new System.Drawing.Size(173, 24);
            this.Trip_Type.TabIndex = 28;
            this.Trip_Type.ValueMember = "id";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Intensity";
            // 
            // Intensity
            // 
            this.Intensity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Intensity.DisplayMember = "description";
            this.Intensity.FormattingEnabled = true;
            this.Intensity.Location = new System.Drawing.Point(532, 306);
            this.Intensity.Name = "Intensity";
            this.Intensity.Size = new System.Drawing.Size(160, 24);
            this.Intensity.TabIndex = 30;
            this.Intensity.ValueMember = "id";
            // 
            // EditTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Intensity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Trip_Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Max_travelers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Min_Travelers);
            this.Controls.Add(this.Duration_Days);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.Destination);
            this.Name = "EditTrip";
            this.Text = "EditTrip";
            ((System.ComponentModel.ISupportInitialize)(this.Duration_Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_Travelers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_travelers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.NumericUpDown Duration_Days;
        private System.Windows.Forms.NumericUpDown Min_Travelers;
        private System.Windows.Forms.NumericUpDown Max_travelers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Trip_Type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Intensity;
    }
}