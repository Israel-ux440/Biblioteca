namespace Biblioteca.WinFormsApp.ModuloLeitor
{
    partial class TelaLeitorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Data Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(139, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(314, 23);
            txtNome.TabIndex = 5;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(139, 55);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(314, 23);
            dtpDataNascimento.TabIndex = 6;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(139, 95);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(314, 23);
            txtCPF.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(139, 175);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(314, 23);
            txtTelefone.TabIndex = 9;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(258, 215);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 35);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(339, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaLeitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(465, 275);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtCPF);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaLeitorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Leitor";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
