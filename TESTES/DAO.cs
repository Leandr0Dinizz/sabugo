using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace TESTES
{
    class DAO
    {

        public MySqlConnection conexao;// conectar ao banco de dados


        public DAO()
        {

            conexao = new MySqlConnection("server=localhost;DataBase=agendaDiniz;Uid=root;Password=");
            try
            {
                conexao.Open();//Abri a conexão com o DB
                Console.WriteLine("Conectado com sucesso!");
            }
            catch (Exception erro)
            {

                Console.WriteLine("Algo deu errado! Verifique a conexão!\n\n" + erro);
                conexao.Close();//Fechar a conexão com o DB
            }//Fim do try catch
        }//Fim da DAO

    }// fim do método



}//fim do projeto
