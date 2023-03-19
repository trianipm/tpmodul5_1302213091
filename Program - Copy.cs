using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek dari class HaloGeneric
        HaloGeneric halo = new HaloGeneric();

        // Memanggil method SapaUser pada objek halo
        halo.SapaUser("Triani Putri Mumpuni");

        // Membuat objek dari class DataGeneric
        DataGeneric<string> data = new DataGeneric<string>("1302213091");

        // Memanggil method PrintData pada objek data
        data.PrintData();

        Console.ReadLine();
    }
}


