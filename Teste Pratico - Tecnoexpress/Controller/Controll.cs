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
        public Controll(){
            this.geraModulos();
        }

        private List<Modulo> listModulos = new List<Modulo>();

        //Método responsável por gerar as instâncias dos módulos através da leitura do arquivo, divisão da cadeia de string e da conversão de valores de string para int e bool, quando necessário.
        public void geraModulos()
        {
            List<string> stringModulos =  ManipulandoArquivos.readFile("Modulos.txt"); //Recebe uma lista onde cada item é uma linha do arquivo de texto

            foreach (string s in stringModulos)
            {
                string[] atributos = splitString(s, '|');
                Modulo m = new Modulo(Convert.ToInt32(atributos[0]), atributos[1], Convert.ToBoolean(atributos[2]), Convert.ToDouble(atributos[3]));

                listModulos.Add(m);
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
                Console.WriteLine(m);
            }
        }
    }
}
