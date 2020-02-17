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
        
        public void testArquivo()
        {
            ManipulandoArquivos.readFile("Modulos.txt");
        }
    }
}
