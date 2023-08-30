using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP
{
    class Program
    {
        static void Main(String[] args)
        {
            SinhVien sv1 = new SinhVien(123,"NgoThiThuyLinh",9.8,8.3);
            Console.WriteLine(sv1.XuatChuoi());
            Console.ReadLine();

        }
    }
    
}
