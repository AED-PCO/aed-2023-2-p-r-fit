namespace WinFormsApp1
{
    partial class F_menu
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
            menuStrip1 = new MenuStrip();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            inserirColaboradorToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lb_usuarioLogado = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, inserirColaboradorToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(836, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // inserirColaboradorToolStripMenuItem
            // 
            inserirColaboradorToolStripMenuItem.Name = "inserirColaboradorToolStripMenuItem";
            inserirColaboradorToolStripMenuItem.Size = new Size(120, 20);
            inserirColaboradorToolStripMenuItem.Text = "Inserir Colaborador";
            inserirColaboradorToolStripMenuItem.Click += inserirColaboradorToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(lb_usuarioLogado);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 616);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 38);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lb_usuarioLogado
            // 
            lb_usuarioLogado.AutoSize = true;
            lb_usuarioLogado.Location = new Point(88, 14);
            lb_usuarioLogado.Name = "lb_usuarioLogado";
            lb_usuarioLogado.Size = new Size(22, 15);
            lb_usuarioLogado.TabIndex = 3;
            lb_usuarioLogado.Text = "---";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuário logado:";
            // 
            // F_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 654);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "F_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_menu";
            Load += F_menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem inserirColaboradorToolStripMenuItem;
        private Panel panel1;
        private Label lb_usuarioLogado;
        private Label label1;
    }
}