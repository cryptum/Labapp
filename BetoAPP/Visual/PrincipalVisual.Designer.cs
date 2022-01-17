
namespace BetoAPP.Visual
{
    partial class PrincipalVisual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalVisual));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amostraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convenioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoanalisetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnDarkAndLight = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_LogadoCom = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_UsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietarioToolStripMenuItem,
            this.ordemToolStripMenuItem,
            this.analiseToolStripMenuItem,
            this.amostraToolStripMenuItem,
            this.culturaToolStripMenuItem,
            this.referenciaToolStripMenuItem,
            this.convenioToolStripMenuItem,
            this.tipoanalisetoolStripMenuItem,
            this.colaboradoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6);
            this.menuStrip1.Size = new System.Drawing.Size(1685, 52);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proprietarioToolStripMenuItem
            // 
            this.proprietarioToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proprietarioToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.user_fill_36px;
            this.proprietarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.proprietarioToolStripMenuItem.Name = "proprietarioToolStripMenuItem";
            this.proprietarioToolStripMenuItem.Size = new System.Drawing.Size(169, 40);
            this.proprietarioToolStripMenuItem.Text = "Proprietário";
            this.proprietarioToolStripMenuItem.Click += new System.EventHandler(this.proprietarioToolStripMenuItem_Click);
            // 
            // ordemToolStripMenuItem
            // 
            this.ordemToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordemToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.file_text_36px;
            this.ordemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ordemToolStripMenuItem.Name = "ordemToolStripMenuItem";
            this.ordemToolStripMenuItem.Size = new System.Drawing.Size(226, 40);
            this.ordemToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemToolStripMenuItem.Click += new System.EventHandler(this.ordemToolStripMenuItem1_Click);
            // 
            // analiseToolStripMenuItem
            // 
            this.analiseToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.analiseToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.microscope_fill_36px;
            this.analiseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.analiseToolStripMenuItem.Name = "analiseToolStripMenuItem";
            this.analiseToolStripMenuItem.Size = new System.Drawing.Size(183, 40);
            this.analiseToolStripMenuItem.Text = "Criar Pedidos";
            this.analiseToolStripMenuItem.Click += new System.EventHandler(this.analiseToolStripMenuItem_Click);
            // 
            // amostraToolStripMenuItem
            // 
            this.amostraToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amostraToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.test_tube_azul_36px;
            this.amostraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.amostraToolStripMenuItem.Name = "amostraToolStripMenuItem";
            this.amostraToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.amostraToolStripMenuItem.Text = "Escrever Laudo";
            this.amostraToolStripMenuItem.Click += new System.EventHandler(this.amostraToolStripMenuItem_Click);
            // 
            // culturaToolStripMenuItem
            // 
            this.culturaToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.culturaToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.plant_fill_36px;
            this.culturaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.culturaToolStripMenuItem.Name = "culturaToolStripMenuItem";
            this.culturaToolStripMenuItem.Size = new System.Drawing.Size(128, 40);
            this.culturaToolStripMenuItem.Text = "Cultura";
            this.culturaToolStripMenuItem.Click += new System.EventHandler(this.culturaToolStripMenuItem_Click);
            // 
            // referenciaToolStripMenuItem
            // 
            this.referenciaToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referenciaToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.pin_fill_36px;
            this.referenciaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.referenciaToolStripMenuItem.Name = "referenciaToolStripMenuItem";
            this.referenciaToolStripMenuItem.Size = new System.Drawing.Size(159, 40);
            this.referenciaToolStripMenuItem.Text = "Referência";
            this.referenciaToolStripMenuItem.Click += new System.EventHandler(this.referenciaToolStripMenuItem_Click);
            // 
            // convenioToolStripMenuItem
            // 
            this.convenioToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convenioToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.request_fill_36px;
            this.convenioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.convenioToolStripMenuItem.Name = "convenioToolStripMenuItem";
            this.convenioToolStripMenuItem.Size = new System.Drawing.Size(148, 40);
            this.convenioToolStripMenuItem.Text = "Convênio";
            this.convenioToolStripMenuItem.Click += new System.EventHandler(this.convenioToolStripMenuItem_Click);
            // 
            // tipoanalisetoolStripMenuItem
            // 
            this.tipoanalisetoolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipoanalisetoolStripMenuItem.Image = global::BetoAPP.Properties.Resources.flask_fill_36px;
            this.tipoanalisetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipoanalisetoolStripMenuItem.Name = "tipoanalisetoolStripMenuItem";
            this.tipoanalisetoolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.tipoanalisetoolStripMenuItem.Text = "Tipo da Análise";
            this.tipoanalisetoolStripMenuItem.Click += new System.EventHandler(this.tipoanaliseToolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colaboradoresToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.shield_user_fill;
            this.colaboradoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(195, 40);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDarkAndLight,
            this.txt_LogadoCom,
            this.lbl_UsuarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1685, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnDarkAndLight
            // 
            this.btnDarkAndLight.Image = global::BetoAPP.Properties.Resources.sun_fill_Dark_36px;
            this.btnDarkAndLight.Name = "btnDarkAndLight";
            this.btnDarkAndLight.Size = new System.Drawing.Size(31, 17);
            this.btnDarkAndLight.Text = "        ";
            this.btnDarkAndLight.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnDarkAndLight.Click += new System.EventHandler(this.btnDarkAndLight_Click);
            // 
            // txt_LogadoCom
            // 
            this.txt_LogadoCom.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_LogadoCom.Name = "txt_LogadoCom";
            this.txt_LogadoCom.Size = new System.Drawing.Size(85, 17);
            this.txt_LogadoCom.Text = "Logado com:";
            // 
            // lbl_UsuarioLogado
            // 
            this.lbl_UsuarioLogado.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UsuarioLogado.Name = "lbl_UsuarioLogado";
            this.lbl_UsuarioLogado.Size = new System.Drawing.Size(36, 17);
            this.lbl_UsuarioLogado.Text = "NAN";
            // 
            // PrincipalVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BetoAPP.Properties.Resources.AgroFrutal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalVisual";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.PrincipalVisual_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem analiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietarioToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txt_LogadoCom;
        private System.Windows.Forms.ToolStripStatusLabel lbl_UsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem convenioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoanalisetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amostraToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel btnDarkAndLight;
        private System.Windows.Forms.ToolStripMenuItem ordemToolStripMenuItem;
    }
}