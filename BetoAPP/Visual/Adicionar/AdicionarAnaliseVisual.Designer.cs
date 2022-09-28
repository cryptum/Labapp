
namespace LabAPP.Visual
{
    partial class AdicionarAnaliseVisual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSolicitação = new System.Windows.Forms.TabPage();
            this.btn_AdicionarAmostra = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NumeroLaudo = new System.Windows.Forms.TextBox();
            this.cbx_Solicitacao = new System.Windows.Forms.ComboBox();
            this.cbx_Cultura = new System.Windows.Forms.ComboBox();
            this.cbx_TipoAnalise = new System.Windows.Forms.ComboBox();
            this.cbx_Fazenda = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Proprietario = new System.Windows.Forms.TextBox();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSolicitação.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AdicionarAmostra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(13, 5);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(146, 32);
            this.txtTitulo.TabIndex = 24;
            this.txtTitulo.Text = "Criar Análise";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Image = global::LabAPP.Properties.Resources.close_fill_vermelho_24px;
            this.btn_Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(122, 29);
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            this.btn_Cancelar.MouseEnter += new System.EventHandler(this.btn_Cancelar_MouseEnter);
            this.btn_Cancelar.MouseHover += new System.EventHandler(this.btn_Cancelar_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Salvar,
            this.btn_Cancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 411);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 33);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salvar.Image = global::LabAPP.Properties.Resources.save_verde_24px;
            this.btn_Salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(99, 29);
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            this.btn_Salvar.MouseEnter += new System.EventHandler(this.btn_Salvar_MouseEnter);
            this.btn_Salvar.MouseHover += new System.EventHandler(this.btn_Salvar_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1314, 477);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSolicitação);
            this.tabControl1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 30);
            this.tabControl1.Location = new System.Drawing.Point(7, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(60, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 449);
            this.tabControl1.TabIndex = 33;
            // 
            // tabSolicitação
            // 
            this.tabSolicitação.Controls.Add(this.btn_AdicionarAmostra);
            this.tabSolicitação.Controls.Add(this.dataGridView1);
            this.tabSolicitação.Controls.Add(this.label5);
            this.tabSolicitação.Controls.Add(this.txt_NumeroLaudo);
            this.tabSolicitação.Controls.Add(this.cbx_Solicitacao);
            this.tabSolicitação.Controls.Add(this.cbx_Cultura);
            this.tabSolicitação.Controls.Add(this.cbx_TipoAnalise);
            this.tabSolicitação.Controls.Add(this.cbx_Fazenda);
            this.tabSolicitação.Controls.Add(this.label17);
            this.tabSolicitação.Controls.Add(this.label16);
            this.tabSolicitação.Controls.Add(this.label15);
            this.tabSolicitação.Controls.Add(this.label14);
            this.tabSolicitação.Controls.Add(this.label13);
            this.tabSolicitação.Controls.Add(this.txt_Proprietario);
            this.tabSolicitação.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabSolicitação.Location = new System.Drawing.Point(4, 34);
            this.tabSolicitação.Name = "tabSolicitação";
            this.tabSolicitação.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSolicitação.Size = new System.Drawing.Size(1292, 411);
            this.tabSolicitação.TabIndex = 3;
            this.tabSolicitação.Text = "Solicitação";
            this.tabSolicitação.UseVisualStyleBackColor = true;
            // 
            // btn_AdicionarAmostra
            // 
            this.btn_AdicionarAmostra.Image = global::LabAPP.Properties.Resources.fileadd_verde_24px;
            this.btn_AdicionarAmostra.Location = new System.Drawing.Point(563, 10);
            this.btn_AdicionarAmostra.Name = "btn_AdicionarAmostra";
            this.btn_AdicionarAmostra.Size = new System.Drawing.Size(24, 24);
            this.btn_AdicionarAmostra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_AdicionarAmostra.TabIndex = 58;
            this.btn_AdicionarAmostra.TabStop = false;
            this.btn_AdicionarAmostra.Click += new System.EventHandler(this.btn_AdicionarAmostra_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(557, 6);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(716, 639);
            this.dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número do Laudo";
            // 
            // txt_NumeroLaudo
            // 
            this.txt_NumeroLaudo.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NumeroLaudo.Location = new System.Drawing.Point(248, 23);
            this.txt_NumeroLaudo.Name = "txt_NumeroLaudo";
            this.txt_NumeroLaudo.Size = new System.Drawing.Size(292, 36);
            this.txt_NumeroLaudo.TabIndex = 1;
            // 
            // cbx_Solicitacao
            // 
            this.cbx_Solicitacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Solicitacao.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Solicitacao.FormattingEnabled = true;
            this.cbx_Solicitacao.ItemHeight = 30;
            this.cbx_Solicitacao.Location = new System.Drawing.Point(247, 195);
            this.cbx_Solicitacao.Name = "cbx_Solicitacao";
            this.cbx_Solicitacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_Solicitacao.Size = new System.Drawing.Size(292, 38);
            this.cbx_Solicitacao.TabIndex = 6;
            // 
            // cbx_Cultura
            // 
            this.cbx_Cultura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Cultura.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Cultura.FormattingEnabled = true;
            this.cbx_Cultura.Location = new System.Drawing.Point(260, 347);
            this.cbx_Cultura.Name = "cbx_Cultura";
            this.cbx_Cultura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_Cultura.Size = new System.Drawing.Size(292, 38);
            this.cbx_Cultura.TabIndex = 5;
            // 
            // cbx_TipoAnalise
            // 
            this.cbx_TipoAnalise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TipoAnalise.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_TipoAnalise.FormattingEnabled = true;
            this.cbx_TipoAnalise.Location = new System.Drawing.Point(247, 138);
            this.cbx_TipoAnalise.Name = "cbx_TipoAnalise";
            this.cbx_TipoAnalise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_TipoAnalise.Size = new System.Drawing.Size(292, 38);
            this.cbx_TipoAnalise.TabIndex = 4;
            // 
            // cbx_Fazenda
            // 
            this.cbx_Fazenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Fazenda.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Fazenda.FormattingEnabled = true;
            this.cbx_Fazenda.Location = new System.Drawing.Point(247, 246);
            this.cbx_Fazenda.Name = "cbx_Fazenda";
            this.cbx_Fazenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_Fazenda.Size = new System.Drawing.Size(292, 38);
            this.cbx_Fazenda.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(32, 347);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 32);
            this.label17.TabIndex = 5;
            this.label17.Text = "Cultura";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(19, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 32);
            this.label16.TabIndex = 4;
            this.label16.Text = "Tipo de Análise";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(19, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 32);
            this.label15.TabIndex = 3;
            this.label15.Text = "Convêncio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(19, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 32);
            this.label14.TabIndex = 2;
            this.label14.Text = "Fazenda";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(16, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "Proprietário";
            // 
            // txt_Proprietario
            // 
            this.txt_Proprietario.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Proprietario.Location = new System.Drawing.Point(248, 80);
            this.txt_Proprietario.Name = "txt_Proprietario";
            this.txt_Proprietario.Size = new System.Drawing.Size(292, 36);
            this.txt_Proprietario.TabIndex = 2;
            this.txt_Proprietario.DoubleClick += new System.EventHandler(this.txt_Proprietario_DoubleClick);
            this.txt_Proprietario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Proprietario_KeyDown);
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Image = global::LabAPP.Properties.Resources.eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(0, 5);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(1340, 538);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbCarregar.TabIndex = 27;
            this.pcbCarregar.TabStop = false;
            this.pcbCarregar.Visible = false;
            // 
            // AdicionarAnaliseVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 444);
            this.ControlBox = false;
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarAnaliseVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdicionarAnaliseVisual_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSolicitação.ResumeLayout(false);
            this.tabSolicitação.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AdicionarAmostra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.ToolStripMenuItem btn_Cancelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Salvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSolicitação;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Proprietario;
        private System.Windows.Forms.ComboBox cbx_Solicitacao;
        private System.Windows.Forms.ComboBox cbx_Cultura;
        private System.Windows.Forms.ComboBox cbx_TipoAnalise;
        private System.Windows.Forms.ComboBox cbx_Fazenda;
        private System.Windows.Forms.PictureBox pcbCarregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NumeroLaudo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btn_AdicionarAmostra;
    }
}