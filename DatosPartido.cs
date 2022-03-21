using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_3D
{
    class DatosPartido
    {
        string noIdentificacionJUgador;
        DateTime fecha;
        string equipoAdversario;
        int golesAnotados;
        public static List<DatosPartido> listadatosPartido = new List<DatosPartido>();

        public string NoIdentificacionJugador { get => noIdentificacionJUgador; set => noIdentificacionJUgador = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string EquipoAdversario { get => equipoAdversario; set => equipoAdversario = value; }
        public int GolesAnotados { get => golesAnotados; set => golesAnotados = value; }
        public static void GuardarenTxt()
        {
            FileStream abrir = new FileStream("datosPartido.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            foreach (var dato in DatosPartido.listadatosPartido)
            {
                escribir.WriteLine(dato.noIdentificacionJUgador);
                escribir.WriteLine(dato.fecha);
                escribir.WriteLine(dato.equipoAdversario);
                escribir.WriteLine(dato.golesAnotados);
            }
            escribir.Close();
            abrir.Close();
        }

        public static void cargarLista()
        {
            FileStream stream = new FileStream("datosPartido.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                DatosPartido datos = new DatosPartido();
                datos.noIdentificacionJUgador = leer.ReadLine();
                datos.fecha = Convert.ToDateTime(leer.ReadLine());
                datos.equipoAdversario = leer.ReadLine();
                datos.golesAnotados = Convert.ToInt16(leer.ReadLine());
                listadatosPartido.Add(datos);
            }
            leer.Close();
            stream.Close();
        }
    }
}

