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
    public partial class BookAndStudent : Form
    {
        public BookAndStudent()
        {
            InitializeComponent();
        }

        private void booktab_Click(object sender, EventArgs e)
        {

        }
        LibraryContext db = new LibraryContext();
        private void bookaddbtn_Click(object sender, EventArgs e)
        {
            if (booknametxt.Text!=""&&authortxt.Text!=""&&copiestxt.Text!=""&&pagecounttxt.Text!=""&&categorytxt.Text!="")
            {
                Book book = new Book();
                book.Book_Name = booknametxt.Text;
                book.Author = authortxt.Text;
                book.Release_Date = releasedate.Value;
                book.Copies = int.Parse(copiestxt.Text);
                book.Page_Count = int.Parse(pagecounttxt.Text);
                book.Category = categorytxt.Text;
                book.IsActive = true;
                db.Books.Add(book);
                db.SaveChanges();
                MessageBox.Show("Kitap Ekleme Başaraılı");
            }
            else
            {
                MessageBox.Show("Lütfen Butun Alanları Eksiksiz Bir Şekilde Doldurunuz");
            }
           
            
        }

        private void copiestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pagecounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void studentaddbtn_Click(object sender, EventArgs e)
        {
            if (studentnametxt.Text!=""&&studentlastnametxt.Text!=""&&departmenttxt.Text!="")
            {
                Student student = new Student();
                student.Name = studentnametxt.Text;
                student.Last_Name = studentlastnametxt.Text;
                student.Department = departmenttxt.Text;
                student.IsActive = true;
                db.Students.Add(student);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Ekleme Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Eksiksiz Doldurunuz");
            }
        }

        private void studentlistbtn_Click(object sender, EventArgs e)
        {
            var x = db.Students.ToList();
            
            studentdatagrid.Rows.Clear();
            foreach (var i in x)
            {
                studentdatagrid.Rows.Add(i.ID, i.Name, i.Last_Name, i.Department,i.Scot);

            }
        }

        private void booklistbtn_Click(object sender, EventArgs e)
        {
            var x = db.Books.ToList();

            bookdatagrid.Rows.Clear();
            foreach (var i in x)
            {
                bookdatagrid.Rows.Add(i.ID, i.Book_Name, i.Author, i.Release_Date,i.Copies,i.Page_Count,i.Category);

            }
        }
        public int bookid;
        private void bookdatagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bookid = int.Parse(bookdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            booknametxt.Text = bookdatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            authortxt.Text = bookdatagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            releasedate.Text = bookdatagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            copiestxt.Text = bookdatagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            pagecounttxt.Text = bookdatagrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            categorytxt.Text = bookdatagrid.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void bookupdatebtn_Click(object sender, EventArgs e)
        {

            if (booknametxt.Text != "" && authortxt.Text != "" && copiestxt.Text != "" && pagecounttxt.Text != "" && categorytxt.Text != "")
            {
                var update = db.Books.Find(bookid);
                update.Book_Name = booknametxt.Text;
                update.Author = authortxt.Text;
                update.Release_Date = releasedate.Value;
                update.Copies = int.Parse(copiestxt.Text);
                update.Page_Count = int.Parse(pagecounttxt.Text);
                update.Category = categorytxt.Text;
                update.IsActive = true;
                db.SaveChanges();
                MessageBox.Show("Kitap Güncelleme Başaraılı");
            }
            else
            {
                MessageBox.Show("Lütfen Butun Alanları Eksiksiz Bir Şekilde Doldurunuz");
            }

        }

        private void bookdeletebtn_Click(object sender, EventArgs e)
        {
            if (bookid!=0)
            {
                var delete = db.Books.Find(bookid);
                db.Books.Remove(delete);
                db.SaveChanges();
                MessageBox.Show("Kitap Silme Başaraılı");
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kitabı Seciniz");
            }
        }
        public int studentid;

        private void studentupdatebtn_Click(object sender, EventArgs e)
        {
            if (studentnametxt.Text != "" && studentlastnametxt.Text != "" && departmenttxt.Text != "")
            {
                var update = db.Students.Find(studentid);
                update.Name = studentnametxt.Text;
                update.Last_Name = studentlastnametxt.Text;
                update.Department = departmenttxt.Text;
                update.IsActive = true;
                db.SaveChanges();
                MessageBox.Show("Öğrenci Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Eksiksiz Doldurunuz");
            }
        }

        private void studentdatagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentid = int.Parse(studentdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            studentnametxt.Text = studentdatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            studentlastnametxt.Text = studentdatagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            departmenttxt.Text = studentdatagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void studentdelete_Click(object sender, EventArgs e)
        {
            if (studentid!=0)
            {
                var delete = db.Students.Find(studentid);
                db.Students.Remove(delete);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Silme Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Öğrenciyi Seçiniz");
            }
        }

        private void studnetbookbtn_Click(object sender, EventArgs e)
        {
            StudentBook stdnbk = new StudentBook();
            stdnbk.Show();
            this.Close();
        }

        private void bookdetailbtn_Click(object sender, EventArgs e)
        {
            BookDetail bkd = new BookDetail();
            bkd.Show();
            this.Close();
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
