namespace ContaBancaria
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textoEmancipado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textoCPF = new System.Windows.Forms.TextBox();
            this.textoIdade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(208, 28);
            this.textoTitular.Margin = new System.Windows.Forms.Padding(4);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(132, 22);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(208, 67);
            this.textoNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(132, 22);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(208, 106);
            this.textoSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(132, 22);
            this.textoSaldo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(49, 210);
            this.botaoDeposito.Margin = new System.Windows.Forms.Padding(4);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(100, 28);
            this.botaoDeposito.TabIndex = 6;
            this.botaoDeposito.Text = "Depositar";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(208, 210);
            this.botaoSaque.Margin = new System.Windows.Forms.Padding(4);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(100, 28);
            this.botaoSaque.TabIndex = 7;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor da operação";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(208, 160);
            this.textoValor.Margin = new System.Windows.Forms.Padding(4);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(132, 22);
            this.textoValor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Permissão para Conta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Idade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Documento:";
            // 
            // textoEmancipado
            // 
            this.textoEmancipado.Location = new System.Drawing.Point(459, 96);
            this.textoEmancipado.Margin = new System.Windows.Forms.Padding(4);
            this.textoEmancipado.Name = "textoEmancipado";
            this.textoEmancipado.Size = new System.Drawing.Size(157, 22);
            this.textoEmancipado.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "CPF :";
            // 
            // textoCPF
            // 
            this.textoCPF.Location = new System.Drawing.Point(459, 162);
            this.textoCPF.Margin = new System.Windows.Forms.Padding(4);
            this.textoCPF.Name = "textoCPF";
            this.textoCPF.Size = new System.Drawing.Size(157, 22);
            this.textoCPF.TabIndex = 16;
            // 
            // textoIdade
            // 
            this.textoIdade.Location = new System.Drawing.Point(459, 30);
            this.textoIdade.Margin = new System.Windows.Forms.Padding(4);
            this.textoIdade.Name = "textoIdade";
            this.textoIdade.Size = new System.Drawing.Size(47, 22);
            this.textoIdade.TabIndex = 12;
            this.textoIdade.TextChanged += new System.EventHandler(this.textoIdade_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Controls.Add(this.botaoDeposito);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Location = new System.Drawing.Point(276, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 255);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textoCPF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textoEmancipado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textoIdade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textoEmancipado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textoCPF;
        private System.Windows.Forms.TextBox textoIdade;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

