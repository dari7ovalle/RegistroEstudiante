using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiante
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 formEstudiantes = new Form1();
            formEstudiantes.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripcionesForm inscripciones = new rInscripcionesForm();
            inscripciones.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cInscripcionesForm cInscripciones = new cInscripcionesForm();
            cInscripciones.Show();
        }

       

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PagosForm pagos = new PagosForm();
            pagos.Show();
        }
    }
}
