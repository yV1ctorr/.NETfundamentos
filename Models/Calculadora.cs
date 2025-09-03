using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Models
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public void Dividir(int a, int b)
        {
            Console.WriteLine($"{a} : {b} = {a / b}");
        }

        public void Potencia(int a, int b)
        {
            double pot = Math.Pow(a, b);
            Console.WriteLine($"{a}^{b} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 3)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 3)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Sin(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 3)}");
        }

        public void Raiz(double a)
        {
            double raiz = Math.Sqrt(a);
            Console.WriteLine($"Raiz quadrada de {a} = {raiz}");
        }
    }
}