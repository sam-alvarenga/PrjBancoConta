using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //biblioteca parar trabalhar com intercionalização
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PrjBancoConta.Forms.Demo
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnFormatar_Click(object sender, EventArgs e)
        {
            //Em C#, o sufixo M é usado para indicar que um valor numérico é do tipo decimal.
            //decimal preco = 199.99;

            //decimal preco = 199;

            //decimal preco = 199 *(decimal) Math.PI;

            //txtNumFormatado.Text = $"Preço do produto {preco:C}";//C: formatar em dinheiro dependedo da localidade

            //txtNumFormatado.Text = $"Preço do produto {preco:N1}"; // quantidade de casas decimais 

            //txtNumFormatado2.Text = $"Preço do produto {preco:N5}"; // quantidade de casas decimais



            //double fatorPercentual = .70; //Como o valor de fatorPercentual é 0.70, o método ToString("P") o multiplica por 100 e adiciona o símbolo de porcentagem(%), resultando em 70 %.

            /* txtNumFormatado.Text = $"Percentual: {fatorPercentual.ToString("P")}";*/ //O método ToString("P") converte o valor da variável fatorPercentual para uma string formatada como porcentagem.

            //Manipulando a localização do sistema para inglês/Americano

            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-UK"); //CultureInfo: é uma classe usada para fornecer informações relacionadas a uma localização específica, como formatação de data, hora. New cria uma nova instância da classe CultureInfo configurada/convenções  para a cultura Inglês (Reino Unido). O identificador "en-UK"
           // decimal preco = 1999 * (decimal)Math.PI;
            //txtNumFormatado.Text = $"Preço do produto {preco:C}";

            //DateTime dataHoje = DateTime.Now;
            //txtNumFormatado2.Text = dataHoje.ToString();


            //Manipulando a saída
            //txtNumFormatado2.Text =  preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            //tipo long é um "int" com maior capacidade numerica.
            //long cpf = 12345677788;
            //txtNumFormatado2.Text = cpf.ToString("000.000.000-00");

            // barra escapa o formato
            DateTime data = DateTime.Now;
            txtNumFormatado2.Text = data.ToString("dd \\de MMMM \\de \\ yyyy HH:mm");
            
            /*d - dia
             * M - mes
             * y - ano
             * h - hora
             * m - minuto
             * s - segundo
             */
            
        }
    }
}
