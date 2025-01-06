namespace View
{
    partial class Janela_Entrada
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
            btt_Entrada = new Button();
            label1 = new Label();
            txt_Codigo_Entrada = new TextBox();
            label_Descricao = new Label();
            label2 = new Label();
            txt_Quantidade_Entrada = new TextBox();
            label3 = new Label();
            txt_Posicao_Entrada = new TextBox();
            btt_Pesquisar = new Button();
            SuspendLayout();
            // 
            // btt_Entrada
            // 
            btt_Entrada.Location = new Point(494 , 212);
            btt_Entrada.Name = "btt_Entrada";
            btt_Entrada.Size = new Size(94 , 29);
            btt_Entrada.TabIndex = 0;
            btt_Entrada.Text = "Executar";
            btt_Entrada.UseVisualStyleBackColor = true;
            btt_Entrada.Click += btt_Entrada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12 , 24);
            label1.Name = "label1";
            label1.Size = new Size(61 , 20);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // txt_Codigo_Entrada
            // 
            txt_Codigo_Entrada.Location = new Point(79 , 24);
            txt_Codigo_Entrada.Name = "txt_Codigo_Entrada";
            txt_Codigo_Entrada.Size = new Size(125 , 27);
            txt_Codigo_Entrada.TabIndex = 2;
            // 
            // label_Descricao
            // 
            label_Descricao.AutoSize = true;
            label_Descricao.Location = new Point(210 , 27);
            label_Descricao.Name = "label_Descricao";
            label_Descricao.Size = new Size(74 , 20);
            label_Descricao.TabIndex = 3;
            label_Descricao.Text = "Descrição";
            label_Descricao.Click += label_Descricao_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12 , 71);
            label2.Name = "label2";
            label2.Size = new Size(90 , 20);
            label2.TabIndex = 4;
            label2.Text = "Quantidade:";
            label2.Click += label2_Click;
            // 
            // txt_Quantidade_Entrada
            // 
            txt_Quantidade_Entrada.Location = new Point(108 , 71);
            txt_Quantidade_Entrada.Name = "txt_Quantidade_Entrada";
            txt_Quantidade_Entrada.Size = new Size(78 , 27);
            txt_Quantidade_Entrada.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12 , 120);
            label3.Name = "label3";
            label3.Size = new Size(62 , 20);
            label3.TabIndex = 6;
            label3.Text = "Posição:";
            // 
            // txt_Posicao_Entrada
            // 
            txt_Posicao_Entrada.Location = new Point(108 , 120);
            txt_Posicao_Entrada.Name = "txt_Posicao_Entrada";
            txt_Posicao_Entrada.Size = new Size(78 , 27);
            txt_Posicao_Entrada.TabIndex = 7;
            // 
            // btt_Pesquisar
            // 
            btt_Pesquisar.Location = new Point(12 , 212);
            btt_Pesquisar.Name = "btt_Pesquisar";
            btt_Pesquisar.Size = new Size(94 , 29);
            btt_Pesquisar.TabIndex = 8;
            btt_Pesquisar.Text = "Pesquisar";
            btt_Pesquisar.UseVisualStyleBackColor = true;
            btt_Pesquisar.Click += btt_Pesquisar_Click;
            // 
            // Janela_Entrada
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610 , 271);
            Controls.Add(btt_Pesquisar);
            Controls.Add(txt_Posicao_Entrada);
            Controls.Add(label3);
            Controls.Add(txt_Quantidade_Entrada);
            Controls.Add(label2);
            Controls.Add(label_Descricao);
            Controls.Add(txt_Codigo_Entrada);
            Controls.Add(label1);
            Controls.Add(btt_Entrada);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Janela_Entrada";
            Text = "Janela_Entrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btt_Entrada;
        private Label label1;
        private TextBox txt_Codigo_Entrada;
        private Label label_Descricao;
        private Label label2;
        private TextBox txt_Quantidade_Entrada;
        private Label label3;
        private TextBox txt_Posicao_Entrada;
        private Button btt_Pesquisar;
    }
}