﻿
namespace BetoAPP.Visual
{
    partial class SolicitanteVisual
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Adiciona = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Edita = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exclui = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Recarrega = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridSolicitante = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Solicitante = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_Solicitante = new System.Windows.Forms.TextBox();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSolicitante)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adiciona,
            this.btn_Edita,
            this.btn_Exclui,
            this.btn_Recarrega});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 32);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Adiciona
            // 
            this.btn_Adiciona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Adiciona.Image = global::BetoAPP.Properties.Resources.file_add_fill;
            this.btn_Adiciona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Adiciona.Name = "btn_Adiciona";
            this.btn_Adiciona.Size = new System.Drawing.Size(112, 28);
            this.btn_Adiciona.Text = "Adicionar";
            this.btn_Adiciona.Click += new System.EventHandler(this.btn_Adiciona_Click);
            // 
            // btn_Edita
            // 
            this.btn_Edita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Edita.Image = global::BetoAPP.Properties.Resources.edit_2_fill;
            this.btn_Edita.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Edita.Name = "btn_Edita";
            this.btn_Edita.Size = new System.Drawing.Size(86, 28);
            this.btn_Edita.Text = "Editar";
            this.btn_Edita.Click += new System.EventHandler(this.btn_Edita_Click);
            // 
            // btn_Exclui
            // 
            this.btn_Exclui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exclui.Image = global::BetoAPP.Properties.Resources.delete_bin_fill;
            this.btn_Exclui.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Exclui.Name = "btn_Exclui";
            this.btn_Exclui.Size = new System.Drawing.Size(91, 28);
            this.btn_Exclui.Text = "Excluir";
            this.btn_Exclui.Click += new System.EventHandler(this.btn_Exclui_Click);
            // 
            // btn_Recarrega
            // 
            this.btn_Recarrega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Recarrega.Image = global::BetoAPP.Properties.Resources.refresh_line;
            this.btn_Recarrega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Recarrega.Name = "btn_Recarrega";
            this.btn_Recarrega.Size = new System.Drawing.Size(169, 28);
            this.btn_Recarrega.Text = "Recarregar Tabela";
            this.btn_Recarrega.Click += new System.EventHandler(this.btn_Recarrega_Click);
            // 
            // dataGridSolicitante
            // 
            this.dataGridSolicitante.AllowUserToAddRows = false;
            this.dataGridSolicitante.AllowUserToDeleteRows = false;
            this.dataGridSolicitante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSolicitante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSolicitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSolicitante.Location = new System.Drawing.Point(13, 155);
            this.dataGridSolicitante.Name = "dataGridSolicitante";
            this.dataGridSolicitante.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSolicitante.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSolicitante.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridSolicitante.RowTemplate.Height = 25;
            this.dataGridSolicitante.Size = new System.Drawing.Size(668, 428);
            this.dataGridSolicitante.TabIndex = 13;
            this.dataGridSolicitante.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridSolicitante_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Solicitante);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.txt_Solicitante);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 99);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btn_Solicitante
            // 
            this.btn_Solicitante.Image = global::BetoAPP.Properties.Resources.search_line__2_;
            this.btn_Solicitante.Location = new System.Drawing.Point(510, 44);
            this.btn_Solicitante.Name = "btn_Solicitante";
            this.btn_Solicitante.Size = new System.Drawing.Size(51, 33);
            this.btn_Solicitante.TabIndex = 6;
            this.btn_Solicitante.UseVisualStyleBackColor = true;
            this.btn_Solicitante.Click += new System.EventHandler(this.btn_Solicitante_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(6, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 29);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Pesquisa";
            // 
            // txt_Solicitante
            // 
            this.txt_Solicitante.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Solicitante.Location = new System.Drawing.Point(165, 44);
            this.txt_Solicitante.Name = "txt_Solicitante";
            this.txt_Solicitante.Size = new System.Drawing.Size(339, 33);
            this.txt_Solicitante.TabIndex = 4;
            this.txt_Solicitante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Solicitante_KeyDown);
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbCarregar.Image = global::BetoAPP.Properties.Resources.Eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(0, 0);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(693, 595);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbCarregar.TabIndex = 30;
            this.pcbCarregar.TabStop = false;
            // 
            // SolicitanteVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 595);
            this.Controls.Add(this.dataGridSolicitante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pcbCarregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SolicitanteVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitante";
            this.Load += new System.EventHandler(this.SolicitanteVisual_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSolicitante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Adiciona;
        private System.Windows.Forms.ToolStripMenuItem btn_Edita;
        private System.Windows.Forms.ToolStripMenuItem btn_Exclui;
        private System.Windows.Forms.ToolStripMenuItem btn_Recarrega;
        private System.Windows.Forms.DataGridView dataGridSolicitante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Solicitante;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_Solicitante;
        private System.Windows.Forms.PictureBox pcbCarregar;
    }
}