
namespace Calculadora_Simples
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gpbAritmetica = new System.Windows.Forms.GroupBox();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbSubtrair = new System.Windows.Forms.RadioButton();
            this.rbSomar = new System.Windows.Forms.RadioButton();
            this.lblX = new System.Windows.Forms.Label();
            this.lnlY = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.gpbAritmetica.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(49, 12);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(172, 20);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(49, 54);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(172, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(49, 94);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(172, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // gpbAritmetica
            // 
            this.gpbAritmetica.Controls.Add(this.rbDividir);
            this.gpbAritmetica.Controls.Add(this.rbMultiplicar);
            this.gpbAritmetica.Controls.Add(this.rbSubtrair);
            this.gpbAritmetica.Controls.Add(this.rbSomar);
            this.gpbAritmetica.Location = new System.Drawing.Point(12, 131);
            this.gpbAritmetica.Name = "gpbAritmetica";
            this.gpbAritmetica.Size = new System.Drawing.Size(209, 116);
            this.gpbAritmetica.TabIndex = 3;
            this.gpbAritmetica.TabStop = false;
            this.gpbAritmetica.Text = "Operações";
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.Location = new System.Drawing.Point(7, 89);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(54, 17);
            this.rbDividir.TabIndex = 3;
            this.rbDividir.TabStop = true;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Location = new System.Drawing.Point(7, 66);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbMultiplicar.TabIndex = 2;
            this.rbMultiplicar.TabStop = true;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbSubtrair
            // 
            this.rbSubtrair.AutoSize = true;
            this.rbSubtrair.Location = new System.Drawing.Point(7, 43);
            this.rbSubtrair.Name = "rbSubtrair";
            this.rbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rbSubtrair.TabIndex = 1;
            this.rbSubtrair.TabStop = true;
            this.rbSubtrair.Text = "Subtrair";
            this.rbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rbSomar
            // 
            this.rbSomar.AutoSize = true;
            this.rbSomar.Location = new System.Drawing.Point(7, 20);
            this.rbSomar.Name = "rbSomar";
            this.rbSomar.Size = new System.Drawing.Size(55, 17);
            this.rbSomar.TabIndex = 0;
            this.rbSomar.TabStop = true;
            this.rbSomar.Text = "Somar";
            this.rbSomar.UseVisualStyleBackColor = true;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(26, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X:";
            // 
            // lnlY
            // 
            this.lnlY.AutoSize = true;
            this.lnlY.Location = new System.Drawing.Point(26, 57);
            this.lnlY.Name = "lnlY";
            this.lnlY.Size = new System.Drawing.Size(17, 13);
            this.lnlY.TabIndex = 5;
            this.lnlY.Text = "Y:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 97);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(77, 282);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(146, 253);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 10;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 317);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lnlY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.gpbAritmetica);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Simples";
            this.gpbAritmetica.ResumeLayout(false);
            this.gpbAritmetica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gpbAritmetica;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbSubtrair;
        private System.Windows.Forms.RadioButton rbSomar;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lnlY;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCalculo;
    }
}

