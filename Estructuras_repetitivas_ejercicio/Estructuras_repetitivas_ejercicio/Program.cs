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
            do
            {
                Console.Clear();
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
            string f = "";
            Console.WriteLine("Ingrese cauntos filas quiere ingresar");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas ; i++) 
            {
                f = f + " " + i;
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
        public void ejercicio3()
        {
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
            Console.WriteLine("Ingrese un numero del 1 al 10");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 0; j <= numero; i++)
                {

                }
            }
        }


        static void Main(string[] args)
        {
            ejercicios ejer = new ejercicios();

            Console.WriteLine("EJERCICIO 1");
            ejer.ejercicio1();
                
            Console.WriteLine("EJERCICIO 2");
            ejer.ejercicio2();

            Console.WriteLine("EJERCICIO 3");
            ejer.ejercicio3();

            Console.WriteLine("EJERCICIO 4");
            ejer.ejercicio4();

        }
    }
}
