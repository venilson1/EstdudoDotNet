using Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dog
{

    internal class Cachorro : Animal
    {
        private int IdadePadrao = 0;

        //exemplo usado exclusivo do c#
        public int Idade { 
            get { return IdadePadrao;}
            set {IdadePadrao = value;}
        }

        private string pele = "null";


        //exemplo usado por muitas linguagens
        public string GetPele()
        {
            return pele;
        }

       public void SetPele(string _pele)
        {
            pele = _pele;
        }


        internal override void Latir()
        {
            Console.WriteLine("Olá eu sou um American");
        }
    }
}
