namespace SistemaInversiones
{
    partial class VistaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaGUI));
            this.textoTitulo = new System.Windows.Forms.Label();
            this.textoCliente = new System.Windows.Forms.Label();
            this.entradaCliente = new System.Windows.Forms.TextBox();
            this.textoTipoInversion = new System.Windows.Forms.Label();
            this.entradaTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entradaMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaPlazo = new System.Windows.Forms.TextBox();
            this.textoMoneda = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textoTitulo
            // 
            resources.ApplyResources(this.textoTitulo, "textoTitulo");
            this.textoTitulo.Name = "textoTitulo";
            // 
            // textoCliente
            // 
            resources.ApplyResources(this.textoCliente, "textoCliente");
            this.textoCliente.Name = "textoCliente";
            this.textoCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // entradaCliente
            // 
            this.entradaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.entradaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entradaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.entradaCliente, "entradaCliente");
            this.entradaCliente.Name = "entradaCliente";
            this.entradaCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoTipoInversion
            // 
            resources.ApplyResources(this.textoTipoInversion, "textoTipoInversion");
            this.textoTipoInversion.Name = "textoTipoInversion";
            // 
            // entradaTipo
            // 
            this.entradaTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.entradaTipo, "entradaTipo");
            this.entradaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.entradaTipo.FormattingEnabled = true;
            this.entradaTipo.Name = "entradaTipo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // entradaMonto
            // 
            this.entradaMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.entradaMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entradaMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.entradaMonto, "entradaMonto");
            this.entradaMonto.Name = "entradaMonto";
            this.entradaMonto.TextChanged += new System.EventHandler(this.entradaMonto_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // entradaPlazo
            // 
            this.entradaPlazo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.entradaPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entradaPlazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.entradaPlazo, "entradaPlazo");
            this.entradaPlazo.Name = "entradaPlazo";
            // 
            // textoMoneda
            // 
            resources.ApplyResources(this.textoMoneda, "textoMoneda");
            this.textoMoneda.Name = "textoMoneda";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaInversiones.Properties.Resources.stats_icon;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // VistaGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textoMoneda);
            this.Controls.Add(this.entradaPlazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entradaMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entradaTipo);
            this.Controls.Add(this.textoTipoInversion);
            this.Controls.Add(this.entradaCliente);
            this.Controls.Add(this.textoCliente);
            this.Controls.Add(this.textoTitulo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VistaGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoTitulo;
        private System.Windows.Forms.Label textoCliente;
        private System.Windows.Forms.TextBox entradaCliente;
        private System.Windows.Forms.Label textoTipoInversion;
        private System.Windows.Forms.ComboBox entradaTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entradaMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entradaPlazo;
        private System.Windows.Forms.Label textoMoneda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

