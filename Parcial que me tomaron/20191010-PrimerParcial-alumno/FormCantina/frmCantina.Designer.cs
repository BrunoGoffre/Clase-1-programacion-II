namespace FormCantina
{
    partial class frmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCantina));
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownCapacidad = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.radioButtonAgua = new System.Windows.Forms.RadioButton();
            this.radioButtonCerveza = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownContenido = new System.Windows.Forms.NumericUpDown();
            this.barra1 = new ControlCantina.barra1();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(179, 386);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(176, 20);
            this.textBoxMarca.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownCapacidad
            // 
            this.numericUpDownCapacidad.Location = new System.Drawing.Point(179, 432);
            this.numericUpDownCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Name = "numericUpDownCapacidad";
            this.numericUpDownCapacidad.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownCapacidad.TabIndex = 2;
            this.numericUpDownCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(401, 385);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 3;
            // 
            // radioButtonAgua
            // 
            this.radioButtonAgua.AutoSize = true;
            this.radioButtonAgua.Location = new System.Drawing.Point(42, 373);
            this.radioButtonAgua.Name = "radioButtonAgua";
            this.radioButtonAgua.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAgua.TabIndex = 4;
            this.radioButtonAgua.TabStop = true;
            this.radioButtonAgua.Text = "Agua";
            this.radioButtonAgua.UseVisualStyleBackColor = true;
            // 
            // radioButtonCerveza
            // 
            this.radioButtonCerveza.AutoSize = true;
            this.radioButtonCerveza.Location = new System.Drawing.Point(42, 405);
            this.radioButtonCerveza.Name = "radioButtonCerveza";
            this.radioButtonCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioButtonCerveza.TabIndex = 5;
            this.radioButtonCerveza.TabStop = true;
            this.radioButtonCerveza.Text = "Cerveza";
            this.radioButtonCerveza.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marca";
            // 
            // numericUpDownContenido
            // 
            this.numericUpDownContenido.Location = new System.Drawing.Point(304, 432);
            this.numericUpDownContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownContenido.Name = "numericUpDownContenido";
            this.numericUpDownContenido.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownContenido.TabIndex = 7;
            this.numericUpDownContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(-2, 1);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(573, 333);
            this.barra1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contenido";
            // 
            // frmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.numericUpDownContenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonCerveza);
            this.Controls.Add(this.radioButtonAgua);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.numericUpDownCapacidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMarca);
            this.Name = "frmCantina";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacidad;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonAgua;
        private System.Windows.Forms.RadioButton radioButtonCerveza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownContenido;
        private ControlCantina.barra1 barra1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

