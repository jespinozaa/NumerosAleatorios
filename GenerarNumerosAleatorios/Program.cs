using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenerarNumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Atributos
            //Instancia de clase para generacion de numeros aleatorios
            Random rnd = new Random();
            var numeroObjetivo = 0;
            var cantNumerosAleatorios = 0;
            var suma = 0.0;
            #endregion

            Console.WriteLine("ingresa Numero Objetivo");
            numeroObjetivo = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Ingresa Cantidad Numeros Aleatorios");
            cantNumerosAleatorios = int.Parse(Console.ReadLine().ToString());

            double[] arr = new double[cantNumerosAleatorios];

            for (int x = 0; x < arr.Length; x++)
            {
                //cambiar a nexInt para obetener numeros enteros
                arr[x] = rnd.NextDouble();
                suma = suma + arr[x];
            }

            Console.WriteLine("Generando numeros aleatorios: ");
            Thread.Sleep(2000);

            foreach (var item in arr)
            {
                Console.WriteLine((item / suma) * numeroObjetivo);
            }

            Console.ReadKey();
            
        }
    }
}
