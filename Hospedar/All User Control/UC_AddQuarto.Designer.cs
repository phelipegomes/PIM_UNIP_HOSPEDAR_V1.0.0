
namespace Hospedar.All_User_Control
{
    partial class UC_AddQuarto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroQuarto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecoQuarto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipoQuarto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTipoCama = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddQuarto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Novo Quarto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(38, 98);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(926, 572);
            this.guna2DataGridView1.TabIndex = 1;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1042, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número do Quarto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1042, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Quarto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1042, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Cama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1042, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Preço";
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroQuarto.DefaultText = "";
            this.txtNumeroQuarto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroQuarto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroQuarto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroQuarto.DisabledState.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroQuarto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroQuarto.FocusedState.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroQuarto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroQuarto.HoverState.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.Location = new System.Drawing.Point(1046, 129);
            this.txtNumeroQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.PasswordChar = '\0';
            this.txtNumeroQuarto.PlaceholderText = "";
            this.txtNumeroQuarto.SelectedText = "";
            this.txtNumeroQuarto.ShadowDecoration.Parent = this.txtNumeroQuarto;
            this.txtNumeroQuarto.Size = new System.Drawing.Size(309, 36);
            this.txtNumeroQuarto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNumeroQuarto.TabIndex = 6;
            // 
            // txtPrecoQuarto
            // 
            this.txtPrecoQuarto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoQuarto.DefaultText = "";
            this.txtPrecoQuarto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecoQuarto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecoQuarto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoQuarto.DisabledState.Parent = this.txtPrecoQuarto;
            this.txtPrecoQuarto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecoQuarto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoQuarto.FocusedState.Parent = this.txtPrecoQuarto;
            this.txtPrecoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoQuarto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecoQuarto.HoverState.Parent = this.txtPrecoQuarto;
            this.txtPrecoQuarto.Location = new System.Drawing.Point(1046, 405);
            this.txtPrecoQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecoQuarto.Name = "txtPrecoQuarto";
            this.txtPrecoQuarto.PasswordChar = '\0';
            this.txtPrecoQuarto.PlaceholderText = "";
            this.txtPrecoQuarto.SelectedText = "";
            this.txtPrecoQuarto.ShadowDecoration.Parent = this.txtPrecoQuarto;
            this.txtPrecoQuarto.Size = new System.Drawing.Size(309, 36);
            this.txtPrecoQuarto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrecoQuarto.TabIndex = 7;
            // 
            // txtTipoQuarto
            // 
            this.txtTipoQuarto.BackColor = System.Drawing.Color.Transparent;
            this.txtTipoQuarto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTipoQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoQuarto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoQuarto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoQuarto.FocusedState.Parent = this.txtTipoQuarto;
            this.txtTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
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
            this.txtTipoQuarto.Location = new System.Drawing.Point(1046, 230);
            this.txtTipoQuarto.Name = "txtTipoQuarto";
            this.txtTipoQuarto.ShadowDecoration.Parent = this.txtTipoQuarto;
            this.txtTipoQuarto.Size = new System.Drawing.Size(309, 36);
            this.txtTipoQuarto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTipoQuarto.TabIndex = 8;
            // 
            // txtTipoCama
            // 
            this.txtTipoCama.BackColor = System.Drawing.Color.Transparent;
            this.txtTipoCama.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTipoCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoCama.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoCama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoCama.FocusedState.Parent = this.txtTipoCama;
            this.txtTipoCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtTipoCama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoCama.HoverState.Parent = this.txtTipoCama;
            this.txtTipoCama.ItemHeight = 30;
            this.txtTipoCama.Items.AddRange(new object[] {
            "Solteiro",
            "Casal Queen Size",
            "Casal King Size",
            "Dormitório"});
            this.txtTipoCama.ItemsAppearance.Parent = this.txtTipoCama;
            this.txtTipoCama.Location = new System.Drawing.Point(1046, 322);
            this.txtTipoCama.Name = "txtTipoCama";
            this.txtTipoCama.ShadowDecoration.Parent = this.txtTipoCama;
            this.txtTipoCama.Size = new System.Drawing.Size(309, 36);
            this.txtTipoCama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTipoCama.TabIndex = 9;
            // 
            // btnAddQuarto
            // 
            this.btnAddQuarto.BorderRadius = 22;
            this.btnAddQuarto.BorderThickness = 1;
            this.btnAddQuarto.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddQuarto.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddQuarto.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddQuarto.CheckedState.Parent = this.btnAddQuarto;
            this.btnAddQuarto.CustomImages.Parent = this.btnAddQuarto;
            this.btnAddQuarto.FillColor = System.Drawing.Color.White;
            this.btnAddQuarto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuarto.ForeColor = System.Drawing.Color.Black;
            this.btnAddQuarto.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddQuarto.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddQuarto.HoverState.Parent = this.btnAddQuarto;
            this.btnAddQuarto.Location = new System.Drawing.Point(1212, 506);
            this.btnAddQuarto.Name = "btnAddQuarto";
            this.btnAddQuarto.ShadowDecoration.Parent = this.btnAddQuarto;
            this.btnAddQuarto.Size = new System.Drawing.Size(143, 45);
            this.btnAddQuarto.TabIndex = 10;
            this.btnAddQuarto.Text = "Salvar";
            this.btnAddQuarto.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_AddQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddQuarto);
            this.Controls.Add(this.txtTipoCama);
            this.Controls.Add(this.txtTipoQuarto);
            this.Controls.Add(this.txtPrecoQuarto);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddQuarto";
            this.Size = new System.Drawing.Size(1407, 714);
            this.Load += new System.EventHandler(this.UC_AddQuarto_Load);
            this.Enter += new System.EventHandler(this.UC_AddQuarto_Enter);
            this.Leave += new System.EventHandler(this.UC_AddQuarto_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroQuarto;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecoQuarto;
        private Guna.UI2.WinForms.Guna2ComboBox txtTipoQuarto;
        private Guna.UI2.WinForms.Guna2ComboBox txtTipoCama;
        private Guna.UI2.WinForms.Guna2Button btnAddQuarto;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
