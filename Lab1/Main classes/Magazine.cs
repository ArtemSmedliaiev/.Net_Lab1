using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Magazine
    {
        public int MagazineId { get; init; }
        public string Name { get; init; }
        public int Period { get; init; }
        public int Edition { get; init; }
        public DateTime ReleaseDate { get; init; }

        public Magazine(int magazineId, string name, int period, int edition, DateTime releaseDate)
        {
            MagazineId = magazineId;
            Name = name;
            Period = period;
            Edition = edition;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"Журнал: {Name} наступна публікація: {ReleaseDate}";
        }
    }
}
