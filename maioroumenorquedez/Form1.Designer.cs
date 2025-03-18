
namespace maioroumenorquedez
{
    partial class FrmMaiorMenor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaiorMenor = new System.Windows.Forms.Label();
            this.txtMaiorMenor = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaiorMenor
            // 
            this.lblMaiorMenor.AutoSize = true;
            this.lblMaiorMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorMenor.Location = new System.Drawing.Point(-7, 9);
            this.lblMaiorMenor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaiorMenor.Name = "lblMaiorMenor";
            this.lblMaiorMenor.Size = new System.Drawing.Size(457, 29);
            this.lblMaiorMenor.TabIndex = 0;
            this.lblMaiorMenor.Text = "Digite um número maior ou menor que 10";
            this.lblMaiorMenor.Click += new System.EventHandler(this.lblMaiorMenor_Click);
            // 
            // txtMaiorMenor
            // 
            this.txtMaiorMenor.Location = new System.Drawing.Point(38, 42);
            this.txtMaiorMenor.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaiorMenor.Name = "txtMaiorMenor";
            this.txtMaiorMenor.Size = new System.Drawing.Size(402, 24);
            this.txtMaiorMenor.TabIndex = 1;
            this.txtMaiorMenor.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(120, 74);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(170, 32);
            this.btn.TabIndex = 2;
            this.btn.Text = "Verificar";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // FrmMaiorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 192);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtMaiorMenor);
            this.Controls.Add(this.lblMaiorMenor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMaiorMenor";
            this.Text = "MaiorMenor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaiorMenor;
        private System.Windows.Forms.TextBox txtMaiorMenor;
        private System.Windows.Forms.Button btn;
    }
}

