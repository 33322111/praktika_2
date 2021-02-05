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
    public partial class Form1 : Form
    {
        public string AnswerData { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendToForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(txtForm1_first.Text);
            if (f.ShowDialog() == DialogResult.OK)
                AnswerData = f.SecondData;
        }

        private void btnGetForm2Data_Click(object sender, EventArgs e)
        {
            txtForm1_second.Text = AnswerData;
        }
    }
}
