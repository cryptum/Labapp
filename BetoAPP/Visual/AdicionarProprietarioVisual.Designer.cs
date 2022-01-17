
namespace BetoAPP.Visual
{
    partial class AdicionarProprietarioVisual
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
            this.btn_Cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Adiciona = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCPF_CNPJ = new System.Windows.Forms.ComboBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Image = global::BetoAPP.Properties.Resources.close_fill_vermelho_24px;
            this.btn_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(106, 28);
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adiciona,
            this.btn_Cancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 428);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 32);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Adiciona
            // 
            this.btn_Adiciona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adiciona.Image = global::BetoAPP.Properties.Resources.save_verde_24px;
            this.btn_Adiciona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Adiciona.Name = "btn_Adiciona";
            this.btn_Adiciona.Size = new System.Drawing.Size(89, 28);
            this.btn_Adiciona.Text = "Salvar";
            this.btn_Adiciona.Click += new System.EventHandler(this.btn_Adiciona_Click);
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
            this.groupBox1.Controls.Add(this.cbxCPF_CNPJ);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(480, 369);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // cbxCPF_CNPJ
            // 
            this.cbxCPF_CNPJ.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxCPF_CNPJ.FormattingEnabled = true;
            this.cbxCPF_CNPJ.Location = new System.Drawing.Point(21, 171);
            this.cbxCPF_CNPJ.Name = "cbxCPF_CNPJ";
            this.cbxCPF_CNPJ.Size = new System.Drawing.Size(121, 38);
            this.cbxCPF_CNPJ.TabIndex = 5;
            this.cbxCPF_CNPJ.SelectedIndexChanged += new System.EventHandler(this.cbxCPF_CNPJ_SelectedIndexChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(157, 172);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(306, 36);
            this.txtCpf.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF ou CNPJ";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObservacao.Location = new System.Drawing.Point(21, 277);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(442, 76);
            this.txtObservacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Observação";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(21, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(442, 36);
            this.txtNome.TabIndex = 1;
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Image = global::BetoAPP.Properties.Resources.eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(0, 0);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(494, 464);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbCarregar.TabIndex = 27;
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
            this.txtTitulo.Size = new System.Drawing.Size(245, 32);
            this.txtTitulo.TabIndex = 24;
            this.txtTitulo.Text = "Adicionar Proprietário";
            // 
            // AdicionarProprietarioVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pcbCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarProprietarioVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem btn_Cancelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Adiciona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbCarregar;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.ComboBox cbxCPF_CNPJ;
        private System.Windows.Forms.Label label3;
    }
}