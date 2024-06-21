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

        private void InitializeComponent()
        {
            txtTitulo = new TextBox();
            txtSubTitulo = new TextBox();
            txtEscritor = new TextBox();
            txtEditora = new TextBox();
            nudAnoPublicacao = new NumericUpDown();
            txtGenero = new TextBox();
            cbStatus = new ComboBox();
            cbTipoExemplar = new ComboBox();
            btnGravar = new Button();
            txtUrl = new TextBox();
            nudTamanho = new NumericUpDown();
            txtIlustrador = new TextBox();
            nudPaginas = new NumericUpDown();
            nudEdicao = new NumericUpDown();
            lblTitulo = new Label();
            lblSubTitulo = new Label();
            lblEscritor = new Label();
            lblEditora = new Label();
            lblAnoPublicacao = new Label();
            lblGenero = new Label();
            lblStatus = new Label();
            lblTipoExemplar = new Label();
            lblUrl = new Label();
            lblTamanho = new Label();
            lblIlustrador = new Label();
            lblPaginas = new Label();
            lblEdicao = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAnoPublicacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTamanho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPaginas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEdicao).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(100, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(260, 23);
            txtTitulo.TabIndex = 1;
            // 
            // txtSubTitulo
            // 
            txtSubTitulo.Location = new Point(100, 38);
            txtSubTitulo.Name = "txtSubTitulo";
            txtSubTitulo.Size = new Size(260, 23);
            txtSubTitulo.TabIndex = 3;
            // 
            // txtEscritor
            // 
            txtEscritor.Location = new Point(100, 64);
            txtEscritor.Name = "txtEscritor";
            txtEscritor.Size = new Size(260, 23);
            txtEscritor.TabIndex = 5;
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(100, 90);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(260, 23);
            txtEditora.TabIndex = 7;
            // 
            // nudAnoPublicacao
            // 
            nudAnoPublicacao.Location = new Point(100, 116);
            nudAnoPublicacao.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAnoPublicacao.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            nudAnoPublicacao.Name = "nudAnoPublicacao";
            nudAnoPublicacao.Size = new Size(260, 23);
            nudAnoPublicacao.TabIndex = 9;
            nudAnoPublicacao.Value = new decimal(new int[] { 2021, 0, 0, 0 });
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(100, 142);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(260, 23);
            txtGenero.TabIndex = 11;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Disponível", "Emprestado", "Reservado", "Indisponível" });
            cbStatus.Location = new Point(100, 168);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(260, 23);
            cbStatus.TabIndex = 13;
            // 
            // cbTipoExemplar
            // 
            cbTipoExemplar.FormattingEnabled = true;
            cbTipoExemplar.Items.AddRange(new object[] { "Ebook", "Hq", "Revista" });
            cbTipoExemplar.Location = new Point(100, 195);
            cbTipoExemplar.Name = "cbTipoExemplar";
            cbTipoExemplar.Size = new Size(260, 23);
            cbTipoExemplar.TabIndex = 15;
            cbTipoExemplar.SelectedIndexChanged += cbTipoExemplar_SelectedIndexChanged;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(197, 274);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 26;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(100, 220);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(260, 23);
            txtUrl.TabIndex = 17;
            txtUrl.Visible = false;
            // 
            // nudTamanho
            // 
            nudTamanho.Location = new Point(100, 246);
            nudTamanho.Name = "nudTamanho";
            nudTamanho.Size = new Size(260, 23);
            nudTamanho.TabIndex = 19;
            nudTamanho.Visible = false;
            // 
            // txtIlustrador
            // 
            txtIlustrador.Location = new Point(100, 220);
            txtIlustrador.Name = "txtIlustrador";
            txtIlustrador.Size = new Size(260, 23);
            txtIlustrador.TabIndex = 21;
            txtIlustrador.Visible = false;
            // 
            // nudPaginas
            // 
            nudPaginas.Location = new Point(100, 220);
            nudPaginas.Name = "nudPaginas";
            nudPaginas.Size = new Size(260, 23);
            nudPaginas.TabIndex = 23;
            nudPaginas.Visible = false;
            // 
            // nudEdicao
            // 
            nudEdicao.Location = new Point(100, 246);
            nudEdicao.Name = "nudEdicao";
            nudEdicao.Size = new Size(260, 23);
            nudEdicao.TabIndex = 25;
            nudEdicao.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.AutoSize = true;
            lblSubTitulo.Location = new Point(12, 41);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(55, 15);
            lblSubTitulo.TabIndex = 2;
            lblSubTitulo.Text = "Subtítulo";
            // 
            // lblEscritor
            // 
            lblEscritor.AutoSize = true;
            lblEscritor.Location = new Point(12, 67);
            lblEscritor.Name = "lblEscritor";
            lblEscritor.Size = new Size(46, 15);
            lblEscritor.TabIndex = 4;
            lblEscritor.Text = "Escritor";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(12, 93);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(44, 15);
            lblEditora.TabIndex = 6;
            lblEditora.Text = "Editora";
            // 
            // lblAnoPublicacao
            // 
            lblAnoPublicacao.AutoSize = true;
            lblAnoPublicacao.Location = new Point(12, 119);
            lblAnoPublicacao.Name = "lblAnoPublicacao";
            lblAnoPublicacao.Size = new Size(106, 15);
            lblAnoPublicacao.TabIndex = 8;
            lblAnoPublicacao.Text = "Ano de Publicação";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(12, 145);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 10;
            lblGenero.Text = "Gênero";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 171);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // lblTipoExemplar
            // 
            lblTipoExemplar.AutoSize = true;
            lblTipoExemplar.Location = new Point(12, 197);
            lblTipoExemplar.Name = "lblTipoExemplar";
            lblTipoExemplar.Size = new Size(98, 15);
            lblTipoExemplar.TabIndex = 14;
            lblTipoExemplar.Text = "Tipo de Exemplar";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(12, 223);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(28, 15);
            lblUrl.TabIndex = 16;
            lblUrl.Text = "URL";
            lblUrl.Visible = false;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Location = new Point(12, 249);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(56, 15);
            lblTamanho.TabIndex = 18;
            lblTamanho.Text = "Tamanho";
            lblTamanho.Visible = false;
            // 
            // lblIlustrador
            // 
            lblIlustrador.AutoSize = true;
            lblIlustrador.Location = new Point(12, 223);
            lblIlustrador.Name = "lblIlustrador";
            lblIlustrador.Size = new Size(57, 15);
            lblIlustrador.TabIndex = 20;
            lblIlustrador.Text = "Ilustrador";
            lblIlustrador.Visible = false;
            // 
            // lblPaginas
            // 
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(12, 223);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(48, 15);
            lblPaginas.TabIndex = 22;
            lblPaginas.Text = "Páginas";
            lblPaginas.Visible = false;
            // 
            // lblEdicao
            // 
            lblEdicao.AutoSize = true;
            lblEdicao.Location = new Point(12, 249);
            lblEdicao.Name = "lblEdicao";
            lblEdicao.Size = new Size(42, 15);
            lblEdicao.TabIndex = 24;
            lblEdicao.Text = "Edição";
            lblEdicao.Visible = false;
            // 
            // TelaExemplarForm
            // 
            ClientSize = new Size(384, 311);
            Controls.Add(btnGravar);
            Controls.Add(nudEdicao);
            Controls.Add(lblEdicao);
            Controls.Add(nudPaginas);
            Controls.Add(lblPaginas);
            Controls.Add(txtIlustrador);
            Controls.Add(lblIlustrador);
            Controls.Add(nudTamanho);
            Controls.Add(lblTamanho);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(cbTipoExemplar);
            Controls.Add(lblTipoExemplar);
            Controls.Add(cbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtGenero);
            Controls.Add(lblGenero);
            Controls.Add(nudAnoPublicacao);
            Controls.Add(lblAnoPublicacao);
            Controls.Add(txtEditora);
            Controls.Add(lblEditora);
            Controls.Add(txtEscritor);
            Controls.Add(lblEscritor);
            Controls.Add(txtSubTitulo);
            Controls.Add(lblSubTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaExemplarForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)nudAnoPublicacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTamanho).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPaginas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEdicao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtSubTitulo;
        private System.Windows.Forms.TextBox txtEscritor;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.NumericUpDown nudAnoPublicacao;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTipoExemplar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.NumericUpDown nudTamanho;
        private System.Windows.Forms.TextBox txtIlustrador;
        private System.Windows.Forms.NumericUpDown nudPaginas;
        private System.Windows.Forms.NumericUpDown nudEdicao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblEscritor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblAnoPublicacao;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTipoExemplar;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblIlustrador;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblEdicao;
    }
}
