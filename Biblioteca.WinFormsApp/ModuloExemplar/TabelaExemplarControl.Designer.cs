namespace Biblioteca.WinFormsApp.ModuloExemplar
{
    partial class TabelaExemplarControl
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
            gridExemplar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(gridExemplar)).BeginInit();
            SuspendLayout();
            // 
            // gridExemplar
            // 
            gridExemplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridExemplar.Dock = DockStyle.Fill;
            gridExemplar.Location = new Point(0, 0);
            gridExemplar.Name = "gridExemplar";
            gridExemplar.Size = new Size(390, 237);
            gridExemplar.TabIndex = 0;
            gridExemplar.CellContentClick += new DataGridViewCellEventHandler(gridExemplar_CellContentClick);
            // 
            // TabelaExemplarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridExemplar);
            Name = "TabelaExemplarControl";
            Size = new Size(390, 237);
            ((System.ComponentModel.ISupportInitialize)(gridExemplar)).EndInit();
            ResumeLayout(false);
        }

        private DataGridView gridExemplar;

        private void gridExemplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementação do evento CellContentClick
        }
    }
}
