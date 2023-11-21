using CineApi.ReportesCine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCine
{
    public partial class LoginIniciarSesion : Form
    {
        public LoginIniciarSesion()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.DarkGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DarkGray;
            }
        }

        private void txtpass_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text =="CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DarkGray;
                
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
           
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
               
                txtpass.ForeColor = Color.DarkGray;
               

            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "321321")
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
            else 
            {
                lblErrorUsuariocontra.Text = "USUARIO/CONTRASEÑA INCORRECTAS";
                lblErrorUsuariocontra.ForeColor = Color.Red;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
