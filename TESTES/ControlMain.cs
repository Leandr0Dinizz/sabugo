using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTES
{
    class ControlMain
    {
        ControlUsuario usuario;
        public ControlMain()
        { 
        
            usuario = new ControlUsuario();
        
        }//fim do método 

        public void operacao()
        {

            do
            {
                usuario.Menu();//Mostrar as opções para o usuario
                switch (usuario.ConsultarOpcao)
                {

                    case 1:
                        usuario.CadastrarUsuario();
                        break;
                    case 2:
                        if (usuario.Logar() == true)
                        {
                            Console.WriteLine("Logado com sucesso!");

                        }
                        else
                        {
                            Console.WriteLine("Login e/ou senha não são válidos!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Obrigado!");
                        break;
                    default:
                        Console.WriteLine("Informe um código de acordo com o menu");
                        break;
                }

            } while (usuario.ConsultarOpcao != 3);

        }//fim do método

    }// fim da classe

}//fim do método
