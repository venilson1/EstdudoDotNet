using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaFornecedor
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_FORNCEDORES = 1;
        public const int CADASTRAR_FORNECEDOR = 2;
        public static void Chamar()
        {
            while (true)
            {
                string mensagem = 
                        "\n    Digite uma das opções abaixo \n" +
                        "\n      1 - Listar Fornecedores " +
                        "\n      2 - Cadastrar Fornecedores" +
                        "\n\n      0 - Voltar";
                
                Console.WriteLine(mensagem);
                

                int valor = int.Parse(Console.ReadLine());
                Console.Clear();

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                
                else if (valor == LER_FORNCEDORES)
                {

                    Console.WriteLine("======================");
                    Console.WriteLine("   LISTA DE FORNECEDORES  ");
                    Console.WriteLine("======================\n");

                    var listaDeFornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor f in listaDeFornecedores)
                    {
                        Console.WriteLine($"Nome: {f.Nome}");
                        Console.WriteLine($"CNPJ: {f.CNPJ}");
                        Console.WriteLine($"Telefone: {f.Telefone}");
                        Console.WriteLine($"CPF do gerente: {f.CPF}");
                        Console.WriteLine("======================\n");

                    }

                    Console.ReadLine();
                    Console.Clear();
                }

                else if (valor == CADASTRAR_FORNECEDOR)
                {
                    var newF = new Fornecedor();

                    Console.WriteLine("======================");
                    Console.WriteLine("   CADASTRAR FORNCEDOR  ");
                    Console.WriteLine("======================\n");

                    Console.WriteLine("Digite o nome do Fornecedor:");
                    var nome = newF.Nome = Console.ReadLine();

                    Console.WriteLine($"Digite o CNPJ de {nome}:");
                    newF.CNPJ = Console.ReadLine();

                    Console.WriteLine($"Digite o telefone de {nome}:");
                    newF.Telefone = Console.ReadLine();

                    Console.WriteLine($"Digite o CPF do gerente da {nome}:");
                    newF.CPF = Console.ReadLine();

                    newF.Gravar();
                    Console.Clear();
                }

            }


                


           
        }
    }
}
