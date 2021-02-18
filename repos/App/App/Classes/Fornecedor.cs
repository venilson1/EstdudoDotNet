using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Classes
{

    public class Fornecedor : Base
    {
        public string CNPJ; 
        public Fornecedor(string _nome, string _telefone, string _CPF, string _CNPJ)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _CPF;
            this.CNPJ = _CNPJ;
        }

        public Fornecedor() { }


        public override void Gravar()
        {
            var ListaDados = this.Ler();
            ListaDados.Add(this);

            StreamWriter r = new StreamWriter(diretorio());
            r.WriteLine("nome;cnpj;telefone;cpf do gerente;");
            foreach (Fornecedor dados in ListaDados)
            {
                var linha =  dados.Nome + ";" + dados.Telefone + ";" + dados.CPF + ";" + dados.CNPJ + ";";
                r.WriteLine(linha);
            }

            r.Close();

        }
        public override List<IPessoa> Ler()
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
                        var dadosArquivo = linha.Split(";");
                        var dados = (Fornecedor)Activator.CreateInstance(this.GetType());
                        dados.SetNome(dadosArquivo[0]);
                        dados.SetTelefone(dadosArquivo[1]);
                        dados.SetCPF(dadosArquivo[2]);
                        dados.CNPJ = dadosArquivo[3];
                        ListaDados.Add(dados);
                    }
                }
            }
            return ListaDados;
        }

    }
}
