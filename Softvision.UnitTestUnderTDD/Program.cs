using System;

namespace Softvision.UnitTestUnderTDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Ingresá un dividendo");
            string dividendo = Console.ReadLine();
            Console.WriteLine("Ahora ingresá un divisor");
            string divisor = Console.ReadLine();
            Dividir(dividendo, divisor);
        }

        //Version 1
        public static int Dividir(string dividendo, string divisor)
        {
            return int.Parse(dividendo) / int.Parse(divisor);
        }

        /*Usuario ingresa un char 'A' y explota*/

        //Version 2
        //public static int Dividir(string dividendo, string divisor)
        //{
        //    int result;

        //    try
        //    {
        //        result = int.Parse(dividendo) / int.Parse(divisor);
        //        Console.WriteLine($"El resultado de dividir {dividendo} por {divisor} es {result}");
        //        return result;
        //    }

        //    catch (FormatException)
        //    {
        //        Console.Write($"Alguno de los datos ingresados no es un numero \n");
        //        throw;
        //    }
        //}

        /*Usuario ingresa un 0 como dividendo o divisor y explota*/

        //Version 3
        //public static int Dividir(string dividendo, string divisor)
        //{
        //    int result;

        //    try
        //    {
        //        result = int.Parse(dividendo) / int.Parse(divisor);
        //        Console.WriteLine($"El resultado de dividir {dividendo} por {divisor} es {result}");
        //        return result;
        //    }

        //    catch (FormatException)
        //    {
        //        Console.Write("Alguno de los datos ingresados no es un numero \n");
        //        throw;
        //    }

        //    catch (DivideByZeroException)
        //    {
        //        Console.Write("La division por cero no es una operacion valida \n");
        //        throw;
        //    }
        //}

        /*Usuario ingresa numero decimal y explota*/

        //Version 4
        //public static decimal Dividir(string dividendo, string divisor)
        //{
        //    decimal result;

        //    try
        //    {
        //        result = decimal.Parse(dividendo) / decimal.Parse(divisor);
        //        Console.WriteLine($"El resultado de dividir {dividendo} por {divisor} es {result}");
        //        return result;
        //    }

        //    catch (FormatException)
        //    {
        //        Console.Write("Alguno de los datos ingresados no es un numero \n");
        //        throw;
        //    }

        //    catch (DivideByZeroException)
        //    {
        //        Console.Write("La division por cero no es una operacion valida \n");
        //        throw;
        //    }
        //}
    }
}
