using CalculosMat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosMAtematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            bool salida = false;


            while (!salida)
            {
                Console.WriteLine("1.-Suma");
                Console.WriteLine("2.-Resta");
                Console.WriteLine("3.-Multiplicacion");
                Console.WriteLine("4.-Division");
                Console.WriteLine("5.-Salir");

                int op = Convert.ToInt32(Console.ReadLine());

                if (!int.TryParse(Console.ReadLine(),out op))
                {
                    Console.WriteLine("Dame una version valida");
                }
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Dame el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Dame el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Calculos.Suma(num1, num2);
                        Console.WriteLine($"El resultado de la suma entre {num1} y {num2} es: {Calculos.Suma(num1, num2)} ");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Dame el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Dame el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Calculos.Resta(num1, num2);
                        Console.WriteLine($"El resultado de la resta entre {num1} y {num2} es: {Calculos.Resta(num1, num2)} ");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Dame el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Dame el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Calculos.Multiplicacion(num1, num2);
                        Console.WriteLine($"El resultado de la multiplicacion entre {num1} y {num2} es {Calculos.Multiplicacion(num1, num2)}");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Dame el primer numero");
                        num1 += Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Dame el segundo numero");
                        num2 += Convert.ToInt32(Console.ReadLine());
                        if (num1 != 0)
                        {
                            Calculos.Division(num1, num2);
                            Console.WriteLine($"El resultado de la divicion entre {num1} y {num2} es {Calculos.Division(num1, num2)}");
                        }
                        else
                        {
                            Console.WriteLine("No es posible dividir entre 0");
                        }
                        if (num2 != 0)
                        {
                            Calculos.Division(num1, num2);
                            Console.WriteLine($"El resultado de la divicion entre {num1} y {num2} es {Calculos.Division(num1, num2)}");
                        }
                        else
                        {
                            Console.WriteLine("No es posible dividir entre 0");
                        }
                        break;
                    case 5:
                        salida = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }

        }
    }
}