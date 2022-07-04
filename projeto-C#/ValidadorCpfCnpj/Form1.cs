using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCpfCnpj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool validaCpf(string cpf)
        {

            bool cpfValido = true;
            //verificar se a variavel tem 11 digitos
            if (cpf.Length != 11)
            {
                cpfValido = false;

            }
            //Verificar se todos os digitos são numeriocs
            for (byte i = 0; i < cpf.Length; i++)
            {
                if (!char.IsDigit(cpf[i]))
                {
                    cpfValido &= false;
                    break;
                }
            }
            bool vNum = false;
            //verifificar se todos os digitos são iguais
            for (byte i = 0; i < cpf.Length; i++)
            {
                if (cpf[0] != cpf[i])
                {
                    vNum = true;
                    break;
                }

            }
            if (cpf == "12345678989" || !vNum)
            {
                cpfValido = false;

            }
            else
            {
                //varificando primeiro digito de controle
                int j = 0;
                int d1 = 0;
                int d2 = 0;

                for (byte i = 10; i > 1; i--)
                {
                    d1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }
                d1 = (d1 * 10) % 11;
                if (d1 >= 10)
                {
                    d1 = 0;
                }
                //verificando se o primeiro digito de controle bateu
                if (d1 != Convert.ToInt32(cpf.Substring(9, 1)))
                {
                    cpfValido = false;

                }
                else
                {
                    //verificando o segundo digito de controle
                    j = 0;
                    for (byte i = 11; i > 1; i--)
                    {
                        d2 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                        j++;
                    }
                    d2 = (d2 * 10) % 11;
                    if (d2 >= 10)
                    {
                        d2 = 0;
                    }
                    if (d2 != Convert.ToInt32(cpf.Substring(10, 1)))
                    {
                        cpfValido = false;
                    }

                }
               
            }


            return cpfValido;
        }


        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVarifcar_Click(object sender, EventArgs e)
        {
          bool verifica = validaCpf(txtCpf.Text);
            if (!verifica)
            {
                lblFalse.ForeColor = Color.Red;
                lblFalse.Text = "Cpf Falso";
            }
            else
            {
                lblFalse.ForeColor = Color.Green;
                lblFalse.Text = "Cpf Valido";
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string entCpf = "";
            bool digValido = true;

            for (int i = 0; i < txtEntrada.Text.Length; i++)
            {
                if (!char.IsDigit(txtEntrada.Text[i]))
                {
                    MessageBox.Show("Digite Apenas Caracteres Numericos!");
                    digValido = false;
                    break;
                }
                break;
            }
            if (txtEntrada.Text == "" || txtEntrada.Text.Length != 8 || !digValido)
            {
                MessageBox.Show("Entre com um Numero de 8 digitos");
            }
            else
            {
                 entCpf = txtEntrada.Text;

            }


                string digitoEstado = "";

                if (rdbEst1.Checked == true)
                {
                    digitoEstado = "1";
                }
                if (rdbEst2.Checked == true)
                {
                    digitoEstado = "2";
                }
                if (rdbEst3.Checked == true)
                {
                    digitoEstado = "3";
                }
                if (rdbEst4.Checked == true)
                {
                    digitoEstado = "4";
                }
                if (rdbEst5.Checked == true)
                {
                    digitoEstado = "5";
                }
                if (rdbEst6.Checked == true)
                {
                    digitoEstado = "6";
                }
                if (rdbEst7.Checked == true)
                {
                    digitoEstado = "7";
                }
                if (rdbEst8.Checked == true)
                {
                    digitoEstado = "8";
                }
                if (rdbEst9.Checked == true)
                {
                    digitoEstado = "9";
                }
                if (rdbEst0.Checked == true)
                {
                    digitoEstado = "0";
                }

            if (digitoEstado == "")
            {
                MessageBox.Show("Selecione Um Codigo De Estado!");
            }
            else
            {



                entCpf += digitoEstado;

                //adiciona primeiro digito verificador
                int dig1 = 0;
                int dig2 = 0;
                int cont = 0;
                for (byte i = 10; i > 1; i--)
                {
                    dig1 += Convert.ToInt32(entCpf.Substring(cont, 1)) * i;
                    cont++;
                }
                dig1 = (dig1 * 10) % 11;
                if (dig1 >= 10)
                {
                    dig1 = 0;
                }
                entCpf += Convert.ToString(dig1);
                cont = 0;
                //adiciona segundo digito verificador
                for (byte i = 11; i > 1; i--)
                {
                    dig2 += Convert.ToInt32(entCpf.Substring(cont, 1)) * i;
                    cont++;
                }
                dig2 = (dig2 * 10) % 11;
                if (dig2 >= 10)
                {
                    dig2 = 0;
                }
                entCpf += Convert.ToString(dig2);

                txtSaida.Text = entCpf;


            }
        }
    }
}
