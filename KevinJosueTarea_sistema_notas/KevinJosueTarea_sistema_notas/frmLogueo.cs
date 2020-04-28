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



namespace KevinJosueTarea_sistema_notas
{
    public partial class frmLogueo : Form
    {
        public frmLogueo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {

                //usuario es un alias 

                var lista = from usuarioo in db.estudiantes
                            where usuarioo.usuario == txtUsuario.Text
                            && usuarioo.contrasena == txtContraseña.Text
                            select usuarioo;

                if (lista.Count() > 0)
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }

        }
    }
}
