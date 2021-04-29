
namespace testeArrays
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
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnMostrarEstado = new System.Windows.Forms.Button();
            this.btnMostrarNomes = new System.Windows.Forms.Button();
            this.btnFuncoes = new System.Windows.Forms.Button();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(13, 70);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(370, 173);
            this.lstResultados.TabIndex = 0;
            // 
            // btnMostrarEstado
            // 
            this.btnMostrarEstado.Location = new System.Drawing.Point(13, 12);
            this.btnMostrarEstado.Name = "btnMostrarEstado";
            this.btnMostrarEstado.Size = new System.Drawing.Size(120, 23);
            this.btnMostrarEstado.TabIndex = 1;
            this.btnMostrarEstado.Text = "Mostrar Estados";
            this.btnMostrarEstado.UseVisualStyleBackColor = true;
            this.btnMostrarEstado.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarNomes
            // 
            this.btnMostrarNomes.Location = new System.Drawing.Point(137, 12);
            this.btnMostrarNomes.Name = "btnMostrarNomes";
            this.btnMostrarNomes.Size = new System.Drawing.Size(120, 23);
            this.btnMostrarNomes.TabIndex = 2;
            this.btnMostrarNomes.Text = "Mostrar Nomes";
            this.btnMostrarNomes.UseVisualStyleBackColor = true;
            this.btnMostrarNomes.Click += new System.EventHandler(this.btnMostrarNomes_Click);
            // 
            // btnFuncoes
            // 
            this.btnFuncoes.Location = new System.Drawing.Point(263, 12);
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(120, 23);
            this.btnFuncoes.TabIndex = 3;
            this.btnFuncoes.Text = "Funções";
            this.btnFuncoes.UseVisualStyleBackColor = true;
            this.btnFuncoes.Click += new System.EventHandler(this.btnFuncoes_Click);
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(263, 41);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(120, 20);
            this.txtAnoNascimento.TabIndex = 4;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(154, 44);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(103, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Ano de Nascimento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 252);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.btnFuncoes);
            this.Controls.Add(this.btnMostrarNomes);
            this.Controls.Add(this.btnMostrarEstado);
            this.Controls.Add(this.lstResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnMostrarEstado;
        private System.Windows.Forms.Button btnMostrarNomes;
        private System.Windows.Forms.Button btnFuncoes;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Label lblIdade;
    }
}

