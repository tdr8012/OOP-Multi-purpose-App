using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectForOOP
{
    public partial class TempConvertor : Form
    {
        public TempConvertor()
        {
            InitializeComponent();
        }
        public class TempConvertors
        {
            private float num;
            public float Num
            {
                get { return num; }
                set { num = value; }
            }

            public TempConvertors()
            {

            }
            public TempConvertors(float num)
            {
                this.num = num;
            }
            internal float CtoF(float num)
            {
                return (num * 9 / 5) + 32;
            }

            internal float FtoC(float num)
            {
                return (num-32) *5 /9;
            }
        }
        static string dirPath = @"..\Test\";
        string path = dirPath + "TempConversions.txt";
        FileStream fs = null;
        
        private void button1_Click(object sender, EventArgs e)
        {
            string chosenTemp = "";
            try
            {
                TempConvertors tempConverted = new TempConvertors();
                float num = Convert.ToSingle(textBox1.Text);

                if (radioButton1.Checked)
                {
                    chosenTemp = radioButton1.Text;
                    num = tempConverted.CtoF(num);
                    textBox2.Text = Convert.ToString(num);
                    textBox3.Text = GetTemperatureDescription(num, "F");
                }
                else if (radioButton2.Checked)
                {
                    chosenTemp = radioButton2.Text;
                    num = tempConverted.FtoC(num);
                    textBox2.Text = Convert.ToString(num);
                    textBox3.Text = GetTemperatureDescription(Convert.ToSingle(textBox2.Text), "C");
                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            try
            {

                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")}\n{textBox1.Text} {chosenTemp} = {textBox1.Text} {label3.Text}");
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
        }
        private string GetTemperatureDescription(float temperature, string unit)
        {

            switch (unit)
            {
                case "C":
                    {
                        textBox3.Text = GetCelsiusDescription(temperature);
                        break;
                    }
                case "F":
                    {
                        textBox3.Text = GetFahrenheitDescription(temperature);
                        break;
                    }
                default:
                    {
                        textBox3.Text = "Invalid unit.";
                        break;
                    }
                    
            }

            return textBox3.Text;
        }
        private string GetCelsiusDescription(float temperature)
        {

            if (temperature > 40 && temperature <= 100)
            {
                textBox3.Text = "Water boils";
            }
            else if (temperature <= 40 && temperature > 37)
            {
                textBox3.Text = "Hot Bath";
            }
            else if (temperature <= 37 && temperature > 30)
            {
                textBox3.Text = "Body temperature";
            }
            else if (temperature <= 30 && temperature > 21)
            {
                textBox3.Text = "Beach Weather";
            }
            else if (temperature <= 21 && temperature > 10)
            {
                textBox3.Text = "Room Temperature";
            }
            else if (temperature <= 10 && temperature > 0)
            {
                textBox3.Text = "Cool Day";
            }
            else if (temperature <= 0 && temperature > -18)
            {
                textBox3.Text = "Freezing point of water";
            }
            else if (temperature <= -18 && temperature > -40)
            {
                textBox3.Text = "Very Cold Day";
            }
            else if (temperature == -40)
            {
                textBox3.Text = "Extremly Cold Day";
            }
            return textBox3.Text;
        }

        private string GetFahrenheitDescription(float temperature)
        {
            if (temperature > 212 && temperature <= 104)
            {
                textBox3.Text = "Water boils";
            }
            else if (temperature <= 104 || temperature > 98.6)
            {
                textBox3.Text = "Hot Bath";
            }
            else if (temperature <= 98.6 && temperature > 86)
            {
                textBox3.Text = "Body temperature";
            }
            else if (temperature <= 86 && temperature > 70)
            {
                textBox3.Text = "Beach Weather";
            }
            else if (temperature <= 70 && temperature > 50)
            {
                textBox3.Text = "Room Temperature";
            }
            else if (temperature <= 50 && temperature > 32)
            {
                textBox3.Text = "Cool Day";
            }
            else if (temperature <= 32 && temperature > 0)
            {
                textBox3.Text = "Freezing point of water";
            }
            else if (temperature <= 0 && temperature > -40)
            {
                textBox3.Text = "Very Cold Day";
            }
            else if (temperature == -40)
            {
                textBox3.Text = "Extremly Cold Day";
            }
            return textBox3.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TempConvertor_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "C";
            label3.Text = "F";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "F";
            label3.Text = "C";
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
        }
    }
}
