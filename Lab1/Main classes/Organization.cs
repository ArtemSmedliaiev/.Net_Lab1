using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Organization
    {
        public int OrganizationId { get; init; }
        public string Name { get; init; }
        public string Adress { get; init; }
        public string City { get; init; }

        public Organization(int organizationId, string name, string adress, string city)
        {
            OrganizationId = organizationId;
            Name = name;
            Adress = adress;
            City = city;
        }

        public override string ToString()
        {
            return $"Назва: {Name} адреса: {Adress} місто: {City}";
        }
    }
}
