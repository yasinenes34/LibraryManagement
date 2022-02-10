using LibraryEntity.Library_Enitity.Entity;
using LibraryEntity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UI.Forms
{
    public partial class Book_Operation : Form
    {
        public Book_Operation()
        {
            InitializeComponent();
        }
        LibraryContext db = new LibraryContext();
        private void BookOperation_Load(object sender, EventArgs e)
        {
            var x = db.Students.ToList();

            studentdatagrid.Rows.Clear();
            foreach (var i in x)
            {
                if (i.IsActive==true)
                {
                    studentdatagrid.Rows.Add(i.ID, i.Name);
                }
               

            }
            var y = db.Books.ToList();

            bookdatagrid.Rows.Clear();
            foreach (var i in y)
            {
                if (i.IsActive==true)
                {
                    bookdatagrid.Rows.Add(i.ID, i.Book_Name, i.Author, i.Release_Date, i.Copies, i.Page_Count, i.Category);
                }
              

            }
        }
        public int bookid, studentid;

        private void bookdatagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            bookid = int.Parse(bookdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            booknametxt.Text = bookdatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void studentdatagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentid = int.Parse(studentdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            studentnametxt.Text = studentdatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        public int id;
        public DateTime returndate;
        private void takebookgird_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse( takebookgird.Rows[e.RowIndex].Cells[0].Value.ToString());
            bknametxt.Text = takebookgird.Rows[e.RowIndex].Cells[1].Value.ToString();
            stdnnametxt.Text = takebookgird.Rows[e.RowIndex].Cells[2].Value.ToString();
            retrundate.Value =Convert.ToDateTime(takebookgird.Rows[e.RowIndex].Cells[4].Value);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void listbtn_Click(object sender, EventArgs e)
        {

            takebookgird.Rows.Clear();
            var x = db.BookOperations.ToList();
            foreach (var i in x)
            {
                if (i.IsActive==true)
                {
                    takebookgird.Rows.Add(i.ID, i.Book.Book_Name, i.Student.Name, i.Purchaseof_Books, i.BookReturn_Date);
                }
            }
        }

        private void takebtn_Click(object sender, EventArgs e)
        {
            if (stdnnametxt.Text!=""&&bknametxt.Text!="")
            {
                var book= db.BookOperations.Find(id);
                if (book!=null)
                {
                    BookOperation bookOperation = new BookOperation();
                    DateTime now = DateTime.Now;
                    TimeSpan span = now.Subtract(retrundate.Value);
                   
                    book.Student.Scot += span.Days; 
                    book.IsActive = false;
                    db.SaveChanges();
                    MessageBox.Show("Kitap Geri Alım İşlemi Başarılı");
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }

        private void givebtn_Click(object sender, EventArgs e)
        {
            BookOperation operation = new BookOperation();
            operation.StudentID = studentid;
            operation.BookID = bookid;
            operation.Purchaseof_Books = purchase.Value;
            operation.BookReturn_Date = retrundate.Value;
            operation.IsActive = true;
            db.BookOperations.Add(operation);
            db.SaveChanges();
            MessageBox.Show("Kitap Verme İşlemi Başarılı");


        }
    }
}
