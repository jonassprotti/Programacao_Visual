namespace Qui_2021_1_Lacos
{
    partial class Form1
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
            this.lblRes = new System.Windows.Forms.Label();
            this.btnFor = new System.Windows.Forms.Button();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.lstRes = new System.Windows.Forms.ListBox();
            this.btnDias = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.BackColor = System.Drawing.Color.Transparent;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(12, 65);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(247, 57);
            this.lblRes.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.Location = new System.Drawing.Point(16, 12);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(243, 33);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // lblRes2
            // 
            this.lblRes2.BackColor = System.Drawing.Color.Transparent;
            this.lblRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes2.Location = new System.Drawing.Point(12, 132);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(247, 57);
            this.lblRes2.TabIndex = 2;
            // 
            // lstRes
            // 
            this.lstRes.FormattingEnabled = true;
            this.lstRes.Location = new System.Drawing.Point(265, 12);
            this.lstRes.Name = "lstRes";
            this.lstRes.Size = new System.Drawing.Size(253, 290);
            this.lstRes.TabIndex = 3;
            // 
            // btnDias
            // 
            this.btnDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDias.Location = new System.Drawing.Point(524, 12);
            this.btnDias.Name = "btnDias";
            this.btnDias.Size = new System.Drawing.Size(157, 33);
            this.btnDias.TabIndex = 4;
            this.btnDias.Text = "Dias da semana";
            this.btnDias.UseVisualStyleBackColor = true;
            this.btnDias.Click += new System.EventHandler(this.btnDias_Click);
            // 
            // btnMeses
            // 
            this.btnMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeses.Location = new System.Drawing.Point(524, 51);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(157, 33);
            this.btnMeses.TabIndex = 5;
            this.btnMeses.Text = "Meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 313);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.btnDias);
            this.Controls.Add(this.lstRes);
            this.Controls.Add(this.lblRes2);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lblRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.ListBox lstRes;
        private System.Windows.Forms.Button btnDias;
        private System.Windows.Forms.Button btnMeses;
    }
}

