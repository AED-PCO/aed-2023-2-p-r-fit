namespace WinFormsApp1
{
    partial class F_todosUsuarios
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
            dataGridView1 = new DataGridView();
            label13 = new Label();
            cb_sexo = new ComboBox();
            cb_unidade = new ComboBox();
            txt_idade = new TextBox();
            txt_endereco = new TextBox();
            txt_email = new TextBox();
            txt_nome = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_inserir = new Button();
            btn_serealizarLista = new Button();
            mtb_cpf = new MaskedTextBox();
            mtb_telefone = new MaskedTextBox();
            mtb_dataNascimento = new MaskedTextBox();
            mtb_altura = new MaskedTextBox();
            mtb_peso = new MaskedTextBox();
            mtb_dataCadastro = new MaskedTextBox();
            btn_Ordenar = new Button();
            btn_voltar = new Button();
            btn_excluir = new Button();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 504);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(836, 150);
            dataGridView1.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(197, 45);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 49;
            label13.Text = "CPF";
            // 
            // cb_sexo
            // 
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            cb_sexo.Location = new Point(354, 340);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(242, 23);
            cb_sexo.TabIndex = 47;
            // 
            // cb_unidade
            // 
            cb_unidade.FormattingEnabled = true;
            cb_unidade.Items.AddRange(new object[] { "Barreiro", "Betim", "Contagem", "Coração Eucarístico", "Praça da liberdade", "São Gabriel" });
            cb_unidade.Location = new Point(354, 282);
            cb_unidade.Name = "cb_unidade";
            cb_unidade.Size = new Size(242, 23);
            cb_unidade.TabIndex = 46;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(354, 248);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(242, 23);
            txt_idade.TabIndex = 44;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(354, 131);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(242, 23);
            txt_endereco.TabIndex = 40;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(354, 71);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(242, 23);
            txt_email.TabIndex = 38;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(354, 12);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(242, 23);
            txt_nome.TabIndex = 37;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(196, 344);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 36;
            label12.Text = "Sexo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(196, 314);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 35;
            label11.Text = "Data de cadastro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(196, 284);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 34;
            label10.Text = "Unidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(196, 254);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 33;
            label9.Text = "Idade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(196, 224);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 32;
            label8.Text = "Altura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 194);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 31;
            label7.Text = "Peso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 164);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 30;
            label6.Text = "Data de nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 134);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 29;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 104);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 28;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 74);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 27;
            label3.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 15);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 26;
            label2.Text = "Nome completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 25;
            // 
            // btn_inserir
            // 
            btn_inserir.Location = new Point(196, 388);
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Size = new Size(95, 23);
            btn_inserir.TabIndex = 50;
            btn_inserir.Text = "Inserir usuário";
            btn_inserir.UseVisualStyleBackColor = true;
            btn_inserir.Click += btn_inserir_Click;
            // 
            // btn_serealizarLista
            // 
            btn_serealizarLista.Location = new Point(500, 437);
            btn_serealizarLista.Name = "btn_serealizarLista";
            btn_serealizarLista.Size = new Size(96, 23);
            btn_serealizarLista.TabIndex = 51;
            btn_serealizarLista.Text = "Salvar";
            btn_serealizarLista.UseVisualStyleBackColor = true;
            btn_serealizarLista.Click += btn_serealizarLista_Click;
            // 
            // mtb_cpf
            // 
            mtb_cpf.Location = new Point(354, 42);
            mtb_cpf.Mask = "000.000.000-00";
            mtb_cpf.Name = "mtb_cpf";
            mtb_cpf.Size = new Size(242, 23);
            mtb_cpf.TabIndex = 53;
            // 
            // mtb_telefone
            // 
            mtb_telefone.Location = new Point(354, 102);
            mtb_telefone.Mask = "(99) 00000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(242, 23);
            mtb_telefone.TabIndex = 55;
            // 
            // mtb_dataNascimento
            // 
            mtb_dataNascimento.Location = new Point(354, 160);
            mtb_dataNascimento.Mask = "00/00/0000";
            mtb_dataNascimento.Name = "mtb_dataNascimento";
            mtb_dataNascimento.Size = new Size(242, 23);
            mtb_dataNascimento.TabIndex = 57;
            mtb_dataNascimento.ValidatingType = typeof(DateTime);
            // 
            // mtb_altura
            // 
            mtb_altura.Location = new Point(354, 219);
            mtb_altura.Mask = "0.00";
            mtb_altura.Name = "mtb_altura";
            mtb_altura.Size = new Size(242, 23);
            mtb_altura.TabIndex = 58;
            // 
            // mtb_peso
            // 
            mtb_peso.Location = new Point(354, 189);
            mtb_peso.Mask = "00.0";
            mtb_peso.Name = "mtb_peso";
            mtb_peso.Size = new Size(242, 23);
            mtb_peso.TabIndex = 59;
            // 
            // mtb_dataCadastro
            // 
            mtb_dataCadastro.Location = new Point(354, 311);
            mtb_dataCadastro.Mask = "00/00/0000";
            mtb_dataCadastro.Name = "mtb_dataCadastro";
            mtb_dataCadastro.Size = new Size(242, 23);
            mtb_dataCadastro.TabIndex = 60;
            mtb_dataCadastro.ValidatingType = typeof(DateTime);
            // 
            // btn_Ordenar
            // 
            btn_Ordenar.Location = new Point(398, 388);
            btn_Ordenar.Name = "btn_Ordenar";
            btn_Ordenar.Size = new Size(96, 23);
            btn_Ordenar.TabIndex = 61;
            btn_Ordenar.Text = "Ordenar";
            btn_Ordenar.UseVisualStyleBackColor = true;
            btn_Ordenar.Click += btn_Ordenar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(500, 388);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(96, 23);
            btn_voltar.TabIndex = 62;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(297, 388);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(95, 23);
            btn_excluir.TabIndex = 63;
            btn_excluir.Text = "Excluir usuario";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(0, 476);
            label14.Name = "label14";
            label14.Size = new Size(196, 25);
            label14.TabIndex = 64;
            label14.Text = "LISTA DE USUARIOS:";
            // 
            // F_todosUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 654);
            Controls.Add(label14);
            Controls.Add(btn_excluir);
            Controls.Add(btn_voltar);
            Controls.Add(btn_Ordenar);
            Controls.Add(mtb_dataCadastro);
            Controls.Add(mtb_peso);
            Controls.Add(mtb_altura);
            Controls.Add(mtb_dataNascimento);
            Controls.Add(mtb_telefone);
            Controls.Add(mtb_cpf);
            Controls.Add(btn_serealizarLista);
            Controls.Add(btn_inserir);
            Controls.Add(label13);
            Controls.Add(cb_sexo);
            Controls.Add(cb_unidade);
            Controls.Add(txt_idade);
            Controls.Add(txt_endereco);
            Controls.Add(txt_email);
            Controls.Add(txt_nome);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "F_todosUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_todosUsuarios";
            Load += F_todosUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label13;
        private ComboBox cb_sexo;
        private ComboBox cb_unidade;
        private TextBox txt_idade;
        private TextBox txt_endereco;
        private TextBox txt_email;
        private TextBox txt_nome;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_inserir;
        private Button btn_serealizarLista;
        private MaskedTextBox mtb_cpf;
        private MaskedTextBox mtb_nome;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox mtb_telefone;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox mtb_dataNascimento;
        private MaskedTextBox mtb_altura;
        private MaskedTextBox mtb_peso;
        private MaskedTextBox mtb_dataCadastro;
        private Button btn_Ordenar;
        private Button btn_voltar;
        private Button btn_excluir;
        private Label label14;
    }
}