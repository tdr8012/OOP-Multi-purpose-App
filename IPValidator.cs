using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectForOOP
{
    public partial class IPValidator : Form
    {
        public IPValidator()
        {
            InitializeComponent();
        }

        Regex obj;
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void IPValidator_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        static string dirPath = @"..\Test\";
        string path = dirPath + "IPv4.txt";
        FileStream fs = null;

        static string dirPath2 = @"..\Test\";
        string path2 = dirPath2 + "IPv6.txt";
        FileStream fs2 = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                obj = new Regex(@"^(\d{1,3}\.){3}\d{1,3}$");
                if (obj.IsMatch(textBox1.Text) == true)
                {
                    MessageBox.Show("Correct IP v4 form");
                }
                else
                {
                    MessageBox.Show("Incorrect IP v4 form");
                }
            }

            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                obj = new Regex(@"^(?:[\w]{1,4}:){6}(:|[\w]{1,4})$");
                if (obj.IsMatch(textBox2.Text) == true)
                {
                    MessageBox.Show("Correct IP v6 form");
                }
                else
                {
                    MessageBox.Show("Incorrect IP v6 form");
                }
            }

            try
            {

                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")}\n{textBox1.Text}");
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
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }

            try
            {

                fs2 = new FileStream(path2, FileMode.Append, FileAccess.Write);
                StreamWriter sw2 = new StreamWriter(fs2);
                sw2.Write($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")}\n{textBox2.Text}");
                sw2.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path2 + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath2 + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs2 != null) fs2.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
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

            try
            {
                fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fs2);
                string textToPrint1 = "";

                while (sr1.Peek() != -1)
                {
                    string row1 = sr1.ReadLine().Trim();
                    textToPrint1 += row1 + "\n";
                }
                MessageBox.Show(textToPrint1);
                sr1.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path2 + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath2 + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }

            finally { if (fs2 != null) fs2.Close(); }
        }
    }
}
