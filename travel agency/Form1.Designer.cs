namespace travel_agency
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Show_Customers = new System.Windows.Forms.Button();
            this.Show_Bookings = new System.Windows.Forms.Button();
            this.Shows_Trips = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Show_Customers
            // 
            this.Show_Customers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Show_Customers.AutoSize = true;
            this.Show_Customers.BackColor = System.Drawing.Color.RoyalBlue;
            this.Show_Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Customers.Location = new System.Drawing.Point(69, 10);
            this.Show_Customers.Name = "Show_Customers";
            this.Show_Customers.Size = new System.Drawing.Size(140, 70);
            this.Show_Customers.TabIndex = 1;
            this.Show_Customers.Text = "Show customers";
            this.Show_Customers.UseVisualStyleBackColor = false;
            this.Show_Customers.Click += new System.EventHandler(this.Show_Customers_Click);
            // 
            // Show_Bookings
            // 
            this.Show_Bookings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Show_Bookings.BackColor = System.Drawing.Color.RoyalBlue;
            this.Show_Bookings.Location = new System.Drawing.Point(469, 10);
            this.Show_Bookings.Name = "Show_Bookings";
            this.Show_Bookings.Size = new System.Drawing.Size(140, 70);
            this.Show_Bookings.TabIndex = 2;
            this.Show_Bookings.Text = "Show bookings";
            this.Show_Bookings.UseVisualStyleBackColor = false;
            this.Show_Bookings.Click += new System.EventHandler(this.Show_Bookings_Click);
            // 
            // Shows_Trips
            // 
            this.Shows_Trips.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Shows_Trips.BackColor = System.Drawing.Color.RoyalBlue;
            this.Shows_Trips.Location = new System.Drawing.Point(861, 10);
            this.Shows_Trips.Name = "Shows_Trips";
            this.Shows_Trips.Size = new System.Drawing.Size(140, 70);
            this.Shows_Trips.TabIndex = 3;
            this.Shows_Trips.Text = "Show Trips";
            this.Shows_Trips.UseVisualStyleBackColor = false;
            this.Shows_Trips.Click += new System.EventHandler(this.Shows_Trips_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Show_Customers);
            this.panel1.Controls.Add(this.Show_Bookings);
            this.panel1.Controls.Add(this.Shows_Trips);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 353);
            this.panel1.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Add.BackColor = System.Drawing.Color.Lime;
            this.Add.Location = new System.Drawing.Point(861, 158);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(140, 70);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(469, 158);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(140, 70);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Edit.BackColor = System.Drawing.Color.DarkOrange;
            this.Edit.Location = new System.Drawing.Point(69, 158);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(140, 70);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1068, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Show_Customers;
        private System.Windows.Forms.Button Show_Bookings;
        private System.Windows.Forms.Button Shows_Trips;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
    }
}

