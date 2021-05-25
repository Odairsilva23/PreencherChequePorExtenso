using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreencherChequePorExtenso.consoleApp
{
    class Program
    {
        public static string resultado { get; private set; }

        static void Main(string[] args)
        {
            

            Cheque cheque = new Cheque();


            string ValorPorExtenso = cheque.ChequePorExtenso(1550.52);

            Console.WriteLine("1550.52");
            Console.WriteLine("O Valor Por extenso do Cheque Será de :/n" );

            Console.WriteLine(ValorPorExtenso);

            Console.ReadLine();
        }
    }
}
