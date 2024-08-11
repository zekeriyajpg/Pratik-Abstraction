using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Abstraction
{
    public class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string ad, string soyad, string departman)
            : base(ad, soyad, departman)
        { }
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum.");
        }


    }

    public class ProjectManager : Employee
    {
        public ProjectManager(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} proje yöneticisi olarak çalışıyorum.");
        }
    }
    public class SalesRepresentative : Employee
    {
        public SalesRepresentative(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} satış temsilcisi olarak çalışıyorum.");
        }
    }
}
