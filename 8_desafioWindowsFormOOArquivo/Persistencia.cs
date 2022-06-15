using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_desafioWindowsFormOOArquivo
{
    internal class Persistencia
    {
        public string caminho {get;set;}
        public Persistencia(string caminho)
        {
            this.caminho = caminho;
        }

        public static void gravarNoArquivoEntrada(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosEntrada.dat", true);

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada);
                escritor.Flush();
            }
            escritor.Close();
        }
        public static void gravarNoArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.DataSaida + ";" + i.HoraSaida + ";" + i.TempoPermanencia + ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }

        public List<Veiculo> lerArquivoEntrada ()
        {
            string linha;
            string[] vetorDados = new string[3];
            List<Veiculo> list = new List<Veiculo>();
            using (StreamReader sr = File.OpenText(caminho))
            {//verificando as linhas do dat
                
                while ((linha = sr.ReadLine()) != null)
                    
                {

                    vetorDados = linha.Split(';');
                    DateTime horainicio = Convert.ToDateTime(vetorDados[1]);
                    DateTime horafim = Convert.ToDateTime(vetorDados[2]);
                    Veiculo veiculo = new Veiculo(vetorDados[0], horainicio, horafim); 

                    list.Add(veiculo);

                }

            }
            return list;

            
        }
        /// <summary>
        /// método que popula a lista de veículos de passaram pela garagem a partir do arquivo base
        /// </summary>
        /// <param name="lista">lista veículos</param>
        public void lerArquivoSaida(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculosSaida.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                lista.Add(new Veiculo(vetorDados[0], Convert.ToDateTime(vetorDados[1]), Convert.ToDateTime(vetorDados[2]), Convert.ToDateTime(vetorDados[3]),
                    Convert.ToDateTime(vetorDados[4]), int.Parse(vetorDados[5]), double.Parse(vetorDados[6])));
            } while (!leitor.EndOfStream);
            leitor.Close();

        }
    }
}

    
