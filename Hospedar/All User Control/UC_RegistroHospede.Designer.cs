
namespace Hospedar.All_User_Control
{
    partial class UC_RegistroHospede
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNacionalidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDtNascimento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCama = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipoQuarto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroQuarto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddHospede = new Guna.UI2.WinForms.Guna2Button();
            this.txtEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Hospede";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Hospede";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nacionalidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gênero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.Parent = this.txtNome;
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedState.Parent = this.txtNome;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(103, 180);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "Insira o Nome Completo";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(309, 36);
            this.txtNome.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNome.TabIndex = 8;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.DefaultText = "";
            this.txtTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.DisabledState.Parent = this.txtTelefone;
            this.txtTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.FocusedState.Parent = this.txtTelefone;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.HoverState.Parent = this.txtTelefone;
            this.txtTelefone.Location = new System.Drawing.Point(103, 282);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PlaceholderText = "Insira o Número de Telefone";
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.ShadowDecoration.Parent = this.txtTelefone;
            this.txtTelefone.Size = new System.Drawing.Size(309, 36);
            this.txtTelefone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTelefone.TabIndex = 9;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNacionalidade.DefaultText = "";
            this.txtNacionalidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNacionalidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNacionalidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNacionalidade.DisabledState.Parent = this.txtNacionalidade;
            this.txtNacionalidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNacionalidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNacionalidade.FocusedState.Parent = this.txtNacionalidade;
            this.txtNacionalidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNacionalidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNacionalidade.HoverState.Parent = this.txtNacionalidade;
            this.txtNacionalidade.Location = new System.Drawing.Point(103, 384);
            this.txtNacionalidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.PasswordChar = '\0';
            this.txtNacionalidade.PlaceholderText = "Insira o País de Origem";
            this.txtNacionalidade.SelectedText = "";
            this.txtNacionalidade.ShadowDecoration.Parent = this.txtNacionalidade;
            this.txtNacionalidade.Size = new System.Drawing.Size(309, 36);
            this.txtNacionalidade.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNacionalidade.TabIndex = 10;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.Transparent;
            this.txtGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGenero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenero.FocusedState.Parent = this.txtGenero;
            this.txtGenero.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGenero.HoverState.Parent = this.txtGenero;
            this.txtGenero.ItemHeight = 30;
            this.txtGenero.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Outro"});
            this.txtGenero.ItemsAppearance.Parent = this.txtGenero;
            this.txtGenero.Location = new System.Drawing.Point(103, 489);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ShadowDecoration.Parent = this.txtGenero;
            this.txtGenero.Size = new System.Drawing.Size(309, 36);
            this.txtGenero.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGenero.TabIndex = 11;
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.txtDtNascimento.CheckedState.ForeColor = System.Drawing.Color.White;
            this.txtDtNascimento.CheckedState.Parent = this.txtDtNascimento;
            this.txtDtNascimento.FillColor = System.Drawing.Color.LightSkyBlue;
            this.txtDtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtNascimento.ForeColor = System.Drawing.Color.Black;
            this.txtDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtNascimento.HoverState.Parent = this.txtDtNascimento;
            this.txtDtNascimento.Location = new System.Drawing.Point(103, 585);
            this.txtDtNascimento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDtNascimento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.ShadowDecoration.Parent = this.txtDtNascimento;
            this.txtDtNascimento.Size = new System.Drawing.Size(309, 36);
            this.txtDtNascimento.TabIndex = 13;
            this.txtDtNascimento.Value = new System.DateTime(2021, 11, 22, 13, 43, 22, 535);
            // 
            // txtCheckin
            // 
            this.txtCheckin.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCheckin.CheckedState.ForeColor = System.Drawing.Color.White;
            this.txtCheckin.CheckedState.Parent = this.txtCheckin;
            this.txtCheckin.FillColor = System.Drawing.Color.LightSkyBlue;
            this.txtCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckin.ForeColor = System.Drawing.Color.Black;
            this.txtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckin.HoverState.Parent = this.txtCheckin;
            this.txtCheckin.Location = new System.Drawing.Point(561, 384);
            this.txtCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.ShadowDecoration.Parent = this.txtCheckin;
            this.txtCheckin.Size = new System.Drawing.Size(309, 36);
            this.txtCheckin.TabIndex = 19;
            this.txtCheckin.Value = new System.DateTime(2021, 11, 22, 13, 32, 38, 709);
            this.txtCheckin.ValueChanged += new System.EventHandler(this.guna2DateTimePicker2_ValueChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.DefaultText = "";
            this.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.DisabledState.Parent = this.txtPreco;
            this.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.FocusedState.Parent = this.txtPreco;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.HoverState.Parent = this.txtPreco;
            this.txtPreco.Location = new System.Drawing.Point(1002, 489);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderText = "";
            this.txtPreco.SelectedText = "";
            this.txtPreco.ShadowDecoration.Parent = this.txtPreco;
            this.txtPreco.Size = new System.Drawing.Size(309, 36);
            this.txtPreco.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPreco.TabIndex = 18;
            // 
            // txtCpf
            // 
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.DefaultText = "";
            this.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.DisabledState.Parent = this.txtCpf;
            this.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.FocusedState.Parent = this.txtCpf;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.HoverState.Parent = this.txtCpf;
            this.txtCpf.Location = new System.Drawing.Point(561, 180);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PlaceholderText = "Insira o CPF";
            this.txtCpf.SelectedText = "";
            this.txtCpf.ShadowDecoration.Parent = this.txtCpf;
            this.txtCpf.Size = new System.Drawing.Size(309, 36);
            this.txtCpf.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCpf.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(557, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Check in";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(998, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Preço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(557, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "CPF";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCama
            // 
            this.txtCama.BackColor = System.Drawing.Color.Transparent;
            this.txtCama.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCama.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCama.FocusedState.Parent = this.txtCama;
            this.txtCama.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCama.HoverState.Parent = this.txtCama;
            this.txtCama.ItemHeight = 30;
            this.txtCama.Items.AddRange(new object[] {
            "Solteiro",
            "Casal Queen Size",
            "Casal King Size",
            "Dormitório"});
            this.txtCama.ItemsAppearance.Parent = this.txtCama;
            this.txtCama.Location = new System.Drawing.Point(1002, 180);
            this.txtCama.Name = "txtCama";
            this.txtCama.ShadowDecoration.Parent = this.txtCama;
            this.txtCama.Size = new System.Drawing.Size(309, 36);
            this.txtCama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCama.TabIndex = 21;
            this.txtCama.SelectedIndexChanged += new System.EventHandler(this.txtCama_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(998, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipo de Cama";
            // 
            // txtTipoQuarto
            // 
            this.txtTipoQuarto.BackColor = System.Drawing.Color.Transparent;
            this.txtTipoQuarto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTipoQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoQuarto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoQuarto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoQuarto.FocusedState.Parent = this.txtTipoQuarto;
            this.txtTipoQuarto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTipoQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoQuarto.HoverState.Parent = this.txtTipoQuarto;
            this.txtTipoQuarto.ItemHeight = 30;
            this.txtTipoQuarto.Items.AddRange(new object[] {
            "Quarto individual",
            "Quarto duplo individual",
            "Quarto twin ",
            "Quarto de casal ",
            "Quarto Triplo ",
            "Quarto quádruplo ",
            "Dormitório "});
            this.txtTipoQuarto.ItemsAppearance.Parent = this.txtTipoQuarto;
            this.txtTipoQuarto.Location = new System.Drawing.Point(1002, 282);
            this.txtTipoQuarto.Name = "txtTipoQuarto";
            this.txtTipoQuarto.ShadowDecoration.Parent = this.txtTipoQuarto;
            this.txtTipoQuarto.Size = new System.Drawing.Size(309, 36);
            this.txtTipoQuarto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTipoQuarto.TabIndex = 23;
            this.txtTipoQuarto.SelectedIndexChanged += new System.EventHandler(this.txtTipoQuarto_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(998, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tipo de Quarto";
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.BackColor = System.Drawing.Color.Transparent;
            this.txtNumeroQuarto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtNumeroQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNumeroQuarto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroQuarto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroQuarto.FocusedState.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNumeroQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroQuarto.HoverState.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.ItemHeight = 30;
            this.txtNumeroQuarto.ItemsAppearance.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.Location = new System.Drawing.Point(1002, 384);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.ShadowDecoration.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.Size = new System.Drawing.Size(309, 36);
            this.txtNumeroQuarto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNumeroQuarto.TabIndex = 25;
            this.txtNumeroQuarto.SelectedIndexChanged += new System.EventHandler(this.txtNumeroQuarto_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(998, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "Número do Quarto";
            // 
            // btnAddHospede
            // 
            this.btnAddHospede.BorderRadius = 22;
            this.btnAddHospede.BorderThickness = 1;
            this.btnAddHospede.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddHospede.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddHospede.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddHospede.CheckedState.Parent = this.btnAddHospede;
            this.btnAddHospede.CustomImages.Parent = this.btnAddHospede;
            this.btnAddHospede.FillColor = System.Drawing.Color.White;
            this.btnAddHospede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHospede.ForeColor = System.Drawing.Color.Black;
            this.btnAddHospede.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddHospede.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddHospede.HoverState.Parent = this.btnAddHospede;
            this.btnAddHospede.Location = new System.Drawing.Point(1118, 576);
            this.btnAddHospede.Name = "btnAddHospede";
            this.btnAddHospede.ShadowDecoration.Parent = this.btnAddHospede;
            this.btnAddHospede.Size = new System.Drawing.Size(193, 45);
            this.btnAddHospede.TabIndex = 26;
            this.btnAddHospede.Text = "Reservar Quarto";
            this.btnAddHospede.Click += new System.EventHandler(this.btnAddHospede_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.DefaultText = "";
            this.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.DisabledState.Parent = this.txtEndereco;
            this.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.FocusedState.Parent = this.txtEndereco;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.HoverState.Parent = this.txtEndereco;
            this.txtEndereco.Location = new System.Drawing.Point(561, 282);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PlaceholderText = "Insira o Endereço Completo";
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.ShadowDecoration.Parent = this.txtEndereco;
            this.txtEndereco.Size = new System.Drawing.Size(309, 36);
            this.txtEndereco.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEndereco.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(557, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Endereço";
            // 
            // UC_RegistroHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAddHospede);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTipoQuarto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCheckin);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDtNascimento);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_RegistroHospede";
            this.Size = new System.Drawing.Size(1407, 714);
            this.Load += new System.EventHandler(this.UC_RegistroHospede_Load);
            this.Leave += new System.EventHandler(this.UC_RegistroHospede_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDtNascimento;
        private Guna.UI2.WinForms.Guna2ComboBox txtGenero;
        private Guna.UI2.WinForms.Guna2TextBox txtNacionalidade;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefone;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckin;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
        private Guna.UI2.WinForms.Guna2TextBox txtCpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox txtNumeroQuarto;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox txtTipoQuarto;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox txtCama;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnAddHospede;
        private Guna.UI2.WinForms.Guna2TextBox txtEndereco;
        private System.Windows.Forms.Label label13;
    }
}
