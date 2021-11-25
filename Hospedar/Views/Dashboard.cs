using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedar.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_RegistroHospede1.Visible = true;
            uC_RegistroHospede1.BringToFront();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReservarQuarto_Click(object sender, EventArgs e)
        {
            uC_AddQuarto2.Visible = true;
            uC_AddQuarto2.BringToFront();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Usuarios1.Visible = false;
            uC_AddQuarto2.Visible = false;
            uC_RegistroHospede1.Visible = false;
            btnReservarQuarto.PerformClick();
        }

        private void uC_AddQuarto2_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uC_CheckoutHospede1.Visible = true;
            uC_CheckoutHospede1.BringToFront();

        }

        private void btnHospedes_Click(object sender, EventArgs e)
        {
            uC_DetalhesHospedes1.Visible = true;
            uC_DetalhesHospedes1.BringToFront();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            uC_Usuarios1.Visible = true;
            uC_Usuarios1.BringToFront();
        }
    }
}
