using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine($"\n========= LENDO ARQUIVOS =========\n" +
                $"CAMINHO: {arquivoComCaminho}" +
                "\n===========================");
             
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoComCaminho2 = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Ler(numeroArquivo + 1);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
