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
    }
}
