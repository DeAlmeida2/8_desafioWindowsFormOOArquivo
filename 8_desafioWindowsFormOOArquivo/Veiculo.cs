using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_desafioWindowsFormOOArquivo
{
    internal class Veiculo
    {
        string placa;
        DateTime dataEntrada;
        DateTime horaEntrada;
        DateTime dataSaida;
        DateTime horaSaida;
        int tempoPermanencia;
        Double valorCobrado;
        string estacionado;



        public Veiculo(string estacionados, string placa, DateTime dataEntrada, DateTime horaEntrada)
        {
            this.estacionado = estacionados;
            this.Placa = placa;
            this.DataEntrada = dataEntrada;
            this.HoraEntrada = horaEntrada;


        }
        public Veiculo(string placa)
        {
            this.Placa = placa;
            estacionado = "s";
            DataEntrada = DateTime.Now;
            HoraEntrada = DateTime.Now;
            DataSaida = DateTime.Now;
            HoraSaida = DateTime.Now;
            tempoPermanencia = 0;
            valorCobrado = 0;
        }
        //O construtor é usado na leitura de saída dos veículos que já entraram

        /// <param name="placa">Identificação do veículo</param>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        /// <param name="tempoPermanecia">tempo em minutos</param>
        /// <param name="valorCobrado"></param>
        public Veiculo(string estacionados, string placa, DateTime dataEntrada, DateTime horaEntrada,
            DateTime dataSaida, DateTime horaSaida, int tempoPermanecia, double valorCobrado) : this(estacionados, placa, dataEntrada, horaEntrada)
        {
            this.dataSaida = dataSaida;
            this.horaSaida = horaSaida;
            this.tempoPermanencia = tempoPermanecia;
            this.valorCobrado = valorCobrado;
        }

        public void gerarDataHora(string tipo) //Gerar a data e hora e jogar no dataGrid;
        {
            DateTime dateTime = DateTime.Now;
            DateTime[] vetorDados = new DateTime[2];
            switch (tipo)
            {
                case "entrada":
                    this.DataEntrada = vetorDados[0];
                    this.HoraEntrada = vetorDados[1];
                    break;
                case "saida":
                    this.DataSaida = vetorDados[0];
                    this.HoraSaida = vetorDados[1];
                    break;
                default:
                    break;
            }
        }

        //metodo que calcula o tempo de permanencia(em minutos) e calcula o valor de cobranca
        /// </summary>
        /// <param name="valorHora">valor de referencia da hora</param>
        public void realizarCobranca(double valorHora)
        {
            int entrada = horaEntrada.Hour * 60 + horaEntrada.Minute; //Onde transformamos o tempo em minutos;


            int saida = horaSaida.Hour * 60 + horaSaida.Minute;

            this.TempoPermanencia = saida - entrada;
            double resultado = (double)this.TempoPermanencia / 60;
            double qtdHorasNaGaragem = Math.Ceiling(resultado);

            this.valorCobrado = (int)qtdHorasNaGaragem * valorHora;
        }
        public string Placa { get => placa; set => placa = value; }
        public DateTime DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime DataSaida { get => dataSaida; set => dataSaida = value; }
        public DateTime HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }
        public string Estacionado { get => estacionado; set => estacionado = value; }
     

    }
}


