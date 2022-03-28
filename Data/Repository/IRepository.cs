using GameIndastry_v2.Models;

namespace GameIndastry_v2.Data.Repository
{
    public interface IRepository
    {
        List<GameModel> GetAllGames();
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        bool EditGenre(Genre genre);
        bool CreateNewGame(GameModel newGame);
        GameModel GetGameModelById(int id);
        List<GameDeveloper> GetAllDevelopers();
    }
}
