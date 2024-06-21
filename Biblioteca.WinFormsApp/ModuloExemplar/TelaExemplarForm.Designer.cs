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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtSubTitulo = new System.Windows.Forms.TextBox();
            this.txtEscritor = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.nudAnoPublicacao = new System.Windows.Forms.NumericUpDown();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTipoExemplar = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();

            // Componentes específicos para Ebook
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.nudTamanho = new System.Windows.Forms.NumericUpDown();

            // Componentes específicos para Hq
            this.txtIlustrador = new System.Windows.Forms.TextBox();

            // Componentes específicos para Revista
            this.nudPaginas = new System.Windows.Forms.NumericUpDown();
            this.nudEdicao = new System.Windows.Forms.NumericUpDown();

            ((System.ComponentModel.ISupportInitialize)(this.nudAnoPublicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdicao)).BeginInit();
            this.SuspendLayout();

            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(260, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtSubTitulo
            // 
            this.txtSubTitulo.Location = new System.Drawing.Point(12, 38);
            this.txtSubTitulo.Name = "txtSubTitulo";
            this.txtSubTitulo.Size = new System.Drawing.Size(260, 20);
            this.txtSubTitulo.TabIndex = 1;
            // 
            // txtEscritor
            // 
            this.txtEscritor.Location = new System.Drawing.Point(12, 64);
            this.txtEscritor.Name = "txtEscritor";
            this.txtEscritor.Size = new System.Drawing.Size(260, 20);
            this.txtEscritor.TabIndex = 2;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(12, 90);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(260, 20);
            this.txtEditora.TabIndex = 3;
            // 
            // nudAnoPublicacao
            // 
            this.nudAnoPublicacao.Location = new System.Drawing.Point(12, 116);
            this.nudAnoPublicacao.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudAnoPublicacao.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudAnoPublicacao.Name = "nudAnoPublicacao";
            this.nudAnoPublicacao.Size = new System.Drawing.Size(260, 20);
            this.nudAnoPublicacao.TabIndex = 4;
            this.nudAnoPublicacao.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(12, 142);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(260, 20);
            this.txtGenero.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Disponivel",
            "Emprestado",
            "Reservado",
            "Indisponivel"});
            this.cbStatus.Location = new System.Drawing.Point(12, 168);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(260, 21);
            this.cbStatus.TabIndex = 6;
            // 
            // cbTipoExemplar
            // 
            this.cbTipoExemplar.FormattingEnabled = true;
            this.cbTipoExemplar.Items.AddRange(new object[] {
            "Ebook",
            "Hq",
            "Revista"});
            this.cbTipoExemplar.Location = new System.Drawing.Point(12, 195);
            this.cbTipoExemplar.Name = "cbTipoExemplar";
            this.cbTipoExemplar.Size = new System.Drawing.Size(260, 21);
            this.cbTipoExemplar.TabIndex = 7;
            this.cbTipoExemplar.SelectedIndexChanged += new System.EventHandler(this.cbTipoExemplar_SelectedIndexChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 222);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(260, 20);
            this.txtUrl.TabIndex = 8;
            this.txtUrl.Visible = false;
            // 
            // nudTamanho
            // 
            this.nudTamanho.Location = new System.Drawing.Point(12, 248);
            this.nudTamanho.Name = "nudTamanho";
            this.nudTamanho.Size = new System.Drawing.Size(260, 20);
            this.nudTamanho.TabIndex = 9;
            this.nudTamanho.Visible = false;
            // 
            // txtIlustrador
            // 
            this.txtIlustrador.Location = new System.Drawing.Point(12, 222);
            this.txtIlustrador.Name = "txtIlustrador";
            this.txtIlustrador.Size = new System.Drawing.Size(260, 20);
            this.txtIlustrador.TabIndex = 10;
            this.txtIlustrador.Visible = false;
            // 
            // nudPaginas
            // 
            this.nudPaginas.Location = new System.Drawing.Point(12, 222);
            this.nudPaginas.Name = "nudPaginas";
            this.nudPaginas.Size = new System.Drawing.Size(260, 20);
            this.nudPaginas.TabIndex = 11;
            this.nudPaginas.Visible = false;
            // 
            // nudEdicao
            // 
            this.nudEdicao.Location = new System.Drawing.Point(12, 248);
            this.nudEdicao.Name = "nudEdicao";
            this.nudEdicao.Size = new System.Drawing.Size(260, 20);
            this.nudEdicao.TabIndex = 12;
            this.nudEdicao.Visible = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(197, 274);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // TelaExemplarForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.nudEdicao);
            this.Controls.Add(this.nudPaginas);
            this.Controls.Add(this.txtIlustrador);
            this.Controls.Add(this.nudTamanho);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cbTipoExemplar);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.nudAnoPublicacao);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtEscritor);
            this.Controls.Add(this.txtSubTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Name = "TelaExemplarForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoPublicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
