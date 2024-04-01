using System.Text;
using MyNamespace;

namespace Pemrograman_Dasar_Dotnet;

internal static class Program
{
    private static void Main(string[] args)
    {
        var databaseMahasiswa = new DatabaseMahasiswa();

        var mahasiswaA = new Mahasiswa("A", "123", "Bumi", 20);
        databaseMahasiswa.AddMahasiswa(mahasiswaA);

        Console.WriteLine(databaseMahasiswa.ToString());
    }
}
