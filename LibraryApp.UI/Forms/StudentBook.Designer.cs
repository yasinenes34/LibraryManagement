
namespace LibraryApp.UI.Forms
{
    partial class StudentBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.findstudent = new System.Windows.Forms.Button();
            this.stdunetnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookdata = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPurchaseOfBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetrunOfBookDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.findstudent);
            this.panel1.Controls.Add(this.stdunetnametxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bookdata);
            this.panel1.Location = new System.Drawing.Point(1, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 288);
            this.panel1.TabIndex = 0;
            // 
            // findstudent
            // 
            this.findstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findstudent.ForeColor = System.Drawing.Color.Black;
            this.findstudent.Location = new System.Drawing.Point(168, 218);
            this.findstudent.Name = "findstudent";
            this.findstudent.Size = new System.Drawing.Size(147, 31);
            this.findstudent.TabIndex = 52;
            this.findstudent.Text = "Find Student";
            this.findstudent.UseVisualStyleBackColor = true;
            this.findstudent.Click += new System.EventHandler(this.findbook_Click);
            // 
            // stdunetnametxt
            // 
            this.stdunetnametxt.Location = new System.Drawing.Point(168, 192);
            this.stdunetnametxt.Name = "stdunetnametxt";
            this.stdunetnametxt.Size = new System.Drawing.Size(147, 20);
            this.stdunetnametxt.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Student Name";
            // 
            // bookdata
            // 
            this.bookdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StudentName,
            this.BookName,
            this.DateOfPurchaseOfBooks,
            this.RetrunOfBookDate,
            this.DeliveryStatus,
            this.Scot});
            this.bookdata.Location = new System.Drawing.Point(0, 28);
            this.bookdata.Name = "bookdata";
            this.bookdata.Size = new System.Drawing.Size(968, 150);
            this.bookdata.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 150;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.Width = 150;
            // 
            // DateOfPurchaseOfBooks
            // 
            this.DateOfPurchaseOfBooks.HeaderText = "DateOfPurchaseOfBooks";
            this.DateOfPurchaseOfBooks.Name = "DateOfPurchaseOfBooks";
            this.DateOfPurchaseOfBooks.Width = 150;
            // 
            // RetrunOfBookDate
            // 
            this.RetrunOfBookDate.HeaderText = "RetrunOfBookDate";
            this.RetrunOfBookDate.Name = "RetrunOfBookDate";
            this.RetrunOfBookDate.Width = 150;
            // 
            // DeliveryStatus
            // 
            this.DeliveryStatus.HeaderText = "DeliveryStatus";
            this.DeliveryStatus.Name = "DeliveryStatus";
            this.DeliveryStatus.ReadOnly = true;
            // 
            // Scot
            // 
            this.Scot.HeaderText = "Scot";
            this.Scot.Name = "Scot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(174, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 33);
            this.label7.TabIndex = 31;
            this.label7.Text = "Library Management System";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(900, -1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 46;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(941, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // StudentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentBook";
            this.Load += new System.EventHandler(this.StudentBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView bookdata;
        private System.Windows.Forms.TextBox stdunetnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findstudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchaseOfBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetrunOfBookDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scot;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}