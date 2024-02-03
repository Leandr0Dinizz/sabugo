using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTES
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ControlMain main = new ControlMain();//Conectando a control e a model
            main.operacao();
            Console.ReadLine();//Manter o Prompt aberto


        }// fim do método
    }// fim da classe
}//fim do projeto
