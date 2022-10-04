using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _islem = "";
        bool ekranTemizle = true;
        int ilkSayi;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            
            int sonSayi = Int32.Parse(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case "+":
                    sonuc = ilkSayi + sonSayi;
                    break;
                case "-":
                    sonuc = ilkSayi - sonSayi;
                    break;
                case "*":
                    sonuc = ilkSayi * sonSayi;
                    break;
                case "/":
                    sonuc = ilkSayi / sonSayi;
                    break;
                case "%":
                    sonuc = ilkSayi % sonSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }
        
        private void btnTopla_Click(object sender, EventArgs e)
        {
            _islem = "+";
            ekranTemizle = true;
            ilkSayi = Int32.Parse(ekranLabel.Text);
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            _islem = "-";
            ekranTemizle = true;
            ilkSayi = Int32.Parse(ekranLabel.Text);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            _islem = "*";
            ekranTemizle = true;
            ilkSayi = Int32.Parse(ekranLabel.Text);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            _islem = "/";
            ekranTemizle = true;
            ilkSayi = Int32.Parse(ekranLabel.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void btnKalan_Click(object sender, EventArgs e)
        {
            _islem = "%";
            ekranTemizle = true;
            ilkSayi = Int32.Parse(ekranLabel.Text);

        }

        private void btnKucuktur_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "<";
        }

        private void btnBuyuktur_Click(object sender, EventArgs e)
        {
            if (ekranTemizle) //ikinsi sayıya basılınca ekranı temizlesin
            {
                ekranLabel.Text = "";
                ekranTemizle = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += ">";
        }
    }
}
