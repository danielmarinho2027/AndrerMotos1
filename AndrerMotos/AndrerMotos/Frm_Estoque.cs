using AndreMotos.Application.Interface;
using AndreMotos.Data.Interfaces;
using AndreMotos.Dominio.EstoqueRoot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrerMotos
{
    public partial class Frm_Estoque : Form
    {
        private IProdutoRepositorio _repositorio;
        public Frm_Estoque()
        {
            _repositorio = Program.container.GetInstance<IProdutoRepositorio>();


            InitializeComponent();
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            dataGridView1.DataSource = _repositorio.ObterTodos();
            btnAtualizar.Enabled = true;
        }


        private void Frm_Estoque_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto model = new Produto
            {

                NomeProduto = textProduto.Text,
                Descricao = textBox3.Text

            };
            var service = Program.container.GetInstance<IProdutoService>();

            if (service.Adicionar(model))
            {
                AtualizarGrid();

                MessageBox.Show(this, "Aluno cadastrado com sucesso.", "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                textProduto.Focus();

                MessageBox.Show(this, "Não foi possível adicionar o aluno. \n\n" + service.ObterNotificacoes(), "LTPV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}