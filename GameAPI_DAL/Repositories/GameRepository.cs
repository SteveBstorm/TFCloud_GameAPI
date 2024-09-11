using GameAPI_DAL.Entities;
using GameAPI_DAL.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_DAL.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly string _connectionString;
        public GameRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("default");
        }

        private Game Mapper(SqlDataReader reader)
        {
            return new Game
            {
                Id = (int)reader["Id"],
                Title = (string)reader["Title"],
                ReleaseYear = (int)reader["ReleaseYear"],
                Editor = (string)reader["Editor"],
                Genre = (string)reader["Genre"],
            };
        }

        public void Create(Game game)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Game VALUES(@title, @editor, @releaseYear, @genre)";
                    cmd.Parameters.AddWithValue("title", game.Title);
                    cmd.Parameters.AddWithValue("editor", game.Editor);
                    cmd.Parameters.AddWithValue("releaseYear", game.ReleaseYear);
                    cmd.Parameters.AddWithValue("genre", game.Genre);

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
        }

        public List<Game> GetAll()
        {
            List<Game> list = new List<Game>();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM game";
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Mapper(reader));
                        }
                    }
                    cnx.Close();
                }
            }
            return list;
        }

        public List<Game> GetByPlayerId(int id)
        {
            List<Game> list = new List<Game>();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM game g JOIN PlayerGame pg " +
                        "ON pg.GameId = g.Id " +
                        "WHERE pg.PlayerId = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Mapper(reader));
                        }
                    }
                    cnx.Close();
                }
            }
            return list;
        }

        public List<Game> GetByGenre(string genre)
        {
            List<Game> list = new List<Game>();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM game WHERE Genre = @genre";
                    cmd.Parameters.AddWithValue("genre", genre);
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Mapper(reader));
                        }
                    }
                    cnx.Close();
                }
            }
            return list;
        }
    }
}
