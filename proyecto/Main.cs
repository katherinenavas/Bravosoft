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
    public partial class Main : Form
    {
       public Registro registro;
       public Iniciar_Sesion iniciar_sesion;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //registroToolStripMenuItem.Visible = false;
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registro == null || registro.IsDisposed)
            {
                registro = new Registro();
                registro.MdiParent = this;
                registro.Show();

            }

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iniciar_sesion == null || iniciar_sesion.IsDisposed)
            {
                iniciar_sesion = new Iniciar_Sesion();
                iniciar_sesion.MdiParent = this;
                iniciar_sesion.Show();

            }
        }


        public void opcionesAdministrador()
        {
            registroToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Visible = false;
            salirToolStripMenuItem.Visible = true;
        }


        public void opcionesUsuario()
        {
            loginToolStripMenuItem.Visible = false;
            salirToolStripMenuItem.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroToolStripMenuItem.Visible = false;
            loginToolStripMenuItem.Visible = true;
            salirToolStripMenuItem.Visible = false;

            if (registro != null)
            {
                if (registro.IsDisposed == false)
                {
                    registro.Close();
                }
            }
        }
        
    }
}
