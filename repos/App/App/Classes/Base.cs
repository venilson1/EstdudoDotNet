using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public class Base : IPessoa
    {
        //propriedades
        public string Nome;
        public string Telefone;
        public string CPF;

        public Base(string _nome, string _telefone, string _CPF)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _CPF;
        }

        public Base() { }

        public void SetNome(string _nome)
        {
            this.Nome = _nome;
        }
        public void SetTelefone(string _telefone)
        {
            this.Telefone = _telefone;
        }
        public void SetCPF(string _CPF)
        {
            this.CPF = _CPF;
        }


        protected string diretorio()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"] + this.GetType().Name + ".csv";
            //return @"C:\arquivos\db\" + this.GetType().Name + ".csv";
        }


        //override: sobescrevendo o método de uma classe pai
        //new: método "rebelde", indiferente se pode ou não sobescrever
        //virtual: o método pode ser sob-escrito para as classes filhas
        //sealed: ninguém poderá sobescrever o método
        public virtual void Gravar()
        {
            var ListaDados = this.Ler();
            ListaDados.Add(this);
            
            StreamWriter r = new StreamWriter(diretorio());
            r.WriteLine("nome;telefone;cpf;");
            foreach (Base dados in ListaDados)
            {
                var linha = dados.Nome + ";" + dados.Telefone + ";" + dados.CPF + ";";
                r.WriteLine(linha);
            }

            r.Close();

        }


        //metodo estático, retornar varios clientes
        //usado para retornar varios clientes 
        // método não estático, ou seja, este metodo é um metodo de instância
        //void porque não tem retorno
        //usado para retornar um cliente
        public virtual List<IPessoa> Ler()
        {
            var ListaDados = new List<IPessoa>();
            if (File.Exists(diretorio()))
            {
                using (StreamReader arquivo = File.OpenText(diretorio()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var dadosArquivo = linha.Split(';') ;
                        //passando atibutos na nova instancia do objeto Instanciado, esses atributos 
                        //estão sendo lidos linha a linha e sendo quebrados a cada ; retornando
                        //um array
                        //cada posição do array é atribuido como valor da propriedade

                        //criando um nova instancia generica **IPessoa, hora irá ser usuario,, hora cliente ...
                        //criar instancia do objeto corrente **this.GetType();
                        var dados = (IPessoa)Activator.CreateInstance(this.GetType());
                        dados.SetNome(dadosArquivo[0]);
                        dados.SetTelefone(dadosArquivo[1]);
                        dados.SetCPF(dadosArquivo[2]);
                        /*
                        var dados = new Base 
                        { 
                            Nome = dadosArquivo[0], 
                            Telefone = dadosArquivo[1], 
                            CPF = dadosArquivo[2] 
                        };*/
                        ListaDados.Add(dados);
                    }
                }
            }
            return ListaDados;
        }
    }
}
