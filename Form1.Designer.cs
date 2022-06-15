namespace CalculaNotas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrimerParcial = new System.Windows.Forms.TextBox();
            this.txtSegundoParcial = new System.Windows.Forms.TextBox();
            this.txtPractica = new System.Windows.Forms.TextBox();
            this.txtAsistencia = new System.Windows.Forms.TextBox();
            this.txtExamenFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotaFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalcularNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(56, 117);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(245, 20);
            this.txtNombreEstudiante.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Estudiante:";
            // 
            // txtPrimerParcial
            // 
            this.txtPrimerParcial.Location = new System.Drawing.Point(56, 180);
            this.txtPrimerParcial.Name = "txtPrimerParcial";
            this.txtPrimerParcial.Size = new System.Drawing.Size(100, 20);
            this.txtPrimerParcial.TabIndex = 2;
            // 
            // txtSegundoParcial
            // 
            this.txtSegundoParcial.Location = new System.Drawing.Point(59, 228);
            this.txtSegundoParcial.Name = "txtSegundoParcial";
            this.txtSegundoParcial.Size = new System.Drawing.Size(100, 20);
            this.txtSegundoParcial.TabIndex = 3;
            // 
            // txtPractica
            // 
            this.txtPractica.Location = new System.Drawing.Point(59, 274);
            this.txtPractica.Name = "txtPractica";
            this.txtPractica.Size = new System.Drawing.Size(100, 20);
            this.txtPractica.TabIndex = 4;
            // 
            // txtAsistencia
            // 
            this.txtAsistencia.Location = new System.Drawing.Point(59, 320);
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.Size = new System.Drawing.Size(100, 20);
            this.txtAsistencia.TabIndex = 5;
            // 
            // txtExamenFinal
            // 
            this.txtExamenFinal.Location = new System.Drawing.Point(59, 366);
            this.txtExamenFinal.Name = "txtExamenFinal";
            this.txtExamenFinal.Size = new System.Drawing.Size(100, 20);
            this.txtExamenFinal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Primer parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Segundo parcial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Practica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Asistencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Examen Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nota Final:";
            // 
            // txtNotaFinal
            // 
            this.txtNotaFinal.Location = new System.Drawing.Point(405, 197);
            this.txtNotaFinal.Name = "txtNotaFinal";
            this.txtNotaFinal.ReadOnly = true;
            this.txtNotaFinal.Size = new System.Drawing.Size(100, 20);
            this.txtNotaFinal.TabIndex = 13;
            this.txtNotaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "RESULTADO";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(338, 298);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(234, 67);
            this.txtMensaje.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CALCULO DE NOTAS ESCOLARES";
            // 
            // btnCalcularNota
            // 
            this.btnCalcularNota.Location = new System.Drawing.Point(405, 98);
            this.btnCalcularNota.Name = "btnCalcularNota";
            this.btnCalcularNota.Size = new System.Drawing.Size(100, 39);
            this.btnCalcularNota.TabIndex = 17;
            this.btnCalcularNota.Text = "Calcular Nota Final";
            this.btnCalcularNota.UseVisualStyleBackColor = true;
            this.btnCalcularNota.Click += new System.EventHandler(this.btnCalcularNota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnCalcularNota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNotaFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExamenFinal);
            this.Controls.Add(this.txtAsistencia);
            this.Controls.Add(this.txtPractica);
            this.Controls.Add(this.txtSegundoParcial);
            this.Controls.Add(this.txtPrimerParcial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrimerParcial;
        private System.Windows.Forms.TextBox txtSegundoParcial;
        private System.Windows.Forms.TextBox txtPractica;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.TextBox txtExamenFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotaFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcularNota;
    }
}

