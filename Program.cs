
// OOP :Nesne  OOP dünyadaki her şeye bir object olarak bakan bir bakış açısıdır.

// OOP'nin en tepedeki tipi object tipidir.

// Tüm her şey objectten türer

// OOP şu başlıklardan oluşur : 
// 1- Kalıtım : Inheritance  : Üst soydan özellik aktarımı
// 2-Kapsüllemek : Encapsulation : Özelliklerin, kapsüllenerek dış dünyaya açılması
// 3-Çok biçimlilik Polymorphism : Özelliklerin nasıl kullanılacağı(zorunlu ? 
//opsiyonel ? zorunlu ise davranışı değiştirebilir miyiz ?)


// OOP'nin ilk konusu nesne oluşturma ile başlayalım


// Ogrenci.cs isimli dosyada bir ogrenci isimli class (sınıf) yazdık.
// Program.cs dosyasında Ogrenci sınıfından nesneler oluşturacağız

// Sınıf ve Nesne Kavramı : 

// Sınıf : Nesne içerisinde olması gerken özelliklerin tanımlı olduğu şablondur

// Sınıf : Mimarin çizimidir. Yani özellikerin durmuş olduğu şablondur

// Nesne : Sınıf içerisinde duran şablondan üretilmiş öğelerdir

// Ogrenci sinifindan bir kaç nesne üretelim

// nesne örneği almak : 


// aşağıdaki kod örneği iki parçadan oluşuyor

// bu kısım stack bölgesinde, bir pointer oluşturur
//Ogrenci o1


// bu kısım ise, stack bölgesindeki pointer'in işaret ettiği heap bölgesindeki alanda bir
// bellek register eder.(Aynı zamanda, bu nesnesin taşımış olduğu değişkenlerin
// başlangıç değerlerini belleye yazar)
//new Ogrenci();

#region Nesne Örneği alma ve ekran yazdırma
/*
Ogrenci ogrenci1 = new Ogrenci();

// değer verelim 
ogrenci1.name="Oğuzhan";
ogrenci1.lastname="Ayaz";
ogrenci1.age=12;

// o1 adında nesnemiz hazır : Ekrana yazdıralım

Console.WriteLine("Ad : {0}",ogrenci1.name);
Console.WriteLine("Soyad : {0}",ogrenci1.lastname);
Console.WriteLine("Yaş : {0}",ogrenci1.age);

*/
#endregion

// 4 adet öğrenci nesnesi üretip, bir dizi içerisine yerleştirelim

Ogrenci ogrenci1=new Ogrenci();
ogrenci1.name="Pınar";
ogrenci1.lastname="Demirtaş";
ogrenci1.age=23;

Ogrenci ogrenci2=new Ogrenci();
ogrenci2.name="Murat";
ogrenci2.lastname="Dedekoca";
ogrenci2.age=10;

Ogrenci ogrenci3=new Ogrenci();
ogrenci3.name="Hilmi";
ogrenci3.lastname="Kanat";
ogrenci3.age=40;

Ogrenci ogrenci4=new Ogrenci();
ogrenci4.name="Büşra";
ogrenci4.lastname="Sarı";
ogrenci4.age=10;

// Bu 4 öğrenci nesnesini bir dizi içerisinde yerleştirelim

Ogrenci[] ogrenciler = new Ogrenci[4];


// Ogrenci dizisi içerisinde Ogrenci nesnelerini yerleştirelim 
ogrenciler[0]=ogrenci1;
ogrenciler[1]=ogrenci2;
ogrenciler[2]=ogrenci3;
ogrenciler[3]=ogrenci4;
// Ogrenciler  adındaki, Ogrenci tipindeki dizi, içerisine sadece öğrenci nesneleri alır

// Örnek : öğrenci tipindeki bir diziye bir int değer atamaya çalışalım 
// Cevap : Ogrenci tipinden bir dizi içerisine başka tipte bir dğer veremezsiniz

// Ögrenci dizisini ekrana yazdıralım 
// 1 : Foreach ile yazdıralım
foreach(Ogrenci ogr in ogrenciler){

    Console.WriteLine("Ad : {0} Soyad : {1} - Yaş : {2}",ogr.name,ogr.lastname,ogr.age);
}


// 2 : For ile yazdıralım




