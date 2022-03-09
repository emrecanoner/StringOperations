using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir karakteri istenilen sayı kadar yazdırma
            Console.WriteLine("***** Bir karakteri istenilen sayı kadar yazdırma *****");
            string str1 = new string('E', 8); //Parantezin içine tek karakter yazmanıza izin verir(char).
            Console.WriteLine(str1);

            //Trim() -> Değerin içindeki beyaz boşlukları siler(White Spaces)
            Console.WriteLine("***** Trim() *****");
            string str2 = "    Emre   Can    ";
            Console.WriteLine(str2.TrimStart()); //Baştaki boşlukları siler.
            Console.WriteLine(str2.TrimEnd()); //Sondaki boşlukları siler.
            Console.WriteLine(str2.Trim()); //Baştaki ve sondaki boşlukları siler.

            //Substring() -> Değerin belirli kısmını alır.
            Console.WriteLine("***** Substring() *****");
            string str3 = "Eskişehir Teknik Üniversitesi";
            Console.WriteLine(str3.Substring(4)); //Dördüncü indeksten itibaren yazdırır.
            Console.WriteLine(str3.Substring(0,2)); //Sıfırıncı indeksten başlayarak 2 indeks yazdırır.
            Console.WriteLine(str3.Substring(3,6)); //Üçüncü indeksten başlayarak 6 indeks yazdırır.

            //ToCharArray() -> Değerin içindekileri bir char array'e atar.
            Console.WriteLine("***** ToCharArray() *****");
            string str4 = "Bilgisayar";
            char[] cArray = str4.ToCharArray();
            char[] cArray2 = str4.ToCharArray(0,5); //Değerin ilk karakterinden itibaren 5 karakteri atar.
            Console.WriteLine(cArray);
            Console.WriteLine(cArray2);

            //ToUpper(), ToLower() -> Değerdeki tüm harfleri büyük ya da küçük yapar.
            Console.WriteLine("***** ToUpper(), ToLower() *****");
            string str5 = "eMre CAN oner";
            Console.WriteLine(str5.ToUpper()); //Harfleri büyük yapar.
            Console.WriteLine(str5.ToLower()); //Harfleri küçük yapar.

            //Split() -> Değeri belirlediğimiz karaktere göre ayırır ve arraylist'e atar.
            Console.WriteLine("***** Split() *****");
            string str6 = "emre,can,öner";
            string str7 = "emre/can/öner";
            string[] strArray = str6.Split(','); //Virgüle göre ayırır.
            string[] strArray2 = str7.Split('/'); //Kesme işaretine göre ayırır.
            Console.WriteLine(strArray[0]);
            Console.WriteLine(strArray2[1]);

            //Clone() -> Değeri object türündeki değişkene kopyalar.
            Console.WriteLine("***** Clone() *****");
            string str8 = "emrecanonercom";
            object str9 = str8.Clone();
            Console.WriteLine(str9);

            //Compare() -> Farklı değerleri karşılaştırır ve sonuç int olarak döner. Aynı ise 0, farklı ise -1 ya da 1 döndürür.
            Console.WriteLine("***** Compare() *****");
            string str10 = "Emre";
            string str11 = "emre";
            string str12 = "Emre";
            Console.WriteLine(string.Compare(str10, str11));
            Console.WriteLine(string.Compare(str10, str12));
            Console.WriteLine(string.Compare(str11, str12));

            //Equals() -> Farklı değerleri karşılaştırır. Aynı ise true değil ise false döndürür.
            Console.WriteLine("***** Equals() *****");
            Console.WriteLine(str10.Equals(str11));
            Console.WriteLine(str10.Equals(str12));
            Console.WriteLine(str11.Equals(str12));

            //Contains() -> Değer içerisinde arama yapmamızı sağlar. True ya da false döndürür.
            Console.WriteLine("***** Contains() *****");
            Console.WriteLine(str10.Contains("em"));
            Console.WriteLine(str10.Contains("Em"));

            //Concat() -> Farklı değerleri birleştirmemizi sağlar.
            Console.WriteLine("***** Concat() *****");
            Console.WriteLine(string.Concat(str10, str11));

            //Join() -> Array'deki değerler arasına değer eklememizi sağlar.
            Console.WriteLine("***** Join() *****");
            string[] strArray3 = { "Emre", "Can", "Öner" };
            Console.WriteLine(string.Join("m", strArray3));
            Console.WriteLine(string.Join("...", strArray3));

            //IndexOf(), LastIndexOf() -> Değer içerisinde arama yapmamızı sağlar.
            //Aranan değer bulunursa, aranan değerin ilk harfinin bulunduğu indeksi döndürür. Değeri bulamazsa -1 döndürür.
            Console.WriteLine("***** IndexOf(), LastIndexOf() *****");
            Console.WriteLine(str10.IndexOf("emr"));
            Console.WriteLine(str10.IndexOf("Em"));
            Console.WriteLine(str10.IndexOf("r"));
            Console.WriteLine(str11.IndexOf("e"));
            Console.WriteLine(str11.LastIndexOf("e")); //Bulduğu son e harfinin indeksini yazdırır.

            //StartWith(), EndWith() -> Değerin istediğimiz değer ile başlayıp başlamadığını ya da bitip bitmediğini kontrol eder.
            Console.WriteLine("***** StartWith(), EndWith() *****");
            Console.WriteLine(str10.StartsWith("E"));
            Console.WriteLine(str10.StartsWith("Em"));
            Console.WriteLine(str10.StartsWith("em"));
            Console.WriteLine(str10.EndsWith("re"));
            Console.WriteLine(str10.EndsWith("Re"));
            Console.WriteLine(str10.EndsWith("e"));

            //Replace() -> Değerin içerisindeki belirli değerleri belirli değerler ile değiştirmemizi sağlar.
            Console.WriteLine("***** Replace() *****");
            Console.WriteLine(str11.Replace("e", "i"));
            Console.WriteLine(str11.Replace("em", "Cem"));

            //Remove() -> Değerin içerisindeki belirli değeri silmemizi sağlar.
            Console.WriteLine("***** Remove() *****");
            string str13 = "string işlemleri";
            Console.WriteLine(str13.Remove(4)); //Dördüncü indeksten itibaren siler.
            Console.WriteLine(str13.Remove(4,2)); //Dördüncü indeksten itibaren 2 indeks siler.
            Console.WriteLine(str13.Remove(2,6)); //İkinci indeksten itibaren 6 indeks siler.

            //Length -> Değerin karakter sayısını bulmamızı sağlar.
            Console.WriteLine("***** Length *****");
            Console.WriteLine(str13.Length);
            Console.WriteLine(str11.Length);

            //@emrecanonercom -> Takip Et :)
        }
    }
}
