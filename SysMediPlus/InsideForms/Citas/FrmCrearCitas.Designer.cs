
namespace SysMediPlus.InsideForms.Citas
{
    partial class FrmCrearCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearCitas));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbBoxInicio = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DateFechaCita = new System.Windows.Forms.DateTimePicker();
            this.TxtMotivo = new System.Windows.Forms.TextBox();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.RbTarde = new System.Windows.Forms.RadioButton();
            this.RbManana = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.CbDoctor = new System.Windows.Forms.ComboBox();
            this.CbPaciente = new System.Windows.Forms.ComboBox();
            this.BtnAgregarD = new System.Windows.Forms.Button();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lbboxFin = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLimpiar.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpiar.Location = new System.Drawing.Point(12, 173);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(236, 43);
            this.BtnLimpiar.TabIndex = 0;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lbboxFin);
            this.panel1.Controls.Add(this.LbBoxInicio);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.DateFechaCita);
            this.panel1.Controls.Add(this.TxtMotivo);
            this.panel1.Controls.Add(this.TxtComentario);
            this.panel1.Controls.Add(this.RbTarde);
            this.panel1.Controls.Add(this.RbManana);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CbDoctor);
            this.panel1.Controls.Add(this.CbPaciente);
            this.panel1.Controls.Add(this.BtnAgregarD);
            this.panel1.Controls.Add(this.CBEstado);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 438);
            this.panel1.TabIndex = 32;
            // 
            // LbBoxInicio
            // 
            this.LbBoxInicio.FormattingEnabled = true;
            this.LbBoxInicio.ItemHeight = 20;
            this.LbBoxInicio.Items.AddRange(new object[] {
            "Seleccione la hora de inicio",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "14:00",
            "15:00",
            "16:00"});
            this.LbBoxInicio.Location = new System.Drawing.Point(209, 272);
            this.LbBoxInicio.Name = "LbBoxInicio";
            this.LbBoxInicio.Size = new System.Drawing.Size(270, 24);
            this.LbBoxInicio.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(44, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Hora de Fin:";
            // 
            // DateFechaCita
            // 
            this.DateFechaCita.CustomFormat = "";
            this.DateFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaCita.Location = new System.Drawing.Point(209, 192);
            this.DateFechaCita.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DateFechaCita.MinDate = new System.DateTime(1930, 12, 31, 0, 0, 0, 0);
            this.DateFechaCita.Name = "DateFechaCita";
            this.DateFechaCita.Size = new System.Drawing.Size(270, 27);
            this.DateFechaCita.TabIndex = 3;
            this.DateFechaCita.Value = new System.DateTime(2021, 4, 12, 0, 0, 0, 0);
            // 
            // TxtMotivo
            // 
            this.TxtMotivo.Location = new System.Drawing.Point(732, 171);
            this.TxtMotivo.Multiline = true;
            this.TxtMotivo.Name = "TxtMotivo";
            this.TxtMotivo.Size = new System.Drawing.Size(270, 97);
            this.TxtMotivo.TabIndex = 9;
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(732, 41);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(270, 98);
            this.TxtComentario.TabIndex = 8;
            // 
            // RbTarde
            // 
            this.RbTarde.AutoSize = true;
            this.RbTarde.Location = new System.Drawing.Point(378, 388);
            this.RbTarde.Name = "RbTarde";
            this.RbTarde.Size = new System.Drawing.Size(66, 24);
            this.RbTarde.TabIndex = 7;
            this.RbTarde.TabStop = true;
            this.RbTarde.Text = "Tarde";
            this.RbTarde.UseVisualStyleBackColor = true;
            // 
            // RbManana
            // 
            this.RbManana.AutoSize = true;
            this.RbManana.Location = new System.Drawing.Point(209, 387);
            this.RbManana.Name = "RbManana";
            this.RbManana.Size = new System.Drawing.Size(83, 24);
            this.RbManana.TabIndex = 6;
            this.RbManana.TabStop = true;
            this.RbManana.Text = "Mañana";
            this.RbManana.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tanda:";
            // 
            // CbDoctor
            // 
            this.CbDoctor.FormattingEnabled = true;
            this.CbDoctor.Location = new System.Drawing.Point(209, 127);
            this.CbDoctor.Name = "CbDoctor";
            this.CbDoctor.Size = new System.Drawing.Size(270, 28);
            this.CbDoctor.TabIndex = 2;
            // 
            // CbPaciente
            // 
            this.CbPaciente.FormattingEnabled = true;
            this.CbPaciente.Location = new System.Drawing.Point(209, 44);
            this.CbPaciente.Name = "CbPaciente";
            this.CbPaciente.Size = new System.Drawing.Size(270, 28);
            this.CbPaciente.TabIndex = 1;
            // 
            // BtnAgregarD
            // 
            this.BtnAgregarD.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAgregarD.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregarD.Location = new System.Drawing.Point(751, 368);
            this.BtnAgregarD.Name = "BtnAgregarD";
            this.BtnAgregarD.Size = new System.Drawing.Size(236, 63);
            this.BtnAgregarD.TabIndex = 10;
            this.BtnAgregarD.Text = "CREAR";
            this.BtnAgregarD.UseVisualStyleBackColor = false;
            this.BtnAgregarD.Click += new System.EventHandler(this.BtnAgregarD_Click);
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(732, 296);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(270, 28);
            this.CBEstado.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(538, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(538, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Motivo de la cita:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(538, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comentario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de la cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctor/a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sofia Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(801, 41);
            this.label4.TabIndex = 33;
            this.label4.Text = "Formulario para agregar nuevas citas en el sistema";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(832, 672);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 43);
            this.button4.TabIndex = 34;
            this.button4.Text = "ATRAS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbboxFin
            // 
            this.lbboxFin.FormattingEnabled = true;
            this.lbboxFin.ItemHeight = 20;
            this.lbboxFin.Items.AddRange(new object[] {
            "Seleccione la hora de fin",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "15:00",
            "16:00",
            "17:00"});
            this.lbboxFin.Location = new System.Drawing.Point(209, 335);
            this.lbboxFin.Name = "lbboxFin";
            this.lbboxFin.Size = new System.Drawing.Size(270, 24);
            this.lbboxFin.TabIndex = 26;
            // 
            // FrmCrearCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1101, 727);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1119, 774);
            this.MinimumSize = new System.Drawing.Size(1119, 774);
            this.Name = "FrmCrearCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR NUEVAS CITAS";
            this.Load += new System.EventHandler(this.FrmCrearCitas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregarD;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbDoctor;
        private System.Windows.Forms.ComboBox CbPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMotivo;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.RadioButton RbTarde;
        private System.Windows.Forms.RadioButton RbManana;
        private System.Windows.Forms.DateTimePicker DateFechaCita;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox LbBoxInicio;
        private System.Windows.Forms.ListBox lbboxFin;
    }
}