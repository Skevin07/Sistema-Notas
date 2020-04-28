using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinJosueTarea_sistema_notas.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNotas not = new frmNotas();
            not.MdiParent = this;
            not.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias mat = new frmMaterias();
            mat.MdiParent = this;
            mat.Show();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEstudiantes estu = new frmEstudiantes();
            estu.MdiParent = this;
            estu.Show();
        }
    }
}
