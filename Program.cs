using PatikafyMusicPlatform;

List<Singer> singers = new List<Singer>
{
    new Singer("Ajda Pekkan", "Pop", 1968, 20000000),
    new Singer("Sezen Aksu", "Turkish Folk Music / Pop", 1971, 10000000),
    new Singer("Funda Arar", "Pop", 1999, 3000000),
    new Singer("Sertab Erener", "Pop", 1994, 5000000),
    new Singer("Sıla", "Pop", 2009, 3000000),
    new Singer("Serdar Ortaç", "Pop", 1994, 10000000),
    new Singer("Tarkan", "Pop", 1992, 40000000),
    new Singer("Hande Yener", "Pop", 1999, 7000000),
    new Singer("Hadise", "Pop", 2005, 5000000),
    new Singer("Gülben Ergen", "Pop / Turkish Folk Music", 1997, 10000000),
    new Singer("Neşet Ertaş", "Turkish Folk Music / Turkish Classical Music", 1960, 2000000)
};
foreach (Singer singer in singers)
{
    Console.WriteLine(singer);
    Console.WriteLine();
}

Console.WriteLine("-------------------------------------------------------------------------------------------");
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar");
Console.WriteLine(" ");
var singersStartingS = singers.Where(x => x.Name.StartsWith("S"));

foreach (Singer singer in singersStartingS)
{
    Console.WriteLine(singer.Name);
    Console.WriteLine();
}
Console.WriteLine("-------------------------------------------------------------------------------------------");
Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar");
Console.WriteLine(" ");
var singersWithAlbumSalesOver10M =singers.Where(x => x.AlbumSales > 10000000);

foreach (Singer singer in singersWithAlbumSalesOver10M)
{
    Console.WriteLine($"{singer.Name} - {singer.AlbumSales}");
    Console.WriteLine();
}

Console.WriteLine("-------------------------------------------------------------------------------------------");
Console.WriteLine(" ");
Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.");
//Orderby ile ilk önce çıkış yılına göre sıralama yapılır. Daha sonra isme göre sıralama yapılır.
var singersBefore2000 = singers.Where(x => x.DebutYear < 2000 && x.MusicGenre == "Pop").OrderBy(x => x.DebutYear).ThenBy(x => x.Name);

foreach (var singer in singersBefore2000)
{
    Console.WriteLine($"{singer.DebutYear} - {singer.Name} - {singer.MusicGenre}");
}

Console.WriteLine("-------------------------------------------------------------------------------------------");
Console.WriteLine(" ");
Console.WriteLine("En çok albüm satan şarkıcı");


var singerWithMostSales = singers.OrderByDescending(x => x.AlbumSales).First();

Console.WriteLine($"{singerWithMostSales.Name} - {singerWithMostSales.AlbumSales}");

Console.WriteLine("-------------------------------------------------------------------------------------------");
Console.WriteLine(" ");

Console.WriteLine("En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı");

Console.WriteLine("En yeni çıkış yapan şarkıcı:");
var newestSinger = singers.OrderByDescending(x => x.DebutYear).First();
Console.WriteLine($"{newestSinger.Name} - {newestSinger.DebutYear}");

Console.WriteLine("\nEn eski çıkış yapan şarkıcı:");
var oldestSinger = singers.OrderBy(x => x.DebutYear).First();
Console.WriteLine($"{oldestSinger.Name} - {oldestSinger.DebutYear}");