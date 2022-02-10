
namespace LibraryApp.UI.Forms
{
    partial class BookDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetail));
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.graphbtn = new System.Windows.Forms.Button();
            this.bookdata = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Release_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPurchaseOfBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetrunOfBookDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findbook = new System.Windows.Forms.Button();
            this.booknametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(313, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 33);
            this.label7.TabIndex = 32;
            this.label7.Text = "Library Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.graphbtn);
            this.panel1.Controls.Add(this.bookdata);
            this.panel1.Controls.Add(this.findbook);
            this.panel1.Controls.Add(this.booknametxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 288);
            this.panel1.TabIndex = 33;
            // 
            // graphbtn
            // 
            this.graphbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphbtn.ForeColor = System.Drawing.Color.Black;
            this.graphbtn.Location = new System.Drawing.Point(803, 192);
            this.graphbtn.Name = "graphbtn";
            this.graphbtn.Size = new System.Drawing.Size(147, 31);
            this.graphbtn.TabIndex = 54;
            this.graphbtn.Text = "Show Graph";
            this.graphbtn.UseVisualStyleBackColor = true;
            // 
            // bookdata
            // 
            this.bookdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BookName,
            this.Author,
            this.Release_Date,
            this.Copies,
            this.PageCount,
            this.Category,
            this.BookReceiver,
            this.DateOfPurchaseOfBooks,
            this.RetrunOfBookDate});
            this.bookdata.Location = new System.Drawing.Point(3, 13);
            this.bookdata.Name = "bookdata";
            this.bookdata.Size = new System.Drawing.Size(968, 150);
            this.bookdata.TabIndex = 53;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 25;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Release_Date
            // 
            this.Release_Date.HeaderText = "Release_Date";
            this.Release_Date.Name = "Release_Date";
            // 
            // Copies
            // 
            this.Copies.HeaderText = "Copies";
            this.Copies.Name = "Copies";
            // 
            // PageCount
            // 
            this.PageCount.HeaderText = "PageCount";
            this.PageCount.Name = "PageCount";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // BookReceiver
            // 
            this.BookReceiver.HeaderText = "BookReceiver";
            this.BookReceiver.Name = "BookReceiver";
            // 
            // DateOfPurchaseOfBooks
            // 
            this.DateOfPurchaseOfBooks.HeaderText = "DateOfPurchaseOfBooks";
            this.DateOfPurchaseOfBooks.Name = "DateOfPurchaseOfBooks";
            // 
            // RetrunOfBookDate
            // 
            this.RetrunOfBookDate.HeaderText = "RetrunOfBookDate";
            this.RetrunOfBookDate.Name = "RetrunOfBookDate";
            // 
            // findbook
            // 
            this.findbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findbook.ForeColor = System.Drawing.Color.Black;
            this.findbook.Location = new System.Drawing.Point(168, 218);
            this.findbook.Name = "findbook";
            this.findbook.Size = new System.Drawing.Size(147, 31);
            this.findbook.TabIndex = 52;
            this.findbook.Text = "Find Book";
            this.findbook.UseVisualStyleBackColor = true;
            this.findbook.Click += new System.EventHandler(this.findstudent_Click);
            // 
            // booknametxt
            // 
            this.booknametxt.Location = new System.Drawing.Point(168, 192);
            this.booknametxt.Name = "booknametxt";
            this.booknametxt.Size = new System.Drawing.Size(147, 20);
            this.booknametxt.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Book Name";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(895, -1);
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
            this.pictureBox6.Location = new System.Drawing.Point(936, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(971, 380);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookDetail";
            this.Load += new System.EventHandler(this.BookDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findbook;
        private System.Windows.Forms.TextBox booknametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView bookdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Release_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchaseOfBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetrunOfBookDate;
        private System.Windows.Forms.Button graphbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}