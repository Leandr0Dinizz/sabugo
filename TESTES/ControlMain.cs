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
                Menu();//Mostrar as opções para o usuario
                switch (ConsultarOpcao)
                {

                    case 1:
                        Cadastrar();




                }

            } while 

        }//fim do método

    }// fim da classe

}//fim do método
