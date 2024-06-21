namespace Biblioteca.WinFormsApp.ModuloLeitor
{
    partial class TabelaLeitorControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView gridLeitores;

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
            this.gridLeitores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeitores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLeitores
            // 
            this.gridLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLeitores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLeitores.Location = new System.Drawing.Point(0, 0);
            this.gridLeitores.Name = "gridLeitores";
            this.gridLeitores.Size = new System.Drawing.Size(390, 237);
            this.gridLeitores.TabIndex = 0;
            // 
            // TabelaLeitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridLeitores);
            this.Name = "TabelaLeitorControl";
            this.Size = new System.Drawing.Size(390, 237);
            ((System.ComponentModel.ISupportInitialize)(this.gridLeitores)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
