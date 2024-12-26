using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan meyve seçmesini istiyoruz.
        Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma, Armut, Çilek, Muz, Diğer)");
        string meyve = Console.ReadLine().ToLower(); // Kullanıcının cevabını küçük harfe çeviriyoruz.

        // IF yapısı ile çözüm
        Console.WriteLine("\nIF Yapısı ile Çözüm:");
        if (meyve == "elma")
        {
            Console.WriteLine("Seçtiğiniz meyve: Elma, Fiyat: 2 TL");
        }
        else if (meyve == "armut")
        {
            Console.WriteLine("Seçtiğiniz meyve: Armut, Fiyat: 3 TL");
        }
        else if (meyve == "çilek")
        {
            Console.WriteLine("Seçtiğiniz meyve: Çilek, Fiyat: 2 TL");
        }
        else if (meyve == "muz")
        {
            Console.WriteLine("Seçtiğiniz meyve: Muz, Fiyat: 3 TL");
        }
        else
        {
            Console.WriteLine("Seçtiğiniz meyve: Diğer, Fiyat: 4 TL");
        }

        // Switch yapısı ile çözüm
        Console.WriteLine("\nSwitch Yapısı ile Çözüm:");
        switch (meyve)
        {
            case "elma":
                Console.WriteLine("Seçtiğiniz meyve: Elma, Fiyat: 2 TL");
                break;
            case "armut":
                Console.WriteLine("Seçtiğiniz meyve: Armut, Fiyat: 3 TL");
                break;
            case "çilek":
                Console.WriteLine("Seçtiğiniz meyve: Çilek, Fiyat: 2 TL");
                break;
            case "muz":
                Console.WriteLine("Seçtiğiniz meyve: Muz, Fiyat: 3 TL");
                break;
            default:
                Console.WriteLine("Seçtiğiniz meyve: Diğer, Fiyat: 4 TL");
                break;
        }
    }
}
