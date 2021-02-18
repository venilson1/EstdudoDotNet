using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
/*
* Os metodos abstratos são parecidos com a Interface,
* A diferença é que os métodos incompletos (ou seja, que não possui implementação)
* devem ser abstratas, e or consequencia a herança desses metodos passam a ser obrigatórias
* 
* Outra caracterista importante de uma abstração é que ela não permite, assim como 
* uma Interface também criar uma instância;
*/
    internal abstract class Animal
    {
        /*
        internal string Coleira;
        internal string Pelo;
        internal string Olhos;
        */
        internal abstract void Latir(); //dados incompletos devem ser abstratos

        internal string Correr()
        {
            return "Animal está correndo";
        }
    }
}
