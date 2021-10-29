
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
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culturatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitantetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoanalisetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_UsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.analiseToolStripMenuItem,
            this.culturatoolStripMenuItem,
            this.referenciatoolStripMenuItem,
            this.solicitantetoolStripMenuItem,
            this.tipoanalisetoolStripMenuItem,
            this.colaboradoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6);
            this.menuStrip1.Size = new System.Drawing.Size(1685, 52);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clienteToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.user_fill;
            this.clienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(169, 40);
            this.clienteToolStripMenuItem.Text = "Proprietário";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.solicitanteToolStripMenuItem_Click);
            // 
            // analiseToolStripMenuItem
            // 
            this.analiseToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.analiseToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.microscope_fill;
            this.analiseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.analiseToolStripMenuItem.Name = "analiseToolStripMenuItem";
            this.analiseToolStripMenuItem.Size = new System.Drawing.Size(128, 40);
            this.analiseToolStripMenuItem.Text = "Análise";
            this.analiseToolStripMenuItem.Click += new System.EventHandler(this.analiseToolStripMenuItem_Click);
            // 
            // culturatoolStripMenuItem
            // 
            this.culturatoolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.culturatoolStripMenuItem.Image = global::BetoAPP.Properties.Resources.plant_fill;
            this.culturatoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.culturatoolStripMenuItem.Name = "culturatoolStripMenuItem";
            this.culturatoolStripMenuItem.Size = new System.Drawing.Size(128, 40);
            this.culturatoolStripMenuItem.Text = "Cultura";
            this.culturatoolStripMenuItem.Click += new System.EventHandler(this.culturatoolStripMenuItem_Click_1);
            // 
            // referenciatoolStripMenuItem
            // 
            this.referenciatoolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referenciatoolStripMenuItem.Image = global::BetoAPP.Properties.Resources.map_pin_2_fill;
            this.referenciatoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.referenciatoolStripMenuItem.Name = "referenciatoolStripMenuItem";
            this.referenciatoolStripMenuItem.Size = new System.Drawing.Size(159, 40);
            this.referenciatoolStripMenuItem.Text = "Referência";
            this.referenciatoolStripMenuItem.Click += new System.EventHandler(this.referenciatoolStripMenuItem_Click_1);
            // 
            // solicitantetoolStripMenuItem
            // 
            this.solicitantetoolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solicitantetoolStripMenuItem.Image = global::BetoAPP.Properties.Resources.git_pull_request_line;
            this.solicitantetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.solicitantetoolStripMenuItem.Name = "solicitantetoolStripMenuItem";
            this.solicitantetoolStripMenuItem.Size = new System.Drawing.Size(157, 40);
            this.solicitantetoolStripMenuItem.Text = "Solicitante";
            this.solicitantetoolStripMenuItem.Click += new System.EventHandler(this.solicitantetoolStripMenuItem_Click_1);
            // 
            // tipoanalisetoolStripMenuItem
            // 
            this.tipoanalisetoolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipoanalisetoolStripMenuItem.Image = global::BetoAPP.Properties.Resources.flask_fill;
            this.tipoanalisetoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipoanalisetoolStripMenuItem.Name = "tipoanalisetoolStripMenuItem";
            this.tipoanalisetoolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.tipoanalisetoolStripMenuItem.Text = "Tipo da Análise";
            this.tipoanalisetoolStripMenuItem.Click += new System.EventHandler(this.tipoanalisetoolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Enabled = false;
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1,
            this.lbl_UsuarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1685, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = global::BetoAPP.Properties.Resources.sun_fill_Dark_36px;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "Usúario atual:";
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
            this.ClientSize = new System.Drawing.Size(1685, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalVisual";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_UsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem culturatoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem solicitantetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoanalisetoolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem culturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoSolicitacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAnaliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culturatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoanalisetoolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}