public class Mahasiswa
{
  private string _nama;
  private string _nim;
  private string _alamat;
  private int _umur;
  public Mahasiswa(string nama, string nim, string alamat, int umur)
  {
    _nama = nama;
    _nim = nim;
    _alamat = alamat;
    _umur = umur;
  }
  public string GetNama()
  {
    return _nama;
  }
  public string GetNim()
  {
    return _nim;
  }
  public string GetAlamat()
  {
    return _alamat;
  }
  public int GetUmur()
  {
    return _umur;
  }
  public void SetNama(string nama)
  {
    _nama = nama;
  }
  public void SetNim(string nim)
  {
    _nim = nim;
  }
  public void SetAlamat(string alamat)
  {
    _alamat = alamat;
  }
  public void SetUmur(int umur)
  {
    _umur = umur;
  }
}
