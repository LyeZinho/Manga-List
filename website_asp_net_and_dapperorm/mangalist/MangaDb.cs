using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;

namespace website_asp_net_and_dapperorm
{
    public class MangaDb
    {
        protected string ConStr()
        {
            string connStr = "server=localhost;database=mangadb;userid=root;password=123456789;";
            return connStr;
        }
        public dynamic ReadManga(string name)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConStr()))
                {
                    string procedure = "get_manga_name";
                    dynamic data = conn.QuerySingle(
                        procedure, new { mname = name }, commandType: CommandType.StoredProcedure
                        );
                    return data;
                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }

        }
        public dynamic ReadMangaByGenre()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConStr()))
                {
                    string procedure = "get_manga_genre";
                    dynamic data = conn.Query(
                        procedure, commandType: CommandType.StoredProcedure
                        );
                    return data;
                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }
        public dynamic ReadMangaAsc()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConStr()))
                {
                    string procedure = "get_manga_asc";
                    dynamic data = conn.Query(
                        procedure, commandType: CommandType.StoredProcedure
                        );
                    return data;
                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }
        public dynamic ReadMangaDesc()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConStr()))
                {
                    string procedure = "get_manga_desc";
                    dynamic data = conn.Query(
                        procedure, commandType: CommandType.StoredProcedure
                        );
                    return data;
                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }
        public bool InsertManga(string nome, string autor, string genero)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConStr()))
                {
                    string procedure = "insert_manga";
                    dynamic data = conn.Execute(
                        procedure, new
                        {
                            mnome = nome,
                            mautor = autor,
                            mgenero = genero,
                            mcaplidos = 0
                        }, commandType: CommandType.StoredProcedure);
                    if (data == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool RemoveMangaNome(string nome)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConStr()))
                {
                    string procedure = "remove_manga_name";
                    dynamic data = conn.Execute(
                        procedure, new
                        {
                            mname = nome
                        }
                        , commandType: CommandType.StoredProcedure);
                    if (data == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool SetMangaCapitolos(string nome, int capitolos)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConStr()))
                {
                    string procedure = "update_manga_chapters";
                    dynamic data = conn.Execute(
                        procedure, new
                        {
                            mname = nome,
                            mchapnew = capitolos
                        }
                        , commandType: CommandType.StoredProcedure);
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}


            