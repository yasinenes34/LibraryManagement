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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci Ve kitap Ekleme Formuna Yönlendiriliyorsunuz");
            BookAndStudent bookAndStudent = new BookAndStudent();
            this.Close();
            bookAndStudent.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci Ve kitap Ekleme Formuna Yönlendiriliyorsunuz");
            BookAndStudent bookAndStudent = new BookAndStudent();
            this.Close();
            bookAndStudent.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap İşlemleri Formuna Yönlendiriliyorsunuz");
            Book_Operation book_Operation = new Book_Operation();
            this.Close();
            book_Operation.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci Ve Kitap İşlemleri Formuna Yönlendiriliyorsunuz");
            StudentBook studentBook = new StudentBook();
            this.Close();
            studentBook.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap Detay Formuna Yönlendiriliyorsunuz");
            BookDetail studentBook = new BookDetail();
            this.Close();
            studentBook.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
