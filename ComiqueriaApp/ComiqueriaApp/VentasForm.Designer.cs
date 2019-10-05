namespace ComiqueriaApp
{
    partial class VentasForm
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
            this.buttonVender = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVender
            // 
            this.buttonVender.Location = new System.Drawing.Point(12, 104);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(120, 32);
            this.buttonVender.TabIndex = 0;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.ButtonVender_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(157, 104);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(118, 32);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(11, 9);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(57, 20);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "label1";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(9, 43);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(68, 17);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioFinal.Location = new System.Drawing.Point(152, 63);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(122, 16);
            this.labelPrecioFinal.TabIndex = 4;
            this.labelPrecioFinal.Text = "Precio final: $X,XX";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(12, 63);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantidad.TabIndex = 5;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.ValueChanged += new System.EventHandler(this.NumericUpDownCantidad_ValueChanged);
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 150);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.labelPrecioFinal);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonVender);
            this.Name = "VentasForm";
            this.Text = "Nueva Venta";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecioFinal;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
    }
}