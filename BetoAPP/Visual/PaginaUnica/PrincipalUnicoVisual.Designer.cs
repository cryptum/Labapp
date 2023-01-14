namespace LabAPP.Visual.PaginaUnica
{
    partial class PrincipalUnicoVisual
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Recarregar = new System.Windows.Forms.Button();
            this.btn_Quadriculado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 177);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1517, 832);
            this.dataGridView.TabIndex = 4;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Novo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Novo.Image = global::LabAPP.Properties.Resources.file_add_fill_azul_32px;
            this.btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Novo.Location = new System.Drawing.Point(17, 20);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(273, 90);
            this.btn_Novo.TabIndex = 10;
            this.btn_Novo.Text = "Criar";
            this.btn_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Recarregar
            // 
            this.btn_Recarregar.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Recarregar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Recarregar.Image = global::LabAPP.Properties.Resources.refresh_line_azul_32px;
            this.btn_Recarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Recarregar.Location = new System.Drawing.Point(343, 20);
            this.btn_Recarregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Recarregar.Name = "btn_Recarregar";
            this.btn_Recarregar.Size = new System.Drawing.Size(273, 90);
            this.btn_Recarregar.TabIndex = 11;
            this.btn_Recarregar.Text = "Recarregar";
            this.btn_Recarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Recarregar.UseVisualStyleBackColor = true;
            this.btn_Recarregar.Click += new System.EventHandler(this.btn_Recarregar_Click);
            // 
            // btn_Quadriculado
            // 
            this.btn_Quadriculado.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Quadriculado.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Quadriculado.Image = global::LabAPP.Properties.Resources.grid_line_azul_32px;
            this.btn_Quadriculado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Quadriculado.Location = new System.Drawing.Point(669, 20);
            this.btn_Quadriculado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Quadriculado.Name = "btn_Quadriculado";
            this.btn_Quadriculado.Size = new System.Drawing.Size(273, 90);
            this.btn_Quadriculado.TabIndex = 13;
            this.btn_Quadriculado.Text = "Quadriculado";
            this.btn_Quadriculado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Quadriculado.UseVisualStyleBackColor = true;
            this.btn_Quadriculado.Click += new System.EventHandler(this.btn_Quadriculado_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Image = global::LabAPP.Properties.Resources.grid_line_azul_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(994, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 90);
            this.button1.TabIndex = 14;
            this.button1.Text = "Laudo";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PrincipalUnicoVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Quadriculado);
            this.Controls.Add(this.btn_Recarregar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrincipalUnicoVisual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalUnicoVisual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalUnicoVisual_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Recarregar;
        private System.Windows.Forms.Button btn_Quadriculado;
        private System.Windows.Forms.Button button1;
    }
}