using Model;
using Control;
using System.Drawing.Text;
using System;




namespace View
{
    partial class Janela_Estoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgv_Estoque = new DataGridView();
            btt_Cadastrar = new Button();
            btt_Cadastros = new Button();
            btt_Entrada = new Button();
            btt_Saida = new Button();
            btt_Consultar = new Button();
            btt_Movimentacao = new Button();
            label1 = new Label();
            txt_Codigo_Filtro = new TextBox();
            label2 = new Label();
            txt_Descricao_Filtro = new TextBox();
            label3 = new Label();
            txt_Posicao_Filtro = new TextBox();
            btt_Filtrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Estoque).BeginInit();
            SuspendLayout();
            // 
            // dgv_Estoque
            // 
            dgv_Estoque.AllowUserToAddRows = false;
            dgv_Estoque.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI" , 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Estoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Estoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI" , 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Estoque.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Estoque.Location = new Point(12 , 63);
            dgv_Estoque.Name = "dgv_Estoque";
            dgv_Estoque.ReadOnly = true;
            dgv_Estoque.RowHeadersWidth = 51;
            dgv_Estoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Estoque.Size = new Size(900 , 445);
            dgv_Estoque.TabIndex = 5;
            // 
            // btt_Cadastrar
            // 
            btt_Cadastrar.Location = new Point(715 , 514);
            btt_Cadastrar.Name = "btt_Cadastrar";
            btt_Cadastrar.Size = new Size(94 , 29);
            btt_Cadastrar.TabIndex = 1;
            btt_Cadastrar.Text = "Cadastrar";
            btt_Cadastrar.UseVisualStyleBackColor = true;
            btt_Cadastrar.Click += btt_Cadastrar_Click;
            // 
            // btt_Cadastros
            // 
            btt_Cadastros.Location = new Point(615 , 514);
            btt_Cadastros.Name = "btt_Cadastros";
            btt_Cadastros.Size = new Size(94 , 29);
            btt_Cadastros.TabIndex = 2;
            btt_Cadastros.Text = "Cadatros";
            btt_Cadastros.UseVisualStyleBackColor = true;
            btt_Cadastros.Click += btt_Cadastros_Click;
            // 
            // btt_Entrada
            // 
            btt_Entrada.Location = new Point(12 , 514);
            btt_Entrada.Name = "btt_Entrada";
            btt_Entrada.Size = new Size(94 , 29);
            btt_Entrada.TabIndex = 3;
            btt_Entrada.Text = "Entrada";
            btt_Entrada.UseVisualStyleBackColor = true;
            btt_Entrada.Click += btt_Entrada_Click;
            // 
            // btt_Saida
            // 
            btt_Saida.Location = new Point(112 , 514);
            btt_Saida.Name = "btt_Saida";
            btt_Saida.Size = new Size(94 , 29);
            btt_Saida.TabIndex = 4;
            btt_Saida.Text = "Saída";
            btt_Saida.UseVisualStyleBackColor = true;
            btt_Saida.Click += btt_Saida_Click;
            // 
            // btt_Consultar
            // 
            btt_Consultar.Location = new Point(254 , 514);
            btt_Consultar.Name = "btt_Consultar";
            btt_Consultar.Size = new Size(94 , 29);
            btt_Consultar.TabIndex = 5;
            btt_Consultar.Text = "Consultar";
            btt_Consultar.UseVisualStyleBackColor = true;
            // 
            // btt_Movimentacao
            // 
            btt_Movimentacao.Location = new Point(354 , 514);
            btt_Movimentacao.Name = "btt_Movimentacao";
            btt_Movimentacao.Size = new Size(122 , 29);
            btt_Movimentacao.TabIndex = 6;
            btt_Movimentacao.Text = "Movimentações";
            btt_Movimentacao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12 , 28);
            label1.Name = "label1";
            label1.Size = new Size(61 , 20);
            label1.TabIndex = 7;
            label1.Text = "Código:";
            // 
            // txt_Codigo_Filtro
            // 
            txt_Codigo_Filtro.Location = new Point(79 , 25);
            txt_Codigo_Filtro.Name = "txt_Codigo_Filtro";
            txt_Codigo_Filtro.Size = new Size(125 , 27);
            txt_Codigo_Filtro.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220 , 28);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(77 , 20);
            label2.TabIndex = 9;
            label2.Text = "Descrição:";
            // 
            // txt_Descricao_Filtro
            // 
            txt_Descricao_Filtro.Location = new Point(303 , 25);
            txt_Descricao_Filtro.Name = "txt_Descricao_Filtro";
            txt_Descricao_Filtro.Size = new Size(341 , 27);
            txt_Descricao_Filtro.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(659 , 28);
            label3.Name = "label3";
            label3.Size = new Size(62 , 20);
            label3.TabIndex = 11;
            label3.Text = "Posição:";
            // 
            // txt_Posicao_Filtro
            // 
            txt_Posicao_Filtro.Location = new Point(727 , 25);
            txt_Posicao_Filtro.Name = "txt_Posicao_Filtro";
            txt_Posicao_Filtro.Size = new Size(63 , 27);
            txt_Posicao_Filtro.TabIndex = 12;
            // 
            // btt_Filtrar
            // 
            btt_Filtrar.Location = new Point(818 , 28);
            btt_Filtrar.Name = "btt_Filtrar";
            btt_Filtrar.Size = new Size(94 , 29);
            btt_Filtrar.TabIndex = 13;
            btt_Filtrar.Text = "Filtrar";
            btt_Filtrar.UseVisualStyleBackColor = true;
            btt_Filtrar.Click += btt_Filtrar_Click;
            // 
            // Janela_Estoque
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(922 , 553);
            Controls.Add(btt_Filtrar);
            Controls.Add(txt_Posicao_Filtro);
            Controls.Add(label3);
            Controls.Add(txt_Descricao_Filtro);
            Controls.Add(label2);
            Controls.Add(txt_Codigo_Filtro);
            Controls.Add(label1);
            Controls.Add(btt_Movimentacao);
            Controls.Add(btt_Consultar);
            Controls.Add(btt_Saida);
            Controls.Add(btt_Entrada);
            Controls.Add(btt_Cadastros);
            Controls.Add(btt_Cadastrar);
            Controls.Add(dgv_Estoque);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Janela_Estoque";
            Text = "Controle de estoque";
            ((System.ComponentModel.ISupportInitialize)dgv_Estoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Janela_Estoque_Load ( object sender , EventArgs e )
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Estoque;
        private Button btt_Cadastrar;
        private Button btt_Cadastros;
        private Button btt_Entrada;
        private Button btt_Saida;
        private Button btt_Consultar;
        private Button btt_Movimentacao;
        private Label label1;
        private TextBox txt_Codigo_Filtro;
        private Label label2;
        private TextBox txt_Descricao_Filtro;
        private Label label3;
        private TextBox txt_Posicao_Filtro;
        private Button btt_Filtrar;
    }
}
