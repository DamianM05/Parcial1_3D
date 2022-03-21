using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_3D
{
    class DatosJugadores
    {
        string noIdentificacion;
        string nombre;
        string equipoPerteneciente;
        public static List<DatosJugadores> listaJugadores = new List<DatosJugadores>();

        public string NoIdentificacion { get => noIdentificacion; set => noIdentificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string EquipoPerteneciente { get => equipoPerteneciente; set => equipoPerteneciente = value; }

        public static void cargarLista()
        {
            FileStream stream = new FileStream("Jugadores.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                DatosJugadores jugador = new DatosJugadores();
                jugador.noIdentificacion = leer.ReadLine();
                jugador.nombre = leer.ReadLine();
                jugador.equipoPerteneciente = leer.ReadLine();
                listaJugadores.Add(jugador);
            }
            leer.Close();
            stream.Close();
        }
    }
}
