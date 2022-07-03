
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string NA;
            double nt, n1, n2, media;

            Console.WriteLine("digite o nome do aluno: ");
            NA = Convert.ToString(Console.ReadLine());

            Console.WriteLine("digite a nota do trabaho: ");
            nt = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a nota da primeira prova: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a nota da segunda prova: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + nt) / 3;


            if (media >= 8.5 && media <= 10)
            {

                Console.WriteLine("Sua nota de media é: " + (media.ToString ("n1")) + ". Prabéns " + NA + "!!");

            }else if (media >= 7 && media <= 8.4)
            {

                Console.WriteLine("Sua nota de media é: " + (media.ToString("n1")) + ". Muito bem " + NA + "!!");

            }
            else if (media >= 6 && media <= 6.9)
            {

                Console.WriteLine("Sua nota de media é: " + (media.ToString("n1")) + ". Você foi aprovado " + NA + ".");

            }
            else if (media >= 0.1 && media <= 5.9)
            {

                Console.WriteLine("Sua nota de media é: " + (media.ToString("n1")) + ". Você foi reprovado "+ NA + ".");

            }
            else
            {

                Console.WriteLine("Sua nota de media é: " + (media.ToString("n1")) + ". Você está completamente reprovado " + NA + "!!");

            }

            Console.ReadKey();
        }
    }
}
