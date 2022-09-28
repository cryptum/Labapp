
namespace LabAPP.Visual
{
    partial class AnaliseVisual
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
            aForm = null;
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Adiciona = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exclui = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Recarregar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ImprimeQuadriculado = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ImprimeLaudo = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Pesquisa = new System.Windows.Forms.MaskedTextBox();
            this.cbx_Pesquisa = new System.Windows.Forms.ComboBox();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dataGridAnalise = new System.Windows.Forms.DataGridView();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adiciona,
            this.btn_Exclui,
            this.btn_Recarregar,
            this.btn_ImprimeQuadriculado,
            this.btn_ImprimeLaudo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1867, 42);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Adiciona
            // 
            this.btn_Adiciona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adiciona.Image = global::LabAPP.Properties.Resources.fileadd_verde_24px;
            this.btn_Adiciona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Adiciona.Name = "btn_Adiciona";
            this.btn_Adiciona.Size = new System.Drawing.Size(186, 36);
            this.btn_Adiciona.Text = "Criar Análise";
            this.btn_Adiciona.Click += new System.EventHandler(this.btn_Adiciona_Click);
            // 
            // btn_Exclui
            // 
            this.btn_Exclui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exclui.Image = global::LabAPP.Properties.Resources.delete_vermelho_24px;
            this.btn_Exclui.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Exclui.Name = "btn_Exclui";
            this.btn_Exclui.Size = new System.Drawing.Size(122, 36);
            this.btn_Exclui.Text = "Excluir";
            this.btn_Exclui.Click += new System.EventHandler(this.btn_Exclui_Click);
            // 
            // btn_Recarregar
            // 
            this.btn_Recarregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Recarregar.Image = global::LabAPP.Properties.Resources.refresh_amarelo_24px;
            this.btn_Recarregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Recarregar.Name = "btn_Recarregar";
            this.btn_Recarregar.Size = new System.Drawing.Size(240, 36);
            this.btn_Recarregar.Text = "Recarregar Tabela";
            this.btn_Recarregar.Click += new System.EventHandler(this.btn_Recarregar_Click);
            // 
            // btn_ImprimeQuadriculado
            // 
            this.btn_ImprimeQuadriculado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ImprimeQuadriculado.Image = global::LabAPP.Properties.Resources.grid_azul_24px;
            this.btn_ImprimeQuadriculado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ImprimeQuadriculado.Name = "btn_ImprimeQuadriculado";
            this.btn_ImprimeQuadriculado.Size = new System.Drawing.Size(294, 36);
            this.btn_ImprimeQuadriculado.Text = "Imprimir Quadriculado";
            this.btn_ImprimeQuadriculado.Click += new System.EventHandler(this.btn_ImprimeQuadriculado_Click);
            // 
            // btn_ImprimeLaudo
            // 
            this.btn_ImprimeLaudo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ImprimeLaudo.Image = global::LabAPP.Properties.Resources.printer_fill_24px;
            this.btn_ImprimeLaudo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ImprimeLaudo.Name = "btn_ImprimeLaudo";
            this.btn_ImprimeLaudo.Size = new System.Drawing.Size(216, 36);
            this.btn_ImprimeLaudo.Text = "Imprimir Laudo";
            this.btn_ImprimeLaudo.Click += new System.EventHandler(this.btn_ImprimeLaudo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_Pesquisa);
            this.groupBox1.Controls.Add(this.cbx_Pesquisa);
            this.groupBox1.Controls.Add(this.btn_Pesquisa);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(19, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(1830, 165);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pesquisa.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Pesquisa.Location = new System.Drawing.Point(639, 70);
            this.txt_Pesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(844, 50);
            this.txt_Pesquisa.TabIndex = 6;
            this.txt_Pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pesquisa_KeyDown);
            // 
            // cbx_Pesquisa
            // 
            this.cbx_Pesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Pesquisa.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Pesquisa.FormattingEnabled = true;
            this.cbx_Pesquisa.Location = new System.Drawing.Point(279, 70);
            this.cbx_Pesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Pesquisa.Name = "cbx_Pesquisa";
            this.cbx_Pesquisa.Size = new System.Drawing.Size(350, 53);
            this.cbx_Pesquisa.TabIndex = 1;
            this.cbx_Pesquisa.SelectedIndexChanged += new System.EventHandler(this.cbx_Pesquisa_SelectedIndexChanged);
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisa.Image = global::LabAPP.Properties.Resources.search_line_24px;
            this.btn_Pesquisa.Location = new System.Drawing.Point(1494, 70);
            this.btn_Pesquisa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(73, 60);
            this.btn_Pesquisa.TabIndex = 3;
            this.btn_Pesquisa.UseVisualStyleBackColor = true;
            this.btn_Pesquisa.Click += new System.EventHandler(this.btn_Pesquisa_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(124, 72);
            this.lbl1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(157, 48);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Pesquisa";
            // 
            // dataGridAnalise
            // 
            this.dataGridAnalise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAnalise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAnalise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAnalise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAnalise.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAnalise.Location = new System.Drawing.Point(20, 258);
            this.dataGridAnalise.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridAnalise.Name = "dataGridAnalise";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAnalise.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAnalise.RowHeadersWidth = 62;
            this.dataGridAnalise.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridAnalise.RowTemplate.Height = 50;
            this.dataGridAnalise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAnalise.Size = new System.Drawing.Size(1829, 665);
            this.dataGridAnalise.TabIndex = 4;
            this.dataGridAnalise.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridAnalise_RowPrePaint);
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbCarregar.Image = global::LabAPP.Properties.Resources.eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(0, 0);
            this.pcbCarregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(1867, 943);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbCarregar.TabIndex = 28;
            this.pcbCarregar.TabStop = false;
            this.pcbCarregar.Visible = false;
            // 
            // AnaliseVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 943);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridAnalise);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pcbCarregar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(949, 629);
            this.Name = "AnaliseVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise";
            this.Load += new System.EventHandler(this.AnaliseVisual_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Adiciona;
        private System.Windows.Forms.ToolStripMenuItem btn_Exclui;
        private System.Windows.Forms.ToolStripMenuItem btn_Recarregar;
        private System.Windows.Forms.ToolStripMenuItem btn_ImprimeQuadriculado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dataGridAnalise;
        private System.Windows.Forms.ComboBox cbx_Pesquisa;
        private System.Windows.Forms.ToolStripMenuItem btn_ImprimeLaudo;
        private System.Windows.Forms.PictureBox pcbCarregar;
        private System.Windows.Forms.MaskedTextBox txt_Pesquisa;
    }
}