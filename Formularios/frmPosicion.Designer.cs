namespace PARCIALDOS
{
    partial class frmPosicion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtNombrePosicion = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnDeleteLinea = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiarGrilla = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Posicion";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(144, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = " Nombre de la Posicion";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(448, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = " Departamento";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(8, 104);
            this.txtPosicion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(95, 20);
            this.txtPosicion.TabIndex = 3;
            this.txtPosicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosicion_KeyDown);
            this.txtPosicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosicion_KeyPress);
            this.txtPosicion.Leave += new System.EventHandler(this.txtPosicion_Leave);
            // 
            // txtNombrePosicion
            // 
            this.txtNombrePosicion.Location = new System.Drawing.Point(144, 104);
            this.txtNombrePosicion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePosicion.Name = "txtNombrePosicion";
            this.txtNombrePosicion.Size = new System.Drawing.Size(300, 20);
            this.txtNombrePosicion.TabIndex = 4;
            this.txtNombrePosicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePosicion_KeyPress);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(448, 104);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(64, 20);
            this.txtDepartamento.TabIndex = 5;
            this.txtDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepartamento_KeyDown);
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamento_KeyPress);
            this.txtDepartamento.Leave += new System.EventHandler(this.txtDepartamento_Leave);
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(104, 103);
            this.btnPosicion.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(37, 22);
            this.btnPosicion.TabIndex = 6;
            this.btnPosicion.Text = "...";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Location = new System.Drawing.Point(512, 103);
            this.btnDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(37, 22);
            this.btnDepartamento.TabIndex = 7;
            this.btnDepartamento.Text = "...";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(623, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = " Maestro de Posicion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(627, 7);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 44);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartamento.Location = new System.Drawing.Point(552, 104);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(160, 20);
            this.lblDepartamento.TabIndex = 13;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(8, 128);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(704, 344);
            this.dgv.TabIndex = 14;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(7, 480);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(120, 44);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar Linea";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnDeleteLinea
            // 
            this.btnDeleteLinea.Location = new System.Drawing.Point(248, 480);
            this.btnDeleteLinea.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLinea.Name = "btnDeleteLinea";
            this.btnDeleteLinea.Size = new System.Drawing.Size(120, 44);
            this.btnDeleteLinea.TabIndex = 16;
            this.btnDeleteLinea.Text = "Borrar Linea";
            this.btnDeleteLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteLinea.UseVisualStyleBackColor = true;
            this.btnDeleteLinea.Click += new System.EventHandler(this.btnDeleteLinea_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(128, 480);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 44);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar Linea";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(368, 480);
            this.btnLimpiarGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(120, 44);
            this.btnLimpiarGrilla.TabIndex = 18;
            this.btnLimpiarGrilla.Text = "Limpiar Grilla";
            this.btnLimpiarGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarGrilla.UseVisualStyleBackColor = true;
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(544, 480);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(168, 44);
            this.btnExportar.TabIndex = 19;
            this.btnExportar.Text = "Exportar la Data a Texto";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 546);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnLimpiarGrilla);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeleteLinea);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtNombrePosicion);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPosicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro de Posicion";
            this.Load += new System.EventHandler(this.frmPosicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtNombrePosicion;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnDeleteLinea;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpiarGrilla;
        private System.Windows.Forms.Button btnExportar;
    }
}