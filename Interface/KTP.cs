using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_7.Interface
{
    class KTP : IMahasiswa
    {
        public void Biodata()
        {
            {
                Console.WriteLine();
                Console.WriteLine("    KTP ( Kartu Tanda Penduduk ) ");
                Console.WriteLine("Nama     : Mukhamad yusuf afandi");
                Console.WriteLine("Alamat   : Rembang");
                Console.WriteLine("Telp  : 08134614622 ");
            }
        }
    }
        
   
}
