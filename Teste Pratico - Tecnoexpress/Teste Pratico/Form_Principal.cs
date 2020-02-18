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

namespace Teste_Pratico
{
    public partial class Form_Principal : Form
    {
        Controll controller = new Controll();
        public Form_Principal()
        {
            InitializeComponent();
            initListView();
            //controller.test();
        }

        private void initListView()
        {
            //Propriedades do ListView
            listView.View = View.Details;
            listView.FullRowSelect = true;

            //Construtor do ListView
            listView.Columns.Add("Módulo", 253);
            listView.Columns.Add("Preço", 100);
        }

        //Método responsável por adicionar elementos na ListView
        private void addListView(string modulo, string preco)
        {
            //Linha
            string[] linha = {modulo, preco};
            ListViewItem item = new ListViewItem(linha);

            listView.Items.Add(item);
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
                        listView.Items.RemoveAt(listView.SelectedIndices[0]);
                    }
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    MessageBox.Show("Por favor, selecone um item da lista", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Error: {0}", outOfRange.Message);
                }
            }
        }
        private void cadastrarModulo_Click(object sender, EventArgs e)
        {
            this.addListView("CONTROLE FINANCEIRO", "R$100");
            this.addListView("CONTROLE DE COMPRA", "R$100");
            this.addListView("CONTROLE INVESTIMENTO", "R$100");
            this.addListView("CONTROLE VENDAS", "R$100");

        }

        private void cadastrarFuncionalidade_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdicionarModulos am = new AdicionarModulos(this.controller);
            am.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.deleteItemListView();
        }
    }
}
