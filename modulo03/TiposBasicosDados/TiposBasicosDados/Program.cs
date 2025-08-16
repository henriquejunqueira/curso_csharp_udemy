using System;

namespace TiposBasicosDados {
    class Program {
        static void Main(string[] args) {

            // Tipos básicos em C#
            // sbyte x = 100; // Tipo primitivo C#
            // SByte x = 100; // Tipo .Net Framework

            // Console.WriteLine(x);

            // byte n1 = -1; // Não aceita número negativo
            // byte n1 = 254;
            // n1++;

            //bool completo = false;
            //char genero = 'F';
            //char letra = '\u0041';

            //byte n1 = 126;
            //int n2 = 1000;
            //int n3 = 2147483647;
            //long n4 = 2147483648L;
            //float n5 = 4.5f; // A letra f indica que é um float
            //double n6 = 4.5;
            //string nome = "Maria Green"; // string é do tipo referência e é imutável
            //object obj1 = "Alex Brown"; // object é do tipo genérico
            //object obj2 = 4.2; // object é do tipo genérico

            //Console.WriteLine(completo);
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(nome);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            // Funções de valores mínimos e máximos
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}