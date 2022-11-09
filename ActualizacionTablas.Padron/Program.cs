using Newtonsoft.Json;
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
        const string PATH = @"C:\BaseBCRA\Padron_AFIP.txt";

        static void Main(string[] args)
        {
            int i = 1;

            try
            {
                using (FileStream fs = File.Open(PATH, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;

                    var lote = new List<RegistroPadron>();

                    TextWriter tw = null;

                    string path = @"C:\BaseBCRA\Padron.txt";

                    //File.Delete(path);

                    if (!File.Exists(path))
                    {
                        File.Create(path);
                        tw = new StreamWriter(path);
                        //tw.WriteLine("The very first line!");
                        //tw.Close();
                    }
                    else if (File.Exists(path))
                    {
                        tw = new StreamWriter(path);
                        //tw.WriteLine("The next line!");
                        //tw.Close();
                    }

                    // Create a new file     
                    while ((line = sr.ReadLine()) != null)
                    {
                        string NroIdentificacion = line.Substring(0, 11);
                        string Denominacion = line.Substring(11, 160);
                        string Actividad = line.Substring(171, 6);
                        string MarcaDeBaja = line.Substring(177, 1);
                        string NumIdentificacionDeReemplazo = line.Substring(178, 11);
                        string Fallecimiento = line.Substring(189, 1);

                        //lote.Add(registroPadron);

                        //if (i % 100 == 0)
                        //{
                        //    db.registrosPadron.AddRange(lote);
                        //    db.SaveChanges();
                        //    lote.Clear();
                        //    Console.WriteLine("inserte i: " + i);
                        //}
                        tw.WriteLine($"{NroIdentificacion};{Denominacion};{Actividad};{MarcaDeBaja};{NumIdentificacionDeReemplazo};{Fallecimiento};");
                        if (i % 100_000 == 0)
                            Console.WriteLine("inserte 100.000, total: " + i);
                        i++;
                    }
                    tw.Close();
                    Console.WriteLine("end");
                }
                //Crear tablas
                //Leer archivo y subirlo
                //Crear indices
                //Cambiar nombre de nueva tabla
            }
            catch (Exception ex) {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
                Console.WriteLine("i: " + i);
            }

            Console.Read();
        }
    }
}
