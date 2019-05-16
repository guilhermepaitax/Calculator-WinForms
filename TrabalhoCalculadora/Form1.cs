using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        double num1, num2;//Criando as variáveis do tipo double que irão receber os valores dos números usados nas contas.
        String operacao;//Criando variável do tipo string que irá receber a operação que será efetuada.

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            labelResultado.Text = labelResultado.Text + "0";//Adiciona o número 0 na labelResultado
            
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "1";//Substitui o texto da label por 1
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "1";//Adiciona o número 1 ao conteúdo da labelResultado
            }
            
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "2";//Substitui o texto da label por 2
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "2";//Adiciona o número 2 ao conteúdo da labelResultado
            }
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "3";//Substitui o texto da label por 3
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "3";//Adiciona o número 3 ao conteúdo da labelResultado
            }
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "4";//Substitui o texto da label por 4
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "4";//Adiciona o número 4 ao conteúdo da labelResultado
            }
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "5";//Substitui o texto da label por 5
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "5";//Adiciona o número 5 ao conteúdo da labelResultado
            }
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "6";//Substitui o texto da label por 6
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "6";//Adiciona o número 6 ao conteúdo da labelResultado
            }
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "7";//Substitui o texto da label por 7
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "7";//Adiciona o número 7 ao conteúdo da labelResultado
            }
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "8";//Substitui o texto da label por 8
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "8";//Adiciona o número 8 ao conteúdo da labelResultado
            }
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")//Verifica se o conteúdo da labelResultado é 0 para que possa ser substituido
            {
                labelResultado.Text = "9";//Substitui o texto da label por 9
            }
            else//Caso o conteúdo da labelResultado não for 0
            {
                labelResultado.Text = labelResultado.Text + "9";//Adiciona o número 9 ao conteúdo da labelResultado
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "soma")//Verifica se o valor da variável operacao é igual á soma, para calcular a operação correspondente
            {
                num2 = Double.Parse(labelResultado.Text);//A variável num2 recebe o valor da labelResultado convertido para double
                num1 = num1 + num2;// Ocorre a soma da variável num1 com o num2, que é armazenada na variável num1
                labelResultado.Text = num1.ToString();//É exibido o valor da num1 na labelResultado
                operacao = "";//A operação é zerada
            }
            if (operacao == "subtracao")//Verifica se o valor da variável operacao é igual á subtracao, para calcular a operação correspondente
            {
                num2 = Double.Parse(labelResultado.Text);//A variável num2 recebe o valor da labelResultado convertido para double
                num1 = num1 - num2;// Ocorre a subtração da variável num1 com o num2, que é armazenada na variável num1
                labelResultado.Text = num1.ToString();//É exibido o valor da num1 na labelResultado
                operacao = "";//A operação é zerada
            }
            if (operacao == "multiplicacao")//Verifica se o valor da variável operacao é igual á multiplicação, para calcular a operação correspondente
            {
                num2 = Double.Parse(labelResultado.Text);//A variável num2 recebe o valor da labelResultado convertido para double
                num1 = num1 * num2;// Ocorre a multiplicação da variável num1 com o num2, que é armazenada na variável num1
                labelResultado.Text = num1.ToString();//É exibido o valor da num1 na labelResultado
                operacao = "";//A operação é zerada
            }
            if (operacao == "divisao")//Verifica se o valor da variável operacao é igual á divisão, para calcular a operação correspondente
            {
                num2 = Double.Parse(labelResultado.Text);//A variável num2 recebe o valor da labelResultado convertido para double
                if (num2 != 0) {//Verifica se o valor de num2 é diferente de 0
                    num1 = num1 / num2;// Ocorre a divisão da variável num1 com o num2, que é armazenada na variável num1
                    labelResultado.Text = num1.ToString();//É exibido o valor da num1 na labelResultado
                    operacao = "";//A operação é zerada
                }
                else//Caso num2 for igual a zero não é possível calcular a divisão
                {
                    MessageBox.Show("Impossivel dividir por 0","Erro");//É exibido a menssagem que é Impossivel dividir por 0
                }
                }
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            
                num1 = Double.Parse(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double 
                operacao = "subtracao";//A variável num1 recebe o valor de subtracao
                labelResultado.Text = "0";// É zerado o valor da labelResultado
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {          
                num1 = Double.Parse(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double 
                operacao = "multiplicacao";//A variável num1 recebe o valor de multiplicacao
                labelResultado.Text = "0";// É zerado o valor da labelResultado          
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            
                num1 = Double.Parse(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double
                operacao = "divisao";//A variável num1 recebe o valor de divisao
                labelResultado.Text = "0";// É zerado o valor da labelResultado 

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "0";// É zerado o valor da labelResultado 
            operacao = "";//A operação é zerada
            num1 = 0;// A variável num1 recebe 0 
            num2 = 0;// A variável num2 recebe 0

        }

        private void buttonXaoQuadrado_Click(object sender, EventArgs e)
        {
            
                num1 = Double.Parse(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double
                labelResultado.Text = (num1 * num1).ToString();//É exibido na labelResultado o valor de num1 multiplicado por num1
            
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            
                if (Double.Parse(labelResultado.Text) > 0)//Verifica se o valor convertido para double da labelResultado é maior que 0
                {
                    num1 = Double.Parse(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double
                    num1 = Math.Sqrt(num1);//A variavel num1 recebe o valor da raiz de num1 calculada com a função Math.Sqrt
                    labelResultado.Text = num1.ToString();//É exibido na labelResultado o valor de num1 convertido para String 
               
                }
                else//Caso o valor de num1 for igual ou menor que 0
                {
                    MessageBox.Show("Entrada inválida", "Erro");// É exibido a menssagem de Entrada inválida, pois não é possivel calcular a operação
            }
                
            
        }

        private void buttonPorcent_Click(object sender, EventArgs e)
        {
            
            labelResultado.Text = ((num1/100) * Double.Parse(labelResultado.Text)).ToString();//labelResultado recebe o valor de num1 dividido por 100 e multiplicado pelo valor da label, convertido para String
            
        }

        private void button1porX_Click(object sender, EventArgs e)
        {
            
                if (labelResultado.Text != "0")//Verifica se o valor da labelResultado é diferente de 0
                {
                    num1 = Double.Parse(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double 
                    labelResultado.Text = (1 / num1).ToString();//É exibido na labelResultado o valor de 1 dividido por num1, convertido para String
                }
                else//Caso labelResultado tenha o valor igual a 0
                {
                    MessageBox.Show("Impossivel dividir por 0", "Erro");//É exibido a menssagem Impossivel dividir por 0
            }
            
            
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {       

                //Verificação para colocar a virgula
                try//Tenta converter o conteúdo da label para um int, pois não pussui virgula.Caso consiga converter significa que o número não possui virgula então é adicionado uma, caso não consiga ele não faz nada pois já tem virgula.
                {
                    Convert.ToInt32(labelResultado.Text);
                    labelResultado.Text = labelResultado.Text + ",";
                }
                catch
                {

                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            labelResultado.Text = (Double.Parse(labelResultado.Text) * -1).ToString();//Multiplica o valor da label convertido para double por -1, para inverter o sinal.
            
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            labelResultado.Text = Math.PI.ToString();//Adiciona a labelResultado o valor de PI usando o Math.PI.
        }

        private void buttonSeno_Click(object sender, EventArgs e)
        {
             
            labelResultado.Text = (Math.Sin(Double.Parse(labelResultado.Text))).ToString();//Calcula o valor do seno com o Math.Sin

        }

        private void buttonCosseno_Click(object sender, EventArgs e)
        {
            
            
                labelResultado.Text = (Math.Cos(Double.Parse(labelResultado.Text))).ToString();//Calcula o valor do cosseno com o Math.Cos

        }

        private void buttonTangente_Click(object sender, EventArgs e)
        {
            
                labelResultado.Text = (Math.Tan(Double.Parse(labelResultado.Text))).ToString();//Calcula o valor da tangente com o Math.Tan

        }

        private void buttonGrauRadiano_Click(object sender, EventArgs e)
        {
            
                num1 = Convert.ToDouble(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double
                labelResultado.Text = (num1 * 0.0174533).ToString();//Converte o valor de graus para radianos e exibe na labelResultado
            
            
        }

        private void buttonRadianoGrau_Click(object sender, EventArgs e)
        {
            
                num1 = Convert.ToDouble(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double
                labelResultado.Text = (num1 * 57.2958).ToString();//Converte o valor de radianos para graus e exibe na labelResultado


        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            
                num1 = Double.Parse(labelResultado.Text);//A variável num1 recebe o valor da labelResultado convertido para double
                operacao = "soma";//A variável num1 recebe o valor de soma
                labelResultado.Text = "0";// É zerado o valor da labelResultado

        }
    }
}
