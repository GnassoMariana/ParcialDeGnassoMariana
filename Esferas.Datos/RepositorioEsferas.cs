using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esferas.Entidades;

namespace Esferas.Datos
{
    public class RepositorioEsferas
    {

        private List<Esfera> listaEsferas;

        public RepositorioEsferas()
        {
            listaEsferas = new List<Esfera>();


        }

        public List<Esfera> GetLista()
        {
            return listaEsferas;
        }

        public void AgregarEsfera(Esfera esfera)
        {
            listaEsferas.Add(esfera);
        }

        public int GetCantidad()
        {
            return listaEsferas.Count();
        }

        public bool BorrarEsfera(Esfera esfera)
        {
            if (listaEsferas.Contains(esfera))
            {
                listaEsferas.Remove(esfera);
                return true;
            }
            return false;
        }

        public List<Esfera> FiltrarEsfera(int radioFiltro)
        {
            return listaEsferas.Where(e => e.Radio > radioFiltro).ToList();
        }

        public int GetCantidadFiltrada(int radioFiltro)
        {
            return listaEsferas.Count(e => e.Radio > radioFiltro);
        }
    }
}
