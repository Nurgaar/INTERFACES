
namespace Trival
{
    partial class FrmTrivial
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
            this.LblPais = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPartidaNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuPartidaSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpcionesNombreCapital = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpcionesNombrePaises = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuOpcionesMultiOpc = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpcionesEscribirResp = new System.Windows.Forms.ToolStripMenuItem();
            this.LblCapital = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPais.Location = new System.Drawing.Point(34, 51);
            this.LblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(41, 17);
            this.LblPais.TabIndex = 0;
            this.LblPais.Text = "Pais:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(39, 86);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(355, 40);
            this.txtPregunta.TabIndex = 1;
            this.txtPregunta.Click += new System.EventHandler(this.BtnSiguiente_Click);
            this.txtPregunta.TextChanged += new System.EventHandler(this.txtPregunta_TextChanged);
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta1.Location = new System.Drawing.Point(39, 209);
            this.txtRespuesta1.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(355, 40);
            this.txtRespuesta1.TabIndex = 2;
            this.txtRespuesta1.Click += new System.EventHandler(this.txtRespuesta1_TextClick);
            this.txtRespuesta1.TextChanged += new System.EventHandler(this.txtRespuesta1_TextChanged);
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtRespuesta2.Location = new System.Drawing.Point(39, 257);
            this.txtRespuesta2.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(355, 41);
            this.txtRespuesta2.TabIndex = 3;
            this.txtRespuesta2.Click += new System.EventHandler(this.txtRespuesta1_TextClick);
            this.txtRespuesta2.TextChanged += new System.EventHandler(this.txtRespuesta2_TextChanged);
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtRespuesta3.Location = new System.Drawing.Point(39, 306);
            this.txtRespuesta3.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(355, 41);
            this.txtRespuesta3.TabIndex = 4;
            this.txtRespuesta3.Click += new System.EventHandler(this.txtRespuesta1_TextClick);
            this.txtRespuesta3.TextChanged += new System.EventHandler(this.txtRespuesta3_TextChanged);
            // 
            // txtRespuesta4
            // 
            this.txtRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtRespuesta4.Location = new System.Drawing.Point(39, 355);
            this.txtRespuesta4.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuesta4.Name = "txtRespuesta4";
            this.txtRespuesta4.Size = new System.Drawing.Size(355, 41);
            this.txtRespuesta4.TabIndex = 5;
            this.txtRespuesta4.Click += new System.EventHandler(this.txtRespuesta1_TextClick);
            this.txtRespuesta4.TextChanged += new System.EventHandler(this.txtRespuesta4_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPartida,
            this.MnuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(533, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuPartida
            // 
            this.MnuPartida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPartidaNueva,
            this.toolStripSeparator1,
            this.MnuPartidaSalir});
            this.MnuPartida.Name = "MnuPartida";
            this.MnuPartida.Size = new System.Drawing.Size(56, 19);
            this.MnuPartida.Text = "Partida";
            // 
            // MnuPartidaNueva
            // 
            this.MnuPartidaNueva.Name = "MnuPartidaNueva";
            this.MnuPartidaNueva.Size = new System.Drawing.Size(108, 22);
            this.MnuPartidaNueva.Text = "Nueva";
            this.MnuPartidaNueva.Click += new System.EventHandler(this.MnuPartidaNueva_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // MnuPartidaSalir
            // 
            this.MnuPartidaSalir.Name = "MnuPartidaSalir";
            this.MnuPartidaSalir.Size = new System.Drawing.Size(108, 22);
            this.MnuPartidaSalir.Text = "Salir";
            this.MnuPartidaSalir.Click += new System.EventHandler(this.MnuPartidaSalir_Click);
            // 
            // MnuOpciones
            // 
            this.MnuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOpcionesNombreCapital,
            this.MnuOpcionesNombrePaises,
            this.toolStripSeparator2,
            this.MnuOpcionesMultiOpc,
            this.MnuOpcionesEscribirResp});
            this.MnuOpciones.Name = "MnuOpciones";
            this.MnuOpciones.Size = new System.Drawing.Size(69, 19);
            this.MnuOpciones.Text = "Opciones";
            this.MnuOpciones.Click += new System.EventHandler(this.MnuOpciones_Click);
            // 
            // MnuOpcionesNombreCapital
            // 
            this.MnuOpcionesNombreCapital.Checked = true;
            this.MnuOpcionesNombreCapital.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuOpcionesNombreCapital.Name = "MnuOpcionesNombreCapital";
            this.MnuOpcionesNombreCapital.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesNombreCapital.Text = "Nombre Capital";
            this.MnuOpcionesNombreCapital.Click += new System.EventHandler(this.MnuOpcionesNombreCapital_Click);
            // 
            // MnuOpcionesNombrePaises
            // 
            this.MnuOpcionesNombrePaises.Name = "MnuOpcionesNombrePaises";
            this.MnuOpcionesNombrePaises.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesNombrePaises.Text = "Nombre Países";
            this.MnuOpcionesNombrePaises.Click += new System.EventHandler(this.MnuOpcionesNombrePaises_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuOpcionesMultiOpc
            // 
            this.MnuOpcionesMultiOpc.Checked = true;
            this.MnuOpcionesMultiOpc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuOpcionesMultiOpc.Name = "MnuOpcionesMultiOpc";
            this.MnuOpcionesMultiOpc.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesMultiOpc.Text = "Múltiples opciones";
            // 
            // MnuOpcionesEscribirResp
            // 
            this.MnuOpcionesEscribirResp.Name = "MnuOpcionesEscribirResp";
            this.MnuOpcionesEscribirResp.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesEscribirResp.Text = "Escribir Respuesta";
            // 
            // LblCapital
            // 
            this.LblCapital.AutoSize = true;
            this.LblCapital.Font = new System.Drawing.Font("Lucida Bright", 11.25F);
            this.LblCapital.Location = new System.Drawing.Point(34, 169);
            this.LblCapital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCapital.Name = "LblCapital";
            this.LblCapital.Size = new System.Drawing.Size(63, 17);
            this.LblCapital.TabIndex = 7;
            this.LblCapital.Text = "Capital:";
            this.LblCapital.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.Location = new System.Drawing.Point(62, 475);
            this.BtnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(158, 32);
            this.BtnSiguiente.TabIndex = 8;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(62, 518);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(158, 32);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtPorcentaje.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtPorcentaje.Location = new System.Drawing.Point(323, 500);
            this.TxtPorcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(61, 30);
            this.TxtPorcentaje.TabIndex = 10;
            this.TxtPorcentaje.TextChanged += new System.EventHandler(this.TxtPorcentaje_TextChanged);
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtResultado.ForeColor = System.Drawing.Color.Black;
            this.TxtResultado.Location = new System.Drawing.Point(231, 420);
            this.TxtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(206, 38);
            this.TxtResultado.TabIndex = 11;
            // 
            // FrmTrivial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(533, 583);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.LblCapital);
            this.Controls.Add(this.txtRespuesta4);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTrivial";
            this.Text = "Trivial";
            this.Load += new System.EventHandler(this.FrmTrivial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuPartida;
        private System.Windows.Forms.ToolStripMenuItem MnuPartidaNueva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuPartidaSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesNombreCapital;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesNombrePaises;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesMultiOpc;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesEscribirResp;
        private System.Windows.Forms.Label LblCapital;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.TextBox TxtResultado;
    }
}

