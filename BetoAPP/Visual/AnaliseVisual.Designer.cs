
namespace BetoAPP.Visual
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
            this.btn_Edita = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exclui = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LimparTodosOsCampos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ImprimeQuadriculado = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Pesquisa = new System.Windows.Forms.ComboBox();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridAnalise = new System.Windows.Forms.DataGridView();
            this.grid_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalise)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adiciona,
            this.btn_Edita,
            this.btn_Exclui,
            this.btn_LimparTodosOsCampos,
            this.btn_ImprimeQuadriculado});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 32);
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
            // 
            // btn_Exclui
            // 
            this.btn_Exclui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exclui.Image = global::BetoAPP.Properties.Resources.delete_bin_fill;
            this.btn_Exclui.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Exclui.Name = "btn_Exclui";
            this.btn_Exclui.Size = new System.Drawing.Size(91, 28);
            this.btn_Exclui.Text = "Excluir";
            // 
            // btn_LimparTodosOsCampos
            // 
            this.btn_LimparTodosOsCampos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LimparTodosOsCampos.Image = global::BetoAPP.Properties.Resources.refresh_line;
            this.btn_LimparTodosOsCampos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_LimparTodosOsCampos.Name = "btn_LimparTodosOsCampos";
            this.btn_LimparTodosOsCampos.Size = new System.Drawing.Size(169, 28);
            this.btn_LimparTodosOsCampos.Text = "Recarregar Tabela";
            // 
            // btn_ImprimeQuadriculado
            // 
            this.btn_ImprimeQuadriculado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ImprimeQuadriculado.Image = global::BetoAPP.Properties.Resources.printer24px;
            this.btn_ImprimeQuadriculado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ImprimeQuadriculado.Name = "btn_ImprimeQuadriculado";
            this.btn_ImprimeQuadriculado.Size = new System.Drawing.Size(205, 28);
            this.btn_ImprimeQuadriculado.Text = "Imprimir Quadriculado";
            this.btn_ImprimeQuadriculado.Click += new System.EventHandler(this.btn_ImprimeQuadriculado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Pesquisa);
            this.groupBox1.Controls.Add(this.btn_Pesquisa);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.txt_Pesquisa);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(729, 99);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // cbx_Pesquisa
            // 
            this.cbx_Pesquisa.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Pesquisa.FormattingEnabled = true;
            this.cbx_Pesquisa.Location = new System.Drawing.Point(135, 40);
            this.cbx_Pesquisa.Name = "cbx_Pesquisa";
            this.cbx_Pesquisa.Size = new System.Drawing.Size(121, 34);
            this.cbx_Pesquisa.TabIndex = 1;
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.Image = global::BetoAPP.Properties.Resources.search_line__2_;
            this.btn_Pesquisa.Location = new System.Drawing.Point(610, 40);
            this.btn_Pesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(51, 33);
            this.btn_Pesquisa.TabIndex = 3;
            this.btn_Pesquisa.UseVisualStyleBackColor = true;
            this.btn_Pesquisa.Click += new System.EventHandler(this.btn_Pesquisa_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(8, 40);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 29);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Pesquisa";
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Pesquisa.Location = new System.Drawing.Point(263, 40);
            this.txt_Pesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(339, 33);
            this.txt_Pesquisa.TabIndex = 2;
            // 
            // dataGridAnalise
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAnalise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAnalise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnalise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_Id,
            this.grid_Nome});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAnalise.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAnalise.Location = new System.Drawing.Point(14, 155);
            this.dataGridAnalise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridAnalise.Name = "dataGridAnalise";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAnalise.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAnalise.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridAnalise.RowTemplate.Height = 25;
            this.dataGridAnalise.Size = new System.Drawing.Size(728, 527);
            this.dataGridAnalise.TabIndex = 4;
            // 
            // grid_Id
            // 
            this.grid_Id.HeaderText = "Código";
            this.grid_Id.Name = "grid_Id";
            // 
            // grid_Nome
            // 
            this.grid_Nome.HeaderText = "Nome";
            this.grid_Nome.Name = "grid_Nome";
            this.grid_Nome.Width = 385;
            // 
            // AnaliseVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridAnalise);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "AnaliseVisual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnalise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Adiciona;
        private System.Windows.Forms.ToolStripMenuItem btn_Edita;
        private System.Windows.Forms.ToolStripMenuItem btn_Exclui;
        private System.Windows.Forms.ToolStripMenuItem btn_LimparTodosOsCampos;
        private System.Windows.Forms.ToolStripMenuItem btn_ImprimeQuadriculado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.DataGridView dataGridAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_Nome;
        private System.Windows.Forms.ComboBox cbx_Pesquisa;
    }
}