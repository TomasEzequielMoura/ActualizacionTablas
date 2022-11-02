using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizacionTablas.Padron
{
    class Program
    {
        const string PATH = @"C:\Users\79\Desktop\Debitia Report 10_28_2022.csv";

        static void Main(string[] args)
        {

            //Conectar a bd

            //Crear tablas

            //Leer archivo y subirlo
            using (FileStream fs = File.Open(PATH, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null && i < 50)
                {

                    Console.WriteLine(line);

                    i++;
                }
            }

            //Crear indices

            //Cambiar nombre de nueva tabla

            Console.Read();

        }
    }
}
