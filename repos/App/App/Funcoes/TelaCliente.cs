using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaCliente
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_CLIENTES = 1;
        public const int CADASTRAR_CLIENTES = 2;
        public static void Chamar()
        {
            while (true)
            {
                string mensagem = 
                        "\n    Digite uma das opções abaixo\n" +
                        "\n      1 - Listar clientes" +
                        "\n      2 - Cadastrar Clientes" +
                        "\n\n      0 - Voltar";
                
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                Console.Clear();

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                
                else if (valor == LER_CLIENTES)
                {

                    //LerCliente é um método estático então não precisa criar uma instância
                    //método estatico: É sempre usado quando for fazer uma ação para varias 
                    //pessoas do modelo

                    Console.WriteLine("======================");
                    Console.WriteLine("   LISTA DE CLIENTES  ");
                    Console.WriteLine("======================\n");

                    var listaDeClientes = new Cliente().Ler();
                    foreach (Cliente c in listaDeClientes)
                    {
                        
                        Console.WriteLine($"Nome: {c.Nome}");
                        Console.WriteLine($"Telefone: {c.Telefone}");
                        Console.WriteLine($"CPF: {c.CPF}");
                        Console.WriteLine("======================\n");
                    }

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    //nova instancia de cliente
                    //cria uma variavel que recebe todos os metodos 
                    //e propriedades de instancia (ou seja não estatica) da Classe Cliente
                    var newC = new Cliente();

                    Console.WriteLine("======================");
                    Console.WriteLine("   CADASTRAR CLIENTE  ");
                    Console.WriteLine("======================\n");

                    Console.WriteLine("Digite o nome do Cliente:");
                    var nome = newC.Nome = Console.ReadLine();

                    Console.WriteLine($"\nDigite o telefone de {nome}:");
                    newC.Telefone = Console.ReadLine();

                    Console.WriteLine($"\nDigite o CPF de {nome}:");
                    newC.CPF = Console.ReadLine();
                    
                    newC.Gravar();
                    Console.Clear();
                }

            }
        }
    }
}
