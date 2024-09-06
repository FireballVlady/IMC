using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double masaCorporal;

            Console.WriteLine("ingresa tu peso");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa tu Altura");
            altura = double.Parse(Console.ReadLine());

            masaCorporal =  altura * altura;
            masaCorporal = peso / masaCorporal;
            Console.WriteLine("Este tu indice de masa corporal " + masaCorporal);

            Console.ReadKey();
        }
    }
}
