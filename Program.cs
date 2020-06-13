using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tugas_Lab_7.AbstracClass;
namespace Tugas_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa Mahasiswa;
             Mahasiswa = new MHS();
             Mahasiswa.Biodata();
             Mahasiswa = new KTP();
             Mahasiswa.Biodata();
          
           





            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
