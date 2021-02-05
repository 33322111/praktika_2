using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika05
{
    public partial class Form2 : Form
    {
        public string FirstData { get; private set; }        
        public string SecondData { get; private set; }

        public Form2(string str)
        {
            InitializeComponent();
            FirstData = str;
        }

        private void btnGetDataForm1_Click(object sender, EventArgs e)
        {
            txtForm2_first.Text = FirstData;
        }

        private void btnSendDataToForm1_Click(object sender, EventArgs e)
        {
            SecondData = txtForm2_second.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SecondData))
            {
                MessageBox.Show("Введите ответ первой форме нажмите кнопку слева!", 
                    "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
