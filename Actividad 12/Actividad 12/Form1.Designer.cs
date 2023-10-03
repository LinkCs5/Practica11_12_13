namespace Actividad_12
{
    partial class forms
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
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMayorVenta = new System.Windows.Forms.TextBox();
            this.textBoxMenorVenta = new System.Windows.Forms.TextBox();
            this.textBoxVentaTotal = new System.Windows.Forms.TextBox();
            this.textBoxVentaPorDia = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVentas
            // 
            this.tablaVentas.BackgroundColor = System.Drawing.Color.LightCoral;
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.tablaVentas.Location = new System.Drawing.Point(30, 12);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.Size = new System.Drawing.Size(747, 359);
            this.tablaVentas.TabIndex = 0;
            this.tablaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aleatorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMayorVenta
            // 
            this.textBoxMayorVenta.Location = new System.Drawing.Point(217, 461);
            this.textBoxMayorVenta.Multiline = true;
            this.textBoxMayorVenta.Name = "textBoxMayorVenta";
            this.textBoxMayorVenta.Size = new System.Drawing.Size(173, 20);
            this.textBoxMayorVenta.TabIndex = 3;
            // 
            // textBoxMenorVenta
            // 
            this.textBoxMenorVenta.Location = new System.Drawing.Point(30, 461);
            this.textBoxMenorVenta.Multiline = true;
            this.textBoxMenorVenta.Name = "textBoxMenorVenta";
            this.textBoxMenorVenta.Size = new System.Drawing.Size(168, 20);
            this.textBoxMenorVenta.TabIndex = 4;
            // 
            // textBoxVentaTotal
            // 
            this.textBoxVentaTotal.Location = new System.Drawing.Point(406, 461);
            this.textBoxVentaTotal.Multiline = true;
            this.textBoxVentaTotal.Name = "textBoxVentaTotal";
            this.textBoxVentaTotal.Size = new System.Drawing.Size(171, 20);
            this.textBoxVentaTotal.TabIndex = 5;
            // 
            // textBoxVentaPorDia
            // 
            this.textBoxVentaPorDia.Location = new System.Drawing.Point(583, 397);
            this.textBoxVentaPorDia.Multiline = true;
            this.textBoxVentaPorDia.Name = "textBoxVentaPorDia";
            this.textBoxVentaPorDia.Size = new System.Drawing.Size(194, 133);
            this.textBoxVentaPorDia.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            // 
            // forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(823, 561);
            this.Controls.Add(this.textBoxVentaPorDia);
            this.Controls.Add(this.textBoxVentaTotal);
            this.Controls.Add(this.textBoxMenorVenta);
            this.Controls.Add(this.textBoxMayorVenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablaVentas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "forms";
            this.Text = "Actividad 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxMayorVenta;
        private System.Windows.Forms.TextBox textBoxMenorVenta;
        private System.Windows.Forms.TextBox textBoxVentaTotal;
        private System.Windows.Forms.TextBox textBoxVentaPorDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

