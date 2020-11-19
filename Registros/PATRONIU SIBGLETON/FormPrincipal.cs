using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros.IU
{
    public partial class FormPrincipal : Form
    {
        //patron singleton
        private FormPrincipal()
        {
            InitializeComponent();

        }

        private static FormLibross instancia = null;
        public static FormLibross obtnerinstancia()
        {
            if (instancia == null) { instancia = new FormLibross();}
            return instancia;
        }


        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibross frm = new FormLibross.obtenerinstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
