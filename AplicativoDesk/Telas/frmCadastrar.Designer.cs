namespace AplicativoDesk.Telas
{
    partial class frmCadastrar
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
            label2 = new Label();
            txtSenha = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            txtLogin = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 97);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(41, 115);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(107, 23);
            txtSenha.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(52, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 53);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(41, 71);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(107, 23);
            txtLogin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 12;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(107, 23);
            txtNome.TabIndex = 11;
            // 
            // frmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 219);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Name = "frmCadastrar";
            Text = "frmCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtSenha;
        private Button btnSalvar;
        private Label label1;
        private TextBox txtLogin;
        private Label label3;
        private TextBox txtNome;
    }
}