using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_02032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int mes = 0;
            bool continuar = true;

            while (continuar == true)
            {
                //ingreso de la opción
                bool opcionCorrecta = false;
                while (opcionCorrecta == false)
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Sipervisado - Jose García - 1106423");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("MENÚ");
                    Console.WriteLine("1. Meses del año");
                    Console.WriteLine("2. Encontrar el número mayor");
                    Console.WriteLine("3. Signos del zodiaco");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Ingrese una opción del menú");
                    try
                    {
                        opcion = int.Parse(Console.ReadLine());

                        if (opcion > 0 && opcion <= 4)
                        {
                            Console.Clear();
                            opcionCorrecta = true;
                        }
                        if (opcion > 4 || opcion == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("El numero no se encuentra dentro de la opción del menu");
                            Console.ReadLine();
                        }
                    }

                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe ingresar un número...");
                        Console.ReadKey();
                    }

                }
                //fin ingreso de opción
                bool opcionuni = true;
                while (opcionuni == true)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Aqui va el ejercicio 1");
                            Console.WriteLine("");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("--------------MESES----------------");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("Ingrese un numero entre 1 y 12");

                            try
                            {
                                mes = int.Parse(Console.ReadLine());

                                if (mes > 12 || mes == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("El numero no se encuentra entre 1 y 12");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Debe ingresar un número...");
                                Console.ReadLine();
                            }

                            switch (mes)
                            {
                                case 1:
                                    Console.WriteLine("Enero");
                                    opcionuni = false;
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Febrero");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 3:
                                    Console.WriteLine("Marzo");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 4:
                                    Console.WriteLine("Abril");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 5:
                                    Console.WriteLine("Mayo");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 6:
                                    Console.WriteLine("Junio");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 7:
                                    Console.WriteLine("Julio");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 8:
                                    Console.WriteLine("Agosto");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 9:
                                    Console.WriteLine("Septiembre");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 10:
                                    Console.WriteLine("Octubre");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 11:
                                    Console.WriteLine("Noviembre");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                                case 12:
                                    Console.WriteLine("Diciembre");
                                    opcionuni = false;
                                    Console.ReadLine();

                                    break;
                            }
                            break;
                            
                        
                        case 2:
                            double a = 0, b = 0, c = 0;
                            bool valortru = true;
                            Console.Clear();
                            Console.WriteLine("Aqui va el ejercicio 2");
                            Console.WriteLine("");
                            try
                            {
                                Console.WriteLine("Ingrese un valor a la letra A");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese un valor a la letra B");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese un valor a la letra C");
                                c = double.Parse(Console.ReadLine());

                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Debe colocar un numero, vuelva a repetir todo...");
                                valortru = false;
                                Console.ReadLine();

                            }
                            while (valortru == true)
                            {
                                if (a > b)
                                {
                                    if (a > c)
                                    {
                                        if (b > c)
                                        {
                                            Console.WriteLine("RESULTADO: " + a + ">" + b + ">" + c);
                                            valortru = false;

                                        }
                                        else if (b == c)
                                        {
                                            Console.WriteLine("RESULTADO: " + a + ">" + b + "=" + c);
                                            valortru = false;

                                        }
                                        else
                                        {
                                            Console.WriteLine("RESULTADO: " + a + ">" + c + ">" + b);
                                            valortru = false;

                                        }

                                    }
                                    else
                                    {
                                        if (a == c)
                                        {
                                            Console.WriteLine("RESULTADO: " + a + "=" + c + ">" + b);
                                            valortru = false;

                                        }
                                        else
                                        {
                                            Console.WriteLine("RESULTADO: " + c + ">" + a + ">" + b);
                                            valortru = false;

                                        }
                                    }
                                }
                                else
                                {
                                    if (a == b)
                                    {
                                        if (a > c)
                                        {
                                            Console.WriteLine("RESULTADO: " + a + "=" + b + ">" + c);
                                            valortru = false;

                                        }
                                        else
                                        {
                                            if (a == c)
                                            {
                                                Console.WriteLine("RESULTADO: " + a + "=" + b + "=" + c);
                                                valortru = false;

                                            }
                                            else
                                            {
                                                Console.WriteLine("RESULTADO: " + c + ">" + a + "=" + b);
                                                valortru = false;

                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (b > c)
                                        {
                                            if (a > c)
                                            {
                                                Console.WriteLine("RESULTADO: " + b + ">" + a + ">" + c);
                                                valortru = false;

                                            }
                                            else if (a == c)
                                            {
                                                Console.WriteLine("RESULTADO: " + b + ">" + a + "=" + c);
                                                valortru = false;

                                            }
                                            else
                                            {
                                                Console.WriteLine("RESULTADO: " + b + ">" + c + ">" + a);
                                                valortru = false;

                                            }
                                        }
                                        else
                                        {
                                            if (b == c)
                                            {
                                                Console.WriteLine("RESULTADO: " + b + "=" + c + ">" + a);
                                                valortru = false;

                                            }
                                            else
                                            {
                                                Console.WriteLine("RESULTADO: " + c + ">" + b + ">" + a);
                                                valortru = false;

                                            }
                                        }
                                    }
                                }
                                opcionuni = false;
                                Console.ReadLine();
                            }
                            

                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Tarea T6_JoseGarcia_1106423");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el año de su nacimiento");
                            try
                            {
                                int año = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingre el mes de su nacimiento");
                                string mess = "";
                                mess = Convert.ToString(Console.ReadLine().ToLower());
                                if (mess == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("debe colocar el nombre del mes...");
                                }
                                else if (mess == "enero" || mess == "febrero" || mess == "marzo" || mess == "abril" || mess == "mayo" || mess == "junio" || mess == "julio" || mess == "agosto" || mess == "septiembre" || mess == "octubre" || mess == "noviembre" || mess == "diciembre")
                                {
                                    bool diare = true;
                                    while (diare == true)
                                    {
                                        Console.WriteLine("Ingrese el dia de su nacimiento");
                                        int dia = Convert.ToInt32(Console.ReadLine());
                                        switch (mess)
                                        {
                                            case "marzo":

                                                //aries
                                                if (dia >= 21 && dia <= 31)
                                                {
                                                    Console.WriteLine("Aries");
                                                    opcionuni = false;
                                                    diare = false;
                                                }
                                                //piscis
                                                else if (dia > 0 && dia <= 20)
                                                {
                                                    Console.WriteLine("Piscis");
                                                    opcionuni = false;
                                                    diare = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                }
                                                break;

                                            case "abril":
                                                //piscis
                                                if (dia > 0 && dia <= 19)
                                                {
                                                    Console.WriteLine("Piscis");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Tauro
                                                else if (dia >= 20 && dia <= 30)
                                                {
                                                    Console.WriteLine("Piscis");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 30 dias");
                                                }
                                                break;
                                            case "mayo":
                                                //tauro
                                                if (dia > 0 && dia <= 20)
                                                {
                                                    Console.WriteLine("Tauro");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Geminis
                                                else if (dia >= 21 && dia <= 31)
                                                {
                                                    Console.WriteLine("Géminis");
                                                    opcionuni = false;
                                                    diare = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + "tiene 1 entre 31 dias");
                                                }
                                                break;
                                            case "junio":
                                                //Geminis
                                                if (dia > 0 && dia <= 20)
                                                {
                                                    Console.WriteLine("Géminis");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Cancer
                                                else if (dia >= 21 && dia <= 30)
                                                {
                                                    Console.WriteLine("Cancer");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 30 dias");
                                                }
                                                break;
                                            case "julio":
                                                //Cancer
                                                if (dia > 0 && dia <= 22)
                                                {
                                                    Console.WriteLine("Cancer");
                                                    opcionuni = false;
                                                    diare = false;

                                                }
                                                //Leo
                                                else if (dia >= 23 && dia <= 31)
                                                {
                                                    Console.WriteLine("Leo");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                }
                                                break;
                                            case "agosto":
                                                //Leo
                                                if (dia > 0 && dia <= 22)
                                                {
                                                    Console.WriteLine("Leo");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Virgo
                                                else if (dia >= 23 && dia <= 31)
                                                {
                                                    Console.WriteLine("Virgo");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                }
                                                break;
                                            case "septiembre":
                                                //Virgo
                                                if (dia > 0 && dia <= 22)
                                                {
                                                    Console.WriteLine("Virgo");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Libra
                                                else if (dia >= 23 && dia <= 31)
                                                {
                                                    Console.WriteLine("Libra");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                }
                                                break;
                                            case "octubre":
                                                //Libra
                                                if (dia > 0 && dia <= 23)
                                                {
                                                    Console.WriteLine("Virgo");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Escorpio
                                                else if (dia >= 24 && dia <= 31)
                                                {
                                                    Console.WriteLine("Libra");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                break;
                                            case "noviembre":
                                                //Escorpio
                                                if (dia > 0 && dia <= 22)
                                                {
                                                    Console.WriteLine("Escorpio");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Sagitario
                                                else if (dia >= 23 && dia <= 31)
                                                {
                                                    Console.WriteLine("Saginario");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                }
                                                break;
                                            case "diciembre":
                                                //Sagitario
                                                if (dia > 0 && dia <= 21)
                                                {
                                                    Console.WriteLine("Sagitario");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Capricornio
                                                else if (dia >= 22 && dia <= 31)
                                                {
                                                    Console.WriteLine("Capricornio");
                                                    diare = false;
                                                    opcionuni = false;
                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                }
                                                break;
                                            case "enero":
                                                //Capricornio
                                                if (dia > 0 && dia <= 19)
                                                {
                                                    Console.WriteLine("Capricornio");
                                                    diare = false;
                                                    opcionuni = false;
                                                }
                                                //Acuario
                                                else if (dia >= 20 && dia <= 31)
                                                {
                                                    Console.WriteLine("Acuario");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 31 dias");
                                                }
                                                break;
                                            case "febrero":
                                                //Acuario
                                                if (dia > 0 && dia <= 18)
                                                {
                                                    Console.WriteLine("Acuario");
                                                    diare = false;
                                                    opcionuni = false;

                                                }
                                                //Piscis
                                                else if (dia >= 19 && dia <= 29)
                                                {
                                                    Console.WriteLine("Piscis");
                                                    diare = false;
                                                    opcionuni = false;
                                                }
                                                else
                                                {
                                                    Console.WriteLine(mess + " tiene 1 entre 29 dias");
                                                }
                                                break;

                                        }
                                        Console.ReadLine();
                                    }
                                    
                                
                                }
                                else
                                {
                                    Console.WriteLine("Debe colocar un mes...");
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            Console.ReadLine();


                            break;
                        case 4:
                            Console.Clear();
                            continuar = false;
                            opcionuni = false;
                            opcionCorrecta = true;
                            break;
                    }
                    
                }
            }

        }
    }
}
