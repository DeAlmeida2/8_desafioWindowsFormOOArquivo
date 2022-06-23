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
         //Lista de veiculos estacionados na garagem
        List<Veiculo> estacionados = new List<Veiculo>();

        List<Veiculo> naoestacionados = new List<Veiculo>();
        public Cadastro()
                {//local do arquivo
            Persistencia P = new Persistencia(@"C:\Users\Andre\OneDrive\Documentos\Aula .NET\Form\8_desafioWindowsFormOOArquivo\8_desafioWindowsFormOOArquivo\teste.txt");

            estacionados = P.lerArquivoEntrada().Where(x => x.Estacionado == "s").ToList();
            naoestacionados = P.lerArquivoEntrada().Where(x => x.Estacionado == "n").ToList();

            InitializeComponent();

            dataGrid_veiculosEstacionados.Columns.Add("placa", "placa");
            dataGrid_veiculosEstacionados.Columns.Add("Data Entrada", "Data Entrada");
            dataGrid_veiculosEstacionados.Columns.Add("Hora Entrada", "Hora Entrada");
            dataGrid_veiculosSaida.Columns.Add("placa", "placa");
            dataGrid_veiculosSaida.Columns.Add("Data Saída", "Data Saída");
            dataGrid_veiculosSaida.Columns.Add("Hora Saída", "Hora Saída");


            foreach (Veiculo i in P.lerArquivoEntrada()) //Onde o sistema faz a leitura das informações do arquivo;
            {
                if (i.Estacionado == "s")

                    dataGrid_veiculosEstacionados.Rows.Add(i.Placa, i.DataEntrada.ToString("dd/MM/yyyy"), i.HoraEntrada.TimeOfDay);
                else
                    dataGrid_veiculosSaida.Rows.Add(i.Placa, i.DataSaida.ToString("dd/MM/yyyy"), i.HoraSaida.TimeOfDay);
            }
           

        }

        private void populardatagrid() //Onde o sistema populariza o arquivo com as informações;
        {
            Persistencia P = new Persistencia(@"C:\Users\Andre\OneDrive\Documentos\Aula .NET\Form\8_desafioWindowsFormOOArquivo\8_desafioWindowsFormOOArquivo\teste.txt");

            foreach (Veiculo i in P.lerArquivoEntrada())
            {
                if (i.Estacionado == "s")

                    dataGrid_veiculosEstacionados.Rows.Add(i.Placa, i.DataEntrada.ToString("dd/MM/yyyy"), i.HoraEntrada.TimeOfDay);
                else
                    dataGrid_veiculosSaida.Rows.Add(i.Placa, i.DataSaida.ToString("dd/MM/yyyy"), i.HoraSaida.TimeOfDay);
            }
        }

        private void limpardatagrid() //Onde o sistema limpa o arquivo para não trazer placas duplicadas;
        {
            dataGrid_veiculosEstacionados.Rows.Clear();
            dataGrid_veiculosSaida.Rows.Clear();
        }


        //A lista de veículo que sairam do estacionamento
        List<Veiculo> historico = new List<Veiculo>();
        double precoHora = 5;

        
        private void button_menu_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show(this);


        }

        private void button_CadastrarEntrada_Click(object sender, EventArgs e)
        {

            bool jaEstacionado = false; //Onde temos quesitos de segurança, como digitar =7 caracteres, limite de vagas e placa já cadastrada;
            if (estacionados.Count() >= 50)
            {
                MessageBox.Show("Não há vagas, favor aguardar a retirada de um´Veículo");
            }
            else if (textBox_cadPlaca.Text.Count() != 7)
            {
                MessageBox.Show("Digite uma placa válida");
            }
            else
            {
                if (estacionados.Any(x => x.Placa == textBox_cadPlaca.Text&&x.Estacionado=="s"))
                {
                    MessageBox.Show("Placa já cadastrada, favor retirar o carro da garagem");
                    jaEstacionado = true;

                }


                if (!jaEstacionado)
                {
                    //Onde adiciona um novo veículo na lista de vagas disponíveis
                    Veiculo v = new Veiculo(textBox_cadPlaca.Text);

                    dataGrid_veiculosEstacionados.Rows.Add(v.Placa, v.DataEntrada, v.HoraEntrada);
                    estacionados.Add(v);

                    Persistencia persistencia = new Persistencia(@"C:\Users\Andre\OneDrive\Documentos\Aula .NET\Form\8_desafioWindowsFormOOArquivo\8_desafioWindowsFormOOArquivo\teste.txt");
                    persistencia.gravarNoArquivoEntrada(v);


                    //Onde é verificado se a quantidade máxima de vagas foi atingida
                    MessageBox.Show($"{estacionados.Where(x=> x.Estacionado=="s").Count()} veiculos estão na garagem, ainda restam {50 - estacionados.Where(x => x.Estacionado == "s").Count()} vagas");

                }


            }

        }

        private void button_cadSaida_Click(object sender, EventArgs e)
        {
            
            {
                //Registrar a saida de um veículo da vaga;
                DataGridViewRow linhaSelecionada = dataGrid_veiculosEstacionados.CurrentRow;
                int indice = linhaSelecionada.Index;
                string placa = (string)dataGrid_veiculosEstacionados.Rows[indice].Cells[0].Value;

                Veiculo veiculo = estacionados.FirstOrDefault(x => x.Placa == placa && x.Estacionado == "s");
                veiculo.DataSaida=DateTime.Now;
                veiculo.HoraSaida = DateTime.Now;
                veiculo.realizarCobranca(precoHora);



                Persistencia persistencia = new Persistencia(@"C:\Users\Andre\OneDrive\Documentos\Aula .NET\Form\8_desafioWindowsFormOOArquivo\8_desafioWindowsFormOOArquivo\teste.txt");
                persistencia.alterarStatus(veiculo);

                estacionados.Remove(estacionados.FirstOrDefault(x => x.Placa == placa));
                
                //após limpar as informações do datagrid, será populaziado novamente com os dados atualizados;
                limpardatagrid();

                populardatagrid();

                MessageBox.Show("O veículo ficou estacionado por : " + veiculo.TempoPermanencia + " minutos. \n O valor do serviço de estacionamento ficou de :  " + veiculo.ValorCobrado.ToString("c"));
                     //informar o tempo de permanência e o valor dos serviços prestados;                        
               
                }
            }
        }
    }


       
    





