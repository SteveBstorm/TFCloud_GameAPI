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
        List<Player> GetAll();
        Player? GetById(int id);
        void Update(Player player);
    }
}
