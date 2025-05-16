namespace pryFakiani_gestion
{
    partial class Frmprovedores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.StatusStrip();
            this.fechahora = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Usuario.SuspendLayout();
            this.fechahora.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(279, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // Usuario
            // 
            this.Usuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaHora});
            this.Usuario.Location = new System.Drawing.Point(0, 428);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(580, 22);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "statusStrip1";
            // 
            // fechahora
            // 
            this.fechahora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.fechahora.Location = new System.Drawing.Point(0, 406);
            this.fechahora.Name = "fechahora";
            this.fechahora.Size = new System.Drawing.Size(580, 22);
            this.fechahora.TabIndex = 2;
            this.fechahora.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(118, 17);
            this.lblUsuario.Text = "toolStripStatusLabel1";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(118, 17);
            this.lblFechaHora.Text = "toolStripStatusLabel2";
            // 
            // Frmprovedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.fechahora);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frmprovedores";
            this.Text = "FrmPropiedades";
            this.Load += new System.EventHandler(this.FrmPropiedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Usuario.ResumeLayout(false);
            this.Usuario.PerformLayout();
            this.fechahora.ResumeLayout(false);
            this.fechahora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip Usuario;
        private System.Windows.Forms.StatusStrip fechahora;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
    }
}