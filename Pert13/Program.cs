namespace Pert13
{
    public class Program
    {
        static void Main(string[] args)
        {
            //membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "3890";
            mhs1.NamaMahasiswa = "Wahyu";

            //membuat object mhs1
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "3869";
            mhs2.NamaMahasiswa = "Mr.Jhoo";

            //membuat object dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0011";
            dosen.NamaDosen = "Friska";

            //membiat object list
            List<Mahasiswa> list = new List<Mahasiswa>();

            //menambahkan elemen list
            list.Add(mhs1);
            list.Add(mhs2);

            //coba rambahkan objek dosen ke list, apa yang terjadi
            //list.Add(dosen);

            Console.WriteLine("{0, -15} {1, -15} ", "NIM", "NAMA");
            Console.WriteLine("=========================");

            foreach (Mahasiswa mhs in list)
            {
                //mengakses elemen list
                //mahasiswa mhs = list[1];
                Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            Console.WriteLine("{0}, {1}", dosen.Nik, dosen.NamaDosen);
            Console.ReadKey();
        }
    }
}