using GameAPI_BLL.Interface;
using GameAPI_BLL.Mappers;
using GameAPI_BLL.Models;
using GameAPI_DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_BLL.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void Create(Game game)
        {
            _gameRepository.Create(game.ToDAL());
        }

        public List<Game> GetAll()
        {
            return _gameRepository.GetAll().Select(x => x.ToBLL()).ToList();
        }

        public List<Game> GetByGenre(string genre)
        {
            return _gameRepository.GetByGenre(genre).Select(x => x.ToBLL()).ToList();

        }

        public List<Game> GetByPlayerId(int id)
        {
            return _gameRepository.GetByPlayerId(id).Select(x => x.ToBLL()).ToList();

        }
    }
}
