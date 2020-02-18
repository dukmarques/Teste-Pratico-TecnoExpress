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
    public partial class CadastrarModulo : Form
    {
        Controll controller;
        public CadastrarModulo(Controll c)
        {
            InitializeComponent();
            this.controller = c;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkModBasico_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkModBasico.Checked == true)
            {
                this.textBoxPreco.Enabled = false;
                this.labelPreco.ForeColor = Color.Silver;
            }
            else
            {
                this.textBoxPreco.Enabled = true;
                this.labelPreco.ForeColor = Color.White;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificaTextBox(this.textBoxDescricao))
            {
                Double preco = 100;
                if (!(this.checkModBasico.Checked) && verificaTextBox(this.textBoxPreco))
                {
                    try
                    {
                        preco = Convert.ToDouble(this.textBoxPreco.Text);
                    }
                    catch (FormatException f)
                    {
                        MessageBox.Show("Informe apenas números", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.textBoxPreco.Clear();
                        this.textBoxPreco.Focus();
                    }
                }

                string descricao = this.textBoxDescricao.Text;
                bool basico = this.checkModBasico.Checked;

                this.controller.cadastrarModulo(descricao, basico, preco);
                this.Close();
            }
            else
            {
                MessageBox.Show("É necessário preencher o campo de descrição do módulo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBoxDescricao.Clear();
                this.textBoxDescricao.Focus();
            }
        }

        private bool verificaTextBox(TextBox textBox)
        {
            if(!(textBox.Text == string.Empty))
            {
                if(!(textBox.Text.Trim() == string.Empty) && (textBox.Text.Length > 0))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
