namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(12, 27);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(154, 23);
            txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(12, 72);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(154, 23);
            txt_senha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(12, 101);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(154, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "Acessar";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(12, 130);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(154, 23);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 189);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_login);
            Controls.Add(txt_senha);
            Controls.Add(label2);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label label2;
        private Button btn_login;
        private Button btn_cancelar;
    }
}
