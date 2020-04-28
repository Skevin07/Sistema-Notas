namespace KevinJosueTarea_sistema_notas.Vista
{
    partial class frmMaterias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNOMBREDEMATERIAD = new System.Windows.Forms.TextBox();
            this.dtvINFOMATERIA = new System.Windows.Forms.DataGridView();
            this.btnGuardarfrm_Materias = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvINFOMATERIA)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(73, 21);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de materia";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtNOMBREDEMATERIAD
            // 
            this.txtNOMBREDEMATERIAD.Location = new System.Drawing.Point(76, 98);
            this.txtNOMBREDEMATERIAD.Name = "txtNOMBREDEMATERIAD";
            this.txtNOMBREDEMATERIAD.Size = new System.Drawing.Size(178, 20);
            this.txtNOMBREDEMATERIAD.TabIndex = 4;
            // 
            // dtvINFOMATERIA
            // 
            this.dtvINFOMATERIA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvINFOMATERIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvINFOMATERIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia,
            this.nombre_materia});
            this.dtvINFOMATERIA.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtvINFOMATERIA.Location = new System.Drawing.Point(12, 157);
            this.dtvINFOMATERIA.Name = "dtvINFOMATERIA";
            this.dtvINFOMATERIA.Size = new System.Drawing.Size(736, 121);
            this.dtvINFOMATERIA.TabIndex = 5;
            this.dtvINFOMATERIA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvINFOMATERIA_CellClick);
            // 
            // btnGuardarfrm_Materias
            // 
            this.btnGuardarfrm_Materias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarfrm_Materias.Location = new System.Drawing.Point(63, 313);
            this.btnGuardarfrm_Materias.Name = "btnGuardarfrm_Materias";
            this.btnGuardarfrm_Materias.Size = new System.Drawing.Size(114, 23);
            this.btnGuardarfrm_Materias.TabIndex = 6;
            this.btnGuardarfrm_Materias.Text = "Guardar";
            this.btnGuardarfrm_Materias.UseVisualStyleBackColor = true;
            this.btnGuardarfrm_Materias.Click += new System.EventHandler(this.btnGuardarfrm_Materias_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(200, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_materia
            // 
            this.id_materia.HeaderText = "ID";
            this.id_materia.Name = "id_materia";
            // 
            // nombre_materia
            // 
            this.nombre_materia.HeaderText = "Materia";
            this.nombre_materia.Name = "nombre_materia";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarfrm_Materias);
            this.Controls.Add(this.dtvINFOMATERIA);
            this.Controls.Add(this.txtNOMBREDEMATERIAD);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Name = "frmMaterias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvINFOMATERIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNOMBREDEMATERIAD;
        private System.Windows.Forms.DataGridView dtvINFOMATERIA;
        private System.Windows.Forms.Button btnGuardarfrm_Materias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_materia;
    }
}