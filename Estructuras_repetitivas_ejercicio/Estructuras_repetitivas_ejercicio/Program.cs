using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_repetitivas_ejercicio
{
    internal class ejercicios
    {
        public void ejercicio1()
        {
            int numero;
            Console.Clear();
            Console.WriteLine("Ejercicio #1");
            do
            {
                
                Console.WriteLine("Ingrese un numero entero del 1 hasta al 99");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Es par");
                }
                Console.ReadLine();
                
            }
            while (numero < 99);
            Console.ReadKey();
        }
        public void ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio #2");
            string f = "";
            Console.WriteLine("Ingrese cauntos filas quiere ingresar");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas ; i++) 
            {
                f = f + " " + i;
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
        public void ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio #3");
            int suma = 0;
            for (int i = 100; i <= 200; i++)
            {
                int div = 0;
                div = i % 9;

                if (div == 0)
                {
                    Console.WriteLine(i);
                    suma = i + suma;
                }
            }
            Console.WriteLine("La suma de todos los numeros divicibles de 9 del 100 al 200 es : " + suma);
            Console.ReadLine();
        }
        public void ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio #4");
            Console.WriteLine("Ingrese un numero positivo del 1 al 10");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                Console.Write(i+" ");
                for (int j = 1; j <= numero; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            ejercicios ejer = new ejercicios();

            ejer.ejercicio1();
                
            ejer.ejercicio2();

            ejer.ejercicio3();

            ejer.ejercicio4();

        }
    }
}
