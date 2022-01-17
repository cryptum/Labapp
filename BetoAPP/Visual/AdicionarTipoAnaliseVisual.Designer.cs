
namespace BetoAPP.Visual
{
    partial class AdicionarTipoAnaliseVisual
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
            this.btn_Cancela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Salva = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancela
            // 
            this.btn_Cancela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancela.Image = global::BetoAPP.Properties.Resources.close_fill_vermelho_24px;
            this.btn_Cancela.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Cancela.Name = "btn_Cancela";
            this.btn_Cancela.Size = new System.Drawing.Size(106, 28);
            this.btn_Cancela.Text = "Cancelar";
            this.btn_Cancela.Click += new System.EventHandler(this.btn_Cancela_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Salva,
            this.btn_Cancela});
            this.menuStrip1.Location = new System.Drawing.Point(0, 161);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 32);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Salva
            // 
            this.btn_Salva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salva.Image = global::BetoAPP.Properties.Resources.save_verde_24px;
            this.btn_Salva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salva.Name = "btn_Salva";
            this.btn_Salva.Size = new System.Drawing.Size(89, 28);
            this.btn_Salva.Text = "Salvar";
            this.btn_Salva.Click += new System.EventHandler(this.btn_Salva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(508, 118);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(21, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(292, 36);
            this.txtNome.TabIndex = 1;
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Image = global::BetoAPP.Properties.Resources.eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(0, 0);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(534, 166);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarregar.TabIndex = 30;
            this.pcbCarregar.TabStop = false;
            this.pcbCarregar.Visible = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(13, 9);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(285, 32);
            this.txtTitulo.TabIndex = 27;
            this.txtTitulo.Text = "Adicionar Tipo de Análise";
            // 
            // AdicionarTipoAnaliseVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(526, 193);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pcbCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(13, 35);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarTipoAnaliseVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem btn_Cancela;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Salva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.PictureBox pcbCarregar;
    }
}