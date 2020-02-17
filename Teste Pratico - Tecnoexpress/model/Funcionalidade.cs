using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Funcionalidade
    {
        private int codModulo;
        private string descricao;

        public Funcionalidade(int codModulo, string descricao)
        {
            this.CodModulo = codModulo;
            this.Descricao = descricao;
        }

        public int CodModulo { get => codModulo; set => codModulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public override string ToString()
        {
            return $"Código do Módulo: {this.codModulo}, Descrição: {this.descricao}";
        }
    }
}
