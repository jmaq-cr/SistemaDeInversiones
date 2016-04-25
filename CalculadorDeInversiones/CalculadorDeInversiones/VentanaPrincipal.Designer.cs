namespace CalculadorDeInversionesGUI
{
    partial class VentanaPrincipal
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
            System.Windows.Forms.Label labelTitulo;
            System.Windows.Forms.Label labelNombre;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label labelMoneda;
            System.Windows.Forms.Label labelMonto;
            System.Windows.Forms.Label labelPlazo;
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.boxMoneda = new System.Windows.Forms.ComboBox();
            this.textboxMonto = new System.Windows.Forms.TextBox();
            this.textboxPlazo = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            labelTitulo = new System.Windows.Forms.Label();
            labelNombre = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelMoneda = new System.Windows.Forms.Label();
            labelMonto = new System.Windows.Forms.Label();
            labelPlazo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AccessibleName = "labelTitulo";
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            labelTitulo.Location = new System.Drawing.Point(131, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new System.Drawing.Size(327, 36);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Calculador de Inversiones";
            // 
            // labelNombre
            // 
            labelNombre.AccessibleName = "labelNombre";
            labelNombre.AutoSize = true;
            labelNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNombre.Location = new System.Drawing.Point(97, 69);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new System.Drawing.Size(68, 19);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AccessibleName = "labelTipo";
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(121, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 19);
            label1.TabIndex = 3;
            label1.Text = "Tipo:";
            // 
            // labelMoneda
            // 
            labelMoneda.AccessibleName = "labelMoneda";
            labelMoneda.AutoSize = true;
            labelMoneda.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelMoneda.Location = new System.Drawing.Point(97, 164);
            labelMoneda.Name = "labelMoneda";
            labelMoneda.Size = new System.Drawing.Size(68, 19);
            labelMoneda.TabIndex = 5;
            labelMoneda.Text = "Moneda:";
            // 
            // labelMonto
            // 
            labelMonto.AccessibleName = "labelMonto";
            labelMonto.AutoSize = true;
            labelMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelMonto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelMonto.Location = new System.Drawing.Point(107, 213);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new System.Drawing.Size(58, 19);
            labelMonto.TabIndex = 7;
            labelMonto.Text = "Monto:";
            // 
            // labelPlazo
            // 
            labelPlazo.AccessibleName = "labelPlazo";
            labelPlazo.AutoSize = true;
            labelPlazo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPlazo.Location = new System.Drawing.Point(115, 262);
            labelPlazo.Name = "labelPlazo";
            labelPlazo.Size = new System.Drawing.Size(50, 19);
            labelPlazo.TabIndex = 10;
            labelPlazo.Text = "Plazo:";
            // 
            // textboxNombre
            // 
            this.textboxNombre.AccessibleName = "textboxNombre";
            this.textboxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textboxNombre.Location = new System.Drawing.Point(171, 67);
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(316, 27);
            this.textboxNombre.TabIndex = 2;
            // 
            // boxTipo
            // 
            this.boxTipo.AccessibleName = "boxTipo";
            this.boxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxTipo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Location = new System.Drawing.Point(171, 113);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(316, 27);
            this.boxTipo.TabIndex = 4;
            this.boxTipo.SelectedIndexChanged += new System.EventHandler(this.boxTipo_SelectedIndexChanged);
            // 
            // boxMoneda
            // 
            this.boxMoneda.AccessibleName = "boxMoneda";
            this.boxMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxMoneda.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.boxMoneda.FormattingEnabled = true;
            this.boxMoneda.Location = new System.Drawing.Point(171, 161);
            this.boxMoneda.Name = "boxMoneda";
            this.boxMoneda.Size = new System.Drawing.Size(316, 27);
            this.boxMoneda.TabIndex = 6;
            // 
            // textboxMonto
            // 
            this.textboxMonto.AccessibleName = "textboxMonto";
            this.textboxMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxMonto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textboxMonto.Location = new System.Drawing.Point(171, 211);
            this.textboxMonto.Name = "textboxMonto";
            this.textboxMonto.Size = new System.Drawing.Size(316, 27);
            this.textboxMonto.TabIndex = 8;
            // 
            // textboxPlazo
            // 
            this.textboxPlazo.AccessibleName = "textboxPlazo";
            this.textboxPlazo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxPlazo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPlazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textboxPlazo.Location = new System.Drawing.Point(171, 260);
            this.textboxPlazo.Name = "textboxPlazo";
            this.textboxPlazo.Size = new System.Drawing.Size(316, 27);
            this.textboxPlazo.TabIndex = 9;
            // 
            // botonCalcular
            // 
            this.botonCalcular.AccessibleName = "botonCalcular";
            this.botonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCalcular.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonCalcular.Location = new System.Drawing.Point(171, 307);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(131, 31);
            this.botonCalcular.TabIndex = 11;
            this.botonCalcular.Text = "CALCULAR";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.AccessibleName = "botonGuardar";
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonGuardar.Location = new System.Drawing.Point(356, 307);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(131, 31);
            this.botonGuardar.TabIndex = 12;
            this.botonGuardar.Text = "GUARDAR";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AccessibleName = "ventanaPrincipal";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(labelPlazo);
            this.Controls.Add(this.textboxPlazo);
            this.Controls.Add(this.textboxMonto);
            this.Controls.Add(labelMonto);
            this.Controls.Add(this.boxMoneda);
            this.Controls.Add(labelMoneda);
            this.Controls.Add(this.boxTipo);
            this.Controls.Add(label1);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(labelNombre);
            this.Controls.Add(labelTitulo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculadorDeInversionesGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.ComboBox boxMoneda;
        private System.Windows.Forms.TextBox textboxMonto;
        private System.Windows.Forms.TextBox textboxPlazo;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonGuardar;
    }
}

