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
    public partial class UC_DetalhesHospedes : UserControl
    {
        function fn = new function();
        String query;

        public UC_DetalhesHospedes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_DetalhesHospedes_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBuscaPor.SelectedIndex == 0)
            {
                query = "select Hospedes.hid, Hospedes.hnome, Hospedes.telefone, Hospedes.nacionalidade, Hospedes.genero, Hospedes.dtnascimento, Hospedes.cpf, Hospedes.endereco, Hospedes.checkin, Hospedes.checkout, quartos.quartoNo, quartos.quartoTipo, quartos.cama, quartos.preco from Hospedes inner join quartos on Hospedes.quartoid = quartos.quartoid";
                getDados(query);

            }
            else if (txtBuscaPor.SelectedIndex == 1)
            {
                query = "select Hospedes.hid, Hospedes.hnome, Hospedes.telefone, Hospedes.nacionalidade, Hospedes.genero, Hospedes.dtnascimento, Hospedes.cpf, Hospedes.endereco, Hospedes.checkin, Hospedes.checkout, quartos.quartoNo, quartos.quartoTipo, quartos.cama, quartos.preco from Hospedes inner join quartos on Hospedes.quartoid = quartos.quartoid where checkout is null";
                getDados(query);
            }
            else if (txtBuscaPor.SelectedIndex == 2)
            {
                query = "select Hospedes.hid, Hospedes.hnome, Hospedes.telefone, Hospedes.nacionalidade, Hospedes.genero, Hospedes.dtnascimento, Hospedes.cpf, Hospedes.endereco, Hospedes.checkin, Hospedes.checkout, quartos.quartoNo, quartos.quartoTipo, quartos.cama, quartos.preco from Hospedes inner join quartos on Hospedes.quartoid = quartos.quartoid where checkout is not null";
                getDados(query);
            }
        }
        private void getDados(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
