using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_desafioWindowsFormOOArquivo
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            Persistencia P = new Persistencia(@"C:\Users\Andre\OneDrive\Documentos\Aula .NET\Form\8_desafioWindowsFormOOArquivo\8_desafioWindowsFormOOArquivo\teste.txt");
            
             InitializeComponent();

            dataGrid_veiculosEstacionados.Columns.Add("placa","placa");
            dataGrid_veiculosEstacionados.Columns.Add("Hora Entrada", "Hora Entrada");
            dataGrid_veiculosEstacionados.Columns.Add("Data Entrada", "Data Entrada");

            foreach (Veiculo i in P.lerArquivoEntrada())
            {
                dataGrid_veiculosEstacionados.Rows.Add(i.Placa,i.HoraEntrada,i.HoraSaida);

            }

        }
        //Lista de veiculos estacionados na garagem
        List<Veiculo> estacionados = new List<Veiculo>();

        //Lista de veículo que sairam do estacionamento
        List<Veiculo> historico = new List<Veiculo>();
        double precoHora = 5;

        /// Registro de carros no estacionamento. Não é possível registrar duas placas iguais. Limite de 50 carros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button_menu_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show(this);


        }

        private void button_cadEntrada_Click(object sender, EventArgs e)
        {
            //CadastarEntrada cadastarEntrada = new CadastarEntrada();
            //cadastarEntrada.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_cadPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_consultar_Click(object sender, EventArgs e)
        {

        }

        private void button_CadastrarEntrada_Click(object sender, EventArgs e)
        {

            bool jaEstacionado = false;
            if (estacionados.Count() >= 50)
            {
                MessageBox.Show("Não há vagas, favor aguardar a retirada de um´Veículo");
            }
            else if (textBox_cadPlaca.Text.Count() < 7)
            {
                MessageBox.Show("Digite uma placa válida");
            }
            else
            {
                if (estacionados.Any(x => x.Placa == textBox_cadPlaca.Text))
                {
                    MessageBox.Show("Placa já cadastrada, favor retirar o carro da garagem");
                    jaEstacionado = true;

                }


                if (!jaEstacionado)
                {
                    //Adiciona um novo veículo na lista de vagas disponíveis
                    Veiculo v = new Veiculo(textBox_cadPlaca.Text);

                    dataGrid_veiculosEstacionados.Rows.Add(v.Placa, v.DataEntrada, v.DataEntrada);
                    estacionados.Add(v);
                    //verifica se a quantidade máxima de vagas foi atingida
                    MessageBox.Show($"{estacionados.Count()} veiculos estão na garagem, ainda restam {50 - estacionados.Count()} vagas");
                }


            }





        }
    }
}
/// <summary>
/// Registra a saída de um veículo da garagem e informa o preço a ser pago
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

/*private void button_cadSaida_Click(object sender, EventArgs e)
{
    //Registrar a saida de um veículo da vaga e informar o preço pago no total
    DataGridViewRow linhaSelecionada = dataGrid_veiculosEstacionados.CurrentRow;
    int indice = linhaSelecionada.Index;
    string placa = (string)dataGrid_veiculosEstacionados.Rows[indice].Cells[1].Value;
    int indexVeiculo;
    //adiciona o veículo na lista de registro diário
    foreach (Veiculo i in estacionados)
    {
        if (i.Placa.Equals(placa))
        {
            indexVeiculo = estacionados.IndexOf(i);
            historico.Add(i);
            i.HoraSaida = DateTime.Now;
            i.Permanencia = i.HoraSaida.Subtract(i.DataEntrada);
            i.Valorpago = Math.Ceiling((i.Permanencia.TotalMinutes / 60)) * precoHora;
            MessageBox.Show($"O valor a ser cobrado é {i.Valorpago} reais, equivalente a {Math.Ceiling(i.Permanencia.TotalHours)} hora(s)");
            break;
        }


    }


}
}
*/


