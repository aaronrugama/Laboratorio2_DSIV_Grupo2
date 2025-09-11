namespace Laboratorio2_DSV_Grupo2
{
    partial class Fmr3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmr3));
            this.lblGeneral = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lstAccidentes = new System.Windows.Forms.ListBox();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.pbppicture = new System.Windows.Forms.PictureBox();
            this.pnlpanel = new System.Windows.Forms.Panel();
            this.txtGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbppicture)).BeginInit();
            this.pnlpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.BackColor = System.Drawing.Color.GhostWhite;
            this.lblGeneral.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(190, 32);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(459, 34);
            this.lblGeneral.TabIndex = 0;
            this.lblGeneral.Text = "Tránsito de la ciudad de Panamá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(12, 127);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(495, 25);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Ingrese Género (1=Mujer, 2=Hombre, 0=Estadísticas):";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(12, 178);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(128, 25);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Ingrese Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(172, 178);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(102, 34);
            this.txtEdad.TabIndex = 5;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(326, 229);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(143, 39);
            this.btnEjecutar.TabIndex = 6;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lstAccidentes
            // 
            this.lstAccidentes.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccidentes.FormattingEnabled = true;
            this.lstAccidentes.ItemHeight = 18;
            this.lstAccidentes.Location = new System.Drawing.Point(44, 306);
            this.lstAccidentes.Name = "lstAccidentes";
            this.lstAccidentes.Size = new System.Drawing.Size(230, 112);
            this.lstAccidentes.TabIndex = 7;
            // 
            // lstResultados
            // 
            this.lstResultados.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 18;
            this.lstResultados.Location = new System.Drawing.Point(424, 306);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(230, 112);
            this.lstResultados.TabIndex = 8;
            // 
            // pbppicture
            // 
            this.pbppicture.Image = ((System.Drawing.Image)(resources.GetObject("pbppicture.Image")));
            this.pbppicture.Location = new System.Drawing.Point(27, 3);
            this.pbppicture.Name = "pbppicture";
            this.pbppicture.Size = new System.Drawing.Size(143, 91);
            this.pbppicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbppicture.TabIndex = 9;
            this.pbppicture.TabStop = false;
            // 
            // pnlpanel
            // 
            this.pnlpanel.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlpanel.Controls.Add(this.pbppicture);
            this.pnlpanel.Controls.Add(this.lblGeneral);
            this.pnlpanel.Location = new System.Drawing.Point(17, 12);
            this.pnlpanel.Name = "pnlpanel";
            this.pnlpanel.Size = new System.Drawing.Size(771, 94);
            this.pnlpanel.TabIndex = 10;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(513, 127);
            this.txtGenero.Multiline = true;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(102, 34);
            this.txtGenero.TabIndex = 11;
            // 
            // Fmr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.pnlpanel);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.lstAccidentes);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Fmr3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pbppicture)).EndInit();
            this.pnlpanel.ResumeLayout(false);
            this.pnlpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ListBox lstAccidentes;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.PictureBox pbppicture;
        private System.Windows.Forms.Panel pnlpanel;
        private System.Windows.Forms.TextBox txtGenero;
    }
}