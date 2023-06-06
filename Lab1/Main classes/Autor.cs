using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Autor
    {
        public int AutorID { get; init; }
        public string AutorName { get; init; }
        public string AutorSurname { get; init; }
        public string AutorMiddleName { get; init; }
        public int OrganizationID { get; init; }

        public Autor(int autorID, string autorName, string autorSurname, string autorMiddleName, int organizationID)
        {
            AutorID = autorID;
            AutorName = autorName;
            AutorSurname = autorSurname;
            AutorMiddleName = autorMiddleName;
            OrganizationID = organizationID;
        }

        public override string ToString()
        {
            return $"Aвтор: {AutorName} {AutorSurname}";
        }
    }
}
