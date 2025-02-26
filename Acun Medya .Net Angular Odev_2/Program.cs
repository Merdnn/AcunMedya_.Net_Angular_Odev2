//1-	For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.
Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

int toplam = 0;

for (; sayi != 0; sayi /= 10)
{
    int rakam = sayi % 10;
    toplam += rakam;
}

Console.WriteLine("Girilen sayının rakamlarının toplamı: " + toplam);

//2- while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız(Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste.)

int sayi = 0;

while (true)
{
    Console.Write("10 ile 100 arasında bir sayı giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi >= 10 && sayi <= 100)
    {
        break;
    }

    else
    {
        Console.Write("Hatalı Giriş yaptınız! Lütfen tekrar 10 ile 100 arasında bir sayı giriniz: ");
    }

}

Console.WriteLine("Girilen Geçerli sayı: " + sayi);


//3- foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.( 0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı.)

int[] yaslar = { 10, 17, 25, 5, 60, 70, 13, 45 };

foreach (int yas in yaslar)
{
    if (yas >= 0 && yas <= 12)
    {
        Console.WriteLine($"{yas} yaş: Çocuk");
    }

    else if (yas >= 13 && yas <= 19)
    {
        Console.WriteLine($"{yas} yaş: Genç");
    }
    else if (yas >= 20 && yas <= 64)
    {
        Console.WriteLine($"{yas} yaş: Yetişkin");
    }
    else if (yas >= 65)
    {
        Console.WriteLine($"{yas} yaş: Yaşlı");
    }
}

//4- Bir dizide tekrar eden elemanları bulan algoritmayı yazınız.

int[] sayilar = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 3, 8, 1 };

Dictionary<int, int> sayac = new Dictionary<int, int>();

foreach (int sayi in sayilar)
{
    if (sayac.ContainsKey(sayi))
    {
        sayac[sayi]++;
    }
    else
    {
        sayac[sayi] = 1;
    }

    Console.WriteLine("Tekrar eden elemanlar:");

    foreach (var eleman in sayac)
    {
        if (eleman.Value > 1)
        {
            Console.WriteLine($"Eleman: {eleman.Key}, Tekrar sayısı: {eleman.Value}");
        }
    }


}


// 5-	Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.


string[] kelimeler = { "merdan", "efe", "Taşş" };

var enUzunKelime = kelimeler.OrderByDescending(kelimeler => kelimeler.Length).First();
var enKisaKelime = kelimeler.OrderBy(kelimeler => kelimeler.Length).First();

Console.WriteLine($"En uzun Kelime: {enUzunKelime}");
Console.WriteLine($"En kısa kelime: {enKisaKelime}");

//6-	Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.

Console.Write("Bir cümle girin: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');
words = words.OrderBy(word => word).ToArray();

Console.WriteLine("Alfabetik sıraya göre kelimeler:");
foreach (var word in words)
{
    Console.WriteLine(word);
}

//7-	Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.

List<string> words = new List<string>();

while (true)
{
    Console.Write("Bir kelime girin (Çıkmak için 'exit' yazın): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    words.Add(input);
}
words = words.OrderBy(word => word).ToList();

Console.WriteLine("Alfabetik sıraya göre kelimeler:");
foreach (var word in words)
{
    Console.WriteLine(word);
}

//8-	Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız.

List<string> words = new List<string>();

while (true)
{
    Console.Write("Bir kelime girin (Çıkmak için 'exit' yazın): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    words.Add(input);
}

words.Reverse();

Console.WriteLine("Girilen kelimelerin tersten sıralanmış hali:");
foreach (var word in words)
{
    Console.WriteLine(word);
}

//9-	Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.

List<int> numbers = new List<int>();

while (true)
{
    Console.Write("Bir sayı girin (Çıkmak için 'exit' yazın): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (int.TryParse(input, out int number))
        numbers.Add(number);
    else
        Console.WriteLine("Lütfen geçerli bir sayı girin.");
}

if (numbers.Count > 0)
{
    double average = numbers.Average();
    numbers.Sort();

    Console.WriteLine($"Girilen sayıların ortalaması: {average}");
    Console.WriteLine("Küçükten büyüğe sıralanmış sayılar:");
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
}
else
{
    Console.WriteLine("Hiç sayı girilmedi.");
}

//10-	Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.

List<int> numbers = new List<int>();

while (true)
{
    Console.Write("Bir sayı girin (Çıkmak için 'exit' yazın): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (int.TryParse(input, out int number))
        numbers.Add(number);
    else
        Console.WriteLine("Lütfen geçerli bir sayı girin.");
}

numbers.RemoveAll(n => n < 10);

if (numbers.Count > 0)
{
    double average = numbers.Average();
    numbers.Sort();

    Console.WriteLine("10’dan küçük olan sayılar silindi.");
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
}
else
{
    Console.WriteLine("Hiç geçerli sayı kalmadı.");
}

//11-	Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.

List<int> grades = new List<int>();

while (true)
{
    Console.Write("Bir not girin (Çıkmak için 'exit' yazın): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (int.TryParse(input, out int grade))
        grades.Add(grade);
    else
        Console.WriteLine("Lütfen geçerli bir not girin.");
}

grades = grades.Select(g => g < 50 ? 50 : g).ToList();

Console.WriteLine("Güncellenmiş notlar (50'nin altındakiler 50 olarak değiştirildi):");
foreach (var grade in grades)
{
    Console.WriteLine(grade);
}

//12 - Metot fonksiyon nedir?
//Metot (veya fonksiyon), belirli bir işlemi gerçekleştiren ve tekrar kullanılabilir kod bloklarıdır. Bir metot, programın farklı yerlerinde çağrılabilir ve böylece kod tekrarını önler, okunabilirliği artırır.

// örnek
int a = 10, b = 20;
int toplam = Topla(a, b);
Console.WriteLine("Toplam: " + toplam);
    }

    static int Topla(int x, int y)
{
    return x + y;
}

//13 - Metotları neden kullanırız?
// a) Aynı işlemi farklı yerlerde kullanmak gerektiğinde, metotlar sayesinde aynı kodu tekrar tekrar yazmak zorunda kalmayız.
// b) Kodun belirli bölümlerini anlamak ve yönetmek daha kolay olur. Her metot belirli bir işlemi yapar, böylece ana kodunuzu daha anlaşılır hale getirirsiniz.
// c) Kodda değişiklik yapmanız gerektiğinde, sadece metodu güncellemeniz yeterlidir.
// d) Bir metodu birden fazla yerde çağırabiliriz, bu da zamandan tasarruf sağlar ve hata yapma olasılığını azaltır.

//14 - Geriye değer döndüren (return kullanan) metot ile void metot arasındaki fark nedir?
//Geriye değer döndüren metotlar, return ile bir değer döndürürken; void metotlar hiçbir değer döndürmez. Geriye değer döndüren metotlar genellikle hesaplama sonuçlarını döndürmek için, void metotlar ise yan etkiler yaratmak (örneğin, ekrana yazdırmak) için kullanılır.

//15 - Metotların parametreleri nasıl çalışır?
void OrnekMetot(int sayi = 10) { }