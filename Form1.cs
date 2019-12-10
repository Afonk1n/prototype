using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form1 : Form
    {
        string login = "1";
        string pass = "1";
        string ulogin = "2";
        string upass = "2";
        public static int acc = 0;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Вход_Click(object sender, EventArgs e)
        {   Вход.BackgroundImage = Image.FromFile("UI/Button/Login.png");
            if ((textBox1.Text == ulogin) && (textBox2.Text == upass))
            {
                acc = 1;
                Stundent secondForm = new Stundent(this,acc);
                secondForm.Show();
                this.Hide();
            }
            else
            {
                if ((textBox1.Text == login) && (textBox2.Text == pass))
                {
                    acc = 2;
                    Stundent secondForm = new Stundent(this,acc);
                    secondForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль.");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Вход_MouseMove(object sender, MouseEventArgs e)
        {
            Вход.Image = Image.FromFile("UI/Button/LoginON.png");
        }

        private void Вход_MouseLeave(object sender, EventArgs e)
        {
            Вход.Image = Image.FromFile("UI/Button/Login.png");
        }
    }
}
