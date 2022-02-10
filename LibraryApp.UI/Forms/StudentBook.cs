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
    public partial class StudentBook : Form
    {
        public StudentBook()
        {
            InitializeComponent();
        }
        LibraryContext db = new LibraryContext();
        BookOperation studentBook = new BookOperation();
        private void StudentBook_Load(object sender, EventArgs e)
        {
           
        }

        private void findbook_Click(object sender, EventArgs e)
        {
            bookdata.Rows.Clear();
            var x = db.BookOperations.ToList();
            var y = db.Students.ToList();
            var b = db.Books.ToList();
            foreach (var i in x)
            {
                foreach (var s in y)
                {
                    if (s.Name.ToLower()==stdunetnametxt.Text.ToLower())
                    {
                        bookdata.Rows.Add(i.ID, i.Student.Name, i.Book.Book_Name, i.Purchaseof_Books, i.BookReturn_Date, i.IsActive,i.Student.Scot);
                    }
                }
              
            }
            for (int i = 0; i < bookdata.RowCount; i++)
            {
               
                DateTime returndate = Convert.ToDateTime(bookdata.Rows[i].Cells[4].Value);
                bool isactive = Convert.ToBoolean(bookdata.Rows[i].Cells[5].Value);
                DateTime now = DateTime.Now;
                if (now>returndate && isactive==true)
                {
                    bookdata.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (isactive == false)
                {
                    bookdata.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                if (now.AddDays(2)<returndate && isactive == true)
                {
                    bookdata.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
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
    }
}
