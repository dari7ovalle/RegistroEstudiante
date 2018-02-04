using RegistroEstudiante.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiante.Entidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            TipoTelefonosDb db = new TipoTelefonosDb();

            TipoTelefonos TipoTelefonos= new TipoTelefonos();

           
            int Id = 0;
            int.TryParse(TelefonoIdtextbox.Text, out Id);
            TipoTelefonos.TipoId = Id;
            TipoTelefonos.Celular = Celulartextbox.Text;
            TipoTelefonos.Telefono = Telefonotextbox.Text;

            db.TipoTelefonos.Add(TipoTelefonos);
            db.SaveChanges();
         
        }
    }
}
