using GameAPI.DTO.Form;
using GameAPI_BLL.Models;

namespace GameAPI.Tools
{
    public static class MesMappers
    {
        public static Player Mapper(this PlayerFormDTO form)
        {
            return new Player
            {
                Email = form.Email,
                Nickname = form.Nickname
            };
        }

        public static Game Mapper(this GameFormDTO form)
        {
            return new Game
            {
                Editor = form.Editor,
                Title = form.Title,
                ReleaseYear = form.ReleaseYear,
                Genre = form.Genre
            };
        }
    }
}
