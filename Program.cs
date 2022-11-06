namespace HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string deger = Console.ReadLine();

            //amerikayı baştan keşfetme metodu
            //---------------------------------

            /*int sayi = 0;

            bool at = false, nokta = false;
            foreach (var hakan in deger)
            {
                sayi++;
                if (sayi == 4)
                    Console.WriteLine(hakan);

                if(hakan == '.')
                    nokta = true;

                if (hakan == '@')
                    at = true;
            }

            if (nokta == true && at == true)
                Console.WriteLine("Eposta adresidir");
            else
                Console.WriteLine("Eposta adresi değildir");

            Console.WriteLine(sayi);*/

            //doğru yöntemi
            //----------------------------------------------

            //Console.WriteLine(deger.Length);
            //Console.WriteLine(deger.Substring(3, 1));

            //var nokta = deger.LastIndexOf('.');
            //var at = deger.IndexOf('@');

            //if (nokta != -1 && at != -1)
            //{
            //    Console.WriteLine("Eposta adresidir");

            //    //ahmet@asd.com
            //    //asd.com

            //    string domain = deger.Substring(deger.IndexOf('@') + 1);

            //    if (domain.Trim() == "asd.com")
            //        Console.WriteLine("Fake mail adresidir");

            //    if(deger.IndexOf("asd.com") != -1)
            //        Console.WriteLine("Fake mail adresidir");
            //}
            //else
            //    Console.WriteLine("Eposta adresi değildir");

            //deger.Trim();

            //string[] turler = { "Gerilim", "Romantik", "Bilimkurgu" };

            //string tur = "";
            //foreach (var item in turler)
            //{
            //    tur += item + ",";
            //}

            //Console.WriteLine("Filmin adı: Yüzüklerin Efendisi, Türü: " + tur.TrimEnd(','));

            //string sehir = Console.ReadLine();

            //if(sehir == "istanbul" "İstanbul", "Istanbul", "ISTANBUL", "İSTANBUL")
            //sehir.Equals("istanbul", StringComparison.CurrentCultureIgnoreCase)

            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    Console.WriteLine(sehir[sehir.Length - i + 1]);
            //}

            //Console.WriteLine(sehir.Reverse().ToString());

            //string veri = Console.ReadLine();
            //Console.WriteLine(veri.Remove(2, 5));
            //Console.WriteLine(veri.Replace(" ", ""));
            //Console.WriteLine("bilgeadam".Replace("a", "z"));

            //if (veri.Contains("@"))
            //    Console.WriteLine("Eposta doğru");

            //string tur = "Bilimkurgu,Fantastik,Aksiyon";
            //var veri = tur.Split(',');

            string[] oyuncular = { "Oyuncu1|20", "Oyuncu2|10", "Oyuncu3|3" };

            foreach (var item in oyuncular)
            {
                var oyuncuBilgi = item.Split('|');
            }
            

            string[] deste = { "Karo|3", "Kupa|8", "Maça|1" };

            var kart = deste[0].Split('|');

        }
    }
}