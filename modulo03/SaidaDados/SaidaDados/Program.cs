using System;
using System.Globalization;

namespace SaidaDados {
    class Program {
        static void Main(String[] args) {

            //char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Console.Write("Bom dia!");
            //Console.WriteLine("Boa tarde!");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("-------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2")); // F2 delimita o número de casas decimais em 2, F3 3 casas...
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // CultureInfo.InvariantCulture define o ponto como separador de decimais. Ele precisa da biblioteca using System.Globalization;

            // Placeholders, concatenação e interpolação
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // Placeholder

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // Concatenação

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // Interpolação
        }
    }
}