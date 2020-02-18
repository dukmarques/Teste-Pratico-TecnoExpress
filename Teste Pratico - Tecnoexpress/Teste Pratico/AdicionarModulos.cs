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
    public partial class AdicionarModulos : Form
    {
        private Controll controller;
        public AdicionarModulos(Controll c)
        {
            InitializeComponent();
            this.controller = c;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }
    }
}
