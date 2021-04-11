
namespace SysMediPlus.InsideForms.Pacientes
{
    partial class FrmUpdatePacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdatePacientes));
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MaskCedula = new System.Windows.Forms.MaskedTextBox();
            this.BtnAgregarD = new System.Windows.Forms.Button();
            this.MaskCelular = new System.Windows.Forms.MaskedTextBox();
            this.MaskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.TxtSector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.CbtipodeUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RbFemenino = new System.Windows.Forms.RadioButton();
            this.RbMasculino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidosP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtNombresP = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.dataGridActuali = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActuali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1005, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "BUSCAR:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscar.Location = new System.Drawing.Point(1103, 198);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(255, 31);
            this.TxtBuscar.TabIndex = 45;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(1371, 677);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 43);
            this.button4.TabIndex = 44;
            this.button4.Text = "ATRAS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLimpiar.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Location = new System.Drawing.Point(12, 182);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(236, 43);
            this.BtnLimpiar.TabIndex = 41;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.MaskCedula);
            this.panel1.Controls.Add(this.BtnAgregarD);
            this.panel1.Controls.Add(this.MaskCelular);
            this.panel1.Controls.Add(this.MaskTelefono);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TxtCalle);
            this.panel1.Controls.Add(this.TxtSector);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProvincia);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TxtCiudad);
            this.panel1.Controls.Add(this.CbtipodeUsuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RbFemenino);
            this.panel1.Controls.Add(this.RbMasculino);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtCorreo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtApellidosP);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtNombresP);
            this.panel1.Controls.Add(this.lblRegistros);
            this.panel1.Controls.Add(this.dataGridActuali);
            this.panel1.Location = new System.Drawing.Point(12, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 436);
            this.panel1.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(788, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 63);
            this.button1.TabIndex = 48;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MaskCedula
            // 
            this.MaskCedula.Location = new System.Drawing.Point(119, 264);
            this.MaskCedula.Mask = "000-0000000-0";
            this.MaskCedula.Name = "MaskCedula";
            this.MaskCedula.Size = new System.Drawing.Size(275, 27);
            this.MaskCedula.TabIndex = 64;
            // 
            // BtnAgregarD
            // 
            this.BtnAgregarD.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAgregarD.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregarD.Location = new System.Drawing.Point(513, 330);
            this.BtnAgregarD.Name = "BtnAgregarD";
            this.BtnAgregarD.Size = new System.Drawing.Size(189, 63);
            this.BtnAgregarD.TabIndex = 47;
            this.BtnAgregarD.Text = "ACTUALIZAR";
            this.BtnAgregarD.UseVisualStyleBackColor = false;
            this.BtnAgregarD.Click += new System.EventHandler(this.BtnAgregarD_Click);
            // 
            // MaskCelular
            // 
            this.MaskCelular.Location = new System.Drawing.Point(707, 144);
            this.MaskCelular.Mask = "000-000-0000";
            this.MaskCelular.Name = "MaskCelular";
            this.MaskCelular.Size = new System.Drawing.Size(270, 27);
            this.MaskCelular.TabIndex = 63;
            // 
            // MaskTelefono
            // 
            this.MaskTelefono.Location = new System.Drawing.Point(707, 203);
            this.MaskTelefono.Mask = "000-000-0000";
            this.MaskTelefono.Name = "MaskTelefono";
            this.MaskTelefono.Size = new System.Drawing.Size(270, 27);
            this.MaskTelefono.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(515, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 24);
            this.label13.TabIndex = 61;
            this.label13.Text = "Tipo de Usuario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(515, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 60;
            this.label12.Text = "Telefono:";
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(707, 89);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(270, 27);
            this.TxtCalle.TabIndex = 59;
            // 
            // TxtSector
            // 
            this.TxtSector.Location = new System.Drawing.Point(707, 37);
            this.TxtSector.Name = "TxtSector";
            this.TxtSector.Size = new System.Drawing.Size(270, 27);
            this.TxtSector.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Provincia:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(119, 330);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(275, 27);
            this.txtProvincia.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(14, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 54;
            this.label11.Text = "Ciudad:";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(119, 391);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(275, 27);
            this.TxtCiudad.TabIndex = 53;
            // 
            // CbtipodeUsuario
            // 
            this.CbtipodeUsuario.FormattingEnabled = true;
            this.CbtipodeUsuario.Location = new System.Drawing.Point(707, 264);
            this.CbtipodeUsuario.Name = "CbtipodeUsuario";
            this.CbtipodeUsuario.Size = new System.Drawing.Size(270, 28);
            this.CbtipodeUsuario.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(515, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(515, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Calle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(513, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Sector:";
            // 
            // RbFemenino
            // 
            this.RbFemenino.AutoSize = true;
            this.RbFemenino.Location = new System.Drawing.Point(299, 145);
            this.RbFemenino.Name = "RbFemenino";
            this.RbFemenino.Size = new System.Drawing.Size(95, 24);
            this.RbFemenino.TabIndex = 48;
            this.RbFemenino.TabStop = true;
            this.RbFemenino.Text = "Femenino";
            this.RbFemenino.UseVisualStyleBackColor = true;
            // 
            // RbMasculino
            // 
            this.RbMasculino.AutoSize = true;
            this.RbMasculino.Location = new System.Drawing.Point(124, 144);
            this.RbMasculino.Name = "RbMasculino";
            this.RbMasculino.Size = new System.Drawing.Size(97, 24);
            this.RbMasculino.TabIndex = 47;
            this.RbMasculino.TabStop = true;
            this.RbMasculino.Text = "Masculino";
            this.RbMasculino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Correo:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(119, 203);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(275, 27);
            this.TxtCorreo.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Apellidos:";
            // 
            // TxtApellidosP
            // 
            this.TxtApellidosP.Location = new System.Drawing.Point(124, 92);
            this.TxtApellidosP.Name = "TxtApellidosP";
            this.TxtApellidosP.Size = new System.Drawing.Size(270, 27);
            this.TxtApellidosP.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(19, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 24);
            this.label14.TabIndex = 40;
            this.label14.Text = "Nombres:";
            // 
            // TxtNombresP
            // 
            this.TxtNombresP.Location = new System.Drawing.Point(124, 40);
            this.TxtNombresP.Name = "TxtNombresP";
            this.TxtNombresP.Size = new System.Drawing.Size(270, 27);
            this.TxtNombresP.TabIndex = 39;
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
            // dataGridActuali
            // 
            this.dataGridActuali.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridActuali.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridActuali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActuali.GridColor = System.Drawing.Color.LightSlateGray;
            this.dataGridActuali.Location = new System.Drawing.Point(993, 40);
            this.dataGridActuali.Name = "dataGridActuali";
            this.dataGridActuali.ReadOnly = true;
            this.dataGridActuali.RowHeadersWidth = 51;
            this.dataGridActuali.RowTemplate.Height = 29;
            this.dataGridActuali.Size = new System.Drawing.Size(530, 366);
            this.dataGridActuali.TabIndex = 22;
            this.dataGridActuali.DataSourceChanged += new System.EventHandler(this.dataGridActuali_DataSourceChanged);
            this.dataGridActuali.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridActuali_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sofia Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(532, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 41);
            this.label4.TabIndex = 42;
            this.label4.Text = "Formulario para actualizar Pacientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUpdatePacientes
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
            this.MaximumSize = new System.Drawing.Size(1583, 783);
            this.MinimumSize = new System.Drawing.Size(1583, 783);
            this.Name = "FrmUpdatePacientes";
            this.Text = "ACTUALIZAR DOCTORES";
            this.Load += new System.EventHandler(this.FrmUpdatePacientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActuali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.DataGridView dataGridActuali;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox MaskCedula;
        private System.Windows.Forms.MaskedTextBox MaskCelular;
        private System.Windows.Forms.MaskedTextBox MaskTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.TextBox TxtSector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.ComboBox CbtipodeUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RbFemenino;
        private System.Windows.Forms.RadioButton RbMasculino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidosP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtNombresP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAgregarD;
    }
}