using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registros.DAO;

namespace Registros.IU
{
    public partial class FormLibross : Form


    {
        public FormLibross()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLibross_Load(object sender, EventArgs e)
        {
            VerRegistros("");
        }
        private void VerRegistros(string condicion)
        {
            librosDAO DAO = new librosDAO();
            dataGridView2.DataSource = DAO.VerRegistros(condicion);


        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }
    }
}
