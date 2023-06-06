using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.SolutionItems
{
    internal class DataListsHolder
    {
        public List<Article> Articles { get; init; } = new List<Article>()
        {
            new Article("Old beauty", 1, new DateTime(2019, 2, 12), 2, 1),
            new Article("Sense of money", 2, new DateTime(2023, 11, 1), 3, 2),
            new Article("Son of the king", 3, new DateTime(2022, 5, 25), 1, 3),
            new Article("Next in fashion", 4, new DateTime(2014, 7, 18), 4, 7),
            new Article("Suit essentials", 5, new DateTime(2018, 3, 9), 5, 5),
            new Article("Richiest people", 6, new DateTime(2021, 4, 14), 6, 4),
            new Article("Jeans importance", 7, new DateTime(2023, 8, 12), 5, 6)
        };
        public List<Magazine> Magazines { get; init; } = new List<Magazine>()
        {
            new Magazine(1, "Vogue", 7, 500, new DateTime(2023, 9, 23)),
            new Magazine(2, "International", 30, 10000, new DateTime(2021, 9, 16)),
            new Magazine(3, "Times", 7, 1000, new DateTime(2022, 11, 2)),
            new Magazine(4, "Forbes", 14, 1000, new DateTime(2022, 1, 26)),
            new Magazine(5, "Cosmopolitan", 7, 1000, new DateTime(2023, 10, 19)),
            new Magazine(6, "Elle", 30, 10000, new DateTime(2019, 4, 29)),
            new Magazine(7, "Bazaar", 7, 100, new DateTime(2024, 3, 8))
        };
        public List<Autor> Autors { get; init; } = new List<Autor>()
        {
            new Autor(1, "Василь", "Василенко", "Василійович", 1),
            new Autor(2, "Тарас", "Тарасенко", "Тарасович", 2),
            new Autor(3, "Ганна", "Іваненко", "Данилівна", 3),
            new Autor(4, "Петро", "Петренко", "Петрович", 1),
            new Autor(5, "Оксана", "Шевченко", "Володимирівна", 4),
            new Autor(6, "Вікторія", "Стельмах", "Вікторівна", 5),
            new Autor(7, "Юлія", "Шевченко", "Ярославівна", 5),
        };
        public List<Organization> Organizations { get; init; } = new List<Organization>()
        {
            new Organization(1, "Global Autors Organization", "20 Great Queen St", "London"),
            new Organization(2, "Autor Group", "95 New Cavendish St", "London"),
            new Organization(3, "New York Autors Organization", "1201 Broadway", "New York"),
            new Organization(4, "World Autors", "580 5th Ave Suite 1721", "New York"),
            new Organization(5, "Товариство київських журналістів", "вул. Хрещатик 18", "Київ")
        };
    }
}
