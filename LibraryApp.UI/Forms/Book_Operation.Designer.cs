
namespace LibraryApp.UI.Forms
{
    partial class Book_Operation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Operation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.retrundate = new System.Windows.Forms.DateTimePicker();
            this.purchase = new System.Windows.Forms.DateTimePicker();
            this.bringing = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.booknametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentnametxt = new System.Windows.Forms.TextBox();
            this.givebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentdatagrid = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.bookdatagrid = new System.Windows.Forms.DataGridView();
            this.book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listbtn = new System.Windows.Forms.Button();
            this.bknametxt = new System.Windows.Forms.TextBox();
            this.stdnnametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.takebtn = new System.Windows.Forms.Button();
            this.takebookgird = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaseof_Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookReturn_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdatagrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takebookgird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 261);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage1.Controls.Add(this.retrundate);
            this.tabPage1.Controls.Add(this.purchase);
            this.tabPage1.Controls.Add(this.bringing);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.booknametxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.studentnametxt);
            this.tabPage1.Controls.Add(this.givebtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.studentdatagrid);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.bookdatagrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Give Book";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // retrundate
            // 
            this.retrundate.Location = new System.Drawing.Point(783, 114);
            this.retrundate.Name = "retrundate";
            this.retrundate.Size = new System.Drawing.Size(200, 20);
            this.retrundate.TabIndex = 73;
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(783, 90);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(200, 20);
            this.purchase.TabIndex = 72;
            // 
            // bringing
            // 
            this.bringing.AutoSize = true;
            this.bringing.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.bringing.ForeColor = System.Drawing.Color.Black;
            this.bringing.Location = new System.Drawing.Point(530, 111);
            this.bringing.Name = "bringing";
            this.bringing.Size = new System.Drawing.Size(193, 23);
            this.bringing.TabIndex = 71;
            this.bringing.Text = "Bringing Back Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(530, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 23);
            this.label4.TabIndex = 70;
            this.label4.Text = "Date of Purchase of Books";
            // 
            // booknametxt
            // 
            this.booknametxt.Location = new System.Drawing.Point(783, 64);
            this.booknametxt.Name = "booknametxt";
            this.booknametxt.ReadOnly = true;
            this.booknametxt.Size = new System.Drawing.Size(186, 20);
            this.booknametxt.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(530, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(530, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Student Name";
            // 
            // studentnametxt
            // 
            this.studentnametxt.Location = new System.Drawing.Point(783, 38);
            this.studentnametxt.Name = "studentnametxt";
            this.studentnametxt.ReadOnly = true;
            this.studentnametxt.Size = new System.Drawing.Size(186, 20);
            this.studentnametxt.TabIndex = 66;
            // 
            // givebtn
            // 
            this.givebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.givebtn.ForeColor = System.Drawing.Color.Black;
            this.givebtn.Location = new System.Drawing.Point(783, 140);
            this.givebtn.Name = "givebtn";
            this.givebtn.Size = new System.Drawing.Size(180, 26);
            this.givebtn.TabIndex = 65;
            this.givebtn.Text = "Give";
            this.givebtn.UseVisualStyleBackColor = true;
            this.givebtn.Click += new System.EventHandler(this.givebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Student";
            // 
            // studentdatagrid
            // 
            this.studentdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.StudentName});
            this.studentdatagrid.Location = new System.Drawing.Point(280, 38);
            this.studentdatagrid.Name = "studentdatagrid";
            this.studentdatagrid.Size = new System.Drawing.Size(244, 150);
            this.studentdatagrid.TabIndex = 54;
            this.studentdatagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentdatagrid_CellMouseDoubleClick);
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student_ID";
            this.Student_ID.Name = "Student_ID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(88, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 53;
            this.label12.Text = "Book";
            // 
            // bookdatagrid
            // 
            this.bookdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_ID,
            this.BookName});
            this.bookdatagrid.Location = new System.Drawing.Point(6, 38);
            this.bookdatagrid.Name = "bookdatagrid";
            this.bookdatagrid.Size = new System.Drawing.Size(244, 150);
            this.bookdatagrid.TabIndex = 0;
            this.bookdatagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookdatagrid_CellMouseDoubleClick);
            // 
            // book_ID
            // 
            this.book_ID.HeaderText = "book_ID";
            this.book_ID.Name = "book_ID";
            // 
            // BookName
            // 
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage2.Controls.Add(this.listbtn);
            this.tabPage2.Controls.Add(this.bknametxt);
            this.tabPage2.Controls.Add(this.stdnnametxt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.takebtn);
            this.tabPage2.Controls.Add(this.takebookgird);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Take Book";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listbtn
            // 
            this.listbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbtn.ForeColor = System.Drawing.Color.Black;
            this.listbtn.Location = new System.Drawing.Point(6, 190);
            this.listbtn.Name = "listbtn";
            this.listbtn.Size = new System.Drawing.Size(149, 26);
            this.listbtn.TabIndex = 73;
            this.listbtn.Text = "List";
            this.listbtn.UseVisualStyleBackColor = true;
            this.listbtn.Click += new System.EventHandler(this.listbtn_Click);
            // 
            // bknametxt
            // 
            this.bknametxt.Location = new System.Drawing.Point(814, 62);
            this.bknametxt.Name = "bknametxt";
            this.bknametxt.ReadOnly = true;
            this.bknametxt.Size = new System.Drawing.Size(149, 20);
            this.bknametxt.TabIndex = 72;
            // 
            // stdnnametxt
            // 
            this.stdnnametxt.Location = new System.Drawing.Point(814, 36);
            this.stdnnametxt.Name = "stdnnametxt";
            this.stdnnametxt.ReadOnly = true;
            this.stdnnametxt.Size = new System.Drawing.Size(149, 20);
            this.stdnnametxt.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(672, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(672, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Student Name";
            // 
            // takebtn
            // 
            this.takebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takebtn.ForeColor = System.Drawing.Color.Black;
            this.takebtn.Location = new System.Drawing.Point(814, 88);
            this.takebtn.Name = "takebtn";
            this.takebtn.Size = new System.Drawing.Size(149, 26);
            this.takebtn.TabIndex = 66;
            this.takebtn.Text = "Take Book";
            this.takebtn.UseVisualStyleBackColor = true;
            this.takebtn.Click += new System.EventHandler(this.takebtn_Click);
            // 
            // takebookgird
            // 
            this.takebookgird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takebookgird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Book_Name,
            this.Student_Name,
            this.Purchaseof_Books,
            this.BookReturn_Date});
            this.takebookgird.Location = new System.Drawing.Point(3, 34);
            this.takebookgird.Name = "takebookgird";
            this.takebookgird.Size = new System.Drawing.Size(645, 150);
            this.takebookgird.TabIndex = 0;
            this.takebookgird.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.takebookgird_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Book_Name
            // 
            this.Book_Name.HeaderText = "Book_Name";
            this.Book_Name.Name = "Book_Name";
            // 
            // Student_Name
            // 
            this.Student_Name.HeaderText = "Student_Name";
            this.Student_Name.Name = "Student_Name";
            // 
            // Purchaseof_Books
            // 
            this.Purchaseof_Books.HeaderText = "Purchaseof_Books";
            this.Purchaseof_Books.Name = "Purchaseof_Books";
            this.Purchaseof_Books.Width = 150;
            // 
            // BookReturn_Date
            // 
            this.BookReturn_Date.HeaderText = "BookReturn_Date";
            this.BookReturn_Date.Name = "BookReturn_Date";
            this.BookReturn_Date.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(214, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 33);
            this.label7.TabIndex = 32;
            this.label7.Text = "Library Management System";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(923, -2);
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
            this.pictureBox6.Location = new System.Drawing.Point(964, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Book_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1001, 326);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Operation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookOperation";
            this.Load += new System.EventHandler(this.BookOperation_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdatagrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takebookgird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView bookdatagrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentdatagrid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker retrundate;
        private System.Windows.Forms.DateTimePicker purchase;
        private System.Windows.Forms.Label bringing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox booknametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentnametxt;
        private System.Windows.Forms.Button givebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridView takebookgird;
        private System.Windows.Forms.TextBox bknametxt;
        private System.Windows.Forms.TextBox stdnnametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button takebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaseof_Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookReturn_Date;
        private System.Windows.Forms.Button listbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}