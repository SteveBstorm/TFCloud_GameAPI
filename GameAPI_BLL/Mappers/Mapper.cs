using BLL = GameAPI_BLL.Models;
using DAL = GameAPI_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_BLL.Mappers
{
    public static class Mapper
    {
        public static DAL.Player ToDAL(this BLL.Player player)
        {
            return new DAL.Player
            {
                Id = player.Id,
                Email = player.Email,
                Nickname = player.Nickname
            };
        }

        public static BLL.Player ToBLL(this DAL.Player player)
        {
            return new BLL.Player
            {
                Id = player.Id,
                Email = player.Email,
                Nickname = player.Nickname
            };
        }

        public static DAL.Game ToDAL(this BLL.Game game)
        {
            return new DAL.Game
            {
                Id = game.Id,
                Title = game.Title,
                Editor = game.Editor,
                ReleaseYear = game.ReleaseYear,
                Genre = game.Genre
            };
        }

        public static BLL.Game ToBLL(this DAL.Game game)
        {
            return new BLL.Game
            {
                Id = game.Id,
                Title = game.Title,
                Editor = game.Editor,
                ReleaseYear = game.ReleaseYear,
                Genre = game.Genre
            };
        }
    }
}
