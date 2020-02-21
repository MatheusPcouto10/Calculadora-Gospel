using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valor.Clear();
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            operacao = "+";

        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            operacao = "-";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            operacao = "*";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            total = double.Parse(txt_valor.Text);
            txt_valor.Text = "";
            operacao = "/";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                txt_valor.Text = Convert.ToString(total + Convert.ToInt32(txt_valor.Text));
            }
            else if (operacao == "-")
            {
                txt_valor.Text = Convert.ToString(total - Convert.ToInt32(txt_valor.Text));
            }
            else if (operacao == "*")
            {
                txt_valor.Text = Convert.ToString(total * Convert.ToInt32(txt_valor.Text));
            }
            else if (operacao == "/")
            {
                txt_valor.Text = Convert.ToString(total / Convert.ToInt32(txt_valor.Text));
            }
        }
    }
}
