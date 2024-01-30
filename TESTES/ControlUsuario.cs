using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTES
{
    class ControlUsuario
    {
        private int opcao = 0;
        private int codigo;
        DAO conectar;
        public ControlUsuario()
        {
            //Instaciar uma variável = Determinando seus valores.
            ConsultarOpcao = 0;
            conectar = new DAO(); // conectando com o banco de dado


        }//fim do método construtor
        public int ConsultarOpcao
        {

            get { return this.opcao; }
            set { this.opcao = value; }



        }//fim do get set           


        public void Menu()
        {
            Console.WriteLine("Bem vindo!! \n" +
                "Escolha uma das opções abaixo:\n" +
                "Primeira vez aqui Efetue o cadastro\n" +
                "1. Login\n" +
                "2. Cadastro\n" +
                "3. Sair");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }// fim do menu

        public void Cadastrar()
        {

            Console.WriteLine("Entre com seu email :");
            string  = Console.ReadLine();
            


        }        



    }// fim da classe
}//fim do projeto
