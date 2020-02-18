using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using Util;

namespace Controller
{
    public class Controll
    {
        //Construtor com inicialização do sistema (ler arquivos e gerar os módulos e funcionalidades);
        public Controll(){
            if (this.geraModulos())
            {
                this.geraFuncionalidades();
            }
        }

        private List<Modulo> listModulos = new List<Modulo>();
        private List<Modulo> modulosSelecionados = new List<Modulo>();

        //Método responsável por gerar as instâncias dos módulos através da leitura do arquivo, 
        //divisão da cadeia de string e da conversão de valores de string para int e bool, quando necessário.
        public bool geraModulos()
        {
            List<string> stringModulos =  ManipulandoArquivos.readFile("Modulos.txt"); //Recebe uma lista onde cada item é uma linha do arquivo de texto

            foreach (string s in stringModulos)
            {
                string[] atributos = splitString(s, '|');
                Modulo m = new Modulo(Convert.ToInt32(atributos[0]), atributos[1], Convert.ToBoolean(atributos[2]), Convert.ToDouble(atributos[3]));

                listModulos.Add(m);
            }

            return true;
        }

        /* Método responsável por gerar as instâncias de Funcionalidades através da leitura do aquivo de texto,
         * após, faz a separação da cadeia de caracteres para gerar os atributos e instânciar o objeto, por ultimo chama 
         * o método de adicionar funcionalidade passando o objeto como parâmetro.
         */
        private void geraFuncionalidades()
        {
            List<string> stringFuncionalidades = ManipulandoArquivos.readFile("Funcionalidades.txt");

            foreach(string s in stringFuncionalidades)
            {
                string[] atributos = splitString(s, '|');
                Funcionalidade f = new Funcionalidade(Convert.ToInt32(atributos[0]), atributos[1]);

                addFuncionalidade(f);
            }
        }

        //Método responsável por adicionar uma funcionalidade a um modulo já existente
        //para isso ele itera a lista de modulos até encontrar o módulo através do seu código
        private void addFuncionalidade(Funcionalidade f)
        {
            Console.WriteLine($"#2 {f.ToString()}");
            foreach (Modulo m in listModulos)
            {
                if(m.Codigo == f.CodModulo)
                {
                    m.AddFuncionalidade(f);
                    Console.WriteLine($"#3 {m.ToString()}");
                }
            }
        }

        /*Métodos responsável por percorrer o vetor com os indices dos módulos selecionados,
         *ao encontrar o módulo na lista de módulos, o mesmo é adicionado na lista de selecionados.
         */
        public void addModuloSelecionado(int codModulo)
        {
            foreach (Modulo m in listModulos)
            {
                if (m.Codigo == codModulo)
                {
                    modulosSelecionados.Add(m);
                }
            }
        }

        //Método responsável por remover um módulo da lista de selecionados
        public void removeModuloSelecionado(int codModulo)
        {
            Modulo remover = null;
            foreach(Modulo m in this.modulosSelecionados)
            {
                if(m.Codigo == codModulo)
                {
                    remover = m;
                }
            }
            if(remover != null)
            {
                modulosSelecionados.Remove(remover);
            }
        }

        //Método para cadastrar novo módulo
        public void cadastrarModulo(string descricao, bool modBasico, double preco)
        {
            //Cria o código automaticamente somando 1 ao valor do código do ultimo módulo da lista
            int codModulo = listModulos[listModulos.Count-1].Codigo + 1;
            Modulo novo = new Modulo(codModulo, descricao.ToUpper(), modBasico, preco);

            listModulos.Add(novo);
        }

        //Método para cadastrar uma funcionalidade
        public void cadastrarFuncionalidade(int codModulo, string descricao)
        {
            Funcionalidade f = new Funcionalidade(codModulo, descricao);
            Console.WriteLine($"#1 {f.ToString()}");
            this.addFuncionalidade(f);
        }

        //Método responsável por finalizar o orçamento calculando e retornando o valor.
        public double finalizarOrcamento()
        {
            double precoTotal = 0;
            bool basico = false;

            foreach(Modulo m in modulosSelecionados)
            {
                //Verifica se o módulo é basico e se já foram adicionados outros módulos básicos, caso já, não soma o valor de novos módulos básicos
                if((m.ModBasico == true) && (basico == false))
                {
                    precoTotal += m.Preco;
                    basico = true;
                }
                else if(m.ModBasico == false)
                {
                    precoTotal += m.Preco;
                }
            }

            return precoTotal;
        }

        //Método responsável por retornar a lista de módulos
        public List<Modulo> getModulos()
        {
            return this.listModulos;
        }

        //Método de acesso ao módulos não selecionados
        public List<Modulo> getModulosNaoSelecionados()
        {
            List<Modulo> naoSelecionados = new List<Modulo>();

            foreach(Modulo m in listModulos)
            {
                if (!modulosSelecionados.Contains(m))
                {
                    naoSelecionados.Add(m);
                }
            }
            return naoSelecionados;
        }

        //Método de Acesso os modulos selecionados
        public List<Modulo> getModulosSelecionados()
        {
            return this.modulosSelecionados;
        }

        //Recebe uma cadeia de string e separa em um array de string tomando como parâmetro de separação o caracter de criterio informado;
        private string[] splitString(string s, char criterio)
        {
            string[] stringSeparada = s.Split(criterio);

            return stringSeparada;
        }
    }
}
