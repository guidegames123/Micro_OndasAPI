namespace AplicativoDesk
{
    partial class frmLogin
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
            txtLogin = new TextBox();
            label1 = new Label();
            btnEntrar = new Button();
            label2 = new Label();
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(40, 27);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(107, 23);
            txtLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Login:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(53, 100);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(82, 29);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 53);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(40, 71);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(107, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(53, 129);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 29);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 222);
            Controls.Add(btnCadastrar);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(btnEntrar);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Label label1;
        private Button btnEntrar;
        private Label label2;
        private TextBox txtSenha;
        private Button btnCadastrar;
    }
}
