namespace MyNamespace
{
  public class DatabaseMahasiswa
  {
    private readonly Dictionary<string, Mahasiswa> _mahasiswas;
    public DatabaseMahasiswa()
    {
      _mahasiswas = [];
    }

    public void AddMahasiswa(Mahasiswa mahasiswa)
    {
      _mahasiswas.Add(mahasiswa.GetNim(), mahasiswa);
    }

    public Mahasiswa GetMahasiswa(string nim)
    {
      return _mahasiswas[nim];
    }

    public void RemoveMahasiswa(string nim)
    {
      _mahasiswas.Remove(nim);
    }

    public void UpdateMahasiswa(Mahasiswa mahasiswa)
    {
      _mahasiswas[mahasiswa.GetNim()] = mahasiswa;
    }

    public List<Mahasiswa> GetAllMahasiswa()
    {
      return [.. _mahasiswas.Values];
    }

    public List<Mahasiswa> GetMahasiswaByNama(string nama)
    {
      return _mahasiswas.Values.Where(mahasiswa => mahasiswa.GetNama().Contains(nama)).ToList();
    }


    public override string ToString()
    {
      var listOfMhs = GetAllMahasiswa();
      var result = new System.Text.StringBuilder();
      foreach (var item in listOfMhs)
      {
        result.Append($"Nama: {item.GetNama()}, NIM: {item.GetNim()}, Alamat: {item.GetAlamat()}, Umur: {item.GetUmur()}\n");
      }
      return result.ToString();
    }
  }
}
