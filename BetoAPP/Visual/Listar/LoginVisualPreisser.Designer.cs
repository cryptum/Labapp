
namespace LabAPP
{
    partial class LoginVisualPreisser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVisualPreisser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_PaginaUnica = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.PictureBox();
            this.btn_LabApp = new System.Windows.Forms.Button();
            this.btn_Minimiza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimiza)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::LabAPP.Properties.Resources.Preisser;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 542);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_PaginaUnica
            // 
            this.btn_PaginaUnica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PaginaUnica.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_PaginaUnica.FlatAppearance.BorderSize = 0;
            this.btn_PaginaUnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PaginaUnica.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PaginaUnica.ForeColor = System.Drawing.Color.White;
            this.btn_PaginaUnica.Location = new System.Drawing.Point(542, 429);
            this.btn_PaginaUnica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PaginaUnica.Name = "btn_PaginaUnica";
            this.btn_PaginaUnica.Size = new System.Drawing.Size(313, 75);
            this.btn_PaginaUnica.TabIndex = 10;
            this.btn_PaginaUnica.Text = "Página Única";
            this.btn_PaginaUnica.UseVisualStyleBackColor = false;
            this.btn_PaginaUnica.Click += new System.EventHandler(this.btn_PaginaUnica_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sair.Image = global::LabAPP.Properties.Resources.close_cinza_24px;
            this.btn_Sair.Location = new System.Drawing.Point(850, 14);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(87, 102);
            this.btn_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.TabStop = false;
            // 
            // btn_LabApp
            // 
            this.btn_LabApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LabApp.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_LabApp.FlatAppearance.BorderSize = 0;
            this.btn_LabApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LabApp.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LabApp.ForeColor = System.Drawing.Color.White;
            this.btn_LabApp.Location = new System.Drawing.Point(169, 429);
            this.btn_LabApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LabApp.Name = "btn_LabApp";
            this.btn_LabApp.Size = new System.Drawing.Size(205, 75);
            this.btn_LabApp.TabIndex = 0;
            this.btn_LabApp.Text = "Lab App";
            this.btn_LabApp.UseVisualStyleBackColor = false;
            this.btn_LabApp.Click += new System.EventHandler(this.btn_LabApp_Click);
            // 
            // btn_Minimiza
            // 
            this.btn_Minimiza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Minimiza.Image = global::LabAPP.Properties.Resources.subtract_cinza_24px;
            this.btn_Minimiza.Location = new System.Drawing.Point(763, 14);
            this.btn_Minimiza.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimiza.Name = "btn_Minimiza";
            this.btn_Minimiza.Size = new System.Drawing.Size(86, 102);
            this.btn_Minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Minimiza.TabIndex = 9;
            this.btn_Minimiza.TabStop = false;
            // 
            // LoginVisualPreisser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 543);
            this.Controls.Add(this.btn_PaginaUnica);
            this.Controls.Add(this.btn_LabApp);
            this.Controls.Add(this.btn_Minimiza);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginVisualPreisser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimiza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Sair;
        private System.Windows.Forms.Button btn_LabApp;
        private System.Windows.Forms.Button btn_PaginaUnica;
        private System.Windows.Forms.PictureBox btn_Minimiza;
    }
}

