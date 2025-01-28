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

namespace projectForOOP
{
    public partial class MoneyConvertor : Form
    {
        public class MoneyExchange
        {
            private double num;
            public double Num
            {
                get { return num; }
                set { num = value; }
            }

            public MoneyExchange()
            {

            }
            public MoneyExchange(double num)
            {
                this.num = num;
            }
            internal double cadToUSD(double num)
            {
                return num * 0.7579602;
            }

            internal double cadToEUR(double num)
            {
                return num * 0.68059079;
            }

            internal double cadToGBP(double num)
            {
                return num * 0.58336193;
            }
            internal double cadToVND(double num)
            {
                return num * 17870.657;
            }
            internal double cadToYEN(double num)
            {
                return num * 104.87025;
            }
            internal double usdToCAD(double num)
            {
                return num * 1.3194704;
            }
            internal double usdToEUR(double num)
            {
                return num * 0.89811112;
            }
            internal double usdToGBP(double num)
            {
                return num * 0.76980937;
            }
            internal double usdToVND(double num)
            {
                return num * 23581.454;
            }
            internal double usdToYen(double num)
            {
                return num * 138.38844;
            }
            internal double eurToCAD(double num)
            {
                return num * 1.4692594;
            }
            internal double eurToUSD(double num)
            {
                return num * 1.113592;
            }
            internal double eurToGBP(double num)
            {
                return num * 0.85724961;
            }
            internal double eurToVND(double num)
            {
                return num * 26262.402;
            }
            internal double eurToYEN(double num)
            {
                return num * 154.12659;
            }
            internal double gbpToCAD(double num)
            {
                return num * 1.7136804;
            }
            internal double gbpToUSD(double num)
            {
                return num * 1.299135;
            }
            internal double gbpToEUR(double num)
            {
                return num * 1.1665408;
            }
            internal double gbpToVND(double num)
            {
                return num * 30667.487;
            }
            internal double gbpToYEN(double num)
            {
                return num * 179.80221;
            }
            internal double vndToCAD(double num)
            {
                return num * 0.000055936878;
            }
            internal double vndToUSD(double num)
            {
                return num * 0.000042368297;
            }
            internal double vndToEUR(double num)
            {
                return num * 0.00003808186;
            }
            internal double vndToGBP(double num)
            {
                return num * 0.000032646175;
            }
            internal double vndToYEN(double num)
            {
                return num * 0.0058698007;
            }
        }
        public MoneyConvertor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        static string dirPath = @"..\Test\";
        string path = dirPath + "MoneyConversions.txt";
        FileStream fs = null;
        private void button4_Click(object sender, EventArgs e)
        {
            string chosenCurrency = "";
            if (!string.IsNullOrWhiteSpace(textBox7.Text))
            {
                if (radioButton1.Checked)
                {
                    chosenCurrency = radioButton1.Text;
                    MoneyExchange converNum = new MoneyExchange();
                    int i;
                    double[] num = new double[6];
                    double[] num2 = new double[6];
                    for (i = 0; i < 6; i++)
                    {
                        num[i] = Convert.ToDouble(textBox7.Text);
                        for (int j = 0; j < 6; j++)
                        {
                            switch (j)
                            {
                                case 0:
                                    textBox1.Text = num[i].ToString();
                                    break;
                                case 1:
                                    {
                                        num2[i] = converNum.cadToUSD(num[i]);
                                        textBox2.Text = num2[i].ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        num2[i] = converNum.cadToEUR(num[i]);
                                        textBox3.Text = num2[i].ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        num2[i] = converNum.cadToGBP(num[i]);
                                        textBox4.Text = num2[i].ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        num2[i] = converNum.cadToVND(num[i]);
                                        textBox5.Text = num2[i].ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        num2[i] = converNum.cadToYEN(num[i]);
                                        textBox6.Text = num2[i].ToString();
                                        break;
                                    }
                            }
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    chosenCurrency = radioButton2.Text;
                    MoneyExchange converNum = new MoneyExchange();
                    int i;
                    double[] num = new double[6];
                    double[] num2 = new double[6];
                    for (i = 0; i < 6; i++)
                    {
                        num[i] = Convert.ToDouble(textBox7.Text);
                        for (int j = 0; j < 6; j++)
                        {
                            switch (j)
                            {
                                case 0:
                                    textBox2.Text = num[i].ToString();
                                    break;
                                case 1:
                                    {
                                        num2[i] = converNum.usdToCAD(num[i]);
                                        textBox1.Text = num2[i].ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        num2[i] = converNum.usdToEUR(num[i]);
                                        textBox3.Text = num2[i].ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        num2[i] = converNum.usdToGBP(num[i]);
                                        textBox4.Text = num2[i].ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        num2[i] = converNum.usdToVND(num[i]);
                                        textBox5.Text = num2[i].ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        num2[i] = converNum.usdToYen(num[i]);
                                        textBox6.Text = num2[i].ToString();
                                        break;
                                    }
                            }
                        }
                    }
                }
                else if (radioButton3.Checked)
                {
                    chosenCurrency = radioButton2.Text;
                    MoneyExchange converNum = new MoneyExchange();
                    int i;
                    double[] num = new double[6];
                    double[] num2 = new double[6];
                    for (i = 0; i < 6; i++)
                    {
                        num[i] = Convert.ToDouble(textBox7.Text);
                        for (int j = 0; j < 6; j++)
                        {
                            switch (j)
                            {
                                case 0:
                                    textBox3.Text = num[i].ToString();
                                    break;
                                case 1:
                                    {
                                        num2[i] = converNum.eurToCAD(num[i]);
                                        textBox1.Text = num2[i].ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        num2[i] = converNum.eurToUSD(num[i]);
                                        textBox2.Text = num2[i].ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        num2[i] = converNum.eurToGBP(num[i]);
                                        textBox4.Text = num2[i].ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        num2[i] = converNum.eurToVND(num[i]);
                                        textBox5.Text = num2[i].ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        num2[i] = converNum.eurToYEN(num[i]);
                                        textBox6.Text = num2[i].ToString();
                                        break;
                                    }
                            }
                        }
                    }
                }
                else if (radioButton4.Checked)
                {
                    chosenCurrency = radioButton3.Text;
                    MoneyExchange converNum = new MoneyExchange();
                    int i;
                    double[] num = new double[6];
                    double[] num2 = new double[6];
                    for (i = 0; i < 6; i++)
                    {
                        num[i] = Convert.ToDouble(textBox7.Text);
                        for (int j = 0; j < 6; j++)
                        {
                            switch (j)
                            {
                                case 0:
                                    textBox4.Text = num[i].ToString();
                                    break;
                                case 1:
                                    {
                                        num2[i] = converNum.gbpToCAD(num[i]);
                                        textBox1.Text = num2[i].ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        num2[i] = converNum.gbpToUSD(num[i]);
                                        textBox2.Text = num2[i].ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        num2[i] = converNum.gbpToEUR(num[i]);
                                        textBox3.Text = num2[i].ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        num2[i] = converNum.gbpToVND(num[i]);
                                        textBox5.Text = num2[i].ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        num2[i] = converNum.gbpToYEN(num[i]);
                                        textBox6.Text = num2[i].ToString();
                                        break;
                                    }
                            }
                        }
                    }
                }
                else if (radioButton5.Checked)
                {
                    chosenCurrency = radioButton4.Text;
                    MoneyExchange converNum = new MoneyExchange();
                    int i;
                    double[] num = new double[6];
                    double[] num2 = new double[6];
                    for (i = 0; i < 6; i++)
                    {
                        num[i] = Convert.ToDouble(textBox7.Text);
                        for (int j = 0; j < 6; j++)
                        {
                            switch (j)
                            {
                                case 0:
                                    textBox5.Text = num[i].ToString();
                                    break;
                                case 1:
                                    {
                                        num2[i] = converNum.vndToCAD(num[i]);
                                        textBox1.Text = num2[i].ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        num2[i] = converNum.vndToUSD(num[i]);
                                        textBox2.Text = num2[i].ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        num2[i] = converNum.vndToEUR(num[i]);
                                        textBox3.Text = num2[i].ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        num2[i] = converNum.vndToGBP(num[i]);
                                        textBox4.Text = num2[i].ToString();
                                        break;
                                    }
                                case 5:
                                    {
                                        num2[i] = converNum.vndToYEN(num[i]);
                                        textBox6.Text = num2[i].ToString();
                                        break;
                                    }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                }
            }
            try
            {

                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);


                sw.Write($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")}\n{textBox7.Text} {chosenCurrency} = {textBox1.Text} CAD; {textBox2.Text} USD; {textBox3.Text} EUR; {textBox4.Text} GBP; {textBox5.Text} VND; {textBox6.Text} YEN\n");

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


        private void MoneyConvertor_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        private void button5_Click(object sender, EventArgs e)
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



