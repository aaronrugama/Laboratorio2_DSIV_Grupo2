namespace Laboratorio2_DSV_Grupo2
{
    partial class FrmPTSD
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMayMi = new System.Windows.Forms.Label();
            this.lblMenMi = new System.Windows.Forms.Label();
            this.lblMenQ = new System.Windows.Forms.Label();
            this.txtMayoresMil = new System.Windows.Forms.TextBox();
            this.txtMenoresMil = new System.Windows.Forms.TextBox();
            this.txtMenoresQuinientos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitulo.Location = new System.Drawing.Point(63, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(731, 67);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULADORA DE VENTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto de venta:";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.Info;
            this.txtMonto.Location = new System.Drawing.Point(343, 139);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(219, 37);
            this.txtMonto.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Olive;
            this.btnAgregar.Location = new System.Drawing.Point(241, 221);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMayMi
            // 
            this.lblMayMi.AutoSize = true;
            this.lblMayMi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayMi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMayMi.Location = new System.Drawing.Point(586, 278);
            this.lblMayMi.Name = "lblMayMi";
            this.lblMayMi.Size = new System.Drawing.Size(193, 28);
            this.lblMayMi.TabIndex = 4;
            this.lblMayMi.Text = "Mayores a 1000";
            this.lblMayMi.Visible = false;
            // 
            // lblMenMi
            // 
            this.lblMenMi.AutoSize = true;
            this.lblMenMi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenMi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenMi.Location = new System.Drawing.Point(591, 198);
            this.lblMenMi.Name = "lblMenMi";
            this.lblMenMi.Size = new System.Drawing.Size(175, 28);
            this.lblMenMi.TabIndex = 5;
            this.lblMenMi.Text = "500 > y < 1000";
            this.lblMenMi.Visible = false;
            // 
            // lblMenQ
            // 
            this.lblMenQ.AutoSize = true;
            this.lblMenQ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenQ.Location = new System.Drawing.Point(586, 115);
            this.lblMenQ.Name = "lblMenQ";
            this.lblMenQ.Size = new System.Drawing.Size(180, 28);
            this.lblMenQ.TabIndex = 6;
            this.lblMenQ.Text = "Menores a 500";
            this.lblMenQ.Visible = false;
            // 
            // txtMayoresMil
            // 
            this.txtMayoresMil.BackColor = System.Drawing.SystemColors.Info;
            this.txtMayoresMil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayoresMil.Location = new System.Drawing.Point(591, 309);
            this.txtMayoresMil.Multiline = true;
            this.txtMayoresMil.Name = "txtMayoresMil";
            this.txtMayoresMil.ReadOnly = true;
            this.txtMayoresMil.Size = new System.Drawing.Size(203, 37);
            this.txtMayoresMil.TabIndex = 7;
            this.txtMayoresMil.Visible = false;
            // 
            // txtMenoresMil
            // 
            this.txtMenoresMil.BackColor = System.Drawing.SystemColors.Info;
            this.txtMenoresMil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenoresMil.Location = new System.Drawing.Point(591, 229);
            this.txtMenoresMil.Multiline = true;
            this.txtMenoresMil.Name = "txtMenoresMil";
            this.txtMenoresMil.ReadOnly = true;
            this.txtMenoresMil.Size = new System.Drawing.Size(203, 37);
            this.txtMenoresMil.TabIndex = 8;
            this.txtMenoresMil.Visible = false;
            // 
            // txtMenoresQuinientos
            // 
            this.txtMenoresQuinientos.BackColor = System.Drawing.SystemColors.Info;
            this.txtMenoresQuinientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenoresQuinientos.Location = new System.Drawing.Point(591, 146);
            this.txtMenoresQuinientos.Multiline = true;
            this.txtMenoresQuinientos.Name = "txtMenoresQuinientos";
            this.txtMenoresQuinientos.ReadOnly = true;
            this.txtMenoresQuinientos.Size = new System.Drawing.Size(203, 37);
            this.txtMenoresQuinientos.TabIndex = 9;
            this.txtMenoresQuinientos.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(423, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmPTSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(835, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMenoresQuinientos);
            this.Controls.Add(this.txtMenoresMil);
            this.Controls.Add(this.txtMayoresMil);
            this.Controls.Add(this.lblMenQ);
            this.Controls.Add(this.lblMenMi);
            this.Controls.Add(this.lblMayMi);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPTSD";
            this.Text = "FrmPTSD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMayMi;
        private System.Windows.Forms.Label lblMenMi;
        private System.Windows.Forms.Label lblMenQ;
        private System.Windows.Forms.TextBox txtMayoresMil;
        private System.Windows.Forms.TextBox txtMenoresMil;
        private System.Windows.Forms.TextBox txtMenoresQuinientos;
        private System.Windows.Forms.Button button1;
    }
}