using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_3D
{
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosJugadores jugador = DatosJugadores.listaJugadores.Find(x => x.Nombre == comboBox1.Text);
            DatosPartido partido = new DatosPartido();
            partido.NoIdentificacionJugador = jugador.NoIdentificacion;
            partido.Fecha = dateTimePicker1.Value;
            partido.EquipoAdversario = textBox1.Text;
            partido.GolesAnotados = Convert.ToInt16(textBox2.Text);
            DatosPartido.listadatosPartido.Add(partido);
            DatosPartido.GuardarenTxt();

            textBox1.Clear();
            textBox2.Clear();
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            foreach (var jugador in datosJugadores.listaJugadores)
                comboBox1.Items.Add(jugador.Nombre);
        }
    }
}
