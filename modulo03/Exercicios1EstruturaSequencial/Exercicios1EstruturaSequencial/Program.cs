using System;
using System.Globalization;

namespace Exercicios1EstruturaSequencial {
    class Program {
        static void Main(string[] args) {
            // Exercício 01
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na 
             * tela a soma desses números com uma
             * mensagem explicativa, conforme exemplos.
             */

            //int primeiroNumero = int.Parse(Console.ReadLine());
            //int segundoNumero = int.Parse(Console.ReadLine());

            //int soma = primeiroNumero + segundoNumero;

            //Console.WriteLine("SOMA = " + soma);

            // ===========================================================

            // Exercício 02
            /* Faça um programa para ler o valor do raio de um círculo, e depois 
             * mostrar o valor da área deste círculo com quatro
             * casas decimais conforme exemplos.
             * Fórmula da área: area = π . raio2
             * Considere o valor de π = 3.14159
             */

            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double area = 3.14159 * Math.Pow(raio, 2);

            //Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            // ===========================================================

            // Exercício 03
            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. 
             * A seguir, calcule e mostre a diferença do produto de A e B pelo 
             * produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
             */

            //int valorA = int.Parse(Console.ReadLine());
            //int valorB = int.Parse(Console.ReadLine());
            //int valorC = int.Parse(Console.ReadLine());
            //int valorD = int.Parse(Console.ReadLine());

            //int diferenca = (valorA * valorB) - (valorC * valorD);

            //Console.WriteLine("DIFERENCA = " + diferenca);

            // ===========================================================

            // Exercício 04
            /* Fazer um programa que leia o número de um funcionário, seu número de 
             * horas trabalhadas, o valor que recebe por hora e calcula o salário 
             * desse funcionário. A seguir, mostre o número e o salário do 
             * funcionário, com duas casas decimais.
             */

            //int numero_funcionario = int.Parse(Console.ReadLine());
            //int numero_horas_trabalhadas = int.Parse(Console.ReadLine());
            //double valor_por_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salario_funcionario = numero_horas_trabalhadas * valor_por_hora;

            //Console.WriteLine("NUMBER = " + numero_funcionario);
            //Console.WriteLine("SALARY = U$ " + salario_funcionario.ToString("F2", CultureInfo.InvariantCulture));

            // ===========================================================

            // Exercício 05
            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, 
             * o valor unitário de cada peça 1, o código de uma peça 2, o número de 
             * peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor 
             * a ser pago.
             */

            //string[] vet1 = Console.ReadLine().Split(' ');

            //int codigo_peca1 = int.Parse(vet1[0]);
            //int numero_peca1 = int.Parse(vet1[1]);
            //double valor_unitario_peca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            //string[] vet2 = Console.ReadLine().Split(' ');

            //int codigo_peca2 = int.Parse(vet2[0]);
            //int numero_peca2 = int.Parse(vet2[1]);
            //double valor_unitario_peca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            //double total = (numero_peca1 * valor_unitario_peca1) + (numero_peca2 * valor_unitario_peca2);

            //Console.WriteLine("VALOR A PAGAR R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            // ===========================================================

            // Exercício 06
            /* Fazer um programa que leia três valores com ponto flutuante de dupla 
             * precisão: A, B e C. Em seguida, calcule e mostre:
             * a) a área do triângulo retângulo que tem A por base e C por altura.
             * b) a área do círculo de raio C. (pi = 3.14159)
             * c) a área do trapézio que tem A e B por bases e C por altura.
             * d) a área do quadrado que tem lado B.
             * e) a área do retângulo que tem lados A e B.
             */

            string[] vet = Console.ReadLine().Split(' ');
            double valorA = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double valorB = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double valorC = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double area_triangulo = (valorA * valorC) / 2;
            double area_circulo = 3.14159 * Math.Pow(valorC, 2);
            double area_trapezio = ((valorA + valorB) * valorC) / 2;
            double area_quadrado = Math.Pow(valorB, 2);
            double areaRetangulo = valorA * valorB;

            Console.WriteLine("TRIANGULO: " + area_triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area_circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + area_trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area_quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
