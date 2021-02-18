using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public interface IPessoa
    {
        //definir os metodos obrigatorios para os filhos
        //não cabe a interface saber se é public ou private ou etc.
        //propriedades e metodos ObRIGATORIO para os herdeiros

        void SetNome(string _nome);
        void SetTelefone(string _telefone);
        void SetCPF(string _CPF);

        void Gravar();
    }
}
