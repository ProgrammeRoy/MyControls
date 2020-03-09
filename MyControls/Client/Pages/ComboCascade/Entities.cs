using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControls.Client.Pages.ComboCascade
{
  public class Genre
  {
    public int GenreId { get; set; }
    public string NameGenre { get; set; }
  }

  public class Serie
  {
    public int SerieId { get; set; }
    public string NameSerie { get; set; }
    public int GenreId { get; set; }
  }

  public class Sale
  {
    public int SaleId { get; set; }
    public int SerieId { get; set; }
    public Serie Serie { get; set; }
    public decimal Price { get; set; }
  }
}
