
namespace SysMediPlus.InsideForms.Doctores
{
    partial class FrmCrearDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearDoctores));
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbEspecialidade = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaskCelular = new System.Windows.Forms.MaskedTextBox();
            this.MaskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.BtnAgregarD = new System.Windows.Forms.Button();
            this.CbTipoUsuario = new System.Windows.Forms.ComboBox();
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(149, 44);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(270, 27);
            this.TxtNombres.TabIndex = 0;
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
            // CbEspecialidade
            // 
            this.CbEspecialidade.FormattingEnabled = true;
            this.CbEspecialidade.Location = new System.Drawing.Point(732, 40);
            this.CbEspecialidade.Name = "CbEspecialidade";
            this.CbEspecialidade.Size = new System.Drawing.Size(236, 28);
            this.CbEspecialidade.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sofia Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(858, 41);
            this.label4.TabIndex = 28;
            this.label4.Text = "Formulario para agregar nuevos doctores en el sistema";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.MaskCelular);
            this.panel1.Controls.Add(this.MaskTelefono);
            this.panel1.Controls.Add(this.BtnAgregarD);
            this.panel1.Controls.Add(this.CbTipoUsuario);
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
            this.panel1.Location = new System.Drawing.Point(12, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 436);
            this.panel1.TabIndex = 29;
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
            this.BtnAgregarD.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAgregarD.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregarD.Location = new System.Drawing.Point(651, 318);
            this.BtnAgregarD.Name = "BtnAgregarD";
            this.BtnAgregarD.Size = new System.Drawing.Size(236, 63);
            this.BtnAgregarD.TabIndex = 19;
            this.BtnAgregarD.Text = "CREAR";
            this.BtnAgregarD.UseVisualStyleBackColor = false;
            this.BtnAgregarD.Click += new System.EventHandler(this.BtnCrearD_Click);
            // 
            // CbTipoUsuario
            // 
            this.CbTipoUsuario.FormattingEnabled = true;
            this.CbTipoUsuario.Location = new System.Drawing.Point(732, 210);
            this.CbTipoUsuario.Name = "CbTipoUsuario";
            this.CbTipoUsuario.Size = new System.Drawing.Size(236, 28);
            this.CbTipoUsuario.TabIndex = 17;
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
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLimpiar.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Location = new System.Drawing.Point(12, 185);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(236, 43);
            this.BtnLimpiar.TabIndex = 20;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(907, 676);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 43);
            this.button4.TabIndex = 30;
            this.button4.Text = "ATRAS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FrmCrearDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1101, 727);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1119, 774);
            this.MinimumSize = new System.Drawing.Size(1119, 774);
            this.Name = "FrmCrearDoctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVOS DOCTORES";
            this.Load += new System.EventHandler(this.FrmCrearDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbEspecialidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidosD;
        private System.Windows.Forms.ComboBox CbTipoUsuario;
        private System.Windows.Forms.ComboBox CBDiasLabor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RbFemenino;
        private System.Windows.Forms.RadioButton RbMasculino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregarD;
        private System.Windows.Forms.MaskedTextBox MaskCelular;
        private System.Windows.Forms.MaskedTextBox MaskTelefono;
        private System.Windows.Forms.Button button4;
    }
}