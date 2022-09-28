
namespace LabAPP
{
    partial class LoginVisualBeto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVisualBeto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_PaginaUnica = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.PictureBox();
            this.btn_Minimiza = new System.Windows.Forms.PictureBox();
            this.btn_LabApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimiza)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LabAPP.Properties.Resources.AgroFrutal;
            this.pictureBox1.Location = new System.Drawing.Point(4, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btn_PaginaUnica);
            this.panel3.Controls.Add(this.btn_Sair);
            this.panel3.Controls.Add(this.btn_Minimiza);
            this.panel3.Controls.Add(this.btn_LabApp);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(696, 490);
            this.panel3.TabIndex = 7;
            // 
            // btn_PaginaUnica
            // 
            this.btn_PaginaUnica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PaginaUnica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_PaginaUnica.FlatAppearance.BorderSize = 0;
            this.btn_PaginaUnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PaginaUnica.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PaginaUnica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_PaginaUnica.Location = new System.Drawing.Point(370, 400);
            this.btn_PaginaUnica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PaginaUnica.Name = "btn_PaginaUnica";
            this.btn_PaginaUnica.Size = new System.Drawing.Size(313, 75);
            this.btn_PaginaUnica.TabIndex = 9;
            this.btn_PaginaUnica.Text = "Página Única";
            this.btn_PaginaUnica.UseVisualStyleBackColor = false;
            this.btn_PaginaUnica.Click += new System.EventHandler(this.btn_PaginaUnica_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.Image = global::LabAPP.Properties.Resources.close_cinza_24px;
            this.btn_Sair.Location = new System.Drawing.Point(605, 0);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(87, 102);
            this.btn_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.TabStop = false;
            // 
            // btn_Minimiza
            // 
            this.btn_Minimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimiza.Image = global::LabAPP.Properties.Resources.subtract_cinza_24px;
            this.btn_Minimiza.Location = new System.Drawing.Point(518, 0);
            this.btn_Minimiza.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimiza.Name = "btn_Minimiza";
            this.btn_Minimiza.Size = new System.Drawing.Size(86, 102);
            this.btn_Minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Minimiza.TabIndex = 7;
            this.btn_Minimiza.TabStop = false;
            // 
            // btn_LabApp
            // 
            this.btn_LabApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LabApp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_LabApp.FlatAppearance.BorderSize = 0;
            this.btn_LabApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LabApp.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LabApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LabApp.Location = new System.Drawing.Point(14, 400);
            this.btn_LabApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LabApp.Name = "btn_LabApp";
            this.btn_LabApp.Size = new System.Drawing.Size(184, 75);
            this.btn_LabApp.TabIndex = 0;
            this.btn_LabApp.Text = "LabApp";
            this.btn_LabApp.UseVisualStyleBackColor = false;
            this.btn_LabApp.Click += new System.EventHandler(this.btn_LabApp_Click);
            // 
            // LoginVisualBeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 489);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginVisualBeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimiza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_PaginaUnica;
        private System.Windows.Forms.PictureBox btn_Sair;
        private System.Windows.Forms.PictureBox btn_Minimiza;
        private System.Windows.Forms.Button btn_LabApp;
    }
}

