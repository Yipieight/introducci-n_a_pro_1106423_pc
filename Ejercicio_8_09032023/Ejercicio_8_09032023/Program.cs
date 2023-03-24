using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_09032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool repetir = true;
            while (repetir == true)
            {
                int A = 0;
                int B = 1;
                int C = 0;
                int i = 2;

                try
                {
                    Console.WriteLine("Ingrese un numero entero");
                    int N = int.Parse(Console.ReadLine());
                    if (N > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Resultado = " + A);
                        if (N > 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Resultado += " + B);
                            if (i < N)
                            {
                                C = A + B;
                                Console.Clear();
                                Console.WriteLine("Resultado += " + C);
                                A = B;
                                B = C;
                                i = i + 1;
                            }
                        }
                       
                    }
                    
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Ingrese un numero entero");
            int n = int.Parse(Console.ReadLine());
        }
    }
}
