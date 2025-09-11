namespace Laboratorio2_DSV_Grupo2
{
    partial class FrmMain
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
            this.btnSolucion5 = new System.Windows.Forms.Button();
            this.btnProblema6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolucion5
            // 
            this.btnSolucion5.Location = new System.Drawing.Point(427, 181);
            this.btnSolucion5.Name = "btnSolucion5";
            this.btnSolucion5.Size = new System.Drawing.Size(75, 23);
            this.btnSolucion5.TabIndex = 0;
            this.btnSolucion5.Text = "Solucion 5";
            this.btnSolucion5.UseVisualStyleBackColor = true;
            this.btnSolucion5.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProblema6
            // 
            this.btnProblema6.Location = new System.Drawing.Point(580, 181);
            this.btnProblema6.Name = "btnProblema6";
            this.btnProblema6.Size = new System.Drawing.Size(75, 23);
            this.btnProblema6.TabIndex = 1;
            this.btnProblema6.Text = "Solucion 6";
            this.btnProblema6.UseVisualStyleBackColor = true;
            this.btnProblema6.Click += new System.EventHandler(this.btnProblema6_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProblema6);
            this.Controls.Add(this.btnSolucion5);
            this.Name = "FrmMain";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolucion5;
        private System.Windows.Forms.Button btnProblema6;
    }
}

