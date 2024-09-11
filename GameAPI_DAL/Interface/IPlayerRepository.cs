using GameAPI_DAL.Entities;

namespace GameAPI_DAL.Interface
{
    public interface IPlayerRepository
    {
        bool Create(Player player);
        void Delete(int id);
        List<Player> GetAll();
        Player? GetById(int id);
        void Update(Player player);
    }
}