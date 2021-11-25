using Hospedar.Views;
using Hospedar.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedar
{
        public partial class Hospedar : Form
        {

        function fn = new function();
        String query;

            public Hospedar()
            {
                InitializeComponent();
            }

            private void guna2TextBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void btnSair_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            query = "select usuario, senha from usuarios where usuario = '" + txbUsuario.Text + "' and senha = '" + txbSenha.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                labelError.Visible = true;
                txbSenha.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal class All_User_Control
        {
            internal class UC_AddQuarto
            {
                public Color BackColor { get; internal set; }
                public bool Visible { get; internal set; }

                internal object BringToFront()
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
