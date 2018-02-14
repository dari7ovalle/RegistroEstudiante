using RegistroEstudiante.BLL;
using RegistroEstudiante.Entidades;
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
    public partial class rBecas : Form
    {
        public rBecas()
        {
            InitializeComponent();
        }

        private Becas LlenarCampos()
        {
            int NotaId = 0;
            NotaId = Decimal.ToInt32(NotaIdUpDownP.Value);
            Becas becas = BecasBLL.Buscar(NotaId);
            if (becas == null)
            {
                MessageBox.Show("No se encontro el pago");
            }
            else
            {

            }
            return becas;
        }

        private Becas LlenaClase()
        {
            Becas becas = new Becas();
            int PctBecasText = int.Parse(porcientotextBox.Text);
            int montoText = int.Parse(MontotextBox.Text);
            if (PctBecasText <= montoText)
            {
                becas.EstudianteId = int.Parse(IdEstudiantesnumericUpDownP.Value.ToString());
               
                becas.Fecha = FechaTimePickerP.Text;
                becas.Monto = montoText;
                becas.MontoaAsignatura = montoText;
                becas.PctBeca = PctBecasText;
                becas.Observaciones = ObservacionestextBoxP.Text;

            }
            else
            {
                MessageBox.Show("El pago es mayor que el monto, debe ser igual o menor");
                becas = null;
            }
            return becas;

        }

        private void BuscarbuttonP_Click(object sender, EventArgs e)
        {

             Becas becas = BecasBLL.Buscar(int.Parse(NotaIdUpDownP.Value.ToString()));
            if (becas != null)
            {
                FechaTimePickerP.Text = becas.Fecha;
                MontotextBox.Text = becas.Monto.ToString();
                porcientotextBox.Text = becas.PctBeca.ToString();
                ObservacionestextBoxP.Text = becas.Observaciones.ToString();

                Estudiantes estudiantes = EstudianteBLL.Buscar(becas.EstudianteId);
                if (estudiantes != null)
                {
                    Nombrelabel.Text = estudiantes.Nombres;
                }

            }
            else
            {

                MessageBox.Show(" rebisese tome fosfobe 12");
            }
        }

        private void BuscarEbuttonP_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = EstudianteBLL.Buscar(int.Parse(IdEstudiantesnumericUpDownP.Value.ToString()));
            if (estudiantes != null)
            {
                Nombrelabel.Text = estudiantes.Nombres;
            }

        }

        private void NuevobuttonP_Click(object sender, EventArgs e)
        {

        }

        private void GuardarbuttonP_Click(object sender, EventArgs e)
        {
            if (BecasBLL.Guardar(LlenaClase()))
            {
                MessageBox.Show("Guardado Correctamente","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EliminarbuttonP_Click(object sender, EventArgs e)
        {
            
            if (BecasBLL.eliminar(int.Parse(NotaIdUpDownP.Value.ToString())))
            {
                MessageBox.Show(" fue eliminado");

            }

            else
            {
                MessageBox.Show(" no se pudo eliminar");
            }

        }
    }


}
