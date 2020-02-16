using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ManipulandoArquivos
    {
        public static string readFile(string path)
        {
            if (File.Exists(path))
            {
                using (Stream sr = File.Open(path, FileMode.Open))
                {
                    StreamReader read = new StreamReader(sr);
                    string linha = read.ReadLine();

                    while (linha != null)
                    {
                        /*Código*/
                    }

                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        //Método para adicionar contéúdo ao arquivo sem sobrescrever o conteúdo existente
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
