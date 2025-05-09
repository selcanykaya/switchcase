Console.Write("Hangi meyveyi satın almak istiyorsunuz: ");
string meyve = Console.ReadLine().ToLower(); //büyük küçük harf duyarlılığını ortadan kaldırmak için ToLower() kullandık.
int fiyat;
//switch case kullanarak meyve fiyatlarını belirliyoruz.
 switch (meyve)
{
    case "elma":
        fiyat = 2;
        break;
    case "armut":
        fiyat = 3;
        break;
    case "çilek":
        fiyat = 2;
        break;
    case "muz":
        fiyat = 3;
        break;
    default:
        fiyat = 4;
        break;
}
Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {fiyat} TLdir." );

//if else kullanarak meyve fiyatlarını belirliyoruz.

/* if (meyve == "elma")
{
    fiyat = 2;
}
else if (meyve == "armut")
{
    fiyat = 3;
}
else if (meyve == "çilek")
{
    fiyat = 2;
}
else if (meyve == "muz")
{
    fiyat = 3;
}
else
{
    fiyat = 4;
}
Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {fiyat} TLdir."); */

////Switch case kullanımı daha pratik ve okunabilir kılıyor ve seçenek eklemeyi kolaylaştırıyor.Her ürün kısa bir ifadeyle eşleştiği için yazımı daha kolay.