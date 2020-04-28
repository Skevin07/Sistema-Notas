using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KevinJosueTarea_sistema_notas.Model;
using KevinJosueTarea_sistema_notas.Vista;

namespace KevinJosueTarea_sistema_notas.Vista
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        estudiantes util = new estudiantes();    
       

        private void button1_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {

                util.nombre_estudiante = txtNAME_ESTUDIANTE.Text;
                util.apellido = txtAPELLIDO.Text;
                util.usuario = txtUSUARIO.Text;
                util.contrasena = txtCONTRASENAA.Text;

                MessageBox.Show("Los datos se han guardado correctamente ");
                db.estudiantes.Add(util);
                db.SaveChanges();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {



              

            }

        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {



        }
    }
}
