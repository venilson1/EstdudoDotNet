using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class TelaUsuario
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_USUARIOS = 1;
        public const int CADASTRAR_USUARIOS = 2;
        public static void Chamar()
        {
            while (true)
            {
                string mensagem = 
                        "\n    Digite uma das opções abaixo \n" +
                        "\n      1 - Listar Usuarios " +
                        "\n      2 - Cadastrar Usuarios" +
                        "\n\n      0 - Voltar";
                
                Console.WriteLine(mensagem);
                

                int valor = int.Parse(Console.ReadLine());
                Console.Clear();

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                
                else if (valor == LER_USUARIOS)
                {

                    Console.WriteLine("======================");
                    Console.WriteLine("   LISTA DE USUARIOS  ");
                    Console.WriteLine("======================\n");

                    var listaDeUsuarios = new Usuario().Ler();
                    foreach (Usuario u in listaDeUsuarios)
                    {
                        Console.WriteLine($"Nome: { u.Nome}");
                        Console.WriteLine($"Telefone: { u.Telefone}");
                        Console.WriteLine($"CPF: { u.CPF}");
                        Console.WriteLine("======================\n");

                    }

                    Console.ReadLine();
                    Console.Clear();
                }

                else if (valor == CADASTRAR_USUARIOS)
                {
                    var newU = new Usuario();

                    Console.WriteLine("======================");
                    Console.WriteLine("   CADASTRAR USUARIO  ");
                    Console.WriteLine("======================\n");

                    Console.WriteLine("Digite o nome do Usuario:");
                    var nome = newU.Nome = Console.ReadLine();

                    Console.WriteLine($"Digite o telefone de {nome}:");
                    newU.Telefone = Console.ReadLine();

                    Console.WriteLine($"Digite o CPF de {nome}:");
                    newU.CPF = Console.ReadLine();

                    newU.Gravar();
                    Console.Clear();
                }

            }


                


           
        }
    }
}
