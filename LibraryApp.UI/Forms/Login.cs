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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void givethebookbtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text.ToLower()=="admin"&&passwordtxt.Text.ToLower()=="admin")
            {
                MessageBox.Show("Giriş Yapıldı Ana Menüye Yönlendiriliyorsunuz.");
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınızı ve ya Şifrenizi Kontrol Ediniz");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
