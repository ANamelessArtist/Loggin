using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loggin
{
    public partial class frmLoggin : Form
    {
        Usuario arf = new Usuario();
        public frmLoggin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            string user = usuarioText.Text;
            string password = contraseñaTxt.Text;

            var lista = arf.Obtenerusuarios();
            var valida = lista.FirstOrDefault(u => u.NombreUsuario == user && u.Contraseña == password);
            if (valida != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("LA POLICIA ESTA EN CAMINO");
            }
        }

        private void frmLoggin_Load(object sender, EventArgs e)
        {

        }
    }
}
