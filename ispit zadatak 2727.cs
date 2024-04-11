using System;

public class Vozilo
{
    public bool JeLiLeti { get; set; }
    public bool JeLiPlovi { get; set; }

    public void KudaVozi()
    {
        Console.WriteLine($"Ovo vozilo {(JeLiLeti ? "leti" : "ne leti")} i {(JeLiPlovi ? "plovi" : "ne plovi")}.");
    }
}

public class Brod : Vozilo
{
    public Brod()
    {
        JeLiLeti = false;
        JeLiPlovi = true;
    }
}


public class Zrakoplov : Vozilo
{
   
    public Zrakoplov()
    {
        JeLiLeti = true;
        JeLiPlovi = false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Brod brod = new Brod();
        Zrakoplov zrakoplov = new Zrakoplov();

        Console.WriteLine("Brod:");
        Console.WriteLine($"Je li leti: {brod.JeLiLeti}");
        Console.WriteLine($"Je li plovi: {brod.JeLiPlovi}");
        brod.KudaVozi();

        Console.WriteLine("\nZrakoplov:");
        Console.WriteLine($"Je li leti: {zrakoplov.JeLiLeti}");
        Console.WriteLine($"Je li plovi: {zrakoplov.JeLiPlovi}");
        zrakoplov.KudaVozi(); 
    }
}
