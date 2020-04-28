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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        estudiantes user = new estudiantes();
        materias usir = new materias();
        notas usor = new notas();

        private void frmNotas_Load(object sender, EventArgs e)
        {

            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                var uniontablas = from estudy in db.estudiantes
                                  from nottas in db.notas
                                  where estudy.id_estudiante == nottas.id_estudiantes
                                  from matery in db.materias
                                  where nottas.id_materia == matery.id_materia

                                  select new
                                  {
                                      ID = estudy.id_estudiante,
                                      Estudiante = estudy.nombre_estudiante,
                                      Materia = matery.nombre_materia,
                                      Nota = nottas.nota,
                                      IDMateria = matery.id_materia,
                                      IDNOTA = nottas.id_notas

                                  };


                foreach( var interar in uniontablas)
                {
                    dtvInformacion.Rows.Add(interar.ID, interar.Estudiante, interar.Materia, interar.Nota, interar.IDMateria, interar.IDNOTA);
                }
             
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
          
            //using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            //{

             

            //    dtvInformacion.DataSource = db.estudiantes.ToList();
            //    dtvInformacion.DataSource = db.materias.ToList();
            //    dtvInformacion.DataSource = db.notas.ToList();


            //    var uniontablas = from estudy in db.estudiantes
            //                      from nottas in db.notas
            //                      where estudy.id_estudiante == nottas.id_estudiantes
            //                      from matery in db.materias
            //                      where nottas.id_materia == matery.id_materia

            //                      select new
            //                      {
            //                          ID = estudy.id_estudiante,
            //                          Estudiante = estudy.nombre_estudiante,
            //                          Materia = matery.nombre_materia,
            //                          Nota = nottas.nota,
            //                          IDMateria = matery.id_materia,
            //                          IDNOTA = nottas.id_notas

            //                      };

            //    foreach (var interar in uniontablas)
            //    {
            //        dtvInformacion.Rows.Add(interar.ID, interar.Estudiante, interar.Materia, interar.Nota, interar.IDMateria, interar.IDNOTA);
            //    }

             

            //}


        }


         //EL DE ELIMINAR FUNCIONA CORRECTAMENTE !!! YA ESTA COMPROBADO 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String id = dtvInformacion.CurrentRow.Cells[0].Value.ToString();
                String ide = dtvInformacion.CurrentRow.Cells[4].Value.ToString();
                String idee = dtvInformacion.CurrentRow.Cells[5].Value.ToString();

                user = db.estudiantes.Find(int.Parse(id));
                db.estudiantes.Remove(user);
                usir = db.materias.Find(int.Parse(ide));
                db.materias.Remove(usir);
                usor = db.notas.Find(int.Parse(idee));
                db.notas.Remove(usor);
                MessageBox.Show("Los cambios se han realizado correctamente, para verficar salga y vuelva a entrar");
                db.SaveChanges();

            }
        }


        //Para agregar un nuevo campo a la base de datos, en este caso solo funciona para notas
        private void btnNuevo_Click(object sender, EventArgs e)
        {
          
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                          
                usor.nota = txtNota.Text;  
                
                db.notas.Add(usor);
                db.SaveChanges();


            }

        }


        //// Este codigo de aca sirve para que cuando selecciones una fila del datagril aparezaca la informacion en los texbox !!
        private void dtvInformacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            String nombre_estudiante = dtvInformacion.CurrentRow.Cells[0].Value.ToString();
            String materia = dtvInformacion.CurrentRow.Cells[4].Value.ToString();
            String nota = dtvInformacion.CurrentRow.Cells[3].Value.ToString();

            txtEstudiante.Text = nombre_estudiante;
            txtMateria.Text = materia;
            txtNota.Text = nota;
        }



       //Codigo para editar a tarvez de los campos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String id = dtvInformacion.CurrentRow.Cells[0].Value.ToString();
                String ide = dtvInformacion.CurrentRow.Cells[4].Value.ToString();
                String idee = dtvInformacion.CurrentRow.Cells[5].Value.ToString();


               
                int idCE = int.Parse(id);
                user = db.estudiantes.Where(VerificarIDE => VerificarIDE.id_estudiante == idCE).First();
                user.nombre_estudiante = txtEstudiante.Text;             
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;

                int idCM = int.Parse(ide);
                usir = db.materias.Where(VerificarIDM => VerificarIDM.id_materia == idCM).First();
                usir.nombre_materia = txtMateria.Text;
                db.Entry(usir).State = System.Data.Entity.EntityState.Modified;

                int idCN = int.Parse(idee);
                usor = db.notas.Where(VerificarIDN => VerificarIDN.id_notas == idCN).First();
                usor.nota = txtNota.Text;
                db.Entry(usor).State = System.Data.Entity.EntityState.Modified;

                MessageBox.Show("Los cambios se han realizado correctamente, para verficar salga y vuelva a entrar");
                db.SaveChanges();

            }
        }

        private void btnCleanCampus_Click(object sender, EventArgs e)
        {
            txtEstudiante.Text = "";
            txtMateria.Text = "";
            txtNota.Text = "";
        }

        private void dtvInformacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }
    }
}


//ESTO QUE VES ACA ES LO DEL INNER JOIN CON LAS TRES TABLAS PERO AHORA QUE PRUEBO NO LO NECESITO YA QUE ESTO SIRVIERIA SI LO CUPARA PARA 
//HACER LO QUE ES LA OPCION NUEVO, EDITAR, EN UN SOLO FORMULARON EN DONDE PODRIA HACER TODOS ESTOS CAMBIOS DE UN SOLO 
//PERO SE DA EL CASO QUE NO PEDO HACER ESO PORQUE ESO LO DIVIDE EN DIFERENTE FORMULARIOS  COMO POR EJEMPLO TODAS LA INFORMACION
//DE LOS ESTUDIANTE SE LOS AGREGARE EN EL FORMULARIO RESPECTIVO DE ESTUDIANTE ASI EL DE MATERIA Y EL DE NOTA RESPECTIVAMENTE
//ENTONCES CREO QUE PARA ESO TENDRE QUE HACER UNA MODIFICACION EN EL INNER JOIN QUE RESPECTA CON LO QUE HARE
//HASTA EL MOMENTO ASI TENGO LA IDEA PERO VERE SI FUNCIONA ASI QUE SALUDOS 

//var uniontablas = from estudy in db.estudiantes
//                  from nottas in db.notas
//                  where estudy.id_estudiante == nottas.id_estudiantes
//                  from matery in db.materias
//                  where nottas.id_materia == matery.id_materia

//                  select new
//                  {
//                      ID = estudy.id_estudiante,
//                      Estudiante = estudy.nombre_estudiante,
//                      Materia = matery.nombre_materia,
//                      Nota = nottas.nota,
//                      IDMateria = matery.id_materia,
//                      IDNOTA = nottas.id_notas

//                  };