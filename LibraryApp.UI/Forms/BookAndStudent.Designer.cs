
namespace LibraryApp.UI.Forms
{
    partial class BookAndStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAndStudent));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.booktab = new System.Windows.Forms.TabPage();
            this.studnetbookbtn = new System.Windows.Forms.Button();
            this.bookdetailbtn = new System.Windows.Forms.Button();
            this.bookdeletebtn = new System.Windows.Forms.Button();
            this.bookupdatebtn = new System.Windows.Forms.Button();
            this.booklistbtn = new System.Windows.Forms.Button();
            this.bookaddbtn = new System.Windows.Forms.Button();
            this.bookdatagrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Release_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorytxt = new System.Windows.Forms.TextBox();
            this.pagecounttxt = new System.Windows.Forms.TextBox();
            this.copiestxt = new System.Windows.Forms.TextBox();
            this.releasedate = new System.Windows.Forms.DateTimePicker();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.booknametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studenttab = new System.Windows.Forms.TabPage();
            this.studentdelete = new System.Windows.Forms.Button();
            this.studentupdatebtn = new System.Windows.Forms.Button();
            this.studentlistbtn = new System.Windows.Forms.Button();
            this.studentdatagrid = new System.Windows.Forms.DataGridView();
            this.studentaddbtn = new System.Windows.Forms.Button();
            this.departmenttxt = new System.Windows.Forms.TextBox();
            this.studentlastnametxt = new System.Windows.Forms.TextBox();
            this.studentnametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.booktab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookdatagrid)).BeginInit();
            this.studenttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booktab);
            this.tabControl1.Controls.Add(this.studenttab);
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 243);
            this.tabControl1.TabIndex = 0;
            // 
            // booktab
            // 
            this.booktab.BackColor = System.Drawing.Color.PeachPuff;
            this.booktab.Controls.Add(this.studnetbookbtn);
            this.booktab.Controls.Add(this.bookdetailbtn);
            this.booktab.Controls.Add(this.bookdeletebtn);
            this.booktab.Controls.Add(this.bookupdatebtn);
            this.booktab.Controls.Add(this.booklistbtn);
            this.booktab.Controls.Add(this.bookaddbtn);
            this.booktab.Controls.Add(this.bookdatagrid);
            this.booktab.Controls.Add(this.categorytxt);
            this.booktab.Controls.Add(this.pagecounttxt);
            this.booktab.Controls.Add(this.copiestxt);
            this.booktab.Controls.Add(this.releasedate);
            this.booktab.Controls.Add(this.authortxt);
            this.booktab.Controls.Add(this.booknametxt);
            this.booktab.Controls.Add(this.label4);
            this.booktab.Controls.Add(this.label5);
            this.booktab.Controls.Add(this.label6);
            this.booktab.Controls.Add(this.label2);
            this.booktab.Controls.Add(this.label1);
            this.booktab.Controls.Add(this.label3);
            this.booktab.Location = new System.Drawing.Point(4, 22);
            this.booktab.Name = "booktab";
            this.booktab.Padding = new System.Windows.Forms.Padding(3);
            this.booktab.Size = new System.Drawing.Size(1074, 217);
            this.booktab.TabIndex = 0;
            this.booktab.Text = "Book Operations";
            this.booktab.Click += new System.EventHandler(this.booktab_Click);
            // 
            // studnetbookbtn
            // 
            this.studnetbookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studnetbookbtn.ForeColor = System.Drawing.Color.Black;
            this.studnetbookbtn.Location = new System.Drawing.Point(817, 164);
            this.studnetbookbtn.Name = "studnetbookbtn";
            this.studnetbookbtn.Size = new System.Drawing.Size(125, 35);
            this.studnetbookbtn.TabIndex = 56;
            this.studnetbookbtn.Text = "studnetdetail";
            this.studnetbookbtn.UseVisualStyleBackColor = true;
            this.studnetbookbtn.Click += new System.EventHandler(this.studnetbookbtn_Click);
            // 
            // bookdetailbtn
            // 
            this.bookdetailbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookdetailbtn.ForeColor = System.Drawing.Color.Black;
            this.bookdetailbtn.Location = new System.Drawing.Point(958, 164);
            this.bookdetailbtn.Name = "bookdetailbtn";
            this.bookdetailbtn.Size = new System.Drawing.Size(104, 35);
            this.bookdetailbtn.TabIndex = 55;
            this.bookdetailbtn.Text = "bookdetail";
            this.bookdetailbtn.UseVisualStyleBackColor = true;
            this.bookdetailbtn.Click += new System.EventHandler(this.bookdetailbtn_Click);
            // 
            // bookdeletebtn
            // 
            this.bookdeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookdeletebtn.ForeColor = System.Drawing.Color.Black;
            this.bookdeletebtn.Location = new System.Drawing.Point(651, 164);
            this.bookdeletebtn.Name = "bookdeletebtn";
            this.bookdeletebtn.Size = new System.Drawing.Size(104, 26);
            this.bookdeletebtn.TabIndex = 54;
            this.bookdeletebtn.Text = "delete";
            this.bookdeletebtn.UseVisualStyleBackColor = true;
            this.bookdeletebtn.Click += new System.EventHandler(this.bookdeletebtn_Click);
            // 
            // bookupdatebtn
            // 
            this.bookupdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookupdatebtn.ForeColor = System.Drawing.Color.Black;
            this.bookupdatebtn.Location = new System.Drawing.Point(527, 164);
            this.bookupdatebtn.Name = "bookupdatebtn";
            this.bookupdatebtn.Size = new System.Drawing.Size(115, 26);
            this.bookupdatebtn.TabIndex = 53;
            this.bookupdatebtn.Text = "Update";
            this.bookupdatebtn.UseVisualStyleBackColor = true;
            this.bookupdatebtn.Click += new System.EventHandler(this.bookupdatebtn_Click);
            // 
            // booklistbtn
            // 
            this.booklistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.booklistbtn.ForeColor = System.Drawing.Color.Black;
            this.booklistbtn.Location = new System.Drawing.Point(416, 164);
            this.booklistbtn.Name = "booklistbtn";
            this.booklistbtn.Size = new System.Drawing.Size(97, 26);
            this.booklistbtn.TabIndex = 52;
            this.booklistbtn.Text = "List";
            this.booklistbtn.UseVisualStyleBackColor = true;
            this.booklistbtn.Click += new System.EventHandler(this.booklistbtn_Click);
            // 
            // bookaddbtn
            // 
            this.bookaddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookaddbtn.ForeColor = System.Drawing.Color.Black;
            this.bookaddbtn.Location = new System.Drawing.Point(165, 164);
            this.bookaddbtn.Name = "bookaddbtn";
            this.bookaddbtn.Size = new System.Drawing.Size(200, 26);
            this.bookaddbtn.TabIndex = 51;
            this.bookaddbtn.Text = "Add";
            this.bookaddbtn.UseVisualStyleBackColor = true;
            this.bookaddbtn.Click += new System.EventHandler(this.bookaddbtn_Click);
            // 
            // bookdatagrid
            // 
            this.bookdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BookName,
            this.Author,
            this.Release_Date,
            this.Copies,
            this.PageCount,
            this.Category});
            this.bookdatagrid.Location = new System.Drawing.Point(405, 14);
            this.bookdatagrid.Name = "bookdatagrid";
            this.bookdatagrid.Size = new System.Drawing.Size(666, 150);
            this.bookdatagrid.TabIndex = 50;
            this.bookdatagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookdatagrid_CellMouseDoubleClick);
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
            // categorytxt
            // 
            this.categorytxt.Location = new System.Drawing.Point(165, 138);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(200, 20);
            this.categorytxt.TabIndex = 49;
            // 
            // pagecounttxt
            // 
            this.pagecounttxt.Location = new System.Drawing.Point(165, 112);
            this.pagecounttxt.Name = "pagecounttxt";
            this.pagecounttxt.Size = new System.Drawing.Size(200, 20);
            this.pagecounttxt.TabIndex = 48;
            this.pagecounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pagecounttxt_KeyPress);
            // 
            // copiestxt
            // 
            this.copiestxt.Location = new System.Drawing.Point(165, 86);
            this.copiestxt.Name = "copiestxt";
            this.copiestxt.Size = new System.Drawing.Size(200, 20);
            this.copiestxt.TabIndex = 47;
            this.copiestxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copiestxt_KeyPress);
            // 
            // releasedate
            // 
            this.releasedate.Location = new System.Drawing.Point(165, 62);
            this.releasedate.Name = "releasedate";
            this.releasedate.Size = new System.Drawing.Size(200, 20);
            this.releasedate.TabIndex = 46;
            // 
            // authortxt
            // 
            this.authortxt.Location = new System.Drawing.Point(165, 42);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(200, 20);
            this.authortxt.TabIndex = 45;
            // 
            // booknametxt
            // 
            this.booknametxt.Location = new System.Drawing.Point(165, 16);
            this.booknametxt.Name = "booknametxt";
            this.booknametxt.Size = new System.Drawing.Size(200, 20);
            this.booknametxt.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Page_Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Copies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Release_Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Book Name";
            // 
            // studenttab
            // 
            this.studenttab.BackColor = System.Drawing.Color.PeachPuff;
            this.studenttab.Controls.Add(this.studentdelete);
            this.studenttab.Controls.Add(this.studentupdatebtn);
            this.studenttab.Controls.Add(this.studentlistbtn);
            this.studenttab.Controls.Add(this.studentdatagrid);
            this.studenttab.Controls.Add(this.studentaddbtn);
            this.studenttab.Controls.Add(this.departmenttxt);
            this.studenttab.Controls.Add(this.studentlastnametxt);
            this.studenttab.Controls.Add(this.studentnametxt);
            this.studenttab.Controls.Add(this.label9);
            this.studenttab.Controls.Add(this.label11);
            this.studenttab.Controls.Add(this.label12);
            this.studenttab.Location = new System.Drawing.Point(4, 22);
            this.studenttab.Name = "studenttab";
            this.studenttab.Padding = new System.Windows.Forms.Padding(3);
            this.studenttab.Size = new System.Drawing.Size(1074, 217);
            this.studenttab.TabIndex = 1;
            this.studenttab.Text = "Student Operations";
            // 
            // studentdelete
            // 
            this.studentdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentdelete.ForeColor = System.Drawing.Color.Black;
            this.studentdelete.Location = new System.Drawing.Point(580, 159);
            this.studentdelete.Name = "studentdelete";
            this.studentdelete.Size = new System.Drawing.Size(129, 26);
            this.studentdelete.TabIndex = 68;
            this.studentdelete.Text = "Delete";
            this.studentdelete.UseVisualStyleBackColor = true;
            this.studentdelete.Click += new System.EventHandler(this.studentdelete_Click);
            // 
            // studentupdatebtn
            // 
            this.studentupdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentupdatebtn.ForeColor = System.Drawing.Color.Black;
            this.studentupdatebtn.Location = new System.Drawing.Point(445, 159);
            this.studentupdatebtn.Name = "studentupdatebtn";
            this.studentupdatebtn.Size = new System.Drawing.Size(129, 26);
            this.studentupdatebtn.TabIndex = 67;
            this.studentupdatebtn.Text = "Update";
            this.studentupdatebtn.UseVisualStyleBackColor = true;
            this.studentupdatebtn.Click += new System.EventHandler(this.studentupdatebtn_Click);
            // 
            // studentlistbtn
            // 
            this.studentlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentlistbtn.ForeColor = System.Drawing.Color.Black;
            this.studentlistbtn.Location = new System.Drawing.Point(300, 159);
            this.studentlistbtn.Name = "studentlistbtn";
            this.studentlistbtn.Size = new System.Drawing.Size(129, 26);
            this.studentlistbtn.TabIndex = 66;
            this.studentlistbtn.Text = "List";
            this.studentlistbtn.UseVisualStyleBackColor = true;
            this.studentlistbtn.Click += new System.EventHandler(this.studentlistbtn_Click);
            // 
            // studentdatagrid
            // 
            this.studentdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdatagrid.Location = new System.Drawing.Point(300, 3);
            this.studentdatagrid.Name = "studentdatagrid";
            this.studentdatagrid.Size = new System.Drawing.Size(771, 150);
            this.studentdatagrid.TabIndex = 65;
            this.studentdatagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentdatagrid_CellMouseDoubleClick);
            // 
            // studentaddbtn
            // 
            this.studentaddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentaddbtn.ForeColor = System.Drawing.Color.Black;
            this.studentaddbtn.Location = new System.Drawing.Point(165, 115);
            this.studentaddbtn.Name = "studentaddbtn";
            this.studentaddbtn.Size = new System.Drawing.Size(129, 26);
            this.studentaddbtn.TabIndex = 64;
            this.studentaddbtn.Text = "Add";
            this.studentaddbtn.UseVisualStyleBackColor = true;
            this.studentaddbtn.Click += new System.EventHandler(this.studentaddbtn_Click);
            // 
            // departmenttxt
            // 
            this.departmenttxt.Location = new System.Drawing.Point(165, 89);
            this.departmenttxt.Name = "departmenttxt";
            this.departmenttxt.Size = new System.Drawing.Size(129, 20);
            this.departmenttxt.TabIndex = 61;
            // 
            // studentlastnametxt
            // 
            this.studentlastnametxt.Location = new System.Drawing.Point(165, 49);
            this.studentlastnametxt.Name = "studentlastnametxt";
            this.studentlastnametxt.Size = new System.Drawing.Size(129, 20);
            this.studentlastnametxt.TabIndex = 59;
            // 
            // studentnametxt
            // 
            this.studentnametxt.Location = new System.Drawing.Point(165, 7);
            this.studentnametxt.Name = "studentnametxt";
            this.studentnametxt.Size = new System.Drawing.Size(129, 20);
            this.studentnametxt.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 55;
            this.label9.Text = "Department";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 23);
            this.label11.TabIndex = 53;
            this.label11.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(298, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 33);
            this.label7.TabIndex = 69;
            this.label7.Text = "Library Management System";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(999, -1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 71;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1040, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 70;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // BookAndStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1078, 295);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookAndStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookAndStudent";
            this.tabControl1.ResumeLayout(false);
            this.booktab.ResumeLayout(false);
            this.booktab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookdatagrid)).EndInit();
            this.studenttab.ResumeLayout(false);
            this.studenttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booktab;
        private System.Windows.Forms.TabPage studenttab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categorytxt;
        private System.Windows.Forms.TextBox pagecounttxt;
        private System.Windows.Forms.TextBox copiestxt;
        private System.Windows.Forms.DateTimePicker releasedate;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.TextBox booknametxt;
        private System.Windows.Forms.DataGridView bookdatagrid;
        private System.Windows.Forms.Button bookdeletebtn;
        private System.Windows.Forms.Button bookupdatebtn;
        private System.Windows.Forms.Button booklistbtn;
        private System.Windows.Forms.Button bookaddbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Release_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Button studentaddbtn;
        private System.Windows.Forms.TextBox departmenttxt;
        private System.Windows.Forms.TextBox studentlastnametxt;
        private System.Windows.Forms.TextBox studentnametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView studentdatagrid;
        private System.Windows.Forms.Button studentdelete;
        private System.Windows.Forms.Button studentupdatebtn;
        private System.Windows.Forms.Button studentlistbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button studnetbookbtn;
        private System.Windows.Forms.Button bookdetailbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}