using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnStart1.Text = "Начать";
            btnStart2.Text = "Начать";
            lblMain.Text = "Главное меню";
            lblGame1.Text = "Игра \"Удвоитель\"";
            lblGame2.Text = "Игра \"Угадай число\"";
            this.Text = "Главное меню";
        }


        private void btnStart_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            MessageBox.Show("Получить 205 за 12 ходов");
            f.ShowDialog();
        }

        private void btnStart_2(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

    }
}
