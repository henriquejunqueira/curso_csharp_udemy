using System;
using System.Globalization; // Biblioteca para usar o CultureInfo.InvariantCulture

namespace EntradaDados2 {
    class Program {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine()); // int.Parse converte a entrada para inteiro
            char ch = char.Parse(Console.ReadLine()); // char.Parse converte a entrada para char
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // double.Parse converte a entrada para double e CultureInfo.InvariantCulture define o separador como ponto

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            //Console.WriteLine(n2);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
