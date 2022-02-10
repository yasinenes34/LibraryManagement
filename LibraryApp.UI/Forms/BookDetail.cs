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
    public partial class BookDetail : Form
    {
        public BookDetail()
        {
            InitializeComponent();
        }
        LibraryContext db = new LibraryContext();
        private void findstudent_Click(object sender, EventArgs e)
        {
            bookdata.Rows.Clear();
            var x = db.BookOperations.ToList();
            var y = db.Students.ToList();
            var b = db.Books.ToList();
            foreach (var i in x)
            {
                foreach (var s in b)
                {
                    if (s.Book_Name.ToLower() == booknametxt.Text.ToLower())
                    {
                        bookdata.Rows.Add(i.ID,i.Book.Book_Name,i.Book.Author, i.Book.Release_Date, i.Book.Copies, i.Book.Page_Count, i.Book.Category, i.Student.Name,i.Purchaseof_Books,i.BookReturn_Date);
                    }
                }

            }
        }

        private void BookDetail_Load(object sender, EventArgs e)
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
    }
}
