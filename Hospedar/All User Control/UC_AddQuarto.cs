using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedar.All_User_Control
{
    public partial class UC_AddQuarto : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddQuarto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtNumeroQuarto.Text != "" && txtTipoQuarto.Text != "" && txtTipoCama.Text != "" && txtPrecoQuarto.Text != "")
            {
                String quartono = txtNumeroQuarto.Text;
                String tipoquarto = txtTipoQuarto.Text;
                String tipocama = txtTipoCama.Text;
                Int64 precoquarto = Int64.Parse(txtPrecoQuarto.Text);

                query = "insert into quartos (quartoNo,quartoTipo,cama,preco) values ('"+quartono+ "','" +tipoquarto+"','"+tipocama+"',"+precoquarto+")";
                fn.setData(query, "Quarto Adicionado");

                UC_AddQuarto_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtNumeroQuarto.Clear();
            txtTipoQuarto.SelectedIndex = -1;
            txtTipoCama.SelectedIndex = -1;
            txtPrecoQuarto.Clear();
        }

        private void UC_AddQuarto_Load(object sender, EventArgs e)
        {
            query = "select * from quartos";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_AddQuarto_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddQuarto_Enter(object sender, EventArgs e)
        {
            UC_AddQuarto_Load(this, null);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
