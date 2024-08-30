using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmListaCliente : Form
    {
        public FrmListaCliente()
        {
            InitializeComponent();
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterLista(nome);
            dgvClientes.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgvClientes.Rows.Add();  
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[cont].Cells[5].Value = cliente.Data_Nasc;
                dgvClientes.Rows[cont].Cells[6].Value = cliente.Data_Cad;
                cont++;
            }
        }


        private void FrmListaCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

    }
}
