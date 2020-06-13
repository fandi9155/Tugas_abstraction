using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_7.AbstracClass
{
    class KTP : Mahasiswa
    {
        public override void Biodata()
        {
            Console.WriteLine();
            Console.WriteLine("    KTP ( Kartu Tanda Penduduk ) ");
            Console.WriteLine("Nama     : Mukhamad yusuf afandi");
            Console.WriteLine("Alamat   : Rembang");
            Console.WriteLine("Telp  : 08134614622 ");

        }
    }
}
