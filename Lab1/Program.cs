using Lab1.ConsolePrint;
using Lab1.SolutionItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{

    public class Program
    {
        static void Main()
        {
            QueriesExecutor qryExecutor = new();
            ConsoleQueriesPrinter printer = new();
            DataListsHolder dataLists = new();

            PrintAndQueriesConnector printQryCon = new(qryExecutor, printer, dataLists);


            Menu menu = new();
            menu.Items = new()
            {
                new MenuItem("1. Вивести всіх авторів", printQryCon.PrintAllAutors),
                new MenuItem("2. Вивести статті назви яких мають принаймні два слова", printQryCon.PrintAllArticlesNameMoreThanWord),
                new MenuItem("3. Вивести журнали наступна публікація в яких буде цього року", printQryCon.PrintMagazinesNextPublishingThisYear),
                new MenuItem("4. Вивести організації згруповані по містам", printQryCon.PrintOrganizationsGroupedByCity),
                new MenuItem("5. Вивести статті по порядку зростання назви", printQryCon.PrintArticlesOrderedByNameLength),
                new MenuItem("6. Вивести статті по порядку публікації з 2020 року", printQryCon.PrintArticlesOrderedByDateAfter2020),
                new MenuItem("7. Вивести статті з ключовим словом Jeans у назві", printQryCon.PrintArticleBySpecificWord),
                new MenuItem("8. Вивести журнали з накладом в діапазоні від 900 до 11000", printQryCon.PrintMagazinesWithEditionRange),
                new MenuItem("9. Вивести статті що були видані після 2020", printQryCon.PrintArticlesWithPublishDateMoreThan2020),
                new MenuItem("10. Вивести статті журнали та авторів", printQryCon.PrintArticleMagazineAndAutor),
                new MenuItem("11. Вивести журнали згруповані по кількості накладу", printQryCon.PrintMagazinesGroupedByEdition),
                new MenuItem("12. Вивести авторів та їхні статті", printQryCon.PrintAllArticlesAndTheirAutors),
                new MenuItem("13. Вивести журнали та їхні статті", printQryCon.PrintArticlesGroupedByMagazines),
                new MenuItem("14. Вивести статті з найбільшим накладом", printQryCon.PrintArticlesWithBiggestEdition),
                new MenuItem("15. Вивести організації в порядку зростання учасників", printQryCon.PrintOrganizationOrderedByParticipantCount),
                new MenuItem("16. Вивести статті згруповані по організаціях в яких автори статтей", printQryCon.PrintArticlesGroupedByOrganization),
                new MenuItem("17. Вивести авторів і кількість журналів виданих з їхніми статтями", printQryCon.PrintCountOfReleasedArticlesOfAutors),
                
                new MenuItem("\n18. Вихід", () => menu.IsExitWanted = true)
            };

            MenuItemSelector selector = new(1, menu.ItemsCount);

            while(!menu.IsExitWanted)
            {
                menu.PrintMenu();
                menu.ExecuteSelectedItem(selector.SelectItem());

                Console.WriteLine("\nДля продовження натисніть будь-яку клавішу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}