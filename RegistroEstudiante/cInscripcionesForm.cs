using RegistroEstudiante.BLL;
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
    public partial class cInscripcionesForm : Form
    {
        public cInscripcionesForm()
        {
            InitializeComponent();
            CargarGridView();
        }

        private void CargarGridView()
        {
            FiltrarcomboBox.SelectedIndex = 0;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(CriteriotextBox.Text, out id);

                InscripcionesdataGridView.DataSource = InscripcionesBLL.GetList(p => p.InscripcionId == id);
            }
            else if (FiltrarcomboBox.SelectedIndex == 2)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(CriteriotextBox.Text, out id);

                InscripcionesdataGridView.DataSource = InscripcionesBLL.GetList(p => p.EstudianteId == id);
            }
            else if (FiltrarcomboBox.SelectedIndex == 3)
            {
                //ponerlo en una funcion
                double Monto = 0;
                double.TryParse(CriteriotextBox.Text, out Monto);

                InscripcionesdataGridView.DataSource = InscripcionesBLL.GetList(p => p.Monto == Monto);
            }
            else if (FiltrarcomboBox.SelectedIndex == 4)
            {
                //ponerlo en una funcion
                double Balance = 0;
                double.TryParse(CriteriotextBox.Text, out Balance);

                InscripcionesdataGridView.DataSource = InscripcionesBLL.GetList(p => p.Balance == Balance);
            }
        }
    }
}
