using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLionSystems
{
    class Sala
    {
        private string nombre;
        private TimeSpan hora_inicio, hora_fin;

        public Sala( string nombre, TimeSpan hora_inicio, TimeSpan hora_fin )
        {
            this.nombre = nombre;
            this.hora_inicio = hora_inicio;
            this.hora_fin = hora_fin;
        }
    }
}
