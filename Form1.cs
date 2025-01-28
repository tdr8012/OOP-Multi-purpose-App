using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectForOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to Exit?", "Exit", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMax obj = new frmMax();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form649 obj = new Form649();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoneyConvertor obj = new MoneyConvertor();
            obj.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TempConvertor obj = new TempConvertor();
            obj.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Simple_Calculator obj = new Simple_Calculator();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            IPValidator iPValidator = new IPValidator();
            iPValidator.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
