namespace WinFormsApp1
{
    partial class F_colaborador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_nomeColaborador = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_senhaColaborador = new TextBox();
            label4 = new Label();
            cb_unidadeColaborador = new ComboBox();
            label5 = new Label();
            btn_inserirColaborador = new Button();
            txt_cpfColaborador = new TextBox();
            btn_voltar = new Button();
            dataGridView1 = new DataGridView();
            btn_excluirColaborador = new Button();
            btn_salvarColaborador = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 66);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // txt_nomeColaborador
            // 
            txt_nomeColaborador.Location = new Point(302, 84);
            txt_nomeColaborador.Name = "txt_nomeColaborador";
            txt_nomeColaborador.Size = new Size(227, 23);
            txt_nomeColaborador.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 110);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 161);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Unidade:";
            // 
            // txt_senhaColaborador
            // 
            txt_senhaColaborador.Location = new Point(302, 226);
            txt_senhaColaborador.Name = "txt_senhaColaborador";
            txt_senhaColaborador.Size = new Size(227, 23);
            txt_senhaColaborador.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 208);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Senha:";
            // 
            // cb_unidadeColaborador
            // 
            cb_unidadeColaborador.FormattingEnabled = true;
            cb_unidadeColaborador.Items.AddRange(new object[] { "Barreiro", "Betim", "Contagem", "Coração Eucarístico", "Praça da liberdade", "São Gabriel" });
            cb_unidadeColaborador.Location = new Point(302, 179);
            cb_unidadeColaborador.Name = "cb_unidadeColaborador";
            cb_unidadeColaborador.Size = new Size(227, 23);
            cb_unidadeColaborador.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 27);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 9;
            label5.Text = "Novo Colaborador:";
            // 
            // btn_inserirColaborador
            // 
            btn_inserirColaborador.Location = new Point(204, 255);
            btn_inserirColaborador.Name = "btn_inserirColaborador";
            btn_inserirColaborador.Size = new Size(118, 23);
            btn_inserirColaborador.TabIndex = 10;
            btn_inserirColaborador.Text = "Inserir colaborador";
            btn_inserirColaborador.UseVisualStyleBackColor = true;
            btn_inserirColaborador.Click += button1_Click;
            // 
            // txt_cpfColaborador
            // 
            txt_cpfColaborador.Location = new Point(302, 128);
            txt_cpfColaborador.Name = "txt_cpfColaborador";
            txt_cpfColaborador.Size = new Size(227, 23);
            txt_cpfColaborador.TabIndex = 3;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(518, 298);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(118, 23);
            btn_voltar.TabIndex = 11;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(192, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 311);
            dataGridView1.TabIndex = 12;
            // 
            // btn_excluirColaborador
            // 
            btn_excluirColaborador.Location = new Point(360, 255);
            btn_excluirColaborador.Name = "btn_excluirColaborador";
            btn_excluirColaborador.Size = new Size(118, 23);
            btn_excluirColaborador.TabIndex = 13;
            btn_excluirColaborador.Text = "Excluir colaborador";
            btn_excluirColaborador.UseVisualStyleBackColor = true;
            btn_excluirColaborador.Click += btn_excluirColaborador_Click;
            // 
            // btn_salvarColaborador
            // 
            btn_salvarColaborador.Location = new Point(518, 255);
            btn_salvarColaborador.Name = "btn_salvarColaborador";
            btn_salvarColaborador.Size = new Size(118, 23);
            btn_salvarColaborador.TabIndex = 14;
            btn_salvarColaborador.Text = "Salvar";
            btn_salvarColaborador.UseVisualStyleBackColor = true;
            btn_salvarColaborador.Click += btn_salvarColaborador_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(192, 314);
            label6.Name = "label6";
            label6.Size = new Size(243, 25);
            label6.TabIndex = 15;
            label6.Text = "LISTA DE FUNCIONÁRIOS:";
            // 
            // F_colaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 654);
            Controls.Add(label6);
            Controls.Add(btn_salvarColaborador);
            Controls.Add(btn_excluirColaborador);
            Controls.Add(dataGridView1);
            Controls.Add(btn_voltar);
            Controls.Add(btn_inserirColaborador);
            Controls.Add(label5);
            Controls.Add(cb_unidadeColaborador);
            Controls.Add(txt_senhaColaborador);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_cpfColaborador);
            Controls.Add(label2);
            Controls.Add(txt_nomeColaborador);
            Controls.Add(label1);
            Name = "F_colaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_colaborador";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nomeColaborador;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox txt_senhaColaborador;
        private Label label4;
        private ComboBox cb_unidadeColaborador;
        private Label label5;
        private Button btn_inserirColaborador;
        private TextBox txt_cpfColaborador;
        private Button btn_voltar;
        private DataGridView dataGridView1;
        private Button btn_excluirColaborador;
        private Button btn_salvarColaborador;
        private Label label6;
    }
}