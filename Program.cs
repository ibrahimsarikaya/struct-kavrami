using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Structlar değer tipindedir. Basit projeler için struct kullanmak daha mantıklıdır.
            //Referans Tipleri: String, class, object, array, pointer > Bir ifade referans türleri içeriyorsa nesnenin adresi üzerinden işlem yapılmaktadır. Heap bölgesinde tutulur. Daha avantajlıdır. Öbekte tutulduğu için.
            //Değer(Value) Tipleri : int, long, byte, char, struct, enum > Stack bölgesinde tutulur.


            Dikdortgen dikdortgen =new Dikdortgen();
            dikdortgen.KisaKenar=3;
            dikdortgen.UzunKenar=4;

            Console.WriteLine("Class Alan Hesabı   :{0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct; // Struct bu şekilde de yaratılabilir. new olarakta tanımlanabilir. 
            //1-Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,5); dersek ve aşağıdaki uzun kenar=5 , kısa kenar=3 ü silersek yine hesap aynı olacaktır. Çıktı da aynı olacaktır.
            //2-Üstteki Class yapısında dikdortgen.KisaKenar=3; ve dikdortgen.UzunKenar=4; yapısını silersek bize consolda 0 değerini gösterir. Çıktı: Class Alan Hesabı: 0 olur.
            //3-Fakat Structta durum böyle değil. dikdortgen_Struct.KisaKenar=3; ve dikdortgen_Struct.UzunKenar=5; yapısını silersek ekrana bişey yazdırmaz hata verir. 
            //4-Hata vermemesi için Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,5); dersek ve aşağıdaki 3 ve 5 atamasını silersek kod çalışır.
            dikdortgen_Struct.KisaKenar=3;
            dikdortgen_Struct.UzunKenar=5;

            Console.WriteLine("Struct Alan Hesabı   :{0}",dikdortgen_Struct.AlanHesapla());

        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen()
        {
            KisaKenar=3;
            UzunKenar=4;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar) // Classın içindeki public Dikdortgen methodu ile aynı tanımlamadır. Tanımlama tiplerinin farklılığı gösterilmiştir.
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}