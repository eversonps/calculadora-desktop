using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex___6
{
    public partial class frmPrincipal : Form
    {
        // declaração de variaveis.
        double m, aux, cont = 0, cont2 = 0;
        double result = 0;
        string op = "";

        public frmPrincipal()
        {
            InitializeComponent();
            contador2();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // adicionando o valor "8" na richtextbox.
            if (rchExibir.Text == "0")
            {
                a();
            }

            rchExibir.Text += "8";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // adicionando o valor "1" na richtextbox.

            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // adicionando o valor "2" na richtextbox.
            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // adicionando o valor "3" na richtextbox.

            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // adicionando o valor "0" na richtextbox.

            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "0";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // adicionando o valor "4" na richtextbox.

            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // adicionando o valor "5" na richtextbox.

            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // adicionando o valor "6" na richtextbox.

            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // adicionando o valor "7" na richtextbox.

            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // programando botão de "=".

            if (op == "+")
            {
                soma();
                rchExibir.Text = result.ToString();
            }
            if (op == "-")
            {
                sub();
                rchExibir.Text = result.ToString();
            }
            if (op == "*")
            {
                mult();
                rchExibir.Text = result.ToString();
            }
            if (op == "/")
            {
                if (double.Parse(rchExibir.Text) != 0)
                {
                    div();
                    rchExibir.Text = result.ToString();
                }
                if (double.Parse(rchExibir.Text) == 0)
                {
                    MessageBox.Show("Não pode dividir por 0");
                    rchExibir.Text = "";
                }

            }
            txtAux.Text = "";
            cont = 0;         
            result = 0;
            cont2 = 0;
            contador2();
            btnDec.Enabled = false;


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (rchExibir.Text == "0")
            {
                a();
            }
            rchExibir.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // programando botão de apagar tudo.

            btnDec.Enabled = true; 
            rchExibir.Text = "";
            txtAux.Text = "";
            result = 0;
            cont2 = 0;
            contador2();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            // Programando botão de soma.

            btnDec.Enabled = true;
            if (cont2 == 1)
            {
                op = "+";
                cont2 = 0;
            }

            if (op == "*")
            {
                mult();
                rchExibir.Text = "";
                op = "+";
                txtAux.Text += aux + " " + op + " ";
            }
            else
             if (op == "-")
            {
                sub();
                rchExibir.Text = "";
                op = "+";
                txtAux.Text += aux + " " + op + " ";
            }
            else
             if (op == "/")
            {
                if (double.Parse(rchExibir.Text) != 0)
                {
                    div();
                    rchExibir.Text = "";
                    op = "+";
                    txtAux.Text += aux + " " + op + " ";
                }
                else
               if (double.Parse(rchExibir.Text) == 0)
                {
                    MessageBox.Show("Não pode dividir por 0");
                    rchExibir.Text = "";
                }
            }
            else
            if (op == "+")
            {
                soma();
                rchExibir.Text = "";
                op = "+";
                txtAux.Text += aux + " " + op + " ";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            // Programando botão de subtração.

            btnDec.Enabled = true;
            if (cont2 == 1)
            {
                op = "-";
                cont2 = 0;
            }

            if (op == "*")
            {
                mult();
                rchExibir.Text = "";
                op = "-";
                txtAux.Text += aux + " " + op + " ";
            }

            else
            if (op == "+")
            {
                soma();
                rchExibir.Text = "";
                op = "-";
                txtAux.Text += aux + " " + op + " ";
            }

            else
            if (op == "/")
            {
                if (double.Parse(rchExibir.Text) != 0)
                {
                    div();
                    rchExibir.Text = "";
                    op = "-";
                    txtAux.Text += aux + " " + op + " ";
                }

            else
                if (double.Parse(rchExibir.Text) == 0)
                {
                    MessageBox.Show("Não pode dividir por 0");
                    rchExibir.Text = "";
                }
            }

            else
           if (op == "-")
            {
                if (cont == 0)
                {
                    aux = double.Parse(rchExibir.Text);
                    result = aux;
                    rchExibir.Text = "";
                    op = "-";
                    txtAux.Text += aux + " " + op + " ";
                    cont++;
                }

                else
                if (cont == 1)
                {
                    sub();
                    rchExibir.Text = "";
                    op = "-";
                    txtAux.Text += aux + " " + op + " ";
                }
            }
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            // Programando botão de multiplicação.

            btnDec.Enabled = true;
            if (cont2 == 1)
            {
                op = "*";
                cont2 = 0;
            }

            if (op == "+")
            {
                soma();
                rchExibir.Text = "";
                op = "*";
                txtAux.Text += aux + " " + op + " ";
            }

           else
           if (op == "-")
            {
                sub();
                rchExibir.Text = "";
                op = "*";
                txtAux.Text += aux + " " + op + " ";
            }

           else
           if (op == "/")
            {
                if (double.Parse(rchExibir.Text) != 0)
                {
                    div();
                    rchExibir.Text = "";
                    op = "*";
                    txtAux.Text += aux + " " + op + " ";
                }

                else
                if (double.Parse(rchExibir.Text) == 0)
                {
                    MessageBox.Show("Não pode dividir por 0");
                    rchExibir.Text = "";
                }
            }

            else
            if (op == "*")
            {
                if (cont == 0)
                {
                    result = 1;
                    cont++;
                }
                mult();
                rchExibir.Text = "";
                op = "*";
                txtAux.Text += aux + " " + op + " ";
            }
        }
        private void btnDivisão_Click(object sender, EventArgs e)
        {
            // Programando botão de dividir.

            btnDec.Enabled = true;
            if (cont2 == 1)
            {
                op = "/";
                cont2 = 0;
            }

            if (op == "*")
            {
                mult();
                rchExibir.Text = "";
                op = "/";
                txtAux.Text += aux + " " + op + " ";
            }

            else
            if (op == "-")
            {
                sub();
                rchExibir.Text = "";
                op = "/";
                txtAux.Text += aux + " " + op + " ";
            }

            else
            if (op == "+")
            {
                soma();
                rchExibir.Text = "";
                op = "/";
                txtAux.Text += aux + " " + op + " ";
            }

            else
            if (op == "/")
            {              
                if (cont == 0)
                {
                    aux = double.Parse(rchExibir.Text);
                    result = aux;
                    rchExibir.Text = "";
                    op = "/";
                    txtAux.Text += aux + " " + op + " ";
                    cont++;
                }
                else

                if (cont == 1)
                {
                    div();
                    rchExibir.Text = "";
                    op = "/";
                    txtAux.Text += aux + " " + op + " ";
                }
            }
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            // Programando botão de 1/X.

            double troca = double.Parse(rchExibir.Text);
            troca = 1 / troca;
            rchExibir.Text = troca.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // calculando raiz quadrada.

            btnDec.Enabled = true;
            double raiz = double.Parse(rchExibir.Text);
            raiz = Math.Sqrt(raiz);
            rchExibir.Text = raiz.ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {

            // adicionando vírgula na richtextbox.

            rchExibir.Text += ",";
            btnDec.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {

            // programando botão de apagar apenas um caractere da richtextbox.

            int apagar = rchExibir.Text.Length - 1;
            if (apagar >= 0)
                rchExibir.Text = rchExibir.Text.Substring(0, apagar);
        }

        private void button26_Click(object sender, EventArgs e)
        {

            // calculando potenciação.

            btnDec.Enabled = true;
            double potencia = double.Parse(rchExibir.Text);
            potencia = Math.Pow(potencia, 2);
            rchExibir.Text = potencia.ToString();
        }

        private void rchExibir_TextChanged(object sender, EventArgs e)
        {

        }
        private void a()
        {
            rchExibir.Text = "";

        }

        private void btnMaismenos_Click(object sender, EventArgs e)
        {
            // programando botão de mais e menos;

            double vlr = double.Parse(rchExibir.Text);
            vlr = vlr * (-1);
            rchExibir.Text = vlr.ToString();
        }

        private void btnPorc_Click(object sender, EventArgs e)
        {
            // Calculando porcentagem.

            double porc = double.Parse(rchExibir.Text);
            porc = result * porc / 100;
            rchExibir.Text = porc.ToString();
        }

        private void btnMmais_Click(object sender, EventArgs e)
        {

            // somar um valor na memória.

            m += double.Parse(rchExibir.Text);

        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            // programando botão para exibir o que está na memória.
            rchExibir.Text = m.ToString();
        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {

            // programando botão para subtrair um valor na memória

            double mm = double.Parse(rchExibir.Text);
            m = m - mm;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {

            // zerar o valor que está na memória

            m = 0;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {

            // programando botão para adicionar valor a memória

            m = double.Parse(rchExibir.Text);
        }

        private void contador2()
        {
            // método criado para chama-lo, assim que compilar o prog
            cont2++;
        }
        private void mult()
        {
            // método de multiplicação.

            aux = double.Parse(rchExibir.Text);
            result = aux * result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // programando botão de apagar o que está escrito na richtextbox.
            rchExibir.Text = "";
            btnDec.Enabled = true;
        }

        private void div()
        {
            // método de divisão.
            aux = double.Parse(rchExibir.Text);
            result = result / aux;
        }

        private void sub()
        {
            // método de subtração.
            aux = double.Parse(rchExibir.Text);
            result = result - aux;
        }

        private void soma()
        {
            // método de soma.
            aux = double.Parse(rchExibir.Text);
            result = aux + result;
        }
    }
}

