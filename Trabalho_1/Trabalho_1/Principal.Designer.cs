namespace Trabalho_1
{
    partial class Principal
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
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.txb_Valor1 = new System.Windows.Forms.TextBox();
            this.txb_Valor2 = new System.Windows.Forms.TextBox();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.btn_Subtrair = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.ForeColor = System.Drawing.Color.Red;
            this.lbl_Descricao.Location = new System.Drawing.Point(44, 9);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(258, 37);
            this.lbl_Descricao.TabIndex = 0;
            this.lbl_Descricao.Text = "CALCULADORA";
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.Location = new System.Drawing.Point(13, 67);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(56, 13);
            this.lbl_Numero1.TabIndex = 1;
            this.lbl_Numero1.Text = "Numero 1:";
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Location = new System.Drawing.Point(13, 106);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(56, 13);
            this.lbl_Numero2.TabIndex = 2;
            this.lbl_Numero2.Text = "Numero 2:";
            // 
            // txb_Valor1
            // 
            this.txb_Valor1.Location = new System.Drawing.Point(75, 64);
            this.txb_Valor1.Name = "txb_Valor1";
            this.txb_Valor1.Size = new System.Drawing.Size(100, 20);
            this.txb_Valor1.TabIndex = 3;
            // 
            // txb_Valor2
            // 
            this.txb_Valor2.Location = new System.Drawing.Point(75, 103);
            this.txb_Valor2.Name = "txb_Valor2";
            this.txb_Valor2.Size = new System.Drawing.Size(100, 20);
            this.txb_Valor2.TabIndex = 4;
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(16, 157);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(84, 34);
            this.btn_Somar.TabIndex = 5;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // btn_Subtrair
            // 
            this.btn_Subtrair.Location = new System.Drawing.Point(106, 157);
            this.btn_Subtrair.Name = "btn_Subtrair";
            this.btn_Subtrair.Size = new System.Drawing.Size(84, 34);
            this.btn_Subtrair.TabIndex = 6;
            this.btn_Subtrair.Text = "Subtrair";
            this.btn_Subtrair.UseVisualStyleBackColor = true;
            this.btn_Subtrair.Click += new System.EventHandler(this.btn_Subtrair_Click);
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.Location = new System.Drawing.Point(196, 157);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(84, 34);
            this.btn_Multiplicar.TabIndex = 7;
            this.btn_Multiplicar.Text = "Multiplicar";
            this.btn_Multiplicar.UseVisualStyleBackColor = true;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Location = new System.Drawing.Point(286, 157);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(84, 34);
            this.btn_Dividir.TabIndex = 8;
            this.btn_Dividir.Text = "Dividir";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(256, 64);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(68, 13);
            this.lbl_Resultado.TabIndex = 9;
            this.lbl_Resultado.Text = "Resultado:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(239, 87);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 36);
            this.lbl_Total.TabIndex = 10;
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Total.Click += new System.EventHandler(this.lbl_Total_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 205);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_Subtrair);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.txb_Valor2);
            this.Controls.Add(this.txb_Valor1);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.lbl_Numero1);
            this.Controls.Add(this.lbl_Descricao);
            this.Name = "Principal";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.TextBox txb_Valor1;
        private System.Windows.Forms.TextBox txb_Valor2;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Button btn_Subtrair;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_Total;
    }
}

