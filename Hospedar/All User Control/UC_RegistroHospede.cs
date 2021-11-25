using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedar.All_User_Control
{
    public partial class UC_RegistroHospede : UserControl
    {
        function fn = new function();
        String query;
        public UC_RegistroHospede()
        {
            InitializeComponent();
        }


        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroQuarto.Items.Clear();
            txtPreco.Clear();
            query = "select quartoNo from quartos where cama = '"+txtCama.Text+"' and quartoTipo= '"+txtTipoQuarto.Text+"' and reservado = 'NAO'";
            setComboBox(query, txtNumeroQuarto);
        }

        private void txtCama_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTipoQuarto.SelectedIndex = -1 ;
            txtNumeroQuarto.Items.Clear();
            txtPreco.Clear();
        }

        int quartoid;

        private void txtNumeroQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select preco, quartoid from quartos where quartoNo = '"+txtNumeroQuarto.Text+"'";
            DataSet ds = fn.getData(query);
            txtPreco.Text = ds.Tables[0].Rows[0][0].ToString();
            quartoid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAddHospede_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtTelefone.Text != "" && txtNacionalidade.Text != "" && txtGenero.Text != "" && txtDtNascimento.Text != "" && txtCpf.Text != "" && txtEndereco.Text != "" && txtCheckin.Text != "" && txtPreco.Text != "")
            {
                String nome = txtNome.Text;
                Int64 tel = Int64.Parse(txtTelefone.Text);
                String nacionalidade = txtNacionalidade.Text;
                String genero = txtGenero.Text;
                String dtnascimento = txtDtNascimento.Text;
                String cpf = txtCpf.Text;
                String endereco = txtEndereco.Text;
                String checkin = txtCheckin.Text;

                query = "insert into Hospedes (hnome,telefone,nacionalidade,genero,dtnascimento,cpf,endereco,checkin,quartoid) values('"+nome+"',"+tel+",'"+nacionalidade+"', '"+genero+"','"+dtnascimento+"','"+cpf+"','"+endereco+"','"+checkin+"',"+quartoid+") update quartos set reservado = 'SIM' where quartoNo = '"+txtNumeroQuarto.Text+"'";
                fn.setData(query, "Quarto Nº " + txtNumeroQuarto.Text + " Reservado com Sucesso");
                clearAll();

            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos","Informação", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtNacionalidade.Clear();
            txtGenero.SelectedIndex = -1;
            txtDtNascimento.ResetText();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtCheckin.ResetText();
            txtCama.SelectedIndex = -1;
            txtTipoQuarto.SelectedIndex = -1;
            txtNumeroQuarto.Items.Clear();
            txtPreco.Clear();
        }

        private void UC_RegistroHospede_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_RegistroHospede_Load(object sender, EventArgs e)
        {

        }
    }
}
