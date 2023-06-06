using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.SolutionItems
{
    internal class QueriesExecutor
    {
        // #1
        public IEnumerable<Autor> GetAllAutors(IEnumerable<Autor> autors)
        {
            return autors;
        }

        // #2
        public IEnumerable<Article> GetAllArticlesNameMoreThanWord(IEnumerable<Article> articles)
        {
            return articles.Where(article => article.Name.Contains(' '));
        }

        // #3
        public IEnumerable<Magazine> GetMagazinesNextPublishingThisYear(IEnumerable<Magazine> magazines)
        {
            return magazines.Where(magazines => magazines.ReleaseDate.Year.Equals(2023));
        }

        // #4
        public Dictionary<string, List<Organization>> GetOrganizationsGroupedByCity(IEnumerable<Organization> organizations)
        {
            return (from organization in organizations
                    group organization by organization.City)
                    .ToDictionary(organizations => organizations.Key, organizations => organizations.ToList());
        }

        // #5
        public IEnumerable<Article> GetArticlesOrderedByNameLength(IEnumerable<Article> articles)
        {
            return articles.OrderBy(article => article.Name.Length);
        }

        //#6
        public IEnumerable<Article> GetArticlesOrderedByDateAfter2020(IEnumerable<Article> articles)
        {
            return articles.Where(articles => articles.AddingDate.Year > 2020).OrderBy(articles => articles.AddingDate);
        }

        //#7
        public IEnumerable<Article> GetArticleBySpecificWord(IEnumerable<Article> articles, string word)
        {
            word = "Jeans";
            return articles.Where(articles => articles.Name.Contains(word)).OrderByDescending(articles => articles.Name);
        }

        //#8
        public IEnumerable<Magazine> GetMagazinesWithEditionRange(IEnumerable<Magazine> magazines, int min, int max)
        {
            return magazines.Where(magazines => magazines.Edition > min && magazines.Edition < max);
        }

        //#9
        public IEnumerable<Article> GetArticlesWithPublishDateMoreThan2020(IEnumerable<Article> articles)
        {
            return (from article in articles
                    where article.AddingDate.Year > 2020
                    select article);
        }

        //#10
        public List<string> GetArticleMagazineAndAutor(IEnumerable<Article> articles,
                                                       IEnumerable<Autor> autors,
                                                       IEnumerable<Magazine> magazines)
        {
            var query = from article in articles
                        join magazine in magazines
                        on article.MagazineID equals magazine.MagazineId
                        join autor in autors
                        on article.AutorID equals autor.AutorID
                        select new
                        {
                            ArticleName = article.Name,
                            MagazineName = magazine.Name,
                            AutorName = autor.AutorName,
                            AutorSurname = autor.AutorSurname
                        };

            var result = new List<string>();
            foreach(var obj in query)
            {
                result.Add($"Назва статті: {obj.ArticleName} журнал у якому ця стаття: {obj.MagazineName} її автор: {obj.AutorName} {obj.AutorSurname}");
            }
            return result;
        }
             
        //#11
        public Dictionary<int, List<Magazine>> GetMagazinesGroupedByEdition(IEnumerable<Magazine> magazines)
        {
            return (from magazine in magazines
                    group magazine by magazine.Edition)
                    .ToDictionary(magazines => magazines.Key, magazines => magazines.ToList());
        }

        //#12
        public IEnumerable<string> GetAllArticlesAndTheirAutors(IEnumerable<Autor> autors, IEnumerable<Article> articles)
        {
            var result = new List<string>();

            var query = from article in articles
                        join autor in autors
                        on article.AutorID equals autor.AutorID
                        orderby article.ArticleId descending
                        select new
                        {
                            ArticleName = article.Name,
                            AutorName = autor.AutorName,
                            AutorSurname = autor.AutorSurname,
                            AutorMiddleName = autor.AutorMiddleName    
                        };

            foreach(var obj in query)
            {
                result.Add($"Стаття: {obj.ArticleName}  Автор: {obj.AutorName} {obj.AutorSurname} {obj.AutorMiddleName}");
            }

            return result;
        }


        //#13
        public Dictionary<string, List<string>> GetArticlesGroupedByMagazines(IEnumerable<Magazine> magazines, IEnumerable<Article> articles)
        {
            return magazines.GroupJoin(articles,
                                            magazines => magazines.MagazineId,
                                            articles => articles.MagazineID,
                                            (magazines, articles) => new
                                            {
                                                MagazineName = magazines.Name,
                                                ArticleName = articles.Select(articles => articles.Name)
                                            })
                            .ToDictionary(magazines => magazines.MagazineName, articles => articles.ArticleName.ToList());
        }

        //#14
        public IEnumerable<Article> GetArticlesWithBiggestEdition(IEnumerable<Article> articles, IEnumerable<Magazine> magazines)
        {
            var MaxEditionMagazinesID = magazines.Where(magazine => magazine.Edition == magazines.Max(magazine => magazine.Edition))
                                                 .Select(magazine => magazine.MagazineId); 
            
            return MaxEditionMagazinesID.Join(articles, 
                                              MEMag => MEMag, 
                                              art => art.MagazineID,
                                              (MEMag, art) => art);        
        }

        //#15
        public IEnumerable<Organization> GetOrganizationOrderedByParticipantCount(IEnumerable<Organization> organizations, 
                                                                                            IEnumerable<Autor> autors)
        {
            var OrganizationsID = autors.Join(organizations,
                                              autors => autors.OrganizationID,
                                              org => org.OrganizationId,
                                              (autors, org) => org.OrganizationId);
            var groupedID = OrganizationsID.GroupBy(orgID => orgID)
                                           .OrderBy(group => group.Count())
                                           .Select(group => group.Key);
            return groupedID.Join(organizations,
                                  groupedID => groupedID,
                                  organizations => organizations.OrganizationId,
                                  (groupedID, organizations) => organizations);
        }
        
        //#16
        public Dictionary<string, List<string>> GetArticlesGroupedByOrganization(IEnumerable<Organization> organizations,
                                                                            IEnumerable<Article> articles,
                                                                            IEnumerable<Autor> autors)
        {
            var articleAutors = from article in articles
                                      join autor in autors
                                      on article.AutorID equals autor.AutorID
                                      select new
                                      {
                                          ArticleName = article.Name,
                                          AutorID = autor.AutorID,
                                          OrganizationID = autor.OrganizationID
                                      };
            var articleOrganizations = from articleAutor in articleAutors
                                      join organization in organizations
                                      on articleAutor.OrganizationID equals organization.OrganizationId
                                      select new
                                      {
                                          OrganizationName = organization.Name,
                                          ArticleName = articleAutor.ArticleName
                                      };
            var groupedArtOrg = from articleOrganization in articleOrganizations
                                group articleOrganization by articleOrganization.OrganizationName into groupedArt
                                select new
                                {
                                    Key = groupedArt.Key,
                                    Values = groupedArt.Select(groupedArt => groupedArt.ArticleName)
                                };
            return groupedArtOrg.ToDictionary(groupedArtOrg => groupedArtOrg.Key, groupedArtOrg => groupedArtOrg.Values.ToList());
        }

        //#17
        public IEnumerable<string> GetCountOfReleasedArticlesOfAutors(IEnumerable<Autor> autors,
                                                                          IEnumerable<Article> articles,
                                                                          IEnumerable<Magazine> magazines)
        {
            var autorArticles = from article in articles
                               join autor in autors
                               on article.AutorID equals autor.AutorID
                               select new
                               {
                                   AutorId = article.AutorID,
                                   MagazineId = article.MagazineID,
                               };
            var autorEditions = from autorArticle in autorArticles
                               join magazine in magazines
                               on autorArticle.MagazineId equals magazine.MagazineId
                               select new
                               {
                                   AutorID = autorArticle.AutorId,
                                   Edition = magazine.Edition
                               };
            var groupAutors = from autorEdition in autorEditions
                             group autorEdition by autorEdition.AutorID into editionAutor
                             select new
                             {
                                 Key = editionAutor.Key,
                                 Value = editionAutor.Sum(editionAutor => editionAutor.Edition)
                             };
            var query = from groupAutor in groupAutors
                        join autor in autors
                        on groupAutor.Key equals autor.AutorID
                        select new
                        {
                            Value = groupAutor.Value,
                            Name = autor.AutorName,
                            Surname = autor.AutorSurname
                        };

            var result = new List<string>();
            foreach (var autor in query)
            {
                result.Add($"Автор: {autor.Name} {autor.Surname} кількість журналів з статтями автора: {autor.Value}");
            }
            return result;
        }
    }
}
