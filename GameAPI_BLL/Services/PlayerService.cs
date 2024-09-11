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
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public bool Create(Player player)
        {
            return _playerRepository.Create(player.ToDAL());
        }

        public void Delete(int id)
        {
            _playerRepository.Delete(id);
        }
        /// <summary>
        /// Retourne la liste des joueurs
        /// </summary>
        /// <returns></returns>
        public List<Player> GetAll()
        {
            return _playerRepository.GetAll().Select(p => p.ToBLL()).ToList();
        }

        public Player? GetById(int id)
        {
            return _playerRepository.GetById(id)?.ToBLL();
        }

        public void Update(Player player)
        {
            _playerRepository.Update(player.ToDAL());
        }
    }
}
