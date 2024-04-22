using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu_das_doras_diogo
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Operacao
        {
            soma,
            subtrai,
            divide,
            multiplica,
            nenhuma
        }
        static Operacao ultimaOperacao = Operacao.nenhuma;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacao.nenhuma)
            {
                fazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacao.nenhuma;    
        }
        
        
        
        
    
        private void button17_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.subtrai;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            TextBoxDisplay.Text += (sender as Button).Text;
        }
      
        private void button11_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBoxDisplay.Text.Length > 0)
            {
                TextBoxDisplay.Text =
                TextBoxDisplay.Text.Remove(TextBoxDisplay.TextLength - 1, 1);

            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.soma;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            TextBoxDisplay.Text += (sender as Button).Text;
        }
        private void fazerCalculo(Operacao ultimaOperacao)
        {
            List<double> Listadenumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case Operacao.soma:
                    Listadenumeros = TextBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    TextBoxDisplay.Text = (Listadenumeros[0] + Listadenumeros[1]).ToString();
                    break;
                case Operacao.subtrai:
                    Listadenumeros = TextBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    TextBoxDisplay.Text = (Listadenumeros[0] - Listadenumeros[1]).ToString();
                    break;
                case Operacao.divide:
                    Listadenumeros = TextBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    TextBoxDisplay.Text = (Listadenumeros[0] / Listadenumeros[1]).ToString();
                    break;
                case Operacao.multiplica:
                    Listadenumeros = TextBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    TextBoxDisplay.Text = (Listadenumeros[0] * Listadenumeros[1]).ToString();
                    break;
                case Operacao.nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += (sender as Button).Text ; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "1";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "6";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "8"; //WIFE
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.multiplica;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            TextBoxDisplay.Text += (sender as Button).Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.divide;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            TextBoxDisplay.Text += (sender as Button).Text;
        }
    }

}