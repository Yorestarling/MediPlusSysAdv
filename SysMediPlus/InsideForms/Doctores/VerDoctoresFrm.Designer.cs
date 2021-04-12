
namespace SysMediPlus.InsideForms.Doctores
{
    partial class VerDoctoresFrm
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
            this.lblRegistros = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistros.Location = new System.Drawing.Point(832, 121);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(137, 24);
            this.lblRegistros.TabIndex = 26;
            this.lblRegistros.Text = "REGISTROS: 0";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBuscar.Location = new System.Drawing.Point(21, 99);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(255, 31);
            this.TxtBuscar.TabIndex = 25;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(857, 523);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 43);
            this.button4.TabIndex = 23;
            this.button4.Text = "ATRAS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPacientes.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.RowHeadersWidth = 51;
            this.dataGridViewPacientes.RowTemplate.Height = 29;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(1027, 369);
            this.dataGridViewPacientes.TabIndex = 22;
            this.dataGridViewPacientes.DataSourceChanged += new System.EventHandler(this.dataGridViewPacientes_DataSourceChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sofia Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "LISTA DE DOCTORES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(282, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // VerDoctoresFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1051, 578);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1069, 625);
            this.MinimumSize = new System.Drawing.Size(1069, 625);
            this.Name = "VerDoctoresFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO DE DOCTORES";
            this.Load += new System.EventHandler(this.VerDoctoresFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}