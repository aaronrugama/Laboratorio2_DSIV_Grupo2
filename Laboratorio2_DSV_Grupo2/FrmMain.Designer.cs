namespace Laboratorio2_DSV_Grupo2
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnSolucion5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProblema6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolucion5
            // 
            this.btnSolucion5.Location = new System.Drawing.Point(353, 199);
            this.btnSolucion5.Name = "btnSolucion5";
            this.btnSolucion5.Size = new System.Drawing.Size(75, 23);
            this.btnSolucion5.TabIndex = 0;
            this.btnSolucion5.Text = "Solucion 5";
            this.btnSolucion5.UseVisualStyleBackColor = true;
            this.btnSolucion5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Solucion 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnProblema6
            // 
            this.btnProblema6.Location = new System.Drawing.Point(580, 181);
            this.btnProblema6.Name = "btnProblema6";
            this.btnProblema6.Size = new System.Drawing.Size(75, 23);
            this.btnProblema6.TabIndex = 2;
            this.btnProblema6.Text = "Solucion 6";
            this.btnProblema6.UseVisualStyleBackColor = true;
            this.btnProblema6.Click += new System.EventHandler(this.btnProblema6_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProblema6);
            this.Controls.Add(this.btnSolucion5);
            this.Name = "FrmMain";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolucion5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProblema6;
    }
}

