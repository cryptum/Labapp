
namespace BetoAPP.Visual
{
    partial class AmostraVisual
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
            this.btn_Adicionar_Amostra = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Recarregar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ImprimeQuadriculado = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ImprimeLaudo = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridAnalise = new System.Windows.Forms.DataGridView();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adicionar_Amostra,
            this.btn_Recarregar,
            this.btn_ImprimeQuadriculado,
            this.btn_ImprimeLaudo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 32);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Adicionar_Amostra
            // 
            this.btn_Adicionar_Amostra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adicionar_Amostra.Image = global::BetoAPP.Properties.Resources.test_tube_fill;
            this.btn_Adicionar_Amostra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Adicionar_Amostra.Name = "btn_Adicionar_Amostra";
            this.btn_Adicionar_Amostra.Size = new System.Drawing.Size(175, 28);
            this.btn_Adicionar_Amostra.Text = "Adicionar Amostra";
            this.btn_Adicionar_Amostra.Click += new System.EventHandler(this.btn_Adicionar_Amostra_Click);
            // 
            // btn_Recarregar
            // 
            this.btn_Recarregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Recarregar.Image = global::BetoAPP.Properties.Resources.refresh_amarelo_24px;
            this.btn_Recarregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Recarregar.Name = "btn_Recarregar";
            this.btn_Recarregar.Size = new System.Drawing.Size(169, 28);
            this.btn_Recarregar.Text = "Recarregar Tabela";
            this.btn_Recarregar.Click += new System.EventHandler(this.btn_Recarregar_Click);
            // 
            // btn_ImprimeQuadriculado
            // 
            this.btn_ImprimeQuadriculado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ImprimeQuadriculado.Image = global::BetoAPP.Properties.Resources.grid_azul_24px;
            this.btn_ImprimeQuadriculado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ImprimeQuadriculado.Name = "btn_ImprimeQuadriculado";
            this.btn_ImprimeQuadriculado.Size = new System.Drawing.Size(205, 28);
            this.btn_ImprimeQuadriculado.Text = "Imprimir Quadriculado";
            this.btn_ImprimeQuadriculado.Click += new System.EventHandler(this.btn_ImprimeQuadriculado_Click);
            // 
            // btn_ImprimeLaudo
            // 
            this.btn_ImprimeLaudo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ImprimeLaudo.Image = global::BetoAPP.Properties.Resources.printer_fill_24px;
            this.btn_ImprimeLaudo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ImprimeLaudo.Name = "btn_ImprimeLaudo";
            this.btn_ImprimeLaudo.Size = new System.Drawing.Size(154, 28);
            this.btn_ImprimeLaudo.Text = "Imprimir Laudo";
            this.btn_ImprimeLaudo.Click += new System.EventHandler(this.btn_ImprimeLaudo_Click);
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
            this.dataGridAnalise.Location = new System.Drawing.Point(14, 50);
            this.dataGridAnalise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridAnalise.Name = "dataGridAnalise";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAnalise.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAnalise.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridAnalise.RowTemplate.Height = 25;
            this.dataGridAnalise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAnalise.Size = new System.Drawing.Size(1029, 494);
            this.dataGridAnalise.TabIndex = 13;
            this.dataGridAnalise.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridAnalise_RowPrePaint);
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbCarregar.Image = global::BetoAPP.Properties.Resources.eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(0, 0);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(1056, 566);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbCarregar.TabIndex = 29;
            this.pcbCarregar.TabStop = false;
            this.pcbCarregar.Visible = false;
            // 
            // AmostraVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 566);
            this.Controls.Add(this.dataGridAnalise);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pcbCarregar);
            this.MinimumSize = new System.Drawing.Size(671, 400);
            this.Name = "AmostraVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análises em aberto";
            this.Load += new System.EventHandler(this.AmostraVisual_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Adicionar_Amostra;
        private System.Windows.Forms.ToolStripMenuItem btn_Recarregar;
        private System.Windows.Forms.ToolStripMenuItem btn_ImprimeQuadriculado;
        private System.Windows.Forms.ToolStripMenuItem btn_ImprimeLaudo;
        private System.Windows.Forms.DataGridView dataGridAnalise;
        private System.Windows.Forms.PictureBox pcbCarregar;
    }
}