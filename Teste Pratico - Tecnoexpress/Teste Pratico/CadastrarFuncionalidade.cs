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
    public partial class CadastrarFuncionalidade : Form
    {
        Controll controller;
        public CadastrarFuncionalidade(Controll c)
        {
            InitializeComponent();
            this.controller = c;
            this.initComboBox();
        }

        public void initComboBox()
        {
            comboBoxModulos.DropDownStyle = ComboBoxStyle.DropDownList;
            List<Modulo> modulos = this.controller.getModulos();
            foreach(Modulo m in modulos)
            {
                comboBoxModulos.Items.Add(m.Descricao);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxModulos.SelectedIndex.ToString()) >= 0)
            {
                if (verificaTextBox(textBoxDescricao))
                {
                    int codModulo = Convert.ToInt32(comboBoxModulos.SelectedIndex.ToString()) + 1;
                    string descricao = textBoxDescricao.Text.ToUpper();

                    this.controller.cadastrarFuncionalidade(codModulo, descricao);
                    MessageBox.Show($"A funcionalidade: {descricao} foi criada para o módulo: {comboBoxModulos.SelectedItem.ToString()}", "Cadastro de Funcionalidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, informe a descrição da nova funcionalidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBoxDescricao.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um módulo para a nova funcionalidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool verificaTextBox(TextBox textBox)
        {
            if (!(textBox.Text == string.Empty))
            {
                if (!(textBox.Text.Trim() == string.Empty) && (textBox.Text.Length > 0))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
