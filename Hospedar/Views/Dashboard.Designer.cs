using Hospedar.All_User_Control;
namespace Hospedar.Views
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnHospedes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovoHospede = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservarQuarto = new Guna.UI2.WinForms.Guna2Button();
            this.panelX = new System.Windows.Forms.Panel();
            this.uC_Usuarios1 = new All_User_Control.UC_Usuarios();
            this.uC_DetalhesHospedes1 = new All_User_Control.UC_DetalhesHospedes();
            this.uC_CheckoutHospede1 = new All_User_Control.UC_CheckoutHospede();
            this.uC_RegistroHospede1 = new All_User_Control.UC_RegistroHospede();
            this.uC_AddQuarto2 = new All_User_Control.UC_AddQuarto();
            this.btnSair = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panelX.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnHospedes);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnNovoHospede);
            this.panel1.Controls.Add(this.btnReservarQuarto);
            this.panel1.Location = new System.Drawing.Point(58, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 142);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Animated = true;
            this.btnUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsuarios.CheckedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.CheckedState.Parent = this.btnUsuarios;
            this.btnUsuarios.CustomBorderColor = System.Drawing.Color.White;
            this.btnUsuarios.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.CustomImages.Parent = this.btnUsuarios;
            this.btnUsuarios.FillColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsuarios.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsuarios.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsuarios.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.HoverState.Parent = this.btnUsuarios;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUsuarios.Location = new System.Drawing.Point(1042, 19);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.ShadowDecoration.Parent = this.btnUsuarios;
            this.btnUsuarios.Size = new System.Drawing.Size(202, 108);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHospedes
            // 
            this.btnHospedes.Animated = true;
            this.btnHospedes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHospedes.CheckedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHospedes.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHospedes.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHospedes.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHospedes.CheckedState.Parent = this.btnHospedes;
            this.btnHospedes.CustomBorderColor = System.Drawing.Color.White;
            this.btnHospedes.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnHospedes.CustomImages.Parent = this.btnHospedes;
            this.btnHospedes.FillColor = System.Drawing.Color.Transparent;
            this.btnHospedes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHospedes.ForeColor = System.Drawing.Color.White;
            this.btnHospedes.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnHospedes.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnHospedes.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnHospedes.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHospedes.HoverState.Parent = this.btnHospedes;
            this.btnHospedes.Image = ((System.Drawing.Image)(resources.GetObject("btnHospedes.Image")));
            this.btnHospedes.ImageSize = new System.Drawing.Size(45, 55);
            this.btnHospedes.Location = new System.Drawing.Point(802, 19);
            this.btnHospedes.Name = "btnHospedes";
            this.btnHospedes.ShadowDecoration.Parent = this.btnHospedes;
            this.btnHospedes.Size = new System.Drawing.Size(210, 108);
            this.btnHospedes.TabIndex = 8;
            this.btnHospedes.Text = "Hospedes";
            this.btnHospedes.Click += new System.EventHandler(this.btnHospedes_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Animated = true;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckOut.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomBorderColor = System.Drawing.Color.White;
            this.btnCheckOut.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckOut.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckOut.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckOut.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckOut.Location = new System.Drawing.Point(555, 19);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(216, 108);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnNovoHospede
            // 
            this.btnNovoHospede.Animated = true;
            this.btnNovoHospede.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoHospede.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNovoHospede.CheckedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNovoHospede.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNovoHospede.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNovoHospede.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnNovoHospede.CheckedState.Parent = this.btnNovoHospede;
            this.btnNovoHospede.CustomBorderColor = System.Drawing.Color.White;
            this.btnNovoHospede.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnNovoHospede.CustomImages.Parent = this.btnNovoHospede;
            this.btnNovoHospede.FillColor = System.Drawing.Color.Transparent;
            this.btnNovoHospede.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNovoHospede.ForeColor = System.Drawing.Color.White;
            this.btnNovoHospede.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnNovoHospede.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnNovoHospede.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnNovoHospede.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNovoHospede.HoverState.Parent = this.btnNovoHospede;
            this.btnNovoHospede.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoHospede.Image")));
            this.btnNovoHospede.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNovoHospede.Location = new System.Drawing.Point(297, 19);
            this.btnNovoHospede.Name = "btnNovoHospede";
            this.btnNovoHospede.ShadowDecoration.Parent = this.btnNovoHospede;
            this.btnNovoHospede.Size = new System.Drawing.Size(226, 108);
            this.btnNovoHospede.TabIndex = 6;
            this.btnNovoHospede.Text = "Novo Hóspede";
            this.btnNovoHospede.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnReservarQuarto
            // 
            this.btnReservarQuarto.Animated = true;
            this.btnReservarQuarto.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReservarQuarto.CheckedState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReservarQuarto.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReservarQuarto.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReservarQuarto.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnReservarQuarto.CheckedState.Parent = this.btnReservarQuarto;
            this.btnReservarQuarto.CustomBorderColor = System.Drawing.Color.White;
            this.btnReservarQuarto.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnReservarQuarto.CustomImages.Parent = this.btnReservarQuarto;
            this.btnReservarQuarto.FillColor = System.Drawing.Color.Transparent;
            this.btnReservarQuarto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReservarQuarto.ForeColor = System.Drawing.Color.White;
            this.btnReservarQuarto.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnReservarQuarto.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnReservarQuarto.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnReservarQuarto.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReservarQuarto.HoverState.Parent = this.btnReservarQuarto;
            this.btnReservarQuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnReservarQuarto.Image")));
            this.btnReservarQuarto.ImageSize = new System.Drawing.Size(60, 60);
            this.btnReservarQuarto.Location = new System.Drawing.Point(13, 19);
            this.btnReservarQuarto.Name = "btnReservarQuarto";
            this.btnReservarQuarto.ShadowDecoration.Parent = this.btnReservarQuarto;
            this.btnReservarQuarto.Size = new System.Drawing.Size(253, 108);
            this.btnReservarQuarto.TabIndex = 5;
            this.btnReservarQuarto.Text = "Reservar Quarto";
            this.btnReservarQuarto.Click += new System.EventHandler(this.btnReservarQuarto_Click);
            // 
            // panelX
            // 
            this.panelX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelX.Controls.Add(this.uC_Usuarios1);
            this.panelX.Controls.Add(this.uC_DetalhesHospedes1);
            this.panelX.Controls.Add(this.uC_CheckoutHospede1);
            this.panelX.Controls.Add(this.uC_RegistroHospede1);
            this.panelX.Controls.Add(this.uC_AddQuarto2);
            this.panelX.Location = new System.Drawing.Point(12, 161);
            this.panelX.Margin = new System.Windows.Forms.Padding(4);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(1302, 505);
            this.panelX.TabIndex = 1;
            // 
            // uC_Usuarios1
            // 
            this.uC_Usuarios1.BackColor = System.Drawing.Color.White;
            this.uC_Usuarios1.Location = new System.Drawing.Point(3, 3);
            this.uC_Usuarios1.Name = "uC_Usuarios1";
            this.uC_Usuarios1.Size = new System.Drawing.Size(1407, 714);
            this.uC_Usuarios1.TabIndex = 4;
            // 
            // uC_DetalhesHospedes1
            // 
            this.uC_DetalhesHospedes1.BackColor = System.Drawing.Color.White;
            this.uC_DetalhesHospedes1.Location = new System.Drawing.Point(3, 3);
            this.uC_DetalhesHospedes1.Name = "uC_DetalhesHospedes1";
            this.uC_DetalhesHospedes1.Size = new System.Drawing.Size(1407, 714);
            this.uC_DetalhesHospedes1.TabIndex = 3;
            // 
            // uC_CheckoutHospede1
            // 
            this.uC_CheckoutHospede1.BackColor = System.Drawing.Color.White;
            this.uC_CheckoutHospede1.Location = new System.Drawing.Point(3, 3);
            this.uC_CheckoutHospede1.Name = "uC_CheckoutHospede1";
            this.uC_CheckoutHospede1.Size = new System.Drawing.Size(1407, 714);
            this.uC_CheckoutHospede1.TabIndex = 2;
            // 
            // uC_RegistroHospede1
            // 
            this.uC_RegistroHospede1.BackColor = System.Drawing.Color.White;
            this.uC_RegistroHospede1.Location = new System.Drawing.Point(3, 3);
            this.uC_RegistroHospede1.Name = "uC_RegistroHospede1";
            this.uC_RegistroHospede1.Size = new System.Drawing.Size(1407, 714);
            this.uC_RegistroHospede1.TabIndex = 1;
            // 
            // uC_AddQuarto2
            // 
            this.uC_AddQuarto2.BackColor = System.Drawing.Color.White;
            this.uC_AddQuarto2.Location = new System.Drawing.Point(3, 3);
            this.uC_AddQuarto2.Name = "uC_AddQuarto2";
            this.uC_AddQuarto2.Size = new System.Drawing.Size(1407, 714);
            this.uC_AddQuarto2.TabIndex = 0;
            this.uC_AddQuarto2.Load += new System.EventHandler(this.uC_AddQuarto2_Load);
            // 
            // btnSair
            // 
            this.btnSair.Animated = true;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.FillColor = System.Drawing.Color.Empty;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSair.Location = new System.Drawing.Point(12, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Animated = true;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.CheckedState.Parent = this.btnMinimizar;
            this.btnMinimizar.CustomImages.Parent = this.btnMinimizar;
            this.btnMinimizar.FillColor = System.Drawing.Color.Empty;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.HoverState.Parent = this.btnMinimizar;
            this.btnMinimizar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMinimizar.Location = new System.Drawing.Point(12, 48);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(31, 30);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panelX;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.panelX);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panelX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelX;
        private Guna.UI2.WinForms.Guna2CircleButton btnSair;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimizar;
        private Guna.UI2.WinForms.Guna2Button btnReservarQuarto;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnHospedes;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnNovoHospede;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_AddQuarto uC_AddQuarto2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_RegistroHospede uC_RegistroHospede1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_CheckoutHospede uC_CheckoutHospede1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_DetalhesHospedes uC_DetalhesHospedes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_Usuarios uC_Usuarios1;
    }
}