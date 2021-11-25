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
    public partial class UC_CheckoutHospede : UserControl
    {
        function fn = new function();
        String query;
        public UC_CheckoutHospede()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_CheckoutHospede_Load(object sender, EventArgs e)
        {
            query = "select Hospedes.hid, Hospedes.hnome, Hospedes.telefone, Hospedes.nacionalidade, Hospedes.genero, Hospedes.dtnascimento, Hospedes.cpf, Hospedes.endereco, Hospedes.checkin, quartos.quartoNo, quartos.quartoTipo, quartos.cama, quartos.preco from Hospedes inner join quartos on Hospedes.quartoid = quartos.quartoid where chekout = 'NAO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            query = "select Hospedes.hid, Hospedes.hnome, Hospedes.telefone, Hospedes.nacionalidade, Hospedes.genero, Hospedes.dtnascimento, Hospedes.cpf, Hospedes.endereco, Hospedes.checkin, quartos.quartoNo, quartos.quartoTipo, quartos.cama, quartos.preco from Hospedes inner join quartos on Hospedes.quartoid = quartos.quartoid where hnome like '" + txtNome.Text + "%' and chekout = 'NAO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtHNome.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNumeroQuarto.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtHNome.Text != "")
            {
                if (MessageBox.Show("Deseja Prosseguir?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String hdate = txtCheckOutDate.Text;
                    query = "update Hospedes set chekout = 'SIM', checkout = '"+hdate+"' where hid = "+id+" update quartos set reservado = 'NAO' where quartoNo = '"+txtNumeroQuarto.Text+"'";
                    fn.setData(query, "Check Out Realizado com Sucesso");
                    UC_CheckoutHospede_Load(this, null);
                    clearAll();

                }
            }
            else
            {
                MessageBox.Show("Nenhum Hospede Selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtHNome.Clear();
            txtNome.Clear();
            txtNumeroQuarto.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CheckoutHospede_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
