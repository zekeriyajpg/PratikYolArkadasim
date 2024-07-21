while (true)
{
    string lokasyonAdi = "";
    int lokasyonFiyati = 0;
    bool lokasyonSecildi = false;

    // Lokasyon seçimi
    while (!lokasyonSecildi)
    {
        Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz (Bodrum, Marmaris, Çeşme): ");
        string lokasyon = Console.ReadLine().Trim().ToLowerInvariant();

        if (lokasyon == "bodrum")
        {
            lokasyonFiyati = 4000;
            lokasyonAdi = "Bodrum";
            lokasyonSecildi = true;
        }
        else if (lokasyon == "marmaris")
        {
            lokasyonFiyati = 3000;
            lokasyonAdi = "Marmaris";
            lokasyonSecildi = true;
        }
        else if (lokasyon == "çeşme" || lokasyon == "cesme")
        {
            lokasyonFiyati = 5000;
            lokasyonAdi = "Çeşme";
            lokasyonSecildi = true;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli bir lokasyon ismi giriniz: Bodrum, Marmaris, Çeşme");
        }
    }

    Console.WriteLine($"{lokasyonAdi} (Paket başlangıç fiyatı {lokasyonFiyati} TL)");

    // Kişi sayısını alma
    int kisiSayisi;
    while (true)
    {
        Console.Write("Kaç kişi için tatil planlamak istiyorsunuz? ");
        if (int.TryParse(Console.ReadLine(), out kisiSayisi) && kisiSayisi > 0)
        {
            break;
        }
        Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz.");
    }

    // Ulaşım şekli seçimi
    int ulasimTutari;
    while (true)
    {
        Console.WriteLine("Tatiline ne şekilde gitmek istiyorsunuz?");
        Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
        Console.Write("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz (1 ya da 2): ");

        string ulasimSecim = Console.ReadLine().Trim();
        if (ulasimSecim == "1")
        {
            ulasimTutari = 1500;
            break;
        }
        else if (ulasimSecim == "2")
        {
            ulasimTutari = 4000;
            break;
        }
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 ya da 2 seçeneklerinden birini giriniz.");
    }

    // Toplam fiyat hesaplama
    int toplamFiyat = lokasyonFiyati + (ulasimTutari * kisiSayisi);
    Console.WriteLine($"Toplam fiyat: {toplamFiyat} TL");

    // Başka tatil planlamak isteyip istemediği sorulması
    Console.Write("Başka bir tatil planlamak ister misiniz? (E/H): ");
    string devam = Console.ReadLine().Trim().ToLowerInvariant();
    if (devam != "e")
    {
        Console.WriteLine("İyi günler!");
        break;
    }
}