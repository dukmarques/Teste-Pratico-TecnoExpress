using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Modulo
    {
        private int codigo;
        private string descricao;
        private bool modBasico;
        private double preco;
        private List<Funcionalidade> funcionalidades;

        public Modulo(int codigo, string descricao, bool modBasico, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.ModBasico = modBasico;
            this.Preco = preco;
            this.Funcionalidades = new List<Funcionalidade>();
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool ModBasico { get => modBasico; set => modBasico = value; }
        public double Preco { get => preco; set => preco = value; }
        internal List<Funcionalidade> Funcionalidades { get => funcionalidades; set => funcionalidades = value; }

        //Adiciona uma funcionalidade a lista de funcionalidades do módulo
        public void AddFuncionalidade(Funcionalidade f)
        {
            this.funcionalidades.Add(f);
        }

        public override string ToString()
        {
            string func = "";
            
            foreach(Funcionalidade f in funcionalidades)
            {
                func += $"{f.Descricao}\n";
            }

            string s = $"Código: {this.codigo}, Descrição: {this.descricao}, Básico: {this.modBasico}, Preço: R${this.preco} \nFuncionalidades do Módulo: {func}";
            return s;
        }
    }
}
