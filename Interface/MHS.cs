using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_7.Interface
{
    class MHS : IMahasiswa
    {
        public void Biodata()
        {
            {
                Console.WriteLine("    KTM ( Kartu Tanda Mahasiswa ) ");
                Console.WriteLine();
                Console.WriteLine("Nama     : Mukhamad yusuf afandi");
                Console.WriteLine("NIm      : 19.11.2803");
                Console.WriteLine("Jurusan  : Informatika ");
            }

        }
    }
   
}
