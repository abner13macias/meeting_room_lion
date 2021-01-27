using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLionSystems
{
    class Sala
    {
        //Se definen los atributos que tendrá la clase 'Sala'
        public int id;
        public string nombre;
        public TimeSpan hora_inicio, hora_fin;

        //Constructor de la clase 'Sala'
        public Sala( int id, string nombre, TimeSpan hora_inicio, TimeSpan hora_fin )
        {
            this.id = id;
            this.nombre = nombre;
            this.hora_inicio = hora_inicio;
            this.hora_fin = hora_fin;
        }
    }
}
