namespace Biblioteca.WinFormsApp.ModuloExemplar
{
    partial class TelaExemplarForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTitulo = new TextBox();
            txtSubTitulo = new TextBox();
            txtEscritor = new TextBox();
            txtEditora = new TextBox();
            nudAnoPublicacao = new NumericUpDown();
            txtGenero = new TextBox();
            cbStatus = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)(nudAnoPublicacao)).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Subtítulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(30, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Escritor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(30, 140);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Editora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(10, 180);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Ano Publ.:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(30, 220);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Gênero:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(30, 260);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 6;
            label7.Text = "Status:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(100, 20);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(314, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtSubTitulo
            // 
            txtSubTitulo.Location = new Point(100, 60);
            txtSubTitulo.Name = "txtSubTitulo";
            txtSubTitulo.Size = new Size(314, 23);
            txtSubTitulo.TabIndex = 1;
            // 
            // txtEscritor
            // 
            txtEscritor.Location = new Point(100, 100);
            txtEscritor.Name = "txtEscritor";
            txtEscritor.Size = new Size(314, 23);
            txtEscritor.TabIndex = 2;
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(100, 140);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(314, 23);
            txtEditora.TabIndex = 3;
            // 
            // nudAnoPublicacao
            // 
            nudAnoPublicacao.Location = new Point(100, 180);
            nudAnoPublicacao.Minimum = 1900;
            nudAnoPublicacao.Maximum = DateTime.Now.Year;
            nudAnoPublicacao.Value = DateTime.Now.Year;
            nudAnoPublicacao.Name = "nudAnoPublicacao";
            nudAnoPublicacao.Size = new Size(120, 23);
            nudAnoPublicacao.TabIndex = 4;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(100, 220);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(314, 23);
            txtGenero.TabIndex = 5;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(100, 260);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(120, 23);
            cbStatus.TabIndex = 6;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(224, 320);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 50);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(340, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaExemplarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 380);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(cbStatus);
            Controls.Add(txtGenero);
            Controls.Add(nudAnoPublicacao);
            Controls.Add(txtEditora);
            Controls.Add(txtEscritor);
            Controls.Add(txtSubTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaExemplarForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Exemplar";
            ((System.ComponentModel.ISupportInitialize)(nudAnoPublicacao)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTitulo;
        private TextBox txtSubTitulo;
        private TextBox txtEscritor;
        private TextBox txtEditora;
        private NumericUpDown nudAnoPublicacao;
        private TextBox txtGenero;
        private ComboBox cbStatus;
        private Button btnGravar;
        private Button btnCancelar;
    }
}
