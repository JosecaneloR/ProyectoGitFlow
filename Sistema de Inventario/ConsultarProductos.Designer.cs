namespace Sistema_de_Inventario
{
    partial class ConsultarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.Parametro = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Filtro = new System.Windows.Forms.ComboBox();
            this.TablaProductos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 100);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar Producto";
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.BackColor = System.Drawing.Color.White;
            this.botonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("botonCerrarSesion.Image")));
            this.botonCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonCerrarSesion.Location = new System.Drawing.Point(590, 636);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.botonCerrarSesion.Size = new System.Drawing.Size(192, 85);
            this.botonCerrarSesion.TabIndex = 20;
            this.botonCerrarSesion.Text = "Volver";
            this.botonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCerrarSesion.UseVisualStyleBackColor = false;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("botonBuscar.Image")));
            this.botonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuscar.Location = new System.Drawing.Point(332, 626);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Padding = new System.Windows.Forms.Padding(5);
            this.botonBuscar.Size = new System.Drawing.Size(233, 95);
            this.botonBuscar.TabIndex = 19;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // Parametro
            // 
            this.Parametro.BorderColor = System.Drawing.Color.SeaGreen;
            this.Parametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parametro.Location = new System.Drawing.Point(332, 553);
            this.Parametro.Name = "Parametro";
            this.Parametro.Size = new System.Drawing.Size(233, 35);
            this.Parametro.TabIndex = 18;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(50, 503);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(276, 32);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Buscar producto por:";
            // 
            // Filtro
            // 
            this.Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.FormattingEnabled = true;
            this.Filtro.Items.AddRange(new object[] {
            "Codigo_producto",
            "Descripcion_producto",
            "Cantidad_producto",
            "Precio_unitario"});
            this.Filtro.Location = new System.Drawing.Point(332, 503);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(233, 37);
            this.Filtro.TabIndex = 16;
            // 
            // TablaProductos
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos.DoubleBuffered = true;
            this.TablaProductos.EnableHeadersVisualStyles = false;
            this.TablaProductos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.TablaProductos.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.TablaProductos.Location = new System.Drawing.Point(56, 139);
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaProductos.RowHeadersWidth = 62;
            this.TablaProductos.RowTemplate.Height = 28;
            this.TablaProductos.Size = new System.Drawing.Size(697, 339);
            this.TablaProductos.TabIndex = 15;
            this.TablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProductos_CellContentClick);
            // 
            // ConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonCerrarSesion);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.Parametro);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.TablaProductos);
            this.Name = "ConsultarProductos";
            this.Text = "ConsultarProductos";
            this.Load += new System.EventHandler(this.ConsultarProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botonCerrarSesion;
        private System.Windows.Forms.Button botonBuscar;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Parametro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox Filtro;
        private Bunifu.Framework.UI.BunifuCustomDataGrid TablaProductos;
    }
}