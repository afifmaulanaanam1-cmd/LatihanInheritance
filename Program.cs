
Siswa siswaObj = new Siswa("Aji", "Aji@gmial.com", "110510", "Siswa", "XPG6");
Guru guruObj = new Guru("Bu Ida", "IdaMustika@gmail.com", "990990", "Guru", "MTK");

siswaObj.TampilkanInfo();
siswaObj.SubmitTugas();

Console.WriteLine();

guruObj.TampilkanInfo();
guruObj.NilaiTugas();
class User
{
    public string Nama;
    public string Email;
    public string Password;
    public string Role;

    public User(string nama, string email, string password, string role)
    {
        Nama = nama;
        Email = email;
        Password = password;
        Role = role;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine("Menampilkan Info User.....");
        Console.WriteLine($"Nama : {Nama}");
        Console.WriteLine($"Role : {Role}");
    }
}

class Siswa : User 
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string role, string classname) : base(nama, email, password, role)
    {
        ClassName = classname;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"Siswa {Nama} sudah mengumpulkan semua tugas");
    }
}

class Guru : User
{
    public string Mapel;
    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        Mapel = mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {Nama} sudah menilai semua tugas {Mapel}");
    }
}
