
namespace Hospedar
{
    partial class Hospedar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospedar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelError = new System.Windows.Forms.Label();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txbSenha);
            this.panel1.Controls.Add(this.txbUsuario);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(567, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 467);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSair
            // 
            this.btnSair.Animated = true;
            this.btnSair.BorderColor = System.Drawing.Color.White;
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.FillColor = System.Drawing.Color.Empty;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSair.Location = new System.Drawing.Point(236, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(49, 50);
            this.btnSair.TabIndex = 1;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(83, 422);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(137, 13);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Usuario ou Senha Incorreto";
            this.labelError.Visible = false;
            this.labelError.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BorderRadius = 18;
            this.btnEntrar.CheckedState.Parent = this.btnEntrar;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.CustomImages.Parent = this.btnEntrar;
            this.btnEntrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.HoverState.Parent = this.btnEntrar;
            this.btnEntrar.Location = new System.Drawing.Point(50, 371);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.ShadowDecoration.Parent = this.btnEntrar;
            this.btnEntrar.Size = new System.Drawing.Size(200, 36);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txbSenha
            // 
            this.txbSenha.Animated = true;
            this.txbSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbSenha.BorderRadius = 18;
            this.txbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSenha.DefaultText = "";
            this.txbSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSenha.DisabledState.Parent = this.txbSenha;
            this.txbSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSenha.FocusedState.Parent = this.txbSenha;
            this.txbSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSenha.HoverState.Parent = this.txbSenha;
            this.txbSenha.Location = new System.Drawing.Point(50, 310);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.PlaceholderForeColor = System.Drawing.Color.White;
            this.txbSenha.PlaceholderText = "SENHA";
            this.txbSenha.SelectedText = "";
            this.txbSenha.ShadowDecoration.Parent = this.txbSenha;
            this.txbSenha.Size = new System.Drawing.Size(200, 36);
            this.txbSenha.TabIndex = 6;
            this.txbSenha.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Animated = true;
            this.txbUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbUsuario.BorderRadius = 18;
            this.txbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsuario.DefaultText = "";
            this.txbUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsuario.DisabledState.Parent = this.txbUsuario;
            this.txbUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsuario.FocusedState.Parent = this.txbUsuario;
            this.txbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsuario.HoverState.Parent = this.txbUsuario;
            this.txbUsuario.Location = new System.Drawing.Point(50, 268);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.PlaceholderText = "USUARIO";
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.ShadowDecoration.Parent = this.txbUsuario;
            this.txbUsuario.Size = new System.Drawing.Size(200, 36);
            this.txbUsuario.TabIndex = 5;
            this.txbUsuario.TextOffset = new System.Drawing.Point(3, 0);
            this.txbUsuario.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Montserrat Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelLogin.Location = new System.Drawing.Point(56, 226);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(188, 23);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Acesso de Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login de Usuário";
            // 
            // Hospedar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 677);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hospedar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospedar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txbSenha;
        private Guna.UI2.WinForms.Guna2TextBox txbUsuario;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private System.Windows.Forms.Label labelError;
        private Guna.UI2.WinForms.Guna2CircleButton btnSair;
    }
}

