using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 12345;
            contaDaGabriela.numero = 845667;
            contaDaGabriela.saldo = 1000;
            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: "+contaDaGabriela.agencia);
            Console.WriteLine("conta: "+contaDaGabriela.numero);
            Console.WriteLine("Saldo: R$"+contaDaGabriela.saldo+",00");

            contaDaGabriela.saldo += 300;
            Console.WriteLine("Saldo: R$" + contaDaGabriela.saldo + ",00");

            Console.ReadLine();
        }
    }
}
