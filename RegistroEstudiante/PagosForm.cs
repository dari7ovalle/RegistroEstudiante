using RegistroEstudiante.BLL;
using RegistroEstudiante.DAL;
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
    public partial class PagosForm : Form
    {
        public PagosForm()
        {
            InitializeComponent();
        }


        private Pagos LlenaClase()
        {
            Pagos pago = new Pagos();
            float pagoText = float.Parse(PagotextBoxP.Text);
            float montoText = float.Parse(MontotextBox.Text);
            if (pagoText <= montoText)
            {
                pago.IdPago = 0;
                pago.IdEstudiante = Decimal.ToInt32(IdEstudiantesnumericUpDownP.Value);
                pago.Monto = float.Parse(MontotextBox.Text);
                pago.Balance = montoText - pagoText;
                pago.Fecha = FechaTimePickerP.Text;
                pago.Pago = float.Parse(PagotextBoxP.Text);
                pago.Observaciones = ObservacionestextBoxP.Text;
            }
            else
            {
                MessageBox.Show("El pago es mayor que el monto, debe ser igual o menor");
                pago = null;
            }
            return pago;

        }

        private void BuscarbuttonP_Click(object sender, EventArgs e)
        {
            Pagos pago = LlenarCampos();




        }

        private void BuscarEbuttonP_Click(object sender, EventArgs e)
        {
            int Id = 0;
            Id = Decimal.ToInt32(IdEstudiantesnumericUpDownP.Value);
            Estudiantes estudiantes = EstudianteBLL.Buscar(Id);
            if (estudiantes == null)
            {
                MessageBox.Show("No existe el estudiante que busca!");
            }
            else
            {
                Nombrelabel.Text = estudiantes.Nombres;
            }
        }

        private Pagos LlenarCampos()
        {
            int Id = 0;
            Id = Decimal.ToInt32(IDnumericUpDownP.Value);
            Pagos pago = PagosBLL.Buscar(Id);
            if (pago == null)
            {
                MessageBox.Show("No se encontro el pago");
            }
            else
            {
                FechaTimePickerP.Text = pago.Fecha;
                IdEstudiantesnumericUpDownP.Value = pago.IdEstudiante;
                MontotextBox.Text = Convert.ToString(pago.Monto);
                PagotextBoxP.Text = Convert.ToString(pago.Pago);
                BalancetextBox.Text = Convert.ToString(pago.Balance);
                ObservacionestextBoxP.Text = pago.Observaciones;
                Estudiantes estudiantes = EstudianteBLL.Buscar(pago.IdEstudiante);
                Nombrelabel.Text = estudiantes.Nombres;

            }

            return pago;

        }

        public void LimpiarTextBox()
        {
            FechaTimePickerP.Value = DateTime.Now;
            IdEstudiantesnumericUpDownP.Value = 0;
            MontotextBox.Text = string.Empty;
            PagotextBoxP.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            ObservacionestextBoxP.Text = string.Empty;
            Nombrelabel.Text = string.Empty;

        }

        private void GuardarbuttonP_Click_1(object sender, EventArgs e)
        {
            PagosDb db = new PagosDb();
            Pagos pagos = new Pagos();

            float Monto = 0, Balance = 0,pago=0;
            int Id = 0;
            float.TryParse(MontotextBox.Text, out Monto);
            float.TryParse(BalancetextBox.Text, out Balance);
            int.TryParse(IdEstudiantesnumericUpDownP.Text, out Id);
            float.TryParse(PagotextBoxP.Text, out pago);
            pagos.IdEstudiante = Id;
            pagos.Fecha = FechaTimePickerP.Text;
            pagos.Monto = Monto;
            pagos.Balance = Balance;
            pagos.Pago = pago;
            pagos.Observaciones = ObservacionestextBoxP.Text;

            db.pago.Add(pagos);
            db.SaveChanges();
            LimpiarTextBox();
        }

        private void NuevobuttonP_Click_1(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void EliminarbuttonP_Click_1(object sender, EventArgs e)
        {
            if (PagosBLL.eliminar((int)IDnumericUpDownP.Value))
            {
                LimpiarTextBox();
                MessageBox.Show("Se elimino correctamente el pago");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el pago");
            }
        }
    }
}
