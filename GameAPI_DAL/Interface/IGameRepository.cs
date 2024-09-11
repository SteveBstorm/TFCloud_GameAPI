using GameAPI_DAL.Entities;

namespace GameAPI_DAL.Interface
{
    public interface IGameRepository
    {
        void Create(Game game);
        List<Game> GetAll();
        List<Game> GetByGenre(string genre);
        List<Game> GetByPlayerId(int id);
    }
}