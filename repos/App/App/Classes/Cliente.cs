using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Classes
{

    public class Cliente : Base
    {
        public Cliente(string _nome, string _telefone, string _CPF)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _CPF;
        }

        public Cliente() { }
       
    }
}
