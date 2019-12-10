using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexoPesoAltura
{
    public class PesoAltura
    {
        static void Main(string[] args)
        {
            double pid, altura;

            string sexo;

            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Sexo: ");
            sexo = Console.ReadLine();

            pid = (72.7 * altura) - 58;

            Console.Write("Sexo: " + sexo);
            Console.Write(" e Peso: " + pid);

            Console.ReadKey();
        }
    }
}
