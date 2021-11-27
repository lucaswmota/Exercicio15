using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o Raio do Circulo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14 * (raio * raio);

            double perimetro = (2*3.14) * raio;

            double diametro = raio * 2;

            Console.WriteLine("A Area do Circulo é de: " + area);

            Console.WriteLine("O Perimetro do circulo é de: " + perimetro);

            Console.WriteLine("O Diametro do Circulo é de: " + diametro);

            Console.ReadKey();
        }
    }
}
