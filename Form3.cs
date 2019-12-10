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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("ПрК 17-1");
            comboBox1.Items.Add("Пр 17-1");
            comboBox2.Items.Add("Прикладное программирование");
            comboBox2.Items.Add("Компьютерные сети");
        }
        public Form3(Stundent stundent, int account)
        {
            InitializeComponent();
        }
        int account2 = Stundent.account;
        private void Min2form_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit2form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(account2== 2)
            {
                
                
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.Visible = false;
                comboBox2.Enabled = false;
                comboBox2.Visible = false;
                dataGridView1.ColumnCount = 2;
                dataGridView1.RowCount = 2;
                dataGridView1.Rows[0].Cells[0].Value = "Прикладное программирование";
                dataGridView1.Rows[1].Cells[0].Value = "Компьютерные сети";
            }
        }
    }
}
