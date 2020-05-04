using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. La raíz cuadrada de un número
            System.Console.WriteLine("1. La raíz cuadrada de un número");

            System.Console.WriteLine("Escibe un numero");
            double raiz = Convert.ToDouble(Console.ReadLine());

            double res1 = System.Math.Sqrt(raiz);
            System.Console.WriteLine("La raíz cuadrada de " + raiz + " es " + res1);

            System.Console.WriteLine("");

            // 2. Un número elevado a la 4ta potencia
            System.Console.WriteLine("2. Un número elevado a la 4ta potencia");

            System.Console.WriteLine("Escibe un numero");
            double potencia = Convert.ToDouble(Console.ReadLine());

            double res2 = System.Math.Pow(potencia, 4);
            System.Console.WriteLine(potencia + " elevado a la 4ta potencia es " + res2);

            System.Console.WriteLine("");

            //3. Obtener el signo de un número
            System.Console.WriteLine("3. Obtener el signo de un número");

            System.Console.WriteLine("Escibe un numero");
            double signo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(signo + " Es " + Signos(System.Math.Sign(signo)));


            System.Console.WriteLine("");

            //4. A partir de dos números, determinar qué número es más grande
            System.Console.WriteLine("4. A partir de dos números, determinar qué número es más grande");

            System.Console.WriteLine("Escibe un numero");
            double num1 = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Escibe un numero");
            double num2 = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Numero mayor de " + num1 + " y " + num2 + " es " + System.Math.Max(num1, num2));


            System.Console.WriteLine("");

            //5. A partir de dos números, determinar qué número es más grande sin importar el signo (ej. -5 es mayor que 4 en este punto)
            System.Console.WriteLine("5. A partir de dos números, determinar qué número es más grande sin importar el signo ");

            System.Console.WriteLine("Escibe un numero");
            double n1Signo = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Escibe un numero");
            double n2Signo = Convert.ToDouble(Console.ReadLine());

            double numAbs1= System.Math.Abs(n1Signo);
            double numAbs2= System.Math.Abs(n2Signo);

            System.Console.WriteLine("Numero mayor de " + n1Signo + " y " + n2Signo + " es " + System.Math.Max(numAbs1, numAbs2));


            System.Console.WriteLine("");

            //6. Quitar los decimales de un número
            System.Console.WriteLine("6. Quitar los decimales de un número");

            System.Console.WriteLine("Escibe un numero");
            double NumeroSinDeciamales = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine(NumeroSinDeciamales+ " sin decimales es "+System.Math.Truncate(NumeroSinDeciamales));


            System.Console.WriteLine("");

            //7. Redondear el siguiente número: 8.55
            System.Console.WriteLine("7. Redondear el siguiente número: 8.55");
            double numRed=8.55;
            System.Console.WriteLine("El redondeo de "+numRed+" es "+System.Math.Round(numRed));

            System.Console.WriteLine("");


        }
        public static String Signos(int comparar)
        {
            if (comparar == 0)
                return "Es igual a 0";

            else if (comparar < 0)
                return "Es negativo";

            else
                return "Es Positivo";
        }
    }
}

