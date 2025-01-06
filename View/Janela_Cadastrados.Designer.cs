namespace View
{
    partial class Janela_Cadastrados
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
            dgv_Cadastros = new DataGridView();
            label1 = new Label();
            txt_Codigo_Cadastros = new TextBox();
            label2 = new Label();
            txt_Descricao_Cadastros = new TextBox();
            btt_Filtrar_Cadastrar = new Button();
            btt_Remover_Cadastros = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Cadastros).BeginInit();
            SuspendLayout();
            // 
            // dgv_Cadastros
            // 
            dgv_Cadastros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cadastros.Location = new Point(10 , 66);
            dgv_Cadastros.Margin = new Padding(3 , 2 , 3 , 2);
            dgv_Cadastros.Name = "dgv_Cadastros";
            dgv_Cadastros.ReadOnly = true;
            dgv_Cadastros.RowHeadersWidth = 51;
            dgv_Cadastros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Cadastros.Size = new Size(624 , 227);
            dgv_Cadastros.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10 , 23);
            label1.Name = "label1";
            label1.Size = new Size(49 , 15);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // txt_Codigo_Cadastros
            // 
            txt_Codigo_Cadastros.Location = new Point(69 , 23);
            txt_Codigo_Cadastros.Margin = new Padding(3 , 2 , 3 , 2);
            txt_Codigo_Cadastros.Name = "txt_Codigo_Cadastros";
            txt_Codigo_Cadastros.Size = new Size(110 , 23);
            txt_Codigo_Cadastros.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195 , 23);
            label2.Name = "label2";
            label2.Size = new Size(61 , 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // txt_Descricao_Cadastros
            // 
            txt_Descricao_Cadastros.Location = new Point(268 , 23);
            txt_Descricao_Cadastros.Margin = new Padding(3 , 2 , 3 , 2);
            txt_Descricao_Cadastros.Name = "txt_Descricao_Cadastros";
            txt_Descricao_Cadastros.Size = new Size(276 , 23);
            txt_Descricao_Cadastros.TabIndex = 4;
            // 
            // btt_Filtrar_Cadastrar
            // 
            btt_Filtrar_Cadastrar.Location = new Point(552 , 23);
            btt_Filtrar_Cadastrar.Margin = new Padding(3 , 2 , 3 , 2);
            btt_Filtrar_Cadastrar.Name = "btt_Filtrar_Cadastrar";
            btt_Filtrar_Cadastrar.Size = new Size(82 , 22);
            btt_Filtrar_Cadastrar.TabIndex = 5;
            btt_Filtrar_Cadastrar.Text = "Filtrar";
            btt_Filtrar_Cadastrar.UseVisualStyleBackColor = true;
            btt_Filtrar_Cadastrar.Click += btt_Filtrar_Cadastrar_Click;
            // 
            // btt_Remover_Cadastros
            // 
            btt_Remover_Cadastros.Location = new Point(268 , 307);
            btt_Remover_Cadastros.Margin = new Padding(3 , 2 , 3 , 2);
            btt_Remover_Cadastros.Name = "btt_Remover_Cadastros";
            btt_Remover_Cadastros.Size = new Size(82 , 22);
            btt_Remover_Cadastros.TabIndex = 6;
            btt_Remover_Cadastros.Text = "Remover";
            btt_Remover_Cadastros.UseVisualStyleBackColor = true;
            btt_Remover_Cadastros.Click += btt_Remover_Cadastros_Click;
            // 
            // Janela_Cadastrados
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(645 , 338);
            Controls.Add(btt_Remover_Cadastros);
            Controls.Add(btt_Filtrar_Cadastrar);
            Controls.Add(txt_Descricao_Cadastros);
            Controls.Add(label2);
            Controls.Add(txt_Codigo_Cadastros);
            Controls.Add(label1);
            Controls.Add(dgv_Cadastros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3 , 2 , 3 , 2);
            MaximizeBox = false;
            Name = "Janela_Cadastrados";
            Text = "Janela_Cadastrados";
            ((System.ComponentModel.ISupportInitialize)dgv_Cadastros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cadastros;
        private Label label1;
        private TextBox txt_Codigo_Cadastros;
        private Label label2;
        private TextBox txt_Descricao_Cadastros;
        private Button btt_Filtrar_Cadastrar;
        private Button btt_Remover_Cadastros;
    }
}