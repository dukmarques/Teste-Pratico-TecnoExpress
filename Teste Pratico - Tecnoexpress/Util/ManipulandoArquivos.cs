using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util
{
    public class ManipulandoArquivos
    {
        //Método que realiza a leitura dos arquivos e retorna uma lista contendo o texto de cada linha;
        public static List<String> readFile(string path)
        {
            if (File.Exists(path))
            {
                using (Stream sr = File.Open(path, FileMode.Open))
                {
                    List<string> txtList = new List<string>();
                    StreamReader read = new StreamReader(sr);
                    string linha = null;

                    while ((linha = read.ReadLine()) != null)
                    {
                        txtList.Add(linha);
                    }

                    return txtList;
                }
            }
            {
                return null; //Caso o arquivo não seja encontrado, é retornado null;
            }
        }

        //Método para adicionar contéúdo ao arquivo sem sobrescrever o conteúdo existente;
        public static void writeFile(string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    /*Código*/
                }
            }
            else
            {
                /*A definir*/
            }
        }
    }
}
