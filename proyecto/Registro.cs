using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Registro : Form
    {


        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            int tipoUsuario;
            String tipo;
            ConjuntoDatosTableAdapters.UsuariosTableAdapter Usuario;
            Usuario= new ConjuntoDatosTableAdapters.UsuariosTableAdapter();
            tipo = cbox_tipoUsuario.SelectedText;
            if (tipo == "Administrador")
            {
                tipoUsuario = 1;
            }
            else
            {
                tipoUsuario = 2;
            }
            try
            {
                Usuario.Insert(txt_nombre.Text, txt_contraseña.Text, tipoUsuario);
                MessageBox.Show("Usuario Registrado");
                
            }
            catch
            {
                MessageBox.Show("No se pudo guardar");
            }



        }

       

       
    }
}
