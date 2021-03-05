
namespace PrimeiraCalculadora
{
    partial class FrmCalculadora
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
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(108, 18);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(44, 13);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A:";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(108, 57);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(44, 13);
            this.lblValorB.TabIndex = 1;
            this.lblValorB.Text = "Valor B:";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(79, 34);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 2;
            this.txtValorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorA_KeyPress);
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(79, 73);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 20);
            this.txtValorB.TabIndex = 3;
            this.txtValorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorB_KeyPress);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(41, 158);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 36);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(147, 158);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 36);
            this.btnSubtrair.TabIndex = 5;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(41, 212);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 36);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtração
            // 
            this.btnSubtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtração.Location = new System.Drawing.Point(147, 212);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(75, 36);
            this.btnSubtração.TabIndex = 7;
            this.btnSubtração.Text = "%";
            this.btnSubtração.UseVisualStyleBackColor = true;
            this.btnSubtração.Click += new System.EventHandler(this.btnSubtração_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(76, 112);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(103, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "________________";
            this.lblResultado.Visible = false;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 262);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Label lblResultado;
    }
}

