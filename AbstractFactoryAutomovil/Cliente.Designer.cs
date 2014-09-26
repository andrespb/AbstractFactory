namespace AbstractFactoryAutomovil
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lstPartes = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radChevrolet = new System.Windows.Forms.RadioButton();
            this.radRenault = new System.Windows.Forms.RadioButton();
            this.radMazda = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.lstPartes);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 237);
            this.panel1.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(95, 162);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lstPartes
            // 
            this.lstPartes.FormattingEnabled = true;
            this.lstPartes.Items.AddRange(new object[] {
            "Auto",
            "Motor",
            "Carroceria"});
            this.lstPartes.Location = new System.Drawing.Point(95, 98);
            this.lstPartes.Name = "lstPartes";
            this.lstPartes.Size = new System.Drawing.Size(121, 21);
            this.lstPartes.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(45, 101);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radChevrolet);
            this.groupBox1.Controls.Add(this.radRenault);
            this.groupBox1.Controls.Add(this.radMazda);
            this.groupBox1.Location = new System.Drawing.Point(32, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // radChevrolet
            // 
            this.radChevrolet.AutoSize = true;
            this.radChevrolet.Location = new System.Drawing.Point(11, 58);
            this.radChevrolet.Name = "radChevrolet";
            this.radChevrolet.Size = new System.Drawing.Size(70, 17);
            this.radChevrolet.TabIndex = 2;
            this.radChevrolet.TabStop = true;
            this.radChevrolet.Text = "Chevrolet";
            this.radChevrolet.UseVisualStyleBackColor = true;
            
            // 
            // radRenault
            // 
            this.radRenault.AutoSize = true;
            this.radRenault.Checked = true;
            this.radRenault.Location = new System.Drawing.Point(78, 27);
            this.radRenault.Name = "radRenault";
            this.radRenault.Size = new System.Drawing.Size(62, 17);
            this.radRenault.TabIndex = 1;
            this.radRenault.TabStop = true;
            this.radRenault.Text = "Renault";
            this.radRenault.UseVisualStyleBackColor = true;
            // 
            // radMazda
            // 
            this.radMazda.AutoSize = true;
            this.radMazda.Location = new System.Drawing.Point(11, 27);
            this.radMazda.Name = "radMazda";
            this.radMazda.Size = new System.Drawing.Size(57, 17);
            this.radMazda.TabIndex = 0;
            this.radMazda.TabStop = true;
            this.radMazda.Text = "Mazda";
            this.radMazda.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox lstPartes;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRenault;
        private System.Windows.Forms.RadioButton radMazda;
        private System.Windows.Forms.RadioButton radChevrolet;
    }
}

