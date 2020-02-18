using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using model;

namespace Teste_Pratico
{
    public partial class Form_Principal : Form
    {
        Controll controller = new Controll();
        public Form_Principal()
        {
            InitializeComponent();
            configListView();
        }

        private void configListView()
        {
            //Propriedades do ListView
            listView.View = View.Details;
            listView.FullRowSelect = true;

            //Construtor do ListView
            listView.Columns.Add("Cod", 0);
            listView.Columns.Add("Módulo", 253);
            listView.Columns.Add("Preço", 100);
        }

        //Método responsável por adicionar elementos na ListView
        private void addListView()
        {
            this.listView.Clear(); //Limpa os dados da listView
            this.configListView(); //Configura a listView

            List<Modulo> modulosSelecionados = controller.getModulosSelecionados();
            
            foreach (Modulo m in modulosSelecionados)
            {
                string[] linha = {Convert.ToString(m.Codigo), m.Descricao, $"R${m.Preco}"};
                ListViewItem item = new ListViewItem(linha);
                listView.Items.Add(item);
            }
        }

        //Método responsável por deletar um item do listview
        private void deleteItemListView()
        {
            if (listView.Items.Count > 0)
            {
                try
                {
                    if ((MessageBox.Show("Deseja realmente remover item da lista?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                    {
                        int cod = Convert.ToInt32(listView.SelectedItems[0].Text);
                        this.controller.removeModuloSelecionado(cod);

                        this.addListView();
                    }
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    MessageBox.Show("Por favor, selecone um item da lista", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Error: {0}", outOfRange.Message);
                }
            }
            else
            {
                MessageBox.Show("Não há módulos para remover.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cadastrarModulo_Click(object sender, EventArgs e)
        {
            CadastrarModulo cd = new CadastrarModulo(this.controller);
            cd.ShowDialog();
        }

        private void cadastrarFuncionalidade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em construção...");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdicionarModulos am = new AdicionarModulos(this.controller);
            am.ShowDialog();
            this.addListView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.deleteItemListView();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente finalizar o orçamento?", "Finalizar orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FinalizacaoOrcamento fo = new FinalizacaoOrcamento(this.controller);
                fo.ShowDialog();
            }
        }
    }
}
