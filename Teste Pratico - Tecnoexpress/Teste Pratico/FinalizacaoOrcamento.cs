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
    public partial class FinalizacaoOrcamento : Form
    {
        Controll controller;
        public FinalizacaoOrcamento(Controll c)
        {
            InitializeComponent();
            this.controller = c;
            this.orcamento();
        }

        private void orcamento()
        {
            List<Modulo> modulos = this.controller.getModulosSelecionados();
            foreach(Modulo m in modulos)
            {
                listBox.Items.Add(m.ToString());
                List<Funcionalidade> funcionalidades = m.Funcionalidades;
                listBox.Items.Add("Funcionalidades:");
                foreach (Funcionalidade f in funcionalidades)
                {
                    listBox.Items.Add($"    * {f.Descricao}");
                }
                listBox.Items.Add("");
            }

            double total = this.controller.finalizarOrcamento();
            this.valorTotal.Text = $"Valor Total: R${total}";
        }

        private void FinalizacaoOrcamento_Load(object sender, EventArgs e)
        {

        }
    }
}
