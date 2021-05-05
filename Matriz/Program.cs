using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestra el uso de arreglos en dos dimensiones  o matrices
            //Variables de control para el ciclo for
            int m = 0;
            int n = 0;

            double sumatoria = 0;
            double promedio = 0.0; 
            double sumatoriaTotal = 0;
            double promedioTotal = 0;

            //Utilizar la variable random
            Random rnd = new Random();

            int[,] datos = new int[4, 7];


            for (n = 0; n < 4; n++)//avanzamos en renglones
            {
                for (m = 0; m < 7; m++)
                {
                    //para llevar acabo la asginacion (nombre matriz, indice f y c y el valor)
                    datos[n, m] = rnd.Next(30);
                }
            }

            //Imprimir los datos
            for (n = 0; n < 4; n++)
            {
                Console.WriteLine("Semana {0}", n);
                for (m = 0; m < 7; m++)
                {
                    Console.Write("{0} ", datos[n, m]);
                }
            }

            //Calcular el promedio por semana
            for (n = 0; n < 4; n++)
            {
                sumatoria = 0.0;
                promedio = 0.0;
                for (m = 0; m < 7; m++)
                {
                    sumatoria += datos[n, m];
                }

                promedio = sumatoria / 7.0;
                Console.WriteLine("El promedio de la semana {0} es {1}", n, promedio);
            }

            //Calcular el promedio total
            for (n = 0; n < 4; n++)
            {
                promedioTotal = 0.0;
                for (m = 0; m < 7; m++)
                {
                    sumatoriaTotal += datos[n, m];
                }
                promedioTotal = sumatoriaTotal / 28.0;
            }
            Console.WriteLine("El promedio total de las semanas: {0}", promedioTotal.ToString("0.00"));

            Console.ReadKey();
        }
    }
}

