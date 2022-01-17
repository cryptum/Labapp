
namespace BetoAPP.Visual
{
    partial class AdicionaUsuarioVisual
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBloqueio = new System.Windows.Forms.RadioButton();
            this.radioAcesso = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioColab = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtAcesso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.btn_Adiciona = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(13, 9);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(201, 32);
            this.txtTitulo.TabIndex = 24;
            this.txtTitulo.Text = "Adicionar Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAcesso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pcbCarregar);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(514, 348);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBloqueio);
            this.groupBox3.Controls.Add(this.radioAcesso);
            this.groupBox3.Location = new System.Drawing.Point(276, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 134);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissão";
            // 
            // radioBloqueio
            // 
            this.radioBloqueio.AutoSize = true;
            this.radioBloqueio.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBloqueio.Location = new System.Drawing.Point(17, 76);
            this.radioBloqueio.Name = "radioBloqueio";
            this.radioBloqueio.Size = new System.Drawing.Size(130, 34);
            this.radioBloqueio.TabIndex = 12;
            this.radioBloqueio.TabStop = true;
            this.radioBloqueio.Text = "Bloqueado";
            this.radioBloqueio.UseVisualStyleBackColor = true;
            this.radioBloqueio.CheckedChanged += new System.EventHandler(this.radioBloqueio_CheckedChanged);
            // 
            // radioAcesso
            // 
            this.radioAcesso.AutoSize = true;
            this.radioAcesso.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAcesso.Location = new System.Drawing.Point(17, 36);
            this.radioAcesso.Name = "radioAcesso";
            this.radioAcesso.Size = new System.Drawing.Size(191, 34);
            this.radioAcesso.TabIndex = 11;
            this.radioAcesso.TabStop = true;
            this.radioAcesso.Text = "Acesso Permitido";
            this.radioAcesso.UseVisualStyleBackColor = true;
            this.radioAcesso.CheckedChanged += new System.EventHandler(this.radioAcesso_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioColab);
            this.groupBox2.Controls.Add(this.radioAdmin);
            this.groupBox2.Location = new System.Drawing.Point(16, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 134);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hierarquia";
            // 
            // radioColab
            // 
            this.radioColab.AutoSize = true;
            this.radioColab.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioColab.Location = new System.Drawing.Point(40, 76);
            this.radioColab.Name = "radioColab";
            this.radioColab.Size = new System.Drawing.Size(145, 34);
            this.radioColab.TabIndex = 9;
            this.radioColab.TabStop = true;
            this.radioColab.Text = "Colaborador";
            this.radioColab.UseVisualStyleBackColor = true;
            this.radioColab.CheckedChanged += new System.EventHandler(this.radioColab_CheckedChanged);
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAdmin.Location = new System.Drawing.Point(40, 36);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(162, 34);
            this.radioAdmin.TabIndex = 10;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Administrador";
            this.radioAdmin.UseVisualStyleBackColor = true;
            this.radioAdmin.CheckedChanged += new System.EventHandler(this.radioAdmin_CheckedChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(93, 123);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(165, 36);
            this.txtSenha.TabIndex = 5;
            // 
            // txtAcesso
            // 
            this.txtAcesso.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAcesso.Location = new System.Drawing.Point(93, 79);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.Size = new System.Drawing.Size(242, 36);
            this.txtAcesso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acesso";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(93, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(402, 36);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbCarregar.Image = global::BetoAPP.Properties.Resources.eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(4, 19);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(506, 326);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbCarregar.TabIndex = 27;
            this.pcbCarregar.TabStop = false;
            this.pcbCarregar.Visible = false;
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
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adiciona,
            this.btn_Fechar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 386);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 32);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Fechar.Image = global::BetoAPP.Properties.Resources.close_fill_vermelho_24px;
            this.btn_Fechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(106, 28);
            this.btn_Fechar.Text = "Cancelar";
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // AdicionaUsuarioVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(528, 418);
            this.ControlBox = false;
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionaUsuarioVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBloqueio;
        private System.Windows.Forms.RadioButton radioAcesso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioColab;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtAcesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem btn_Adiciona;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Fechar;
        private System.Windows.Forms.PictureBox pcbCarregar;
    }
}