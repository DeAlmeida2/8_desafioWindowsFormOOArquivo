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

        public void gravarNoArquivoEntrada(Veiculo v) //gravar os veículos no arquivo;
        {

            using (StreamWriter escritor = File.AppendText(caminho))
            {
                string linha = v.Estacionado + ";" + v.Placa + ";" + v.DataEntrada + ";" + v.HoraEntrada + ";" + v.DataSaida +";" + v.HoraSaida + ";" + v.TempoPermanencia + ";" + v.ValorCobrado;
                escritor.WriteLine(linha);
            }

        }
          
        public void alterarStatus (Veiculo veiculo) //Pegar a linha e alterar de "s" para "n" os veículos estacionados;
        {

            string[] linhas=File.ReadAllLines(caminho);

            string[] vetorDados = new string[8];
            for (int i = 0; i < linhas.Length; i++)
            {
                vetorDados = linhas[i].Split(';');
                string estacionado = vetorDados[0];

                if (vetorDados[1] == veiculo.Placa && estacionado == "s")
                {
                   linhas[i] = $"n;{vetorDados[1]};{vetorDados[2]};{vetorDados[3]};{veiculo.DataSaida};{veiculo.HoraSaida}; {veiculo.TempoPermanencia};{veiculo.ValorCobrado}";

                }
            }
            File.WriteAllLines(caminho, linhas);
        
        }
            
            public static void gravarNoArquivoSaida(List<Veiculo> lista) //Gravar no arquivo;
        {
            StreamWriter escritor = new StreamWriter("teste");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.DataSaida + ";" + i.HoraSaida + ";" + i.TempoPermanencia + ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }

        public List<Veiculo> lerArquivoEntrada () //Ler no arquivo de entrada;
        {
            string linha;
            string[] vetorDados = new string[8];
            List<Veiculo> list = new List<Veiculo>();
            using (StreamReader sr = File.OpenText(caminho))
            {//verificando as linhas do dat
                
                while ((linha = sr.ReadLine()) != null)
                    
                {

                    vetorDados = linha.Split(';');
                    DateTime horainicio = Convert.ToDateTime(vetorDados[2]);
                    DateTime horafim = Convert.ToDateTime(vetorDados[3]);
                    string estacionado = vetorDados[0];
                    Veiculo veiculo = new Veiculo(estacionado, vetorDados[1], horainicio, horafim, Convert.ToDateTime(vetorDados[4]), Convert.ToDateTime(vetorDados[5]),int.Parse(vetorDados[6]), double.Parse(vetorDados[7])); 
                    
                    list.Add(veiculo);

                }

            }
            return list;

            
        }
       
    }
}


    
