namespace FormParcial
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
            this.textBoxNombrePlaneta = new System.Windows.Forms.TextBox();
            this.buttonAgregarPlaneta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTiempoOrbita = new System.Windows.Forms.TextBox();
            this.textBoxNombreSatelite = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboboxPlanetas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownCompletarOrbita = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCompletarRotacion = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipoPlaneta = new System.Windows.Forms.ComboBox();
            this.numericUpDownTiempoRotacion = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLunas = new System.Windows.Forms.NumericUpDown();
            this.buttonAgregarSatelite = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompletarOrbita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompletarRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLunas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombrePlaneta
            // 
            this.textBoxNombrePlaneta.Location = new System.Drawing.Point(146, 36);
            this.textBoxNombrePlaneta.Name = "textBoxNombrePlaneta";
            this.textBoxNombrePlaneta.Size = new System.Drawing.Size(120, 20);
            this.textBoxNombrePlaneta.TabIndex = 0;
            // 
            // buttonAgregarPlaneta
            // 
            this.buttonAgregarPlaneta.Location = new System.Drawing.Point(12, 266);
            this.buttonAgregarPlaneta.Name = "buttonAgregarPlaneta";
            this.buttonAgregarPlaneta.Size = new System.Drawing.Size(255, 53);
            this.buttonAgregarPlaneta.TabIndex = 1;
            this.buttonAgregarPlaneta.Text = "Agregar planeta";
            this.buttonAgregarPlaneta.UseVisualStyleBackColor = true;
            this.buttonAgregarPlaneta.Click += new System.EventHandler(this.buttonAgregarPlaneta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de el planeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo en completa orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timepo en completa rotacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad de lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de planeta";
            // 
            // textBoxTiempoOrbita
            // 
            this.textBoxTiempoOrbita.Location = new System.Drawing.Point(146, 70);
            this.textBoxTiempoOrbita.Name = "textBoxTiempoOrbita";
            this.textBoxTiempoOrbita.Size = new System.Drawing.Size(121, 20);
            this.textBoxTiempoOrbita.TabIndex = 7;
            // 
            // textBoxNombreSatelite
            // 
            this.textBoxNombreSatelite.Location = new System.Drawing.Point(465, 82);
            this.textBoxNombreSatelite.Name = "textBoxNombreSatelite";
            this.textBoxNombreSatelite.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombreSatelite.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(641, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 426);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Planeta";
            // 
            // comboboxPlanetas
            // 
            this.comboboxPlanetas.FormattingEnabled = true;
            this.comboboxPlanetas.Location = new System.Drawing.Point(465, 36);
            this.comboboxPlanetas.Name = "comboboxPlanetas";
            this.comboboxPlanetas.Size = new System.Drawing.Size(121, 21);
            this.comboboxPlanetas.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre de Satelite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = " Tiempo en completar la orbita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiempo en completa la rotacion";
            // 
            // numericUpDownCompletarOrbita
            // 
            this.numericUpDownCompletarOrbita.Location = new System.Drawing.Point(465, 123);
            this.numericUpDownCompletarOrbita.Name = "numericUpDownCompletarOrbita";
            this.numericUpDownCompletarOrbita.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCompletarOrbita.TabIndex = 15;
            // 
            // numericUpDownCompletarRotacion
            // 
            this.numericUpDownCompletarRotacion.Location = new System.Drawing.Point(465, 167);
            this.numericUpDownCompletarRotacion.Name = "numericUpDownCompletarRotacion";
            this.numericUpDownCompletarRotacion.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCompletarRotacion.TabIndex = 16;
            // 
            // comboBoxTipoPlaneta
            // 
            this.comboBoxTipoPlaneta.FormattingEnabled = true;
            this.comboBoxTipoPlaneta.Location = new System.Drawing.Point(145, 187);
            this.comboBoxTipoPlaneta.Name = "comboBoxTipoPlaneta";
            this.comboBoxTipoPlaneta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoPlaneta.TabIndex = 17;
            // 
            // numericUpDownTiempoRotacion
            // 
            this.numericUpDownTiempoRotacion.Location = new System.Drawing.Point(146, 107);
            this.numericUpDownTiempoRotacion.Name = "numericUpDownTiempoRotacion";
            this.numericUpDownTiempoRotacion.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTiempoRotacion.TabIndex = 18;
            // 
            // numericUpDownLunas
            // 
            this.numericUpDownLunas.Location = new System.Drawing.Point(146, 149);
            this.numericUpDownLunas.Name = "numericUpDownLunas";
            this.numericUpDownLunas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLunas.TabIndex = 19;
            // 
            // buttonAgregarSatelite
            // 
            this.buttonAgregarSatelite.Location = new System.Drawing.Point(314, 266);
            this.buttonAgregarSatelite.Name = "buttonAgregarSatelite";
            this.buttonAgregarSatelite.Size = new System.Drawing.Size(271, 53);
            this.buttonAgregarSatelite.TabIndex = 20;
            this.buttonAgregarSatelite.Text = "Agregar Satelite";
            this.buttonAgregarSatelite.UseVisualStyleBackColor = true;
            this.buttonAgregarSatelite.Click += new System.EventHandler(this.buttonAgregarSatelite_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(573, 54);
            this.button3.TabIndex = 21;
            this.button3.Text = "Mover astros";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(573, 53);
            this.button4.TabIndex = 22;
            this.button4.Text = "Mostrar informacion";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAgregarSatelite);
            this.Controls.Add(this.numericUpDownLunas);
            this.Controls.Add(this.numericUpDownTiempoRotacion);
            this.Controls.Add(this.comboBoxTipoPlaneta);
            this.Controls.Add(this.numericUpDownCompletarRotacion);
            this.Controls.Add(this.numericUpDownCompletarOrbita);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboboxPlanetas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxNombreSatelite);
            this.Controls.Add(this.textBoxTiempoOrbita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregarPlaneta);
            this.Controls.Add(this.textBoxNombrePlaneta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompletarOrbita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompletarRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombrePlaneta;
        private System.Windows.Forms.Button buttonAgregarPlaneta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTiempoOrbita;
        private System.Windows.Forms.TextBox textBoxNombreSatelite;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboboxPlanetas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownCompletarOrbita;
        private System.Windows.Forms.NumericUpDown numericUpDownCompletarRotacion;
        private System.Windows.Forms.ComboBox comboBoxTipoPlaneta;
        private System.Windows.Forms.NumericUpDown numericUpDownTiempoRotacion;
        private System.Windows.Forms.NumericUpDown numericUpDownLunas;
        private System.Windows.Forms.Button buttonAgregarSatelite;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

