using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluGames
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogos CadastrarJogos = new Jogos();
            CadastrarJogos.ShowDialog();
        }

        private void btn_menu_locacao_Click(object sender, EventArgs e)
        {
            Alugar Locacao = new Alugar();
            Locacao.ShowDialog();
        }

        private void btn_menu_cliente_Click(object sender, EventArgs e)
        {
            Clientes CadastrarClientes = new Clientes();
            CadastrarClientes.ShowDialog();
        }
    }
}
