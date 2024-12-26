using Library.BookManager;
namespace Library.BookBase;
public class BaseOfBook
{
    private static BaseOfBook _instance = null;
    private static readonly object _obj = new object();
    public static List<IBook> books { get; } = new List<IBook>()
    {
        new Comic
    {
        Title = "Alicja w krainie czarów",
        Author = "Charles Lutwidge Dodgson",
        Id = 1,
        Description = "Książka ukazuje absurdalną logikę snu, jest pełna satyrycznych aluzji do przyjaciół i wrogów Dodgsona,\n" +
                      " parodii szkolnych wierszyków, których uczyły się w XIX wieku brytyjskie dzieci, zawiera także \n" +
                      "odniesienia lingwistyczne i matematyczne.",
        Price = 49.99,
    },
    new Comic
    {
        Title = "Spiderman",
        Author = "Stan Lee",
        Id = 2,
        Description = "Historia Petera Parkera, który po ugryzieniu przez radioaktywnego pająka zyskuje nadludzkie zdolności.",
        Price = 29.99,
    },
    new Comic
    {
        Title = "Batman",
        Author = "Bob Kane",
        Id = 3,
        Description = "Opowieść o Bruce'ie Wayne'ie, który walczy z przestępczością w Gotham City jako Batman.",
        Price = 39.99,
    },
    new Comic
    {
        Title = "Superman",
        Author = "Jerry Siegel",
        Id = 4,
        Description = "Historia Kal-Ela, ostatniego syna Kryptona, który przybywa na Ziemię i staje się Supermanem.",
        Price = 24.99,
    },
    new Comic
    {
        Title = "Wonder Woman",
        Author = "William Moulton Marston",
        Id = 5,
        Description = "Opowieść o Dianie, księżniczce Amazonek, która walczy o pokój i sprawiedliwość jako Wonder Woman.",
        Price = 27.99,
    },
    new Comic
    {
        Title = "X-Men",
        Author = "Stan Lee",
        Id = 6,
        Description = "Grupa mutantów z nadludzkimi zdolnościami, którzy walczą o akceptację i pokój między ludźmi a mutantami.",
        Price = 34.99,
    },
    new Comic
    {
        Title = "The Flash",
        Author = "Gardner Fox",
        Id = 7,
        Description = "Historia Barry'ego Allena, który zyskuje nadludzką szybkość i staje się Flashem.",
        Price = 22.99,
    },
    new Comic
    {
        Title = "Green Lantern",
        Author = "John Broome",
        Id = 8,
        Description = "Opowieść o Halie Jordanie, który zostaje wybrany na członka Korpusu Zielonych Latarni.",
        Price = 26.99,
    },
    new Comic
    {
        Title = "Iron Man",
        Author = "Stan Lee",
        Id = 9,
        Description = "Historia Tony'ego Starka, genialnego wynalazcy, który tworzy zaawansowaną zbroję i staje się Iron Manem.",
        Price = 31.99,
    },
    new Comic
    {
        Title = "Thor",
        Author = "Stan Lee",
        Id = 10,
        Description = "Opowieść o nordyckim bogu piorunów, Thorze, który walczy o pokój w Asgardzie i na Ziemi.",
        Price = 28.99,
    }
    };

    private BaseOfBook() { }

    public static BaseOfBook GetInstance()
    {
        lock (_obj)
        {
            if (_instance == null)
            {
                _instance = new BaseOfBook();
            }
        }
        return _instance;
    }
}