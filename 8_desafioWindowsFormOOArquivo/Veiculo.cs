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

        

        public Veiculo(string placa, DateTime dataEntrada, DateTime horaEntrada)
        {
            this.Placa = placa;
            this.DataEntrada = dataEntrada;
            this.HoraEntrada = horaEntrada;

        }
        public Veiculo(string placa)
        {
            this.Placa = placa;
        }
        //O construtor é usado na leitura de saída dos veículos que já entraram

        /// <param name="placa">Identificação do veículo</param>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        /// <param name="tempoPermanecia">tempo em minutos</param>
        /// <param name="valorCobrado"></param>
        public Veiculo (string placa, DateTime dataEntrada, DateTime horaEntrada,
            DateTime dataSaida, DateTime horaSaida, int tempoPermanecia, double valorCobrado) : this(placa, dataEntrada, horaEntrada)
        {
            this.dataSaida = dataSaida;
            this.horaSaida = horaSaida;
            this.tempoPermanencia = tempoPermanecia;
            this.valorCobrado = valorCobrado;
        }

               public void gerarDataHora(string tipo)
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
            //horaEntrada = "8:14"; -> 8*60+14 = 494
            //horaSaida = "10:15";  -> 10*60+15 = 615
            //descobrindo o tempo em minutos da entrada
            int entrada = horaEntrada.Hour*60+horaEntrada.Minute;

            //descobrindo o tempo em minutos da saida
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

        /// <summary>
        /// metodo que procura um veiculo na lista a partir de sua placa
        /// </summary>
        /// <param name="placa">identificação do veículo</param>
        /// <param name="lista">lista de veículos ou de entrada ou de saída</param>
        /// <returns>a posição em que o veículo se encontra na lista, caso contrário, -27</returns>
        public static int localizado(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27; //codigo do ESC, ou seja, veiculo nao localizado
        }
        /// <summary>
        /// metodo que descobre se há espaço ou não na garagem, ou lista de controle da garagem
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        /// <param name="tamanhoGaragem">quantidade de vagas na garagem</param>
        /// <returns></returns>
        public static bool temLugar(List<Veiculo> lista, int tamanhoGaragem)
        {
            return lista.Count < tamanhoGaragem;

        }

}
}
