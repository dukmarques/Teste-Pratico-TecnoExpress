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
    public partial class AdicionarModulos : Form
    {
        private Controll controller;
        public AdicionarModulos(Controll c)
        {
            InitializeComponent();
            this.controller = c;
            this.addItemListView();
        }

        //Configura a listView
        private void configListView()
        {
            //Propriedades do ListView
            listView.View = View.Details;
            listView.FullRowSelect = true;

            //Construtor do ListView
            listView.Columns.Add("Cod", 0);
            listView.Columns.Add("Módulo", 260);
            listView.Columns.Add("Preço", 85);
        }

        //Método que adiciona os módulos ao listView para exibição na interface
        private void addItemListView()
        {
            this.listView.Clear(); //Limpa as linhas e colunas da listview
            this.configListView(); //Configura a listView

            List<Modulo> modulos = controller.getModulosNaoSelecionados();

            foreach (Modulo m in modulos)
            {
                string[] linha = {Convert.ToString(m.Codigo), m.Descricao, $"R${m.Preco}"};

                ListViewItem item = new ListViewItem(linha);
                listView.Items.Add(item);
            }
        }

        //Métodos de eventclick do botão que seleciona 1 ou mais modulos da lista
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                try
                {
                    int codModulo = Convert.ToInt32(listView.SelectedItems[0].Text);
                    this.controller.addModuloSelecionado(codModulo);

                    //Chama novamente o método de adicionar linhas na listView, desta vez o método removerá o item já selecionado
                    this.addItemListView();
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    MessageBox.Show("Por favor, selecone um item da lista", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Error: {0}", outOfRange.Message);
                }
            }
            else
            {
                MessageBox.Show("Não há mais módulos disponíveis para adicionar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
