using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    internal class Ilce
    {
        public int IlceId { get; set; }
        public Il Il { get; set; }
        public string Name { get; set; }

        public Ilce(int ılceId, Il Il, string name)
        {
            IlceId = ılceId;
            this.Il = Il;
            Name = name;
        }

        public string info()
        {
           
            return $"İl: {Il.info()}, İlçe: {Name}";
        }

    }
}
