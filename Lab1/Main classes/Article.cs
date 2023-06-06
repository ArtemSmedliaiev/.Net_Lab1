using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Article
    {
        public string Name { get; init; }
        public int ArticleId { get; init; }
        public int AutorID { get; init; }
        public int MagazineID { get; init; }
        public DateTime AddingDate { get; init; }

        public Article(string name, int articleId, DateTime addingDate, int autorID, int magazineID)
        {
            Name = name;
            ArticleId = articleId;
            AddingDate = addingDate;
            AutorID = autorID;
            MagazineID = magazineID;
        }

        public override string ToString()
        {
            return $"Назва статті: {Name} дата публікації: {AddingDate}";
        }
    }
}
