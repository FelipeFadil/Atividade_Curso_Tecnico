using System;
using System.Collections.Generic;
using MySqlConnector;

namespace UC04_Atividade_2_Felipe_Fadil.Models
{
    public class PacotesTuristicosRepository
    {
        private const string DadosConexao = "Database=easy_trip;Data Source=localhost;User Id=root;";

        //Testar conexao
        public void TestarConexao(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando!");
            Conexao.Close();
        }

        //CRUD
        public List<PacotesTuristicos> Listar(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "SELECT * FROM pacotesturisticos";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<PacotesTuristicos> Lista = new List<PacotesTuristicos>();

            while(Reader.Read()){

                PacotesTuristicos pacotesTuristicos = new PacotesTuristicos();
                pacotesTuristicos.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    pacotesTuristicos.Nome = Reader.GetString("Nome");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                    pacotesTuristicos.Origem = Reader.GetString("Origem");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                    pacotesTuristicos.Destino = Reader.GetString("Destino");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                    pacotesTuristicos.Atrativos = Reader.GetString("Atrativos");

                pacotesTuristicos.Saida = Reader.GetDateTime("Saida");
                pacotesTuristicos.Retorno = Reader.GetDateTime("Retorno");
                pacotesTuristicos.Usuario = Reader.GetInt32("Usuario");

                Lista.Add(pacotesTuristicos);
            }

            Conexao.Close();
            return Lista;
        }

        public void Inserir(PacotesTuristicos pacotesTuristicos){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "INSERT into pacotesturisticos (Nome, Origem, Destino, Atrativos, Saida, Retorno, Usuario) values (@Nome, @Origem, @Destino, @Atrativos, @Saida, @Retorno, @Usuario)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id",pacotesTuristicos.Id);
            Comando.Parameters.AddWithValue("@Nome",pacotesTuristicos.Nome);
            Comando.Parameters.AddWithValue("@Origem",pacotesTuristicos.Origem);
            Comando.Parameters.AddWithValue("@Destino",pacotesTuristicos.Destino);
            Comando.Parameters.AddWithValue("@Atrativos",pacotesTuristicos.Atrativos);
            Comando.Parameters.AddWithValue("@Saida",pacotesTuristicos.Saida);
            Comando.Parameters.AddWithValue("@Retorno",pacotesTuristicos.Retorno);
            Comando.Parameters.AddWithValue("@Usuario",pacotesTuristicos.Usuario);
            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Atualizar(PacotesTuristicos pacotesTuristicos){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "UPDATE pacotesturisticos SET Nome=@Nome, Origem=@Origem, Destino=@Destino, Atrativos=@Atrativos, Saida=@Saida, Retorno=@Retorno, Usuario=@Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id",pacotesTuristicos.Id);
            Comando.Parameters.AddWithValue("@Nome",pacotesTuristicos.Nome);
            Comando.Parameters.AddWithValue("@Origem",pacotesTuristicos.Origem);
            Comando.Parameters.AddWithValue("@Destino",pacotesTuristicos.Destino);
            Comando.Parameters.AddWithValue("@Atrativos",pacotesTuristicos.Atrativos);
            Comando.Parameters.AddWithValue("@Saida",pacotesTuristicos.Saida);
            Comando.Parameters.AddWithValue("@Retorno",pacotesTuristicos.Retorno);
            Comando.Parameters.AddWithValue("@Usuario",pacotesTuristicos.Usuario);
            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Deletar(PacotesTuristicos pacotesTuristicos){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "DELETE FROM pacotesturisticos WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id",pacotesTuristicos.Id);
            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public PacotesTuristicos BuscarPorId(int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "SELECT * FROM pacotesturisticos WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id",Id);

            MySqlDataReader Reader = Comando.ExecuteReader();
            PacotesTuristicos pacotesTuristicos = new PacotesTuristicos();

            if(Reader.Read()){
                pacotesTuristicos.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    pacotesTuristicos.Nome = Reader.GetString("Nome");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                    pacotesTuristicos.Origem = Reader.GetString("Origem");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                    pacotesTuristicos.Destino = Reader.GetString("Destino");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                    pacotesTuristicos.Atrativos = Reader.GetString("Atrativos");

                pacotesTuristicos.Saida = Reader.GetDateTime("Saida");
                pacotesTuristicos.Retorno = Reader.GetDateTime("Retorno");
                pacotesTuristicos.Usuario = Reader.GetInt32("Usuario");
            }

            Conexao.Close();
            return pacotesTuristicos;
        }

    }
}