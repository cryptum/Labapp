
namespace BetoAPP
{
    partial class LoginVisual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVisual));
            this.btn_Acessar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbCarregar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sair = new System.Windows.Forms.PictureBox();
            this.btn_Minimiza = new System.Windows.Forms.PictureBox();
            this.pnl_Usuario = new System.Windows.Forms.Panel();
            this.pnl_Senha = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimiza)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Acessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Acessar.FlatAppearance.BorderSize = 0;
            this.btn_Acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acessar.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Acessar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Acessar.Location = new System.Drawing.Point(177, 445);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(116, 45);
            this.btn_Acessar.TabIndex = 0;
            this.btn_Acessar.Text = "Acessar";
            this.btn_Acessar.UseVisualStyleBackColor = false;
            this.btn_Acessar.Click += new System.EventHandler(this.btn_Acessar_Click);
            this.btn_Acessar.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Acessar_Paint);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Usuario.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Usuario.Location = new System.Drawing.Point(168, 183);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(190, 33);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Usuario_KeyDown);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Senha.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Senha.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Senha.Location = new System.Drawing.Point(168, 263);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(190, 33);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(55, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 521);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BetoAPP.Properties.Resources.AgroFrutal;
            this.pictureBox1.Location = new System.Drawing.Point(47, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pcbCarregar
            // 
            this.pcbCarregar.Image = global::BetoAPP.Properties.Resources.Eclipse_0_6s_200px;
            this.pcbCarregar.Location = new System.Drawing.Point(157, 318);
            this.pcbCarregar.Name = "pcbCarregar";
            this.pcbCarregar.Size = new System.Drawing.Size(147, 121);
            this.pcbCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarregar.TabIndex = 7;
            this.pcbCarregar.TabStop = false;
            this.pcbCarregar.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.pcbCarregar);
            this.panel2.Controls.Add(this.btn_Sair);
            this.panel2.Controls.Add(this.btn_Minimiza);
            this.panel2.Controls.Add(this.btn_Acessar);
            this.panel2.Controls.Add(this.pnl_Usuario);
            this.panel2.Controls.Add(this.txt_Usuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pnl_Senha);
            this.panel2.Controls.Add(this.txt_Senha);
            this.panel2.Location = new System.Drawing.Point(384, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 521);
            this.panel2.TabIndex = 6;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.Image = global::BetoAPP.Properties.Resources.close_line;
            this.btn_Sair.Location = new System.Drawing.Point(370, 0);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(61, 61);
            this.btn_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.TabStop = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            this.btn_Sair.MouseLeave += new System.EventHandler(this.btn_Sair_MouseLeave);
            this.btn_Sair.MouseHover += new System.EventHandler(this.btn_Sair_MouseHover);
            // 
            // btn_Minimiza
            // 
            this.btn_Minimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimiza.Image = global::BetoAPP.Properties.Resources.subtract_line;
            this.btn_Minimiza.Location = new System.Drawing.Point(321, 0);
            this.btn_Minimiza.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimiza.Name = "btn_Minimiza";
            this.btn_Minimiza.Size = new System.Drawing.Size(60, 61);
            this.btn_Minimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Minimiza.TabIndex = 6;
            this.btn_Minimiza.TabStop = false;
            this.btn_Minimiza.Click += new System.EventHandler(this.btn_Minimiza_Click);
            this.btn_Minimiza.MouseLeave += new System.EventHandler(this.btn_Minimiza_MouseLeave);
            this.btn_Minimiza.MouseHover += new System.EventHandler(this.btn_Minimiza_MouseHover);
            // 
            // pnl_Usuario
            // 
            this.pnl_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_Usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Usuario.Location = new System.Drawing.Point(168, 213);
            this.pnl_Usuario.Name = "pnl_Usuario";
            this.pnl_Usuario.Size = new System.Drawing.Size(190, 5);
            this.pnl_Usuario.TabIndex = 1;
            // 
            // pnl_Senha
            // 
            this.pnl_Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_Senha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_Senha.Location = new System.Drawing.Point(168, 293);
            this.pnl_Senha.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Senha.Name = "pnl_Senha";
            this.pnl_Senha.Size = new System.Drawing.Size(190, 5);
            this.pnl_Senha.TabIndex = 0;
            // 
            // LoginVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "LoginVisual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarregar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimiza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Acessar;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Usuario;
        private System.Windows.Forms.Panel pnl_Senha;
        private System.Windows.Forms.PictureBox btn_Sair;
        private System.Windows.Forms.PictureBox btn_Minimiza;
        private System.Windows.Forms.PictureBox pcbCarregar;
    }
}

