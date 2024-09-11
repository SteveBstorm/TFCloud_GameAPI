using GameAPI_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_BLL.Interface
{
    public interface IGameService
    {
        void Create(Game game);
        List<Game> GetAll();
        List<Game> GetByGenre(string genre);
        List<Game> GetByPlayerId(int id);
    }
}
