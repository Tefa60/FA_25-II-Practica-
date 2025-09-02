using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_1_PRACTICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejer1();
            Console.ReadKey();
        }
        static void Ejer1()
        {
            string nombre, carrera; //declarando variables
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera");
            carrera = Console.ReadLine();
            Console.WriteLine($"{nombre} bienbenido al curso fundamentos de algoritmos de la carrera {carrera}");


        }
        static void Ejer2()
        {
            Console.Write("Ingrese numero x:");
            int x= int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero y:");
            int y=Convert.ToInt32(Console.ReadLine());
            double resu = x / y;
            Console.WriteLine("Suma:"+ (x + y));
            Console.WriteLine("Resta:" + (x - y));
            Console.WriteLine("Multiplicacion:" + (x * y));
            Console.WriteLine("Division:" + resu);

        }
        static void Ejer3()
        {

        }
        static void Ejer4()
        {

        }
        static void Ejer5()
        {

        }
        static void Ejer6()
        {

        }
    }
}
