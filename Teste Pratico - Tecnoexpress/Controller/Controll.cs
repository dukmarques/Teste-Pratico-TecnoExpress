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
            foreach(Modulo m in listModulos)
            {
                if(m.Codigo == f.CodModulo)
                {
                    m.AddFuncionalidade(f);
                }
            }
        }

        //Recebe uma cadeia de string e separa em um array de string tomando como parâmetro de separação o caracter de criterio informado;
        private string[] splitString(string s, char criterio)
        {
            string[] stringSeparada = s.Split(criterio);

            return stringSeparada;
        }

        public void test()
        {
            foreach (Modulo m in listModulos)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}
