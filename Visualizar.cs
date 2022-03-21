using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_3D
{
    class Visualizar
    {
        string nombre;
        int goles;
        public static List<Visualizar> listadeViusalizacion = new List<Visualizar>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Goles { get => goles; set => goles = value; }

        public static void CargarLista()
        {
            foreach (var partido in DatosPartido.listadatosPartido)
            {
                Visualizar dato = new Visualizar();
                DatosJugadores jugador = DatosJugadores.listaJugadores.Find(x => x.NoIdentificacion == partido.NoIdentificacionJugador);
                dato.nombre = jugador.Nombre;
                dato.goles = partido.GolesAnotados;
                listadeViusalizacion.Add(dato);
            }
        }
    }
}
