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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Игра в Угадайку";
            lblGame.Text = "Игра в Угадайку";
            btnCheck.Text = "";
            Random rand = new Random(100);            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
