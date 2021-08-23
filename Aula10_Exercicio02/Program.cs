using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeano, idademes, idadedias;
            Console.WriteLine("Informe sua idade em anos: ");
            idadeano = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua idade em meses: ");
            idademes = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua idade em dias: ");
            idadedias = int.Parse(Console.ReadLine());

            int totaldias = (idadeano * 365) + (idademes * 30) + idadedias;
            Console.WriteLine("Você tem " + totaldias + " dias vividos!");

            Console.ReadKey();
        }
    }
}
