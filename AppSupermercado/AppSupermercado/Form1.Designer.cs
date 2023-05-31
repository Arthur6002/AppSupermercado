namespace AppSupermercado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtValorUnt = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de Vendas";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblValorTotal.Location = new System.Drawing.Point(385, 591);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(32, 33);
            this.lblValorTotal.TabIndex = 4;
            this.lblValorTotal.Text = "0";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(183, 12);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(260, 20);
            this.txtProduto.TabIndex = 5;
            // 
            // txtValorUnt
            // 
            this.txtValorUnt.Location = new System.Drawing.Point(183, 123);
            this.txtValorUnt.Name = "txtValorUnt";
            this.txtValorUnt.Size = new System.Drawing.Size(260, 20);
            this.txtValorUnt.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(183, 62);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(260, 20);
            this.txtQuantidade.TabIndex = 7;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(183, 172);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(126, 62);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(79, 655);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(126, 62);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Nova Venda";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(317, 655);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 62);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(12, 280);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(505, 264);
            this.lstProdutos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(336, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorUnt);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtValorUnt;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label label6;
    }
}

