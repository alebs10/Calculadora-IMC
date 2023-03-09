using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double peso, imc, altura;

            Console.WriteLine("******************");
            Console.WriteLine("CALCULADORA DE IMC");
            Console.WriteLine("******************");
            Thread.Sleep(2600);
            Console.Clear();

            Console.WriteLine("O IMC é reconhecido como padrão internacional" +
                " para avaliar o grau de sobrepeso e obesidade.É calculando" +
                " dividindo o peso(em kg) pela altura ao quadrado (em metros).");
            Thread.Sleep(9000);
            Console.Clear();

            Console.WriteLine("Digite seu peso em kg: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura em centímetros: ");
            altura = double.Parse(Console.ReadLine());


            imc = peso / (altura * altura);

            if (imc >= 0 && imc < 18.5)
            {
                Console.WriteLine(imc.ToString("F2") + " kg/m² (Abaixo do peso normal)");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine(imc.ToString("F2") + " kg/m² (Peso normal)");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine(imc.ToString("F2") + "kg/m² (Excesso de peso)");
            }
            else if (imc >=30 && imc <= 34.9)
            {
                Console.WriteLine(imc.ToString("F2") + "kg/m² (Obesidade classe I)");
            }
            else if (imc >= 35.5 && imc <= 39.9)
            {
                Console.WriteLine(imc.ToString("F2") + "kg/m² (Obesidade classe II)");
            }
            else if (imc >= 40)
            {
                Console.WriteLine(imc.ToString("F2") + "kg/m² (Obesidade classe III)");
            }
            else
            {
                Console.WriteLine("Avaliação de peso inválida, renicie o programa e tente novamente...");
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
