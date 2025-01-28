using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectForOOP
{
    public partial class frmMax : Form
    {
        public frmMax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        static string dirPath = @"..\Test\";
        static string path = dirPath + "Max.txt";
        FileStream fs = null;
        private void button3_Click(object sender, EventArgs e)
        {
            string numbers = " ";
            Random random = new Random();
            int randomNumber = random.Next(1,50);
            numbers += randomNumber.ToString() + "\t";
            numbers += randomNumber.ToString() + "\t";
            randomNumber = random.Next(1, 50);
            numbers += randomNumber.ToString() + "\t";
            randomNumber = random.Next(1, 50);
            numbers += randomNumber.ToString() + "\t";
            randomNumber = random.Next(1, 50);
            numbers += randomNumber.ToString() + "\t";
            randomNumber = random.Next(1, 50);
            numbers += randomNumber.ToString() + "\t";
            randomNumber = random.Next(1, 50);
            numbers += randomNumber.ToString() + "\t";
            textBox1.Text = numbers;

            try
            {

                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")}, {textBox1.Text}");
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void frmMax_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string textToPrint = "";

                while (sr.Peek() != -1)
                {
                    string row = sr.ReadLine().Trim();
                    textToPrint += row + "\n";
                }
                MessageBox.Show(textToPrint);
                sr.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }

            finally { if (fs != null) fs.Close(); }
        }
    }
}

