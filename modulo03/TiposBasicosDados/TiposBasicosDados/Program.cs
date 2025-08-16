using System;

namespace TiposBasicosDados {
    class Program {
        static void Main(string[] args) {

            // sbyte x = 100; // Tipo primitivo C#
            // SByte x = 100; // Tipo .Net Framework

            // Console.WriteLine(x);

            // byte n1 = -1; // Não aceita número negativo
            // byte n1 = 254;
            // n1++;

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}