using System;
using System.Windows.Forms;

namespace CalculadoraGospel
{
    public partial class Form1 : Form
    {
        double total = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_numerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
            label2.Text = "";
            label1.Text = "";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            txt_valor.Clear();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            label1.Text = "+";
            operacao = "+";

        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            label1.Text = "-";
            operacao = "-";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            label1.Text = "X";
            operacao = "*";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            label1.Text = "÷";
            operacao = "/";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                label2.Text = "=";
                txt_valor.Text = Convert.ToString(total + Convert.ToDouble(txt_valor.Text));
            }
            else if (operacao == "-")
            {
                label2.Text = "=";
                txt_valor.Text = Convert.ToString(total - Convert.ToDouble(txt_valor.Text));
            }
            else if (operacao == "*")
            {
                label2.Text = "=";
                txt_valor.Text = Convert.ToString(total * Convert.ToDouble(txt_valor.Text));
            }
            else if (operacao == "/")
            {
                label2.Text = "=";
                txt_valor.Text = Convert.ToString(total / Convert.ToDouble(txt_valor.Text));
            }
        }
    }
}
