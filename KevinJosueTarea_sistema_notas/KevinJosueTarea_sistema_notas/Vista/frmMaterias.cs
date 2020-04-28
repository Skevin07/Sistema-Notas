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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }

        materias usaM = new materias();


        private void frmMaterias_Load(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {

                var materias = db.materias;

                foreach(var interar in materias)
                {
                    dtvINFOMATERIA.Rows.Add(interar.id_materia, interar.nombre_materia);
                }
               

            }
        }

        private void btnGuardarfrm_Materias_Click(object sender, EventArgs e)
        {

            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                usaM.nombre_materia = txtNOMBREDEMATERIAD.Text;
                
                db.materias.Add(usaM);
                MessageBox.Show("Los datos se han guardado correctamente ");
                db.SaveChanges();


            }


        }

        private void btnACTUALIZARfrm_Materias_Click(object sender, EventArgs e)
        {

            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {

                

            }

        }

        private void dtvINFOMATERIA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id_materia = dtvINFOMATERIA.CurrentRow.Cells[0].Value.ToString();
            String nombre_materia = dtvINFOMATERIA.CurrentRow.Cells[1].Value.ToString();

            txtID.Text = id_materia;
            txtNOMBREDEMATERIAD.Text = nombre_materia;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNOMBREDEMATERIAD.Text = "";
        }
    }
}
