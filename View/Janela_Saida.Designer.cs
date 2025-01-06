namespace View
{
    partial class Janela_Saida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btt_Pesquisar = new Button();
            btt_Executar = new Button();
            txt_Codigo_Saida = new TextBox();
            txt_Quantidade_Saida = new TextBox();
            txt_Posicao_Saida = new TextBox();
            label_Descricao_Saida = new Label();
            label_Quantidade_Saida = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12 , 9);
            label1.Name = "label1";
            label1.Size = new Size(61 , 20);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12 , 66);
            label2.Name = "label2";
            label2.Size = new Size(90 , 20);
            label2.TabIndex = 1;
            label2.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12 , 107);
            label3.Name = "label3";
            label3.Size = new Size(62 , 20);
            label3.TabIndex = 2;
            label3.Text = "Posição:";
            // 
            // btt_Pesquisar
            // 
            btt_Pesquisar.Location = new Point(12 , 234);
            btt_Pesquisar.Name = "btt_Pesquisar";
            btt_Pesquisar.Size = new Size(94 , 29);
            btt_Pesquisar.TabIndex = 3;
            btt_Pesquisar.Text = "Pesquisar";
            btt_Pesquisar.UseVisualStyleBackColor = true;
            btt_Pesquisar.Click += btt_Pesquisar_Click;
            // 
            // btt_Executar
            // 
            btt_Executar.Location = new Point(481 , 234);
            btt_Executar.Name = "btt_Executar";
            btt_Executar.Size = new Size(94 , 29);
            btt_Executar.TabIndex = 4;
            btt_Executar.Text = "Executar";
            btt_Executar.UseVisualStyleBackColor = true;
            btt_Executar.Click += btt_Executar_Click;
            // 
            // txt_Codigo_Saida
            // 
            txt_Codigo_Saida.Location = new Point(79 , 12);
            txt_Codigo_Saida.Name = "txt_Codigo_Saida";
            txt_Codigo_Saida.Size = new Size(125 , 27);
            txt_Codigo_Saida.TabIndex = 5;
            // 
            // txt_Quantidade_Saida
            // 
            txt_Quantidade_Saida.Location = new Point(108 , 66);
            txt_Quantidade_Saida.Name = "txt_Quantidade_Saida";
            txt_Quantidade_Saida.Size = new Size(96 , 27);
            txt_Quantidade_Saida.TabIndex = 6;
            // 
            // txt_Posicao_Saida
            // 
            txt_Posicao_Saida.Location = new Point(80 , 107);
            txt_Posicao_Saida.Name = "txt_Posicao_Saida";
            txt_Posicao_Saida.Size = new Size(57 , 27);
            txt_Posicao_Saida.TabIndex = 7;
            // 
            // label_Descricao_Saida
            // 
            label_Descricao_Saida.AutoSize = true;
            label_Descricao_Saida.Location = new Point(232 , 12);
            label_Descricao_Saida.Name = "label_Descricao_Saida";
            label_Descricao_Saida.Size = new Size(74 , 20);
            label_Descricao_Saida.TabIndex = 8;
            label_Descricao_Saida.Text = "Descrição";
            // 
            // label_Quantidade_Saida
            // 
            label_Quantidade_Saida.AutoSize = true;
            label_Quantidade_Saida.Location = new Point(232 , 66);
            label_Quantidade_Saida.Name = "label_Quantidade_Saida";
            label_Quantidade_Saida.Size = new Size(161 , 20);
            label_Quantidade_Saida.TabIndex = 9;
            label_Quantidade_Saida.Text = "Quantidade Disponível";
            // 
            // Janela_Saida
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587 , 272);
            Controls.Add(label_Quantidade_Saida);
            Controls.Add(label_Descricao_Saida);
            Controls.Add(txt_Posicao_Saida);
            Controls.Add(txt_Quantidade_Saida);
            Controls.Add(txt_Codigo_Saida);
            Controls.Add(btt_Executar);
            Controls.Add(btt_Pesquisar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Janela_Saida";
            Text = "Janela_Saida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btt_Pesquisar;
        private Button btt_Executar;
        private TextBox txt_Codigo_Saida;
        private TextBox txt_Quantidade_Saida;
        private TextBox txt_Posicao_Saida;
        private Label label_Descricao_Saida;
        private Label label_Quantidade_Saida;
    }
}