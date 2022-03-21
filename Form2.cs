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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Visualizar.listadeViusalizacion.Clear();
            Visualizar.CargarLista();
            CenterToScreen();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Visualizar.listadeViusalizacion;
            dataGridView1.Refresh();
        }

        private void ordenarPorGolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizar.listadeViusalizacion = Visualizar.listadeViusalizacion.OrderByDescending
                (x => x.Goles).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Visualizar.listadeViusalizacion;
            dataGridView1.Refresh();
        }

        private void promedioDeGolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto;
            texto = Visualizar.listadeViusalizacion.Average(x => x.Goles).ToString();
            MessageBox.Show("El promedio de Goles del partido fue de: " + texto);
        }
    }
}
    

