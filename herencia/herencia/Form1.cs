using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //crear la instancia de la clase administrativo
            Administrativo administrativo = new Administrativo();

            administrativo.name = "Carlos";
            administrativo.area = "Ventas";

            MessageBox.Show(administrativo.registrar());
            MessageBox.Show(administrativo.consultar());
            MessageBox.Show(administrativo.sueldo());

            //Crear instancia de la clase docente
            Docente docente = new Docente();

            docente.name = "Emilia";
            docente.cargo = "Maestra";
            docente.HorasTrabajadas = "20";

            MessageBox.Show(docente.registrar());
            MessageBox.Show(docente.consultar());
            MessageBox.Show(docente.sueldo());

            //Crear instancia de la clase personallimpieza
            PersonalLimpieza personalLimpieza = new PersonalLimpieza();

            personalLimpieza.name = "Esdeth";
            personalLimpieza.turno = "Nocturno";

            MessageBox.Show(personalLimpieza.registrar());
            MessageBox.Show(personalLimpieza.consultar());
            MessageBox.Show(personalLimpieza.sueldo());

        }
    }
}