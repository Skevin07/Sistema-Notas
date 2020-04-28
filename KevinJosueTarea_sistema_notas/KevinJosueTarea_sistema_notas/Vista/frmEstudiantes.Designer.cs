namespace KevinJosueTarea_sistema_notas.Vista
{
    partial class frmEstudiantes
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
            this.btnGUARDARfrm_Estudiante = new System.Windows.Forms.Button();
            this.txtNAME_ESTUDIANTE = new System.Windows.Forms.TextBox();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.txtCONTRASENAA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGUARDARfrm_Estudiante
            // 
            this.btnGUARDARfrm_Estudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGUARDARfrm_Estudiante.Location = new System.Drawing.Point(12, 312);
            this.btnGUARDARfrm_Estudiante.Name = "btnGUARDARfrm_Estudiante";
            this.btnGUARDARfrm_Estudiante.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDARfrm_Estudiante.TabIndex = 0;
            this.btnGUARDARfrm_Estudiante.Text = "Guardar";
            this.btnGUARDARfrm_Estudiante.UseVisualStyleBackColor = true;
            this.btnGUARDARfrm_Estudiante.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNAME_ESTUDIANTE
            // 
            this.txtNAME_ESTUDIANTE.Location = new System.Drawing.Point(12, 79);
            this.txtNAME_ESTUDIANTE.Name = "txtNAME_ESTUDIANTE";
            this.txtNAME_ESTUDIANTE.Size = new System.Drawing.Size(258, 20);
            this.txtNAME_ESTUDIANTE.TabIndex = 2;
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(12, 129);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(258, 20);
            this.txtAPELLIDO.TabIndex = 3;
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(12, 182);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(258, 20);
            this.txtUSUARIO.TabIndex = 4;
            // 
            // txtCONTRASENAA
            // 
            this.txtCONTRASENAA.Location = new System.Drawing.Point(12, 244);
            this.txtCONTRASENAA.Name = "txtCONTRASENAA";
            this.txtCONTRASENAA.Size = new System.Drawing.Size(258, 20);
            this.txtCONTRASENAA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(93, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar campos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCONTRASENAA);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.txtAPELLIDO);
            this.Controls.Add(this.txtNAME_ESTUDIANTE);
            this.Controls.Add(this.btnGUARDARfrm_Estudiante);
            this.Name = "frmEstudiantes";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGUARDARfrm_Estudiante;
        private System.Windows.Forms.TextBox txtNAME_ESTUDIANTE;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.TextBox txtCONTRASENAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}