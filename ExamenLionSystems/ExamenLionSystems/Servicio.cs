using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLionSystems
{
    class Servicio
    {
        private List<Sala> salasOcupadas = new List<Sala>();
        private ConexionMySQL DBConnection = new ConexionMySQL();

        public Servicio()
        {
            obtenerSalasOcupadas();
        }

        public void obtenerSalasOcupadas()
        {
            salasOcupadas = DBConnection.obtenerSalasOcupadas();
        }
    }
}
