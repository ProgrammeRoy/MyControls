using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControls.Client.Pages.ComboCascade
{
  public class Repository
  {
    List<Genre> TableGenre()
    {
      return new List<Genre>
      {
        new Genre(){ GenreId=1, NameGenre="Suspense"},
        new Genre(){ GenreId=2, NameGenre="Drama"}
      };
    }

    List<Serie> TableSerie()
    {
      return new List<Serie>
      {
        new Serie(){ SerieId=1, NameSerie="Stranger Things", GenreId=1},
        new Serie(){ SerieId=2, NameSerie="Sherlok Holmes", GenreId=2},
        new Serie(){ SerieId=3, NameSerie="Money Heist", GenreId=1},
        new Serie(){ SerieId=4, NameSerie="The Crown", GenreId=2}
      };
    }

    //-------Task

    public async Task<List<Genre>> GetGenres()
    {
      var sql = from g in TableGenre()
                select g;
      return sql.ToList();
    }

    public async Task<List<Serie>> GetSeriesByGenre(int genreId)
    {
      var sql = from s in TableSerie()
                where s.GenreId == genreId
                select s;
      return sql.ToList();
    }
  }
}
