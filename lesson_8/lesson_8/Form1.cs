using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        TrueFalse database = new TrueFalse();
        public Form1()
        {
            InitializeComponent();
            btnFile.Text = "File";
            miNew.Text = "New";
            miOpen.Text = "Open";
            miSave.Text = "Save";
            miExit.Text = "Exit";
            cboxTrue.Text = "Правда";
            btnAdd.Text = "Добавить";
            btnDelete.Text = "Удалить";
            btnSaveQuest.Text = "Сохранить";
            
        }

        private void miNew_Click(object sender, EventArgs e)
        {

        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {

        }

        private void miExit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }
    }
}
