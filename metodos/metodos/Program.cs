using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //José Andrés García Elías 1106423
            escojerfigura();
            electrodomesticos();
            divisores();
        }

        public static void escojerfigura()
        {
            Console.WriteLine("-----------Menú-----------");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Escoje una figura");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Coloca el radio del circulo");
                    double radio = double.Parse(Console.ReadLine());
                    double area = Math.Pow(radio, 2)*Math.PI;
                    Console.WriteLine("El área del circulo es: " + area.ToString("F2"));
                    break;
                case 2:
                    Console.WriteLine("Coloca la base del triangulo");
                    double basetri = double.Parse(Console.ReadLine());
                    Console.WriteLine("Coloca la altura del triangulo");
                    double alturatri = double.Parse(Console.ReadLine());
                    double areatri = (basetri * alturatri) / 2; 
                    Console.WriteLine("El área del triangulo es: " + areatri.ToString("F2"));
                    break;
                case 3:
                    Console.WriteLine("Coloca el lado del cuadrado");
                    double ladocua = double.Parse(Console.ReadLine());
                    double areacua = Math.Pow(ladocua, 2);
                    Console.WriteLine("El área del cuadrado es: " + areacua);
                    break;
            }
            Console.ReadKey();
        }
        
        public static void electrodomesticos()
        {
            double recargo = 0;
            double precioaun= 0;

            double[] energia = new double[4] {100,80,60,60};
            Console.WriteLine("Ingrese el precio del electrodimestico");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el consumo energetico (A al D)");
            string letra = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el peso en KG (kilogramo)");
            double peso = double.Parse(Console.ReadLine());
            switch (letra)
            {
                case "A":
                    precioaun = precio + energia[0];
                    recargo = precio + 100;
                    if (peso > 20 & peso < 40)
                    {
                        recargo = recargo + (recargo*0.05);
                    }
                    else if (peso >= 40)
                    {
                        recargo = recargo + (recargo * 0.1);
                    }
                    break;
                case "B":
                    precioaun = precio + energia[0];
                    recargo = precio + 80;
                    if (peso > 20 & peso < 40)
                    {
                        recargo = recargo + (recargo * 0.05);
                    }
                    else if (peso >= 40)
                    {
                        recargo = recargo + (recargo * 0.1);
                    }
                    break;
                case "C":
                    precioaun = precio + energia[0];
                    recargo = precio + 60;
                    if (peso > 20 & peso < 40)
                    {
                        recargo = recargo + (recargo * 0.05);
                    }
                    else if (peso >= 40)
                    {
                        recargo = recargo + (recargo * 0.1);
                    }
                    break;
                case "D":
                    precioaun = precio + energia[0];
                    recargo = precio + 50;
                    if (peso > 20 & peso < 40)
                    {
                        recargo = recargo + (recargo * 0.05);
                    }
                    else if (peso >= 40)
                    {
                        recargo = recargo + (recargo * 0.1);
                    }
                    break;
            }
            Console.WriteLine("El precio total del producto es: " + recargo);
            Console.WriteLine("El número energetico: " + letra);
            Console.WriteLine("El peso del producto es: " + peso);
            Console.WriteLine("El color del producto es: " + color);
            Console.ReadKey();


        }
        public static void divisores()
        {
            string mostrar = "";
            Console.WriteLine("Ingrese un número para sacar sus divisores");
            int numero = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= numero; i++)
            {
                int divisor = numero % i;
                if (divisor == 0)
                {
                    mostrar = mostrar + " "+ i;
                }
            }

            Console.WriteLine($"Los números divisores de {numero} son: {mostrar}");
            Console.ReadKey();
        }

    }
}
