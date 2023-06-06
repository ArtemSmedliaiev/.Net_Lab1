using Lab1.SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ConsolePrint
{
    internal class PrintAndQueriesConnector
    {
        private QueriesExecutor _qryExecutor;
        private ConsoleQueriesPrinter _printer;
        private DataListsHolder _dataLists;

        public PrintAndQueriesConnector(QueriesExecutor qryExecutor, ConsoleQueriesPrinter printer,
               DataListsHolder dataLists)
        {
            _qryExecutor = qryExecutor;
            _printer = printer;
            _dataLists = dataLists;
        }

        public void PrintAllAutors()
        {
            _printer.Print("всіх авторів", _qryExecutor.GetAllAutors(_dataLists.Autors));
        }

        public void PrintAllArticlesNameMoreThanWord()
        {
            _printer.Print("всі статті назви яких мають принаймні два слова", _qryExecutor.GetAllArticlesNameMoreThanWord(_dataLists.Articles));
        }

        public void PrintMagazinesNextPublishingThisYear()
        {
            _printer.Print("всі журнали в яких наступна публікація буде цього року", _qryExecutor.GetMagazinesNextPublishingThisYear(_dataLists.Magazines));
        }

        public void PrintOrganizationsGroupedByCity()
        {
            _printer.Print("організації згруповані по містам", _qryExecutor.GetOrganizationsGroupedByCity(_dataLists.Organizations));
        }

        public void PrintArticlesOrderedByNameLength()
        {
            _printer.Print("статті по порядку зростання назви", _qryExecutor.GetArticlesOrderedByNameLength(_dataLists.Articles));
        }

        public void PrintArticlesOrderedByDateAfter2020()
        {
            _printer.Print("статті по порядку публікації з 2020 року", _qryExecutor.GetArticlesOrderedByDateAfter2020(_dataLists.Articles));
        }

        public void PrintArticleBySpecificWord()
        {
            _printer.Print("статті з ключовим словом Jeans у назві", _qryExecutor.GetArticleBySpecificWord(_dataLists.Articles, "jeans"));
        }

        public void PrintMagazinesWithEditionRange()
        {
            _printer.Print("журнали з накладом в діапазоні від 900 до 11000", _qryExecutor.GetMagazinesWithEditionRange(_dataLists.Magazines, 900, 11000));
        }

        public void PrintArticlesWithPublishDateMoreThan2020()
        {
            _printer.Print("статті що були видані після 2020", _qryExecutor.GetArticlesWithPublishDateMoreThan2020(_dataLists.Articles));
        }

        public void PrintArticleMagazineAndAutor()
        {
            _printer.Print("стаття журнал та автор", _qryExecutor.GetArticleMagazineAndAutor(_dataLists.Articles, _dataLists.Autors, _dataLists.Magazines));
        }

        public void PrintMagazinesGroupedByEdition()
        {
            _printer.Print("журнали згруповані по кількості накладу", _qryExecutor.GetMagazinesGroupedByEdition(_dataLists.Magazines));
        }

        public void PrintAllArticlesAndTheirAutors()
        {
            _printer.Print("авторів та їх статті", _qryExecutor.GetAllArticlesAndTheirAutors(_dataLists.Autors, _dataLists.Articles));
        }

        public void PrintArticlesGroupedByMagazines()
        {
            _printer.Print("журнали та їхні статті", _qryExecutor.GetArticlesGroupedByMagazines(_dataLists.Magazines, _dataLists.Articles));
        }

        public void PrintArticlesWithBiggestEdition()
        {
            _printer.Print("статті з найбільшим накладом", _qryExecutor.GetArticlesWithBiggestEdition(_dataLists.Articles, _dataLists.Magazines));
        }

        public void PrintOrganizationOrderedByParticipantCount()
        {
            _printer.Print("організації в порядку зростання кількості учасників", _qryExecutor.GetOrganizationOrderedByParticipantCount(_dataLists.Organizations, _dataLists.Autors));
        }

        public void PrintArticlesGroupedByOrganization()
        {
            _printer.Print("статті згруповані по організаціях в яких автори статтей", _qryExecutor.GetArticlesGroupedByOrganization(_dataLists.Organizations, _dataLists.Articles, _dataLists.Autors));
        }

        public void PrintCountOfReleasedArticlesOfAutors()
        {
            _printer.Print("авторів і кількість журналів виданих з їхніми статтями", _qryExecutor.GetCountOfReleasedArticlesOfAutors(_dataLists.Autors, _dataLists.Articles, _dataLists.Magazines));
        }
    }
}
