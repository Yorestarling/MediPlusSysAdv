
namespace SysMediPlus.InsideForms.Doctores
{
    partial class FrmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdate));
            this.button4 = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridActuali = new System.Windows.Forms.DataGridView();
            this.MaskCelular = new System.Windows.Forms.MaskedTextBox();
            this.MaskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.BtnAgregarD = new System.Windows.Forms.Button();
            this.CbCargo = new System.Windows.Forms.ComboBox();
            this.CBDiasLabor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RbFemenino = new System.Windows.Forms.RadioButton();
            this.RbMasculino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidosD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.CbEspecialidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActuali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(1371, 685);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 43);
            this.button4.TabIndex = 35;
            this.button4.Text = "ATRAS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLimpiar.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Location = new System.Drawing.Point(12, 190);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(236, 43);
            this.BtnLimpiar.TabIndex = 32;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblRegistros);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridActuali);
            this.panel1.Controls.Add(this.MaskCelular);
            this.panel1.Controls.Add(this.MaskTelefono);
            this.panel1.Controls.Add(this.BtnAgregarD);
            this.panel1.Controls.Add(this.CbCargo);
            this.panel1.Controls.Add(this.CBDiasLabor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RbFemenino);
            this.panel1.Controls.Add(this.RbMasculino);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtApellidosD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNombres);
            this.panel1.Controls.Add(this.CbEspecialidade);
            this.panel1.Location = new System.Drawing.Point(12, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 436);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistros.Location = new System.Drawing.Point(1386, 13);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(137, 24);
            this.lblRegistros.TabIndex = 38;
            this.lblRegistros.Text = "REGISTROS: 0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(779, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 63);
            this.button1.TabIndex = 23;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridActuali
            // 
            this.dataGridActuali.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridActuali.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridActuali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActuali.Location = new System.Drawing.Point(993, 40);
            this.dataGridActuali.Name = "dataGridActuali";
            this.dataGridActuali.ReadOnly = true;
            this.dataGridActuali.RowHeadersWidth = 51;
            this.dataGridActuali.RowTemplate.Height = 29;
            this.dataGridActuali.Size = new System.Drawing.Size(526, 366);
            this.dataGridActuali.TabIndex = 22;
            this.dataGridActuali.DataSourceChanged += new System.EventHandler(this.dataGridActuali_DataSourceChanged);
            this.dataGridActuali.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridActuali_CellDoubleClick);
            // 
            // MaskCelular
            // 
            this.MaskCelular.Location = new System.Drawing.Point(149, 382);
            this.MaskCelular.Mask = "000-000-0000";
            this.MaskCelular.Name = "MaskCelular";
            this.MaskCelular.Size = new System.Drawing.Size(270, 27);
            this.MaskCelular.TabIndex = 21;
            // 
            // MaskTelefono
            // 
            this.MaskTelefono.Location = new System.Drawing.Point(149, 291);
            this.MaskTelefono.Mask = "000-000-0000";
            this.MaskTelefono.Name = "MaskTelefono";
            this.MaskTelefono.Size = new System.Drawing.Size(270, 27);
            this.MaskTelefono.TabIndex = 20;
            // 
            // BtnAgregarD
            // 
            this.BtnAgregarD.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAgregarD.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregarD.Location = new System.Drawing.Point(538, 307);
            this.BtnAgregarD.Name = "BtnAgregarD";
            this.BtnAgregarD.Size = new System.Drawing.Size(189, 63);
            this.BtnAgregarD.TabIndex = 19;
            this.BtnAgregarD.Text = "ACTUALIZAR";
            this.BtnAgregarD.UseVisualStyleBackColor = false;
            this.BtnAgregarD.Click += new System.EventHandler(this.BtnAgregarD_Click);
            // 
            // CbCargo
            // 
            this.CbCargo.FormattingEnabled = true;
            this.CbCargo.Location = new System.Drawing.Point(732, 210);
            this.CbCargo.Name = "CbCargo";
            this.CbCargo.Size = new System.Drawing.Size(236, 28);
            this.CbCargo.TabIndex = 17;
            // 
            // CBDiasLabor
            // 
            this.CBDiasLabor.FormattingEnabled = true;
            this.CBDiasLabor.Location = new System.Drawing.Point(732, 131);
            this.CBDiasLabor.Name = "CBDiasLabor";
            this.CBDiasLabor.Size = new System.Drawing.Size(236, 28);
            this.CBDiasLabor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(538, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo de Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(538, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dia de Labor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(538, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Especialidades:";
            // 
            // RbFemenino
            // 
            this.RbFemenino.AutoSize = true;
            this.RbFemenino.Location = new System.Drawing.Point(324, 211);
            this.RbFemenino.Name = "RbFemenino";
            this.RbFemenino.Size = new System.Drawing.Size(95, 24);
            this.RbFemenino.TabIndex = 12;
            this.RbFemenino.TabStop = true;
            this.RbFemenino.Text = "Femenino";
            this.RbFemenino.UseVisualStyleBackColor = true;
            // 
            // RbMasculino
            // 
            this.RbMasculino.AutoSize = true;
            this.RbMasculino.Location = new System.Drawing.Point(149, 210);
            this.RbMasculino.Name = "RbMasculino";
            this.RbMasculino.Size = new System.Drawing.Size(97, 24);
            this.RbMasculino.TabIndex = 11;
            this.RbMasculino.TabStop = true;
            this.RbMasculino.Text = "Masculino";
            this.RbMasculino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos:";
            // 
            // TxtApellidosD
            // 
            this.TxtApellidosD.Location = new System.Drawing.Point(149, 128);
            this.TxtApellidosD.Name = "TxtApellidosD";
            this.TxtApellidosD.Size = new System.Drawing.Size(270, 27);
            this.TxtApellidosD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(149, 44);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(270, 27);
            this.TxtNombres.TabIndex = 0;
            // 
            // CbEspecialidade
            // 
            this.CbEspecialidade.FormattingEnabled = true;
            this.CbEspecialidade.Location = new System.Drawing.Point(732, 40);
            this.CbEspecialidade.Name = "CbEspecialidade";
            this.CbEspecialidade.Size = new System.Drawing.Size(236, 28);
            this.CbEspecialidade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sofia Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(532, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 41);
            this.label4.TabIndex = 33;
            this.label4.Text = "Formulario para actualizar doctores\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscar.Location = new System.Drawing.Point(1103, 206);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(255, 31);
            this.TxtBuscar.TabIndex = 36;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1005, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "BUSCAR:";
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1565, 736);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1583, 783);
            this.MinimumSize = new System.Drawing.Size(1583, 783);
            this.Name = "FrmUpdate";
            this.Text = "ACTUALIZAR DOCTORES";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActuali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridActuali;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox MaskCelular;
        private System.Windows.Forms.MaskedTextBox MaskTelefono;
        private System.Windows.Forms.Button BtnAgregarD;
        private System.Windows.Forms.ComboBox CbCargo;
        private System.Windows.Forms.ComboBox CBDiasLabor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RbFemenino;
        private System.Windows.Forms.RadioButton RbMasculino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidosD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.ComboBox CbEspecialidade;
    }
}