using System;
using System.Text;
using System.Threading;

namespace ConsoleApplicationNET
{
    public class Program
    {
        #region Main
        public static void Main(string[] args)
        {
            #region Variáveis
            WriteLines.Program_Args_Question();
            // Imprime caracteres UTF8:
            Console.OutputEncoding = Encoding.UTF8;
            #endregion
        }
    }
    #endregion
}

