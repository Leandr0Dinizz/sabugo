using K4os.Compression.LZ4.Internal;
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
        public string ValidacaoLogin;
        public string ValidacaoSenha;
        public int i;
        DAO conectar;
        public ControlUsuario()
        {
            //Instaciar uma variável = Determinando seus valores.
            ConsultarOpcao = 0;
            conectar = new DAO(); // conectando com o banco de dado
            i =  0;


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
                "1. Cadastro\n" +
                "2. Login\n" +
                "3. Sair");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }// fim do menu

        public void CadastrarUsuario()
        {

            Console.WriteLine("Entre com seu email :");
            string login = Console.ReadLine();
            Console.WriteLine("Informe uma senha");
            string senha = Console.ReadLine();
            Console.WriteLine("\n *** Cadastrado com sucesso! ***");
            
            //Dados que vou inserir no BD
            conectar.inserir(login, senha);
                    
        }//fim do método cadastrar        

        public Boolean Logar()
        {
           
                conectar.PreencherVetor();
                for (i = 0; i < 100; i++)
                {
                    Console.WriteLine("\n***LOGIN***\n");
                    Console.WriteLine("Digite seu login: "); //Coletando login
                    ValidacaoLogin = Console.ReadLine();

                    Console.WriteLine("\nDigite sua senha: "); //Coletando a senha
                    ValidacaoSenha = Console.ReadLine();

                    //Validação
                    if (conectar.validacao(ValidacaoLogin, ValidacaoSenha) == true)
                    {
                        return true;

                    }
                }//Fim do for
                return false;
 

        }// fim do logar





    }// fim da classe
}//fim do projeto
