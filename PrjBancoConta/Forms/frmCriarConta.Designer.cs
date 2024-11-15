namespace PrjBancoConta.Forms
{
    partial class frmCriarConta
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
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            label4 = new Label();
            btnCadastrar = new Button();
            dtpDataCriacao = new DateTimePicker();
            label5 = new Label();
            cbTipoDeconta = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(183, 133);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 0;
            label1.Text = "Titular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 297);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(183, 338);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 2;
            label3.Text = "Confirmar a Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(336, 135);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(183, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(336, 300);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(183, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(336, 340);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(183, 23);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(318, 49);
            label4.Name = "label4";
            label4.Size = new Size(201, 37);
            label4.TabIndex = 6;
            label4.Text = "Crie sua Conta";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(352, 398);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 27);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtpDataCriacao
            // 
            dtpDataCriacao.Format = DateTimePickerFormat.Short;
            dtpDataCriacao.Location = new Point(336, 173);
            dtpDataCriacao.Name = "dtpDataCriacao";
            dtpDataCriacao.Size = new Size(183, 23);
            dtpDataCriacao.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(183, 174);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 10;
            label5.Text = "Data de nascimento:";
            // 
            // cbTipoDeconta
            // 
            cbTipoDeconta.FormattingEnabled = true;
            cbTipoDeconta.Items.AddRange(new object[] { "Conta Poupança\t", "Conta Especial" });
            cbTipoDeconta.Location = new Point(336, 216);
            cbTipoDeconta.Name = "cbTipoDeconta";
            cbTipoDeconta.Size = new Size(183, 23);
            cbTipoDeconta.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(183, 215);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 12;
            label6.Text = "Tipo de Conta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(183, 256);
            label7.Name = "label7";
            label7.Size = new Size(137, 21);
            label7.TabIndex = 14;
            label7.Text = "Número de Conta:";
            // 
            // frmCriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(cbTipoDeconta);
            Controls.Add(label5);
            Controls.Add(dtpDataCriacao);
            Controls.Add(btnCadastrar);
            Controls.Add(label4);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmCriarConta";
            Text = "Criar Conta";
            Load += frmCriarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Label label4;
        private Button btnCadastrar;
        private DateTimePicker dtpDataCriacao;
        private Label label5;
        private ComboBox cbTipoDeconta;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
    }
}