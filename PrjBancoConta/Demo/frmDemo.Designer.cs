namespace PrjBancoConta.Forms.Demo
{
    partial class frmDemo
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
            txtNumBruto = new TextBox();
            txtNumFormatado = new TextBox();
            btnFormatar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumFormatado2 = new TextBox();
            SuspendLayout();
            // 
            // txtNumBruto
            // 
            txtNumBruto.Location = new Point(119, 99);
            txtNumBruto.Name = "txtNumBruto";
            txtNumBruto.Size = new Size(321, 23);
            txtNumBruto.TabIndex = 0;
            // 
            // txtNumFormatado
            // 
            txtNumFormatado.Location = new Point(119, 183);
            txtNumFormatado.Name = "txtNumFormatado";
            txtNumFormatado.Size = new Size(321, 23);
            txtNumFormatado.TabIndex = 1;
            
            // 
            // btnFormatar
            // 
            btnFormatar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormatar.Location = new Point(346, 318);
            btnFormatar.Name = "btnFormatar";
            btnFormatar.Size = new Size(94, 34);
            btnFormatar.TabIndex = 2;
            btnFormatar.Text = "Formatar";
            btnFormatar.UseVisualStyleBackColor = true;
            btnFormatar.Click += btnFormatar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 76);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "Número Bruto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 160);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 4;
            label2.Text = "Número Formatado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 230);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 6;
            label3.Text = "Número Formatado";
            // 
            // txtNumFormatado2
            // 
            txtNumFormatado2.Location = new Point(119, 265);
            txtNumFormatado2.Name = "txtNumFormatado2";
            txtNumFormatado2.Size = new Size(321, 23);
            txtNumFormatado2.TabIndex = 5;
            // 
            // frmDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 375);
            Controls.Add(label3);
            Controls.Add(txtNumFormatado2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFormatar);
            Controls.Add(txtNumFormatado);
            Controls.Add(txtNumBruto);
            Name = "frmDemo";
            Text = "frmDemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumBruto;
        private TextBox txtNumFormatado;
        private Button btnFormatar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumFormatado2;
    }
}