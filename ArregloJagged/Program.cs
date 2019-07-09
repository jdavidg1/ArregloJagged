using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            //Arreglo contenedor
            double[][] Prueba = new double[5][];

            //Inicialización de los arreglos
            Prueba[0]= new double[a];
            Prueba[1]= new double[5];
            Prueba[2]= new double[1];
            Prueba[3]= new double[4];
            Prueba[4]= new double[2];

            Prueba[1][3] = 7.4;
            Prueba[4][1]= 22.1;



            Console.WriteLine(Prueba[1][3]);
            Console.ReadKey();

        }
    }
}


