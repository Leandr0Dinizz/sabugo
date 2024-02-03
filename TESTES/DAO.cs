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
        public string dados;
        public string sql;
        public string resultado;
        public string[] login;
        public string[] senha;
        public int[] idUsuario;
        public int i;
        public int contador;

        



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


        //método inserir

        public void inserir(string login, string senha)
        {

            try
            {

                dados = "('','" + login + "','" + senha + "')";
                sql = "insert into usuario(idUsuario, login, senha) values" + dados;

                MySqlCommand conn = new MySqlCommand(sql, conexao); // prepara a execução no banco de dados
                resultado = "" + conn.ExecuteNonQuery();//ctrl + Enter -> executando o comando no banco de dados
                Console.WriteLine(resultado + "Linha afetada");
            }
            catch (Exception erro)
            {

                Console.WriteLine("Erro!!! Algo deu errado\n" + erro);
            }//fim do try catch

        }//fim do método


        public void PreencherVetor()
        {


            string query = "Select * from usuario";

            //instanciar vetor
            idUsuario = new int[100];
            login = new string[100];
            senha = new string[100];


            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {


                idUsuario[i] = 0;
                login[i] = "";
                senha[i] = "";
            }//fim do for


            //Preparando o comando para o banco
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {

                idUsuario[i] = Convert.ToInt32(leitura["idUsuario"]);
                login[i] = "" + leitura["login"];
                senha[i] = "" + leitura["senha"];
                i++;
                contador++;
            }


            leitura.Close();//Encerrar o acesso ao banco de dados
        }//fim preencher

        public bool validacao(string resposta1, string resposta2)
        {
            for (i = 0; i < 100; i++)
            {
                if (resposta1 == login[i] && resposta2 == senha[i])
                {
                    return true;
                }
            }
            return false;

            }

    }// fim da classe
}//fim do projeto
