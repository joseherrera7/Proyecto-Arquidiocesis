namespace ProyectoArquidiocesis
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupletoriaBautizo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnExpedienteMatrimonial = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSupletoriaConfirmacion = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Formularios";
            // 
            // btnSupletoriaBautizo
            // 
            this.btnSupletoriaBautizo.AutoSize = true;
            this.btnSupletoriaBautizo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupletoriaBautizo.Depth = 0;
            this.btnSupletoriaBautizo.Icon = null;
            this.btnSupletoriaBautizo.Location = new System.Drawing.Point(85, 112);
            this.btnSupletoriaBautizo.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnSupletoriaBautizo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupletoriaBautizo.Name = "btnSupletoriaBautizo";
            this.btnSupletoriaBautizo.Primary = false;
            this.btnSupletoriaBautizo.Size = new System.Drawing.Size(223, 36);
            this.btnSupletoriaBautizo.TabIndex = 3;
            this.btnSupletoriaBautizo.Text = "Supletoria de Bautizo";
            this.btnSupletoriaBautizo.UseVisualStyleBackColor = true;
            this.btnSupletoriaBautizo.Click += new System.EventHandler(this.BtnSupletoriaBautizo_Click);
            // 
            // btnExpedienteMatrimonial
            // 
            this.btnExpedienteMatrimonial.AutoSize = true;
            this.btnExpedienteMatrimonial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExpedienteMatrimonial.Depth = 0;
            this.btnExpedienteMatrimonial.Icon = null;
            this.btnExpedienteMatrimonial.Location = new System.Drawing.Point(85, 52);
            this.btnExpedienteMatrimonial.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnExpedienteMatrimonial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExpedienteMatrimonial.Name = "btnExpedienteMatrimonial";
            this.btnExpedienteMatrimonial.Primary = false;
            this.btnExpedienteMatrimonial.Size = new System.Drawing.Size(243, 36);
            this.btnExpedienteMatrimonial.TabIndex = 4;
            this.btnExpedienteMatrimonial.Text = "Expediente matrimonial";
            this.btnExpedienteMatrimonial.UseVisualStyleBackColor = true;
            this.btnExpedienteMatrimonial.Click += new System.EventHandler(this.BtnExpedienteMatrimonial_Click);
            // 
            // btnSupletoriaConfirmacion
            // 
            this.btnSupletoriaConfirmacion.AutoSize = true;
            this.btnSupletoriaConfirmacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupletoriaConfirmacion.Depth = 0;
            this.btnSupletoriaConfirmacion.Icon = null;
            this.btnSupletoriaConfirmacion.Location = new System.Drawing.Point(65, 172);
            this.btnSupletoriaConfirmacion.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnSupletoriaConfirmacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupletoriaConfirmacion.Name = "btnSupletoriaConfirmacion";
            this.btnSupletoriaConfirmacion.Primary = false;
            this.btnSupletoriaConfirmacion.Size = new System.Drawing.Size(279, 36);
            this.btnSupletoriaConfirmacion.TabIndex = 5;
            this.btnSupletoriaConfirmacion.Text = "Supletoria de Confirmación";
            this.btnSupletoriaConfirmacion.UseVisualStyleBackColor = true;
            this.btnSupletoriaConfirmacion.Click += new System.EventHandler(this.BtnSupletoriaConfirmacion_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnExpedienteMatrimonial);
            this.groupBox1.Controls.Add(this.btnSupletoriaConfirmacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSupletoriaBautizo);
            this.groupBox1.Location = new System.Drawing.Point(154, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(406, 250);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formularios";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.White;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(501, 394);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(211, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Archivos Guardados";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoArquidiocesis.Properties.Resources.background_3246124_1920;
            this.ClientSize = new System.Drawing.Size(750, 458);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Index";
            this.Text = "Arquidiócesis de Guatemala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton btnSupletoriaBautizo;
        private MaterialSkin.Controls.MaterialFlatButton btnExpedienteMatrimonial;
        private MaterialSkin.Controls.MaterialFlatButton btnSupletoriaConfirmacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

