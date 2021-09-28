
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
            this.solicitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAnaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoSolicitacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_UsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitanteToolStripMenuItem,
            this.analiseToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.colaboradoresToolStripMenuItem,
            this.seetingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6);
            this.menuStrip1.Size = new System.Drawing.Size(1229, 52);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // solicitanteToolStripMenuItem
            // 
            this.solicitanteToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solicitanteToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.user_fill;
            this.solicitanteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.solicitanteToolStripMenuItem.Name = "solicitanteToolStripMenuItem";
            this.solicitanteToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.solicitanteToolStripMenuItem.Text = "Solicitante";
            this.solicitanteToolStripMenuItem.Click += new System.EventHandler(this.solicitanteToolStripMenuItem_Click);
            // 
            // analiseToolStripMenuItem
            // 
            this.analiseToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.analiseToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.microscope_fill;
            this.analiseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.analiseToolStripMenuItem.Name = "analiseToolStripMenuItem";
            this.analiseToolStripMenuItem.Size = new System.Drawing.Size(114, 40);
            this.analiseToolStripMenuItem.Text = "Análise";
            this.analiseToolStripMenuItem.Click += new System.EventHandler(this.analiseToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.relatórioToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.printer_fill;
            this.relatórioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(107, 40);
            this.relatórioToolStripMenuItem.Text = "Laudo";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colaboradoresToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.shield_user_fill;
            this.colaboradoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(170, 40);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // seetingsToolStripMenuItem
            // 
            this.seetingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.culturaToolStripMenuItem,
            this.referenciaToolStripMenuItem,
            this.tipoAnaliseToolStripMenuItem,
            this.tipoSolicitacaoToolStripMenuItem});
            this.seetingsToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seetingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seetingsToolStripMenuItem.Image")));
            this.seetingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seetingsToolStripMenuItem.Name = "seetingsToolStripMenuItem";
            this.seetingsToolStripMenuItem.Size = new System.Drawing.Size(139, 40);
            this.seetingsToolStripMenuItem.Text = "Definições";
            // 
            // culturaToolStripMenuItem
            // 
            this.culturaToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.culturaToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.plant_fill;
            this.culturaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.culturaToolStripMenuItem.Name = "culturaToolStripMenuItem";
            this.culturaToolStripMenuItem.Size = new System.Drawing.Size(245, 42);
            this.culturaToolStripMenuItem.Text = "Cultura";
            this.culturaToolStripMenuItem.Click += new System.EventHandler(this.culturaToolStripMenuItem_Click);
            // 
            // referenciaToolStripMenuItem
            // 
            this.referenciaToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referenciaToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.map_pin_2_fill;
            this.referenciaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.referenciaToolStripMenuItem.Name = "referenciaToolStripMenuItem";
            this.referenciaToolStripMenuItem.Size = new System.Drawing.Size(245, 42);
            this.referenciaToolStripMenuItem.Text = "Referência";
            this.referenciaToolStripMenuItem.Click += new System.EventHandler(this.referenciaToolStripMenuItem_Click);
            // 
            // tipoAnaliseToolStripMenuItem
            // 
            this.tipoAnaliseToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipoAnaliseToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.flask_fill;
            this.tipoAnaliseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipoAnaliseToolStripMenuItem.Name = "tipoAnaliseToolStripMenuItem";
            this.tipoAnaliseToolStripMenuItem.Size = new System.Drawing.Size(245, 42);
            this.tipoAnaliseToolStripMenuItem.Text = "Tipo da Análise";
            this.tipoAnaliseToolStripMenuItem.Click += new System.EventHandler(this.tipoAnaliseToolStripMenuItem_Click);
            // 
            // tipoSolicitacaoToolStripMenuItem
            // 
            this.tipoSolicitacaoToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipoSolicitacaoToolStripMenuItem.Image = global::BetoAPP.Properties.Resources.git_pull_request_line;
            this.tipoSolicitacaoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipoSolicitacaoToolStripMenuItem.Name = "tipoSolicitacaoToolStripMenuItem";
            this.tipoSolicitacaoToolStripMenuItem.Size = new System.Drawing.Size(245, 42);
            this.tipoSolicitacaoToolStripMenuItem.Text = "Tipo da Solicitação";
            this.tipoSolicitacaoToolStripMenuItem.Click += new System.EventHandler(this.tipoSolicitacaoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_UsuarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1229, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "Usúario atual:";
            // 
            // lbl_UsuarioLogado
            // 
            this.lbl_UsuarioLogado.Name = "lbl_UsuarioLogado";
            this.lbl_UsuarioLogado.Size = new System.Drawing.Size(33, 17);
            this.lbl_UsuarioLogado.Text = "NAN";
            // 
            // PrincipalVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 594);
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
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAnaliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoSolicitacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitanteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_UsuarioLogado;
    }
}