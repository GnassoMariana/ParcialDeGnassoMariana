using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esferas.Entidades;

namespace Esferas.Datos
{
    public static class ManejadorSecuencial
    {
        private static string archivo = "Esferas.txt";

        public static void GuardarEsferasSecuencial(List<Esfera> listaEsferas)
        {
            using (var escritorDeArchivo = new StreamWriter(archivo))
            {
                foreach (Esfera esfera in listaEsferas)
                {
                    string linea = ConstruirLinea(esfera);
                    escritorDeArchivo.WriteLine(linea);
                }
            }
        }

        public static List<Esfera> LeerEsferasSecuencial()
        {
            using (var lectorDeArchivo = new StreamReader(archivo))
            {
                List<Esfera> listaEsferas = new List<Esfera>();

                while (!lectorDeArchivo.EndOfStream)
                {
                    string linea = lectorDeArchivo.ReadLine();
                    Esfera esfera = ConstruirEsfera(linea);

                    listaEsferas.Add(esfera);
                         
                }

                return listaEsferas;
            }
        }

        private static Esfera ConstruirEsfera(string linea)
        {
            //No pude guardar por campos
            return new Esfera();
        }

        private static string ConstruirLinea(Esfera esfera)
        {
            return $"{esfera.Radio}";
        }
    }
}


