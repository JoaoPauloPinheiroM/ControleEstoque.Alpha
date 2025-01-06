namespace View
{
    partial class Janela_Cadastro
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
            txt_Codigo_Cadastro = new TextBox();
            label_Descricao = new Label();
            label2 = new Label();
            txt_Descricao_Cadastrar = new TextBox();
            btt_Cadastrar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28 , 34);
            label1.Name = "label1";
            label1.Size = new Size(61 , 20);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // txt_Codigo_Cadastro
            // 
            txt_Codigo_Cadastro.Location = new Point(95 , 34);
            txt_Codigo_Cadastro.Name = "txt_Codigo_Cadastro";
            txt_Codigo_Cadastro.Size = new Size(125 , 27);
            txt_Codigo_Cadastro.TabIndex = 1;
            // 
            // label_Descricao
            // 
            label_Descricao.AutoSize = true;
            label_Descricao.Location = new Point(28 , 74);
            label_Descricao.Name = "label_Descricao";
            label_Descricao.Size = new Size(0 , 20);
            label_Descricao.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(0 , 0);
            label2.Name = "label2";
            label2.Size = new Size(100 , 23);
            label2.TabIndex = 6;
            // 
            // txt_Descricao_Cadastrar
            // 
            txt_Descricao_Cadastrar.Location = new Point(106 , 74);
            txt_Descricao_Cadastrar.Name = "txt_Descricao_Cadastrar";
            txt_Descricao_Cadastrar.Size = new Size(421 , 27);
            txt_Descricao_Cadastrar.TabIndex = 4;
            // 
            // btt_Cadastrar
            // 
            btt_Cadastrar.Location = new Point(433 , 168);
            btt_Cadastrar.Name = "btt_Cadastrar";
            btt_Cadastrar.Size = new Size(94 , 29);
            btt_Cadastrar.TabIndex = 5;
            btt_Cadastrar.Text = "Cadastrar";
            btt_Cadastrar.UseVisualStyleBackColor = true;
            btt_Cadastrar.Click += btt_Cadastrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23 , 74);
            label3.Name = "label3";
            label3.Size = new Size(77 , 20);
            label3.TabIndex = 7;
            label3.Text = "Descrição:";
            // 
            // Janela_Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564 , 242);
            Controls.Add(label3);
            Controls.Add(btt_Cadastrar);
            Controls.Add(txt_Descricao_Cadastrar);
            Controls.Add(label2);
            Controls.Add(label_Descricao);
            Controls.Add(txt_Codigo_Cadastro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Janela_Cadastro";
            Text = "Janela_Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Codigo_Cadastro;
        private Label label_Descricao;
        private Label label2;
        private TextBox txt_Descricao_Cadastrar;
        private Button btt_Cadastrar;
        private Label label3;
    }
}