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
    public partial class UC_Usuarios : UserControl
    {
        function fn = new function();
        String query;
        public UC_Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Usuarios_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && txtTelefone.Text != "" && txtGenero.Text != "" && txtEmail.Text != "" && txtUsuario.Text != "" && txtSenha.Text != "")
            {
                String nome = txtNome.Text;
                Int64 telefone = Int64.Parse(txtTelefone.Text);
                String genero = txtGenero.Text;
                String email = txtEmail.Text;
                String usuario = txtUsuario.Text;
                String senha = txtSenha.Text;

                query = "insert into usuarios (unome,telefone,genero,email,usuario,senha) values ('"+nome+"',"+telefone+",'"+genero+"','"+email+"','"+usuario+"','"+senha+"')";
                fn.setData(query, "Usuário Registrado");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabUsuarios.SelectedIndex == 1)
            {
                setUsuario(guna2DataGridView1);
            }
            else if (tabUsuarios.SelectedIndex == 2)
            {
                setUsuario(guna2DataGridView2);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                if (MessageBox.Show("Deseja Prosseguir?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = "delete from usuarios where userid = " + txtID.Text + "";
                    fn.setData(query, "Usuário Deletado");
                    tabUsuarios_SelectedIndexChanged(this, null);
                } 
               
            }
         
        }

        public void getMaxID()
        {
            query = "select max(userid) from usuarios";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }
        }
        public void clearAll()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtGenero.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
        }
        public void setUsuario(DataGridView dgv)
        {
            query = "select * from usuarios";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void UC_Usuarios_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
