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
    public partial class Stundent : Form
    {

        
        private Point mouseOffset;
        private bool isMouseDown = false;
        public Stundent()
        {   DateTime startdate = new DateTime(2019, 09, 01);
            InitializeComponent();
            //label3.Text = (DateTime.Now.Date-startdate).ToString();
        }
        public Stundent(Form1 form1, int acc)
        {
            InitializeComponent();
        }
        int account = Form1.acc;
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.magtu.ru/sveden/struct/mnogoprofilnyj-kolledzh/istoriya.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.magtu.ru/sveden/struct/mnogoprofilnyj-kolledzh/struktura-kolledzha.html");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.magtu.ru/sveden/struct/mnogoprofilnyj-kolledzh/struktura-kolledzha/%D0%BD%D0%B0%D0%BF%D1%80%D0%B0%D0%B2%D0%BB%D0%B5%D0%BD%D0%B8%D1%8F-%D0%BF%D0%BE%D0%B4%D0%B3%D0%BE%D1%82%D0%BE%D0%B2%D0%BA%D0%B8,-%D1%81%D0%BF%D0%B5%D1%86%D0%B8%D0%B0%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D0%B8.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/course/view.php?id=26619");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/folder/view.php?id=219250");
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - 
                SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Close();
        }

        private void Замена_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/folder/view.php?id=219250");
        }
        private void Замена_MouseHover(object sender, EventArgs p)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(Замена, "Замены в расписании (1 Семестр, 2019) \nВыберите нужную дату");
            Замена.Image = Image.FromFile("UI/Left/Замена/ЗаменыON.png");
        }
        private void Расписание_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/folder/view.php?id=219213");
        }
        private void Расписание_MouseHover(object sender, EventArgs o)
        {
            ToolTip b = new ToolTip();
            b.SetToolTip(Расписание, "Основное расписание (1 Семестр, 2019) \nОТДЕЛЕНИЕ № 1 «ИНФОРМАЦИОННЫЕ ТЕХНОЛОГИИ»");
            Расписание.Image = Image.FromFile("UI/Left/Расписание/РасписаниеON.png");
        }

        private void Вашикурсы_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/my/#");
        }

        private void Вашикурсы_MouseHover(object sender, EventArgs i)
        {
            ToolTip c = new ToolTip();
            c.SetToolTip(Вашикурсы, "Ваши подписанные на данный момент курсы");
            Вашикурсы.Image = Image.FromFile("UI/Right/Ваши курсы/Ваши курсыON.png");
        }

        private void Всеновости_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/vestimpk");
        }

        private void Всеновости_MouseHover(object sender, EventArgs u)
        {
            ToolTip d = new ToolTip();
            d.SetToolTip(Вестимпк, "Вести МПК в соц.сети Вконтакте.");
            Вестимпк.Image = Image.FromFile("UI/Left/Вести МПК/Вести МПКON.png");
        }

        private void Главная_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/");
        }

        private void Главная_MouseHover(object sender, EventArgs y)
        {
            ToolTip j = new ToolTip();
            j.SetToolTip(Главная, "Главная страница портала. \nПросмотр актуальной ветки новости");
            Главная.Image = Image.FromFile("UI/Left/Главная/ГлавнаяON.png");
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.magtu.ru/");
        }

        private void Logo_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Logo, "Главная страница сайта МГТУ");
        }

        private void NameK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.magtu.ru/sveden/struct/mnogoprofilnyj-kolledzh.html");
        }

        private void NameK_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(NameK, "Узнать подробнее о многопрофильном колледже");
            NameK.Image = Image.FromFile("UI/Center/Многопрофильный колледжON.png");
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Exit, "Выход из профиля");
        }

        private void Отделения_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/course/view.php?id=26619");
        }

        private void Отделения_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Отделения, "Все отделения МпК");
            Отделения.Image = Image.FromFile("UI/Left/Отделения/ОтделенияON.png");
        }

        private void Зачётка_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/report/magtu_record_book/");
        }

        private void Зачётка_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Зачётка, "Ваша зачётная книга");
            Зачётка.Image = Image.FromFile("UI/Right/Зачётная кнг/Зачётная кнг.ON.png");
        }

        private void Портфолио_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/report/magtu_stipendiya_portfolio/");
        }

        private void Портфолио_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Портфолио, "Ваше порфолио\nЗдесь выкладываются ваши грамоты");
            Портфолио.Image = Image.FromFile("UI/Right/Портфолио/ПортфолиоON.png");
        }

        private void Сообщения_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/message/index.php");
        }

        private void Сообщения_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Сообщения, "Сообщения. \nВы можете писать сообщения своим одногруппникам и преподователям");
            Сообщения.Image = Image.FromFile("UI/Right/Сообщения/СообщенияON.png");
        }

        private void Уведомления_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/message/output/popup/notifications.php");
        }

        private void Уведомления_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Уведомления, "Уведомления");
            Уведомления.Image = Image.FromFile("UI/Right/Уведомления/УведомленияON.png");
        }

        private void новостиl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/forum/discuss.php?d=7322");
        }

        private void новостиl_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(новостиl, "Просмотреть полную новость");
            новостиl.Image = Image.FromFile("UI/Icons/icons8-external-link-51ON.png");
        }

        private void Новости_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/forum/view.php?f=3");
        }

        private void Новости_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(Новости, "Просмотреть все новости");
            Новости.Image = Image.FromFile("UI/Center/НовостиON.png");
        }

        private void новости2l_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/forum/discuss.php?d=7346");
        }

        private void новости2l_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(новости2l, "Просмотреть полную новость");
            новости2l.Image = Image.FromFile("UI/Icons/icons8-external-link-51ON.png");
        }

        private void новости3l_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://newlms.magtu.ru/mod/forum/discuss.php?d=7331#p52050");
        }

        private void новости3l_MouseHover(object sender, EventArgs e)
        {
            ToolTip g = new ToolTip();
            g.SetToolTip(новости3l, "Просмотреть полную новость");
            новости3l.Image = Image.FromFile("UI/Icons/icons8-external-link-51ON.png");
        }

       

        private void Stundent_Load(object sender, EventArgs e)
        {
            if (account == 2)
            {
                Avatar.Image = Image.FromFile("UI/Avatar/teacher.png");
                name.Image = Image.FromFile("UI/Names/Регина Закирова.png");
                name.Location = new Point(1066, 224);

            }
            else
            {
                Avatar.Image = Image.FromFile("UI/Avatar/male.png");
                name.Image = Image.FromFile("UI/Names/Андрей Фатюшкин.png");
                label1.Visible = false;
                label1.Enabled = false;
            }
            if (account== 2)
            {
                Зачётка.Enabled = false;
                Портфолио.Enabled = false;
                Зачётка.Visible = false;
                Портфолио.Visible = false;
                ПортфICO.Visible = false;
                ПортфICO.Enabled = false;
                

            }
        }

        private void Главная_MouseLeave(object sender, EventArgs e)
        {
            Главная.Image = Image.FromFile("UI/Left/Главная/Главная.png");
        }

        private void Вестимпк_MouseLeave(object sender, EventArgs e)
        {
            Вестимпк.Image = Image.FromFile("UI/Left/Вести МПК/Вести МПК.png");
        }

        private void Отделения_MouseLeave(object sender, EventArgs e)
        {
            Отделения.Image = Image.FromFile("UI/Left/Отделения/Отделения.png");
        }

        private void Расписание_MouseLeave(object sender, EventArgs e)
        {
            Расписание.Image = Image.FromFile("UI/Left/Расписание/Расписание.png");
        }

        private void Замена_MouseLeave(object sender, EventArgs e)
        {
            Замена.Image = Image.FromFile("UI/Left/Замена/Замены.png");
        }

        private void Портфолио_MouseLeave(object sender, EventArgs e)
        {
            Портфолио.Image = Image.FromFile("UI/Right/Портфолио/Портфолио.png");
        }

        private void Зачётка_MouseLeave(object sender, EventArgs e)
        {
            Зачётка.Image = Image.FromFile("UI/Right/Зачётная кнг/Зачётная кнг..png");
        }

        private void Сообщения_MouseLeave(object sender, EventArgs e)
        {
            Сообщения.Image = Image.FromFile("UI/Right/Сообщения/Сообщения.png");
        }

        private void Уведомления_MouseLeave(object sender, EventArgs e)
        {
            Уведомления.Image = Image.FromFile("UI/Right/Уведомления/Уведомления.png");
        }

        private void Новости_MouseLeave(object sender, EventArgs e)
        {
            Новости.Image = Image.FromFile("UI/Center/Новости.png");
        }

        private void новостиl_MouseLeave(object sender, EventArgs e)
        {

            новостиl.Image = Image.FromFile("UI/Icons/icons8-external-link-51.png");
        }

        private void новости2l_MouseLeave(object sender, EventArgs e)
        {
            новости2l.Image = Image.FromFile("UI/Icons/icons8-external-link-51.png");
        }

        private void новости3l_MouseLeave(object sender, EventArgs e)
        {
            новости3l.Image = Image.FromFile("UI/Icons/icons8-external-link-51.png");
        }

        private void NameK_MouseLeave(object sender, EventArgs e)
        {
            NameK.Image = Image.FromFile("UI/Center/Многопрофильный колледж.png");
        }

        private void Вашикурсы_MouseLeave(object sender, EventArgs e)
        {
            Вашикурсы.Image = Image.FromFile("UI/Right/Ваши курсы/Ваши курсы.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 journal = new Form3();
            journal.Show();
            this.Hide();
        }

        
    }
}
