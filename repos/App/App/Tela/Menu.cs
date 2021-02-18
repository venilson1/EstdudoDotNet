using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela
{
    class Menu
    {
            public const int SAIDA_PROGRAMA = 0;
            public const int LER_ARQUIVOS = 1;
            public const int TABUADA = 2;
            public const int CALCULO_MEDIA = 3;
            public const int CADASTRAR_CLIENTES = 4;
            public const int CADASTRAR_USUARIOS = 5;
            public const int CADASTRAR_FORNECEDORES = 6;
        public static void Criar()
            {

            Console.WriteLine("\nOlá Fulano, Seja Bem Vindo ao Programa de Testes\n");
                while (true)
                {

                string mensagem =
                    "=================================================\n" +
                    "\n  Digite uma das opções abaixo\n" +
                    "\n      1 - Para ler Arquivos" +
                    "\n      2 - Para executar tabuada" +
                    "\n      3 - Calcular média de alunos" +
                    "\n      4 - Clientes" +
                    "\n      5 - Usuarios" +
                    "\n      6 - Fornecedor" +
                    "\n\n      0 - Sair do Programa\n" +
                    "\n=================================================";
                        Console.WriteLine(mensagem);

                    int valor = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (valor == SAIDA_PROGRAMA)
                    {
                        break;
                    }
                    else if (valor == LER_ARQUIVOS)
                    {
                        Console.WriteLine("============== Opção Ler Arquivos ==============");
                        Arquivo.Ler(1);
                        Console.WriteLine("\n=====================================\n");
                    }
                    else if (valor == TABUADA)
                    {
                        Console.WriteLine("=============== Opção Tabuada ===============");
                        Console.WriteLine("Digite o numero que deseja na tabuada");
                        int numero = int.Parse(Console.ReadLine());
                        Tabuada.Calcular(numero);
                        Console.WriteLine("\n=====================================\n");
                    }
                    else if (valor == CALCULO_MEDIA)
                    {
                        Console.WriteLine("\n\nCalculo Media\n");
                        Media.Aluno();
                    }
                    else if (valor == CADASTRAR_CLIENTES)
                    {
                        Console.WriteLine("\n\n===================================== Clientes =====================================\n");
                        TelaCliente.Chamar();
                    }
                    else if (valor == CADASTRAR_USUARIOS)
                    {
                        Console.WriteLine("\n\n===================================== Usuarios =====================================\n");
                        TelaUsuario.Chamar();
                    }
                    else if (valor == CADASTRAR_FORNECEDORES)
                    {
                        Console.WriteLine("\n\n===================================== Fornecedores =====================================\n");
                        TelaFornecedor.Chamar();
                    }
                    else
                    {
                        Console.WriteLine("\n=============== Opção Inválida ===============\n");
                    }
                }
                
        }
    }
}
