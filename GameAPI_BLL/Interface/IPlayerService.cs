using GameAPI_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_BLL.Interface
{
    public interface IPlayerService
    {
        bool Create(Player player);
        void Delete(int id);
        /// <summary>
        /// Retourne la liste des joueurs
        /// </summary>
        /// <returns></returns>
        List<Player> GetAll();
        Player? GetById(int id);
        void Update(Player player);
    }
}
