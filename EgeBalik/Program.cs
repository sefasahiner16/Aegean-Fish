namespace EgeBalik;

class Program
{

    class EgeDeniziB
    {
        public string fishName { get; set; }
        public string fishOtherName { get; set; }
        public string fishSize { get; set; }
        public string fishInfo { get; set; }
        public string[] fishEnvironment { get; set; }

        public EgeDeniziB(string n, string o, string s, string i, string[] e)
        {
            fishName = n;
            fishOtherName = o;
            fishSize = s;
            fishInfo = i;
            fishEnvironment = e;
        }

        public static void BalikYazdir(EgeDeniziB balik)
        {
            Console.WriteLine($"Balık Adı: {balik.fishName}");
            if (balik.fishOtherName == null)
            {
                Console.WriteLine($"Balık Diğer Adı: Yok");
            }
            else
            {
                Console.WriteLine($"Balık Diğer Adı: {balik.fishOtherName}");
            }
            Console.WriteLine($"Balık Boyutu: {balik.fishSize}");
            Console.WriteLine($"Balık Bilgi: {balik.fishInfo}");
            Console.WriteLine($"Balık Ortam: {balik.fishEnvironment}");
        }
    }

    public static void Main(string[] args)
    {

        EgeDeniziB balik1 = new EgeDeniziB("Akya", "Liça", "Maksimum yetişkin boyutları, 200 cm uzunluk ve 50 kg ağırlıktır. Ancak, genellikle Ege denizinde bulunanların 120 cm civarına kadar büyüdükleri görülmüştür.", "Carangida familyasının bir üyesi olan akya balığı, boyutları ve zevkli avcılığı ile olta balıkçılarının avlanırken en çok heyecanlandığı deniz balıklarından biridir. Akya olarak bilinen bu tür, aynı zamanda liça balığı olarak da adlandırılır.Maksimum yetişkin boyutları, 200 cm uzunluk ve 50 kg ağırlıktır. Ancak, genellikle Ege denizinde bulunanların 120 cm civarına kadar büyüdükleri görülmüştür.Üreme dönemleri olan Mayıs ve Ağustos arasında yumurtlamak için gittikleri nehir birleşimlerinde kefaller ve sardalyaları yiyerek güç toplarlar. Ana besinleri kefal yavrularıdır.Nehir ağızlarına yakın alanlarda daha küçük boyuttakiler bulunurken büyük boyutlu akyalar, 40-50 metre derinlikte ve kıyıya uzak olmayan alanlarda yaşar.", ["Ege Denizi"]);
        EgeDeniziB balik2 = new EgeDeniziB("Yaygın Aslan", "Şeytan Ateş", "Yetişkin boyutları 35 cm’ye kadar ulaşabilir.", "Hint-Pasifik bölgesine özgü bir aslan balığı varyantı olan bu tür, bilimsel olarak Pterois miles olarak adlandırılmıştır. Benzerlikleri dolayısıyla kırmızı aslan balığı ile karışıtırılırlar.Hint-Pasifik bölgesinin yanı sıra ülkemiz sularından Ege denizinde de yaşadıkları biliniyor. Genel aslan balığı çeşitleri gibi bu tür de zehirli bir türdür.Sırtında toplamda 13 adet diken bulunur. Renkleri kırmızı, gri veya ten rengi tonlarındadır. Geceleri avlandıklarından gündüzleri pek aktif bir tür değillerdir. Küçük kabuklular ve balıklar ile beslenirler.Yetişkin boyutları 35 cm’ye kadar ulaşabilir. Ege balıkları arasında olsalar da yaygın olarak Kızıldeniz’de ve Endenozya sularında görülürler.", ["Ege Denizi"]);
        EgeDeniziB balik3 = new EgeDeniziB("Barbunya", "Barbun", "Maksimum boyutları 40 cm’dir ancak, Ege Denizi bölgesindekiler genellikle 18-20 cm civarında olurlar.", "Gerçek adı Barbunya balığı olsa da halk arasında Barbun adı ile bilinir. Mullidae familyasından olan bu türe Mullus barbatus bilimsel adı verilmiştir.Ege denizi gibi sıcak ve ılıman suların kıyıya yakın kumlu ve çamurlu bölgelerinde yaşarlar. Nadiren de olsa kayalık alanlarda görülmektedirler. Tekir balığına benzerlikleri ile bilinirler. Aradaki farkı anlamak için burun, göz altı ve sırt yüzgecine bakılmalıdır.Maksimum boyutları 40 cm’dir ancak, Ege Denizi bölgesindekiler genellikle 18-20 cm civarında olurlar. Ege balıkları arasında ticari öneme sahip, eti lezzetli balıklardandır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik4 = new EgeDeniziB("Çipura", "Çupra", "200 gr ve üzeri olanlar Çipura, bunun altında olanlar ise Lidaki olarak isimlendirilir.", "Çipura balığı diğer adıyla Çupra, Ege denizi balık türleri arasında yer alsa da aslında Akdeniz bölgesinde de yaşarlar.Ilıman sulara sahip bölgelerin, kumlu ve çamurlu bölgelerinde yaşarlar. Zaman zaman nehir ağızları ve lagünlerde bulundukları da olur. 200 gr ve üzeri olanlar Çipura, bunun altında olanlar ise Lidaki olarak isimlendirilir. Kuvvetli bir çeneye sahiptir ve bu sayede kabukluları kolayca yiyebilir. Avlanmak isteniyorsa yaz aylarında kıyıya yakın, kış aylarında 30-40 metre derinlikte avlanabilirler. Kışın boyut olarak daha iri Çipuralar daha derin noktalara inerler. Ticari değeri yüksek ve eti oldukça lezzetli ege denizi balıklarındandır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik5 = new EgeDeniziB("Çitari", "Sarpa", "Maksimum olarak 51 cm uzunluk ölçülmüş olup, genellikle 15-30 cm civarında görülürler.", "Görüntü olarak Çipura balığına çok benzerdir. Halk arasında Sarpa balığı olarak bilinirler. Yüzeyden 70 metre derinliğe kadar uzanan yaşam alanları vardır.Maviye çalan gri renkli üst kısımları, gümüş renkli yan kısımları vardır. Maksimum olarak 51 cm uzunluk ölçülmüş olup, genellikle 15-30 cm civarında görülürler. Ege denizi balık türleri arasında ticari değeri yoktur. Yapılan araştırmalarda tam olarak tespit edilemese de balığın tükettiği bir alg neticesinde, sarpa yiyen insanlarda halüsinojenik balık sarhoşluğu denilen rahatsızlığa sebep olur.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik6 = new EgeDeniziB("Çizgili Hani", "Yazılı Hani", "Uzunlukları en fazla 25 cm’ye ulaşır.", "Hani balığı, Orfoz’un da içinde bulunduğu Serranidae familyasından ve Levreğin içinde bulunduğu Serraninae alt türünden bir balıktır. Bilimsel adı Serranus scriba’dır. Çizgili hani balığı Ege denizi balıkları arasında yer almaktadır ancak hani balıkları genel olarak Akdeniz ve Karadeniz’de yaygındırar. Ülkemiz denizlerinden Ege Denizi’ne özgü Çizgili hani, 5 ila 150 metre arasında yaşam alanına sahiptir. Gündüzleri kayalıkların oluşturduğu mağaralarda geçirirken, alacakaranlık ve geceleri avlanmak için ortaya çıkar. Genellikle yalnız yaşadıkları görülse de küçük sürüler halinde yüzdüklerine de rastlanmaktadır. Uzunlukları en fazla 25 cm’ye ulaşır. Kabuklular, kafadanbacaklılar ve küçük balıklar ile beslenir. Ticari değeri olmayan, eti lezzetli Ege balıklarından biridir.", ["Ege Denizi"]);
        EgeDeniziB balik7 = new EgeDeniziB("Dikenli Vatoz", null, "Ege denizinde bulunan dikenli vatozlar, genellikle 40-45 cm civarında veya daha küçük boyuttadır.", "Dikenli vatoz, Dasyatidae familyasından bir vatoz balığı türüdür. Akdeniz ve Karadeniz bölgelerimizde de görülen bu tür, daha fazla görülmesi sebebiyle Ege Denizi balık türleri arasında bulunmalıdır. Çok derin sularda değil, genellikle 60 metre civarı derinlikte ve çamurlu alanlarda yaşarlar. Ana besinleri dipte yaşayan kabuklu türleridir. Ek olarak yumuşakçalar, solucanlar ve küçük balıklarla da beslenir. Ege denizinde bulunan dikenli vatozlar, genellikle 40-45 cm civarında veya daha küçük boyuttadır. Tırtırlı kuyruk ve iğneleri yüzünden insanlar için tehlikeli balık türleri arasındadır. Ticari değeri yoktur.", ["Ege Denizi", "Akdeniz", "Karadeniz"]);
        EgeDeniziB balik8 = new EgeDeniziB("Eşkina", null, "Eşkina, en fazla 60 cm boyuta ulaşabilir ancak, ülkemiz sularında genellikle 30-40 cm civarında görülürler.", "Eşina balığı, Sciaenidae familyasından bir deniz balığı türüdür. Bilimsel adı Sciaena umbra olan bu tür, Akdeniz ve Ege Denizi bölgelerimizde bulunmaktadır. Eşkina balığı amatör avcılık yapanların sıklıkla karşılaştığı bir türdür.Yavru eşkinalar kıyı şeritlere yakın nehir ağızlarında yaşarken, yetişkinler 5 metre ile 200 metre arasında yaşarlar. Ege balıkları listemize dahil ettiğimiz eşkina, en fazla 60 cm boyuta ulaşabilir ancak, ülkemiz sularında genellikle 30-40 cm civarında görülürler. Bu balığı sıradışı kılan bir özelliği de vardır. Balığın kafasından, alın bölgesinden 1 cm çapında taş çıkar. Bilimsel olarak kanıtlanmamış olsa da bu taş limon ile eritilerek tüketildiğinde böbrek taşı rahatsızlığına iyi geldiği düşünülür.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik9 = new EgeDeniziB("Horozbina", null, "Genellikle küçük boyutlara sahip olabilen bu balığın, yılan balığına benzer varyantlarıyla 55 cm boyutuna ulaştığı görülmüştür. İri bir göz ve ağız yapısına sahiptir.", "Horozbina, Blenniidae familyasından 900 civarı alt türe sahip, hem tuzlu hem de tatlı sularda (küçük bir bölümü) yaşayan alt varyantlara sahip balık türlerinin ortak adıdır. Horozbina tür adı altında 150 farklı cins ve 900 civarı da varyant tanımlanmıştır. Tatlı su blennysi olarak bilinen bir türü, nadiren de olsa akvaryumlarda beslenmektedir. Genellikle küçük boyutlara sahip olabilen bu balığın, yılan balığına benzer varyantlarıyla 55 cm boyutuna ulaştığı görülmüştür. İri bir göz ve ağız yapısına sahiptir. Zamanlarının büyük kısmını deniz tabanında ve kayalık yarıklarında geçirirler. Ticari değeri olmayan, Akdeniz ve Ege Denizi balıklarından biridir.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik10 = new EgeDeniziB("İskaroz", "Papağan", "Yetişkin dönemlerinde en fazla 50 cm olabilirler ancak, ülkemizdeki iskaroz balıkları 20-30 cm civarındadır.", "Genellikle ılıman ve sıcak sulara sahip denizlerde yaşarlar. Bilimsel adı Sparisoma cretense olan tür Scaridae familyasındandır.Parlak renklere sahip bir balıktır. Görünüşü itibariyle sazan balığının tropik halini andırır. Papağan isminin verilmesi ağızlarının papağan gagasına benzemesindendir. Erkekler daha koyu tondaki renklere sahipken dişiler, kırmızı-turuncu tonlarındadır. Zamanlarının çoğu mercan resiflerinde geçer. Burada deniz yosunu ile beslenirler. Yetişkin dönemlerinde en fazla 50 cm olabilirler ancak, ülkemizdeki iskaroz balıkları 20-30 cm civarındadır. Ticari değeri bulunmayan iskarozun eti orta lezzettedir.", ["Ege Denizi", "Akdeniz", "Marmara"]);
        EgeDeniziB balik11 = new EgeDeniziB("İskorpit", null, "Kayıt edilmiş maksimum uzunluk 37 cm iken, ülkemiz sularında yetişkin olanları 20-25 cm civarında görülürler.", "İskorpit, Ege balıkları arasında zehirli türlerden biridir. Yüzgeçlerinde bulunan dikenlere dokunulduğunda kişiyi zehirler ve bölgede kızarıklık, şişlik görülür.Bu etki 2-3 gün devam eder. Amonyak kullanılarak tedavi edilebilir. Özellikle amatör balıkçılar tarafından kırlangıç balığı ile karıştırılıp yaralanmalara sebep olmaktadır. Tutulduğunda dikenlerine dokunmamaya dikkat edilmelidir. Kayıt edilmiş maksimum uzunluk 37 cm iken, ülkemiz sularında yetişkin olanları 20-25 cm civarında görülürler. Akdeniz, Karadeniz ve Ege denizi balık türlerinden biridir. İskorpit, zehirli balıklardan biri olsa da eti lezzetli olan ve barındırdığı vitamin ve yağlar ile insan sağlığına çok yararlı bir balıktır.", ["Ege Denizi", "Akdeniz", "Karadeniz"]);
        EgeDeniziB balik12 = new EgeDeniziB("İsparoz", "İspari", "Maksimum 25 cm uzunluğa erişebilirler. Ülkemiz sularında 15-18 cm civarında ispariler bulunur.", "Sparidae familyasından olan isparinin bilimsel adı Diplodus annularis’dir. Bu balık genellikle ılıman sahil bölgelerine yakın alanlarda yaşar. Ege balıklarından biridir ve diğer denizlerimizde de bulunur. Maksimum 25 cm uzunluğa erişebilirler. Ülkemiz sularında 15-18 cm civarında ispariler bulunur. Sportif balıkçılıkta sevilen bir balık türüdür. Genç olanları kışın lagünlere giderek beslenirler. Karides, yavru balıklar ve kurtçuklar ana besinleridir. Ticari değeri düşüktür ve genellikle olta balıkçılığı ile avlanırlar. Eti lezzetli ve az kılçıklı bir balıktır.", ["Ege Denizi", "Akdeniz", "Karadeniz", "Marmara"]);
        EgeDeniziB balik13 = new EgeDeniziB("İzmarit", "İstrongilos", "En fazla 25 cm boyutuna (erkekler) ulaşan bu tür, ülkemizde genellikle 15 cm civarında görülür.", "İzmarit balığı, Ege denizi balık türleri arasında yer alıyor ancak Akdeniz bölgelemizde daha yaygın bulunur. Bilimsel adı Spicara smaris olan izmarit, Sparidae familyasından bir deniz balığı türüdür. Ilık sulara sahip bölgelerin kayalık, çamurlu dip kısımlarında yaşamaktadır. En fazla 25 cm boyutuna (erkekler) ulaşan bu tür, ülkemizde genellikle 15 cm civarında görülür. Ülkemiz sularında iki tür izmarit yaşamaktadır; İstargilos ve Menekşe izmarit. Eti lezzetli bir balıktır ve genellikle önce pişirilip sonra ayıklanır.", ["Ege Denizi", "Akdeniz", "Karadeniz"]);
        EgeDeniziB balik14 = new EgeDeniziB("Kalkan", null, "Maksimum 1 metre uzunluğa erişebilirler. Ülkemiz denizlerinde ise yetişkinler 60-70 cm civarında görülür.", "Kalkan balığı (Scophthalmus maximus), gözleri vücudunun solunda olan, Scophthalmidae familyasından bir deniz balığı türüdür. Vücudunun sağını deniz tabanına yatmak için kullanır. Ülkemizin tüm denizlerinde yaşayan bir türdür. Yaşam alanları 20 metre ile 70 metre arasındadır. Tipik balık türlerinden farklı olarak yuvarlak bir vücuda sahiptir. Maksimum 1 metre uzunluğa erişebilirler. Ülkemiz denizlerinde ise yetişkinler 60-70 cm civarında görülür. Henüz yavruyken gözleri sağda ve solda ayrı durmaktadır. 8-10 cm civarına ulaştıklarında sağ göz vücutlarının sol tarafına kaymaya başlar.", ["Ege Denizi", "Akdeniz", "Karadeniz", "Marmara"]);
        EgeDeniziB balik15 = new EgeDeniziB("Karagöz", null, "Maksimum 50 cm boyutuna ulaşabilir. Bu bölgelerde yaygın olarak 25 cm civarında görülür.", "Karagöz balığının Çipura ile yakın akrabalığı bulunmaktadır. Sarmos, mırmır, sivri gaga gibi birkaç çeşidi vardır. Maksimum 50 cm boyutuna ulaşabilir. Ülkemizde Akdeniz, Karadeniz ve Ege Denizi bölgelerimizde yaşarlar. Bu bölgelerde yaygın olarak 25 cm civarında görülür. Kayalık, kumlu alanlarda yaşarlar. Görünüşü ile Çupra balığına benzemesinin yanı sıra lezzet olarak da benzerdir. Serin dönemlerde tüketimesi tavsiye edilir bu dönemlerde eti daha yağlı ve lezzetli olmaktadır.", ["Ege Denizi", "Akdeniz", "Karadeniz"]);
        EgeDeniziB balik16 = new EgeDeniziB("Kolyoz,", null, "En fazla 50 cm uzunluğa kadar büyüyebilir ancak ülkemiz sularında görülen yetişkinler ortalama 20-25 cm civarındadır.", "Uskumsugillerden olan kolyoz, Scombridae familyasından bir deniz balığıdır. Uskumruya çok benzeyen bir balıktır. Kuyruk yüzgecine bakılarak ayırt edilebilir. Bu türün kuyruk yüzgecinin ucu daha sivridir. Genç olanlar kıyılara yakın kumlu alanlar ve yosun yataklarında yaşarken, yetişkin olanlar daha açıkta derin sularda yaşar. Sürüler halinde yaşamlarını sürdürürler. En fazla 50 cm uzunluğa kadar büyüyebilir ancak ülkemiz sularında görülen yetişkinler ortalama 20-25 cm civarındadır. Eti lezzetli ege balıkları arasındadır.", ["Ege Denizi", "Akdeniz", "Karadeniz", "Marmara"]);
        EgeDeniziB balik17 = new EgeDeniziB("Kırma Mercan", null, "İnce, oval yapıda bir vücuda sahip olan kırma mercan en fazla 50 cm boyutuna ulaşabilir. Genel olarak 15-30 cm arasında görülürler.", "Kırma mercan balığı (Pagellus erythrinus) çipura ailesinden, Sparidae familyası mensubu, Akdeniz ve Ege balıklarından biridir. Özellikle Akdeniz ülkelerinde bolca tüketilen lezzetli bir balık türüdür. İnce, oval yapıda bir vücuda sahip olan kırma mercan en fazla 50 cm boyutuna ulaşabilir. Genel olarak 15-30 cm arasında görülürler. Bu tür bir hermafrodittir; sonradan cinsiyet değiştirebilirler. Genellikle hayatlarının ilk yıllarında dişi, sonraki yıllarında ise erkek olurlar. Hepçil bir balıktır ve ana besinleri küçük balıklar ve omurgasızlardan oluşur. Akdeniz ülkelerinde ticari değere sahip, lezzetli bir balıktır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik18 = new EgeDeniziB("Lahoz", "Grida", "En fazla 125 cm uzunluk ve 25 kg ağırlığa ulaşabilirler.", "Lahoz balığı Hani balıkları ailesinden, Ege ve Akdeniz bölgelerinde bulunan bir türdür. Bu tür iri ege balıkları arasındadır. En fazla 125 cm uzunluk ve 25 kg ağırlığa ulaşabilirler. Yaşam alanları 20-250 metre arasında kayalık, çakıllı ve taşlı alanlardır. Son derece yırtıcı etçil balıklardan biridir. Yiyebileceği her türlü balık, omurgasız ve kabuklu türleri ile beslenir. Orfoz balığı ile yakından akrabadır ve ticari değeri bulunduğu bölgeye göre değişir. Özellikle Akdeniz bölgesinde etinin lezzetli ile bilinir.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik19 = new EgeDeniziB("Levrek", null, "Şimdiye kadar kayıt altına alınan en büyük boyutları 1m ve 12 kg olsa da yaygın olarak 50 cm ve 5 kg civarında görülürler.", "Birçoğumuzun da yakından tanıdığı Levrek balığı, Dicentrarchus familyasından bir balık türüdür. Bilimsel olarak ilk kez 1758 yılında Dicentrarchus labrax olarak tanımlanmıştır. Şimdiye kadar kayıt altına alınan en büyük boyutları 1m ve 12 kg olsa da yaygın olarak 50 cm ve 5 kg civarında görülürler. Akdeniz ve Ege başta olmak üzere tüm denizlerimizde yaşadıkları biliniyor. Haliçler, lagünler, akarsuların denize döküldüğü yerler ana yaşam alanlarıdır. Kısa bir süreliğine tatlı sulara geçtikleri de bilinmektedir (tatlı su levreklerinin dışında). Ticari değeri yüksek, etinin lezzetini kanıtlamış Ege denizi balık türlerinden biridir.", ["Ege Denizi", "Akdeniz", "Karadeniz", "Marmara"]);
        EgeDeniziB balik20 = new EgeDeniziB("Lipsoz", "Lipsos", "En fazla 50 cm ve 3 kg ağırlığa ulaştığı biliniyor ancak, sularımızdaki yetişkin lipsoz balıkları genellikle 25-30 cm civarındadır.", "Lipsoz balığı, görünümü ile iskorpit balığına benzeyen Scorpaenidae familyasından bir balık türüdür. Lipsos ismiyle de bilinen bu türün bilimsel adı Scorpaena scrofa’dır. Ülkemiz sularında Akdeniz ve Ege Denizi türlerinden biridir, Karadeniz bölgesinde bulunmaz. S. porcus türü Karadeniz bölgesinde görülebilir. İskorpit balığı gibi bu balık da zehirli balıklardan biridir. Vücut rengi kiremit rengi tonlarından, pembemsi tonlara kadar değişebilir. En fazla 50 cm ve 3 kg ağırlığa ulaştığı biliniyor ancak, sularımızdaki yetişkin lipsoz balıkları genellikle 25-30 cm civarındadır. Yenilebilir balıklardan biridir, en çok çorba ve buğulama yapıldığında lezzetlidir.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik21 = new EgeDeniziB("Lüfer", null, "Maksimum ölçülen boyutları 120 cm ve 14 kg’dır. Bölgemizde yaşayan yetişkin lüferler 30-60 cm arasında bulunurlar.", "Lüfer,  Pomatomidae familyasından bir balık türüdür. Ege balıkları arasında ekonomik değeri yüksek ve çok lezzetli bir balıktır. Bilimsel adı Pomatomus saltatrix olan lüfer, ülkemizin tüm denizlerinde bulunmaktadır. Maksimum ölçülen boyutları 120 cm ve 14 kg’dır. Bölgemizde yaşayan yetişkin lüferler 30-60 cm arasında bulunurlar. Lüfer, gevşek ve küçük gruplar halinde yaşayan yırtıcı deniz balıklarından balıklardan biridir. Lüfer bir dönem koruma altına alınarak avlanılması ve satışı yapılması yasaklanmış balık türlerindendir. Ancak, günümüzde yasak bitirilerek 18 cm ve üzeri olanların avlanması ve satılması serbest bırakılmıştır.", ["Ege Denizi", "Akdeniz", "Karadeniz", "Marmara"]);
        EgeDeniziB balik22 = new EgeDeniziB("Mahmuzlu Camgöz Köpek Balığı", null, "En fazla 150 cm ve 10 kg boyutlarına eriştikleri tespit edilmiştir ancak, genellikle 80 cm ve 4 kg civarlarına ulaşırlar.", "Mahmuzlu camgöz Squalidae familyasından, Akdeniz ve Ege Denizi başta olmak üzere ülkemiz sularında bulunmaktadır. Ülkemizde tüketilmese de Avrupa ülkelerinde tüketildiği bilinmektedir. Ana besinleri balık sürüleri ve ahtapotlar olan bu türün, profesyonel balıkçıların ağlarına ciddi hasar verdiği biliniyor. Nadiren de olsa dip balıklarını avlayan amatör balıkçıların oltasına takıldığı görülmektedir. En fazla 150 cm ve 10 kg boyutlarına eriştikleri tespit edilmiştir ancak, genellikle 80 cm ve 4 kg civarlarına ulaşırlar. Ticari değeri yoktur.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik23 = new EgeDeniziB("Mandagöz Mercan", "Kırmızı Çipura", "Kaydedilen en büyük uzunluk 70 cm, yaygın olarak da 30 cm ve 4 kg’dır.", "Kırmızı (kızıl) çipura olarak da bilinen mandagöz mercan (Pagellus bogaraveo) Sparidae familyasından bir deniz balığıdır. Akdeniz başta olmak üzere ılıman ve sıcak denizleri tercih eden bir türdür, ılıman ısısıyla Ege balıklarından da biridir. Bulunduğu bölgeye göre en fazla 400 ila 700 metre derine inebilen bir balıktır. Kaydedilen en büyük uzunluk 70 cm, yaygın olarak da 30 cm ve 4 kg’dır. Eti lezzetli, ızgarada pişilmesi tercih edilen bir mercan varyantıdır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik24 = new EgeDeniziB("Melanur", "Melanurya", "Kaydedilen maksimum boyutları, 38 cm ve 930 gr’dır. Ülkemiz sularında yaygın olarak 20 cm civarında görülürler.", "Melanur diğer adıyla Melanurya, Sparidae familyasından bir deniz türüdür. Ülkemizde Akdeniz, Marmara ve Ege bölgerinde bulunur. Bilimsel adı Oblada melanura olan melanur, Ege denizi balık türleri arasında yer alıyor. Çok iri boyutlara ulaşabilen bir tür değildir. Kaydedilen maksimum boyutları, 38 cm ve 930 gr’dır. Ülkemiz sularında yaygın olarak 20 cm civarında görülürler. Hepçil olan türün ana besini omurgasızlardır. Eti lezzetli türlerden biri olan melanurun ticari değeri orta seviyelerdedir.", ["Ege Denizi", "Akdeniz", "Marmara"]);
        EgeDeniziB balik25 = new EgeDeniziB("Mersin", null, "Yetişkin mersin balıkları ortalama 140 ila 300 cm uzunluğa, 100 ila 200 kg ağırlığa ulaşabilirler.", "Mersin balığı birçok farklı türün ortak adıdır. Mersin balığı adı altında 19 farklı cins balık bulunmaktadır. Görünümlerindeki ufak farklılar ile ayrılırlar. Bu balıklar Acipenseridae familyasına aittir. Akdeniz bölgemizde daha yaygın olan tür, Ege balıkları arasında da bulunmaktadır. Türe göre boyutları farketmektedir. Yetişkin mersin balıkları ortalama 140 ila 300 cm uzunluğa, 100 ila 200 kg ağırlığa ulaşabilirler. Şimdiye kadarki ölçülen en büyük boyutlar; 7.2 metre ve 1571 kilogramdır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik26 = new EgeDeniziB("Mürekkepbalığı", null, "Cinse göre 20 cm ile 17 metre arasında değişen çeşitleri vardır. Yaygın olarak yetişkin olanları 50-60 cm arasındadır.", "Mürekkepbalığı Cephalopoda (Kafadanbacaklılar) sınıfından, deniz türleri arasında olan bir yumuşakça türüdür. İkisi diğerlerinden daha uzun olan toplam 10 adet kolları vardır ve iç bölgelerinde çok sayıda vantuz bulunur. Ege denizi balıkları arasında yer alan mürekkepbalığı, sıcak sularda yaşayan bir türdür. Bu türün boyutları çok değişkendir. Cinse göre 20 cm ile 17 metre arasında değişen çeşitleri vardır. Yaygın olarak yetişkin olanları 50-60 cm arasındadır. Ticari değeri olan, eti lezzetli bir yumuşakça türüdür.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik27 = new EgeDeniziB("Mırmır", null, "En fazla 55 cm ve 1 kg ağırlığa ulaşmaktadırlar ancak, yaygın boyutları 30 cm civarındadır.", "Sparidae familyasından olan mırmır balığı, ekonomik değeri yüksek lezzetli balık türlerinden biridir. Denizin diplerinde ve kumlu kısımlarda yaşayan mırmır balığı sıklıkla avlanan Ege balıkları arasındadır.Ülkemizde Ege, Akdeniz ve Marmara bölgelerinde bolca bulunurlar. Ana besinlerini kabuklular, solucanlar ve yumuşakçalar oluşturur. En fazla 55 cm ve 1 kg ağırlığa ulaşmaktadırlar ancak, yaygın boyutları 30 cm civarındadır. Ticari değeri yüksek Ege denizi balık türlerinden biridir.", ["Ege Denizi", "Akdeniz", "Marmara"]);
        EgeDeniziB balik28 = new EgeDeniziB("Orfoz", "Taş Hanisi", "En fazla 140 cm ve 60 kg boyutlarına ulaşabilirler. Ülkemiz denizlerinde yaygın görülen boyutları ortalama 60 cm ve 15 kg’dır.", "Serranidae familyasından Orfoz, Taş hanisi adıyla da bilinir. Bilimsel adı Epinephelus marginatus’dur. Orfozlar hermafrodit (çift cinsiyetli) deniz balıkları arasındadır. Orfoz balığı neslinin tükenmesiyle karşı karşıya olduğu için avlanması yasak türlerdendir. Ülkemizde Akdeniz ve Ege denizlerinin güney kısımlarında yaşarlar. En fazla 140 cm ve 60 kg boyutlarına ulaşabilirler. Boyutları ile iri ege balıklarından biridir. Ülkemiz denizlerinde yaygın görülen boyutları ortalama 60 cm ve 15 kg’dır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik29 = new EgeDeniziB("Orkinos", "Ton Balığı", "Yetişkin bir ton balığı, 6 metre uzunluğa ve 1 ton ağırlığa ulaşmaktadır. Ancak, bu boyutlarda Orkinos bulma ihtimali çok düşüktür genellikle 3-4 metre ve 400-600 kg arasında avlanırlar.", "Çoğumuzun marketlerde konserve içerinde gördüğü Orkinos, Uskumrugiller (Scombridae) ailesinin üyesidir. Kendi aralarında farklı türlere sahip olan, Orkinos ortak adı verilen bu balık denizlerdeki en iri balıklardan biridir. Ege denizi balıkları arasında en büyük türlerden biridir. Yetişkin bir ton balığı, 6 metre uzunluğa ve 1 ton ağırlığa ulaşmaktadır. Ancak, bu boyutlarda Orkinos bulma ihtimali çok düşüktür genellikle 3-4 metre ve 400-600 kg arasında avlanırlar. Ekonomik değeri çok yüksek ve son deree lezzetli balıklardandır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik30 = new EgeDeniziB("Pisi", null, "En fazla 60 cm boyut ölçülmüştür ancak, yaygın boyutları 30 cm civarındadır.", "Pisi balığı kalkan ile karıştırılabilir ancak resimlerine bakıldığında kolayca ayırt edilebilir. Pleuronectidae familyasından olan pisi balığının vücudu kalkana göre daha elips şeklindedir ve kalkanın sırtında olan düğme diye tabir edilen kemikli yapılar yoktur. Yine pisi balığının gözleri de vücudun sağ tarafındadır. En fazla 60 cm boyut ölçülmüştür ancak, yaygın boyutları 30 cm civarındadır. Ülkemizde Akdeniz, Ege, Karadeniz ve Marmara bölgelerimizde bulunur.", ["Ege Denizi", "Akdeniz", "Karadeniz", "Marmara"]);
        EgeDeniziB balik31 = new EgeDeniziB("Sardalya", null, "Denizlerimizde 15-20 cm boyutlara ulaşırlar ancak okyanus bölgelerindeki sardalyalar 30 cm uzunluğa kadar büyümektedir.", "Saldalya hamsi ile yakından akraba, Clupeinae familyasından bir balık türüdür. Sürüler halinde kıyıya yakın geçerek göç ederek yaşamlarını sürdürürler. Akdeniz ve Karadeniz’de daha yaygın görülen sardalya, Ege denizi balık türleri arasında da yer almaktadır. Denizlerimizde 15-20 cm boyutlara ulaşırlar ancak okyanus bölgelerindeki sardalyalar 30 cm uzunluğa kadar büyümektedir. Ticari değeri çok yüksek, lezzetli balık türlerindendir.", ["Ege Denizi", "Akdeniz", "Karadeniz"]);
        EgeDeniziB balik32 = new EgeDeniziB("Sargan", "Zargana", "Yaşadıkları bölgeye göre 1 metre uzunluğa erişmektedirler ancak Akdeniz ve Ege denizlerimizde 60 cm civarına kadar büyümektedirler.", "Tipik balık görünümünün dışında uzun ve ince bir vücuda sahip sargan (Belone belone), Belonidae familyasının üyesidir. Vücut yapıları sayesinde hızlı ve çevik deniz balıklarındandır. Yaşadıkları bölgeye göre 1 metre uzunluğa erişmektedirler ancak Akdeniz ve Ege denizlerimizde 60 cm civarına kadar büyümektedirler. Ana besinleri küçük balıklardır ve hamsi, çaça gibi balık türleri ile beslenir. Ticari değeri yüksek, lezzetli Akdeniz ve Ege balıkları arasındadır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik33 = new EgeDeniziB("Sargoz", "Baltabaş", "Boyu 45 santimetreye kadar varır ama 15-30 santim boyundaki bireyleri yaygındır. ", "Sargoz, Akdeniz ve Ege bölgelerinde sıklıkla Karagöz ile karıştırılır. Diplodus sargus bilimsel adı verilmiştir ve Sparidae ailesinden bir deniz balığı türüdür. Bu balık bölgeye göre farklı isimler almıştır. Baltabaş, Sargos ve Ak Karagöz olarak da bilinirler. Ülkemizde Akdeniz ve Ege bölgelerimizde yaygındır. Güçlü çeneye sahiptirler ana besinleri; kabuklular, yumuşakçalar ve deniz yosunları. Ekonomik değeri yüksek, lezzetli bir balıktır.", ["Ege Denizi", "Akdeniz"]);
        EgeDeniziB balik34 = new EgeDeniziB("Sinarit", null, "1 metre uzunluğa, 20 kg ağırlığa ulaşırlar.", "Sparidae familyasından olan Sinarit’in bilimsel adı Dentex dentex’dir. Akdeniz’de yaygındır ancak Karadeniz, Marmara ve Ege balıkları arasında da yer alırlar. Taşlı ve kumlu bölgelerde 200 metre derinliğe kadar yaşarlar. Ana besinleri kafadanbacaklılar ve yumuşakçalardır. Genellikle yalnız yaşarlar ancak üreme dönemlerinde küçük sürüler halinde görülmektedirler. 1 metre uzunluğa, 20 kg ağırlığa ulaşırlar. Olta avcılığı son derece zevkli, eti lezzetli ama az bulunan bir balıktır.", ["Ege Denizi", "Akdeniz", "Karadeniz", "Marmara"]);
        EgeDeniziB balik35 = new EgeDeniziB("Tekir", null, "Kaydedilmiş en büyük boyutları 40 cm ve 1 kg’dır ancak sularımızda yaygın olarak 25 cm civarında görülürler.", "Bilimsel adı Mullus surmuletus olan Tekir, Mullidae familyasından bir deniz balığıdır. Akdeniz, Karadeniz ve Ege denizi balık türleri arasındadır. 5 metrelik sığ sulardan 400 metre derinlikteki sulara kadar uzanan yaşam alanları vardır. Kaydedilmiş en büyük boyutları 40 cm ve 1 kg’dır ancak sularımızda yaygın olarak 25 cm civarında görülürler. Ticari değeri olan bir balıktır ve av balığı olarak da kullanılmaktadır.", ["Ege Denizi", "Akdeniz", "Karadeniz"]);
        EgeDeniziB balik36 = new EgeDeniziB("Trakonya", "Dragon", "1 metre ile 150 metre arasında kumlu, çakıllı alanlarda yaşamaktadır. En fazla 55 cm boyuta ulaşabilirler ve genellikle 25 cm civarında görülürler.", "Trakonya balığı halk arasında dragon balığı olarak da bilinmektedir. Trachinidae ailesinden olan balığın bilimsel adı Trachinus draco’dur. Vücudunda zehirli dikenlere sahiptir ve dokunulduğunda toksik bir madde salgılar. Zehirli Ege balıkları arasındadır. Zehri kuvvetlidir, uzuv kaybı veya kalp krizine neden olabilmektedir. 1 metre ile 150 metre arasında kumlu, çakıllı alanlarda yaşamaktadır. Küçük balıklar, omurgasızlar ve kabuklular ana besinleridir. En fazla 55 cm boyuta ulaşabilirler ve genellikle 25 cm civarında görülürler. Ticari değer yoktur.", ["Ege Denizi", "Akdeniz", "Karadeniz"]);
        EgeDeniziB balik37 = new EgeDeniziB("Trança", "Altınkaş", "Yetişkin boyutları 60-75 cm civarındadır ancak 1 metre üzerine de çıkabilmektedir.", "Ege balıkları arasında meşhurlaşmış türlerden biridir. Bölgede Çavuş, Antenli mercan, Altınkaş isimleri ile de bilinir. Bilimsel adı Pagrus caeruleostictus’dur ve mercan familyasından bir türdür. Sığ ve sıcak sularda tek olarak yaşayan iri bir balıktır. Etçil bir balıktır ve kafadanbacaklılar, küçük balıklar ana besinleridir. Okyanuslara ve farklı denizlere sürekli göç eden balıklardandır. Yetişkin boyutları 60-75 cm civarındadır ancak 1 metre üzerine de çıkabilmektedir. Ekonomik değeri yüksek, lezzetli bir balıktır.", ["Ege Denizi"]);
        EgeDeniziB balik38 = new EgeDeniziB("Zurna", null, "En fazla 50 cm, ortamala 35 cm boyutlarındadır.", "Zurna balığı (Scomberesox saurus), Scomberesocidae familyasından bir deniz balığıdır. Açık denizlerde yaşayan bu tür, Süveyş kanalının açılmasından sonra Akdeniz ve Ege denizlerinde görülmüştür. En fazla 50 cm, ortamala 35 cm boyutlarındadır. Balık yavruları ve plankton ile beslenir. Avlanmadıkları için herhangi bir ticari değeri yoktur.", ["Ege Denizi", "Akdeniz"]);


        List<EgeDeniziB> AegeanFish = new List<EgeDeniziB>(38);
        AegeanFish.Add(balik1);
        AegeanFish.Add(balik2);
        AegeanFish.Add(balik3);
        AegeanFish.Add(balik4);
        AegeanFish.Add(balik5);
        AegeanFish.Add(balik6);
        AegeanFish.Add(balik7);
        AegeanFish.Add(balik8);
        AegeanFish.Add(balik9);
        AegeanFish.Add(balik10);
        AegeanFish.Add(balik11);
        AegeanFish.Add(balik12);
        AegeanFish.Add(balik13);
        AegeanFish.Add(balik14);
        AegeanFish.Add(balik15);
        AegeanFish.Add(balik16);
        AegeanFish.Add(balik17);
        AegeanFish.Add(balik18);
        AegeanFish.Add(balik19);
        AegeanFish.Add(balik20);
        AegeanFish.Add(balik21);
        AegeanFish.Add(balik22);
        AegeanFish.Add(balik23);
        AegeanFish.Add(balik24);
        AegeanFish.Add(balik25);
        AegeanFish.Add(balik26);
        AegeanFish.Add(balik27);
        AegeanFish.Add(balik28);
        AegeanFish.Add(balik29);
        AegeanFish.Add(balik30);
        AegeanFish.Add(balik31);
        AegeanFish.Add(balik32);
        AegeanFish.Add(balik33);
        AegeanFish.Add(balik34);
        AegeanFish.Add(balik35);
        AegeanFish.Add(balik36);
        AegeanFish.Add(balik37);
        AegeanFish.Add(balik38);

        List<EgeDeniziB>[] BalikGruplari = new List<EgeDeniziB>[4];
        BalikGruplari[0] = AegeanFish.GetRange(0, 10);
        BalikGruplari[1] = AegeanFish.GetRange(10, 10);
        BalikGruplari[2] = AegeanFish.GetRange(20, 10);
        BalikGruplari[3] = AegeanFish.GetRange(30, 8);


        GrupYazdir(BalikGruplari);


        //Stack oluşturma ve Stack'i ekrana yazdırma
        StackSelf balikStack = new StackSelf(38);
        foreach (var item in AegeanFish)
            balikStack.Push(item);
        for (int i = 0; i < 38; i++)
        {
            EgeDeniziB balikS = balikStack.Pop();
            EgeDeniziB.BalikYazdir(balikS);
        }

        //Queue oluşturma ve Ekrana Yazdırma
        QueueSelf balikQueue = new QueueSelf(38);
        foreach (var item in AegeanFish)
            balikQueue.Insert(item);
        for (int j = 0; j < 38; j++)
        {
            EgeDeniziB balikQ = balikQueue.Remove();
            EgeDeniziB.BalikYazdir(balikQ);
        }

        //Priority Queue oluşturma ve Alfabetik sırayla silerek ekrana yazdırma
        PQueue balikpqueue = new PQueue();
        foreach (var item in AegeanFish)
            balikpqueue.Ekle(item);
        for (int i = 0; i < 38; i++)
        {
            EgeDeniziB balikP = balikpqueue.Remove();
            EgeDeniziB.BalikYazdir(balikP);
        }

        MarketQueue marketqueue = new MarketQueue();
        int[] musteri = { 15, 1, 12, 8, 7, 4, 21, 3, 2, 6, 5, 9, 11 };

        foreach(var item in musteri)
        {
            marketqueue.Ekle(item);
        }

        double islemsuresi = 3.3;
        for(int i = 0; i < musteri.Length; i++)
        {
            Console.WriteLine($"Müsteri {i + 1} işlem süresi: {islemsuresi * musteri[i]}");
        }
        double toplamsure = 0;
        int musterino = 0;
        Console.WriteLine("Öncelikli Kuyrukta işlem süreleri: ");
        while(!marketqueue.isEmpty())
        {
            int minurun = marketqueue.Remove();
            double islemtamamlanmasure = minurun * islemsuresi;
            toplamsure += islemtamamlanmasure;
            Console.WriteLine($"Müşteri {musterino}: {islemtamamlanmasure:F2}");
            musterino++;
        }
        double ortalama = toplamsure / musteri.Length;
        Console.WriteLine($"Ortalama işlem süresi: {ortalama} sn");
    }

    //10'lu balık gruplarını yazdıran metot
    private static void GrupYazdir(List<EgeDeniziB>[] grup)
    {
        for (int i = 0; i < grup.Length; i++)
        {
            Console.WriteLine($"Grup {i + 1}:");
            int digerAdsayisi = 0;

            foreach (var balik in grup[i])
            {
                Console.WriteLine($"Balık Adı: {balik.fishName}");
                if (!string.IsNullOrEmpty(balik.fishOtherName)) //Eğer balığı ikinci bir adı vara yazdırıyor ve bunu diğer ad sayısına ekliyor.
                {
                    Console.WriteLine($"Diğer Adı: {balik.fishOtherName}");
                    digerAdsayisi++;
                }
                else
                {
                    Console.WriteLine("Diğer Adı: Bulunmuyor.");
                }

                Console.WriteLine($"Boyutu: {balik.fishSize}");
                Console.WriteLine($"Bilgi: {balik.fishInfo}");
                Console.WriteLine($"Ortam: {string.Join(",", balik.fishEnvironment)}");
                Console.WriteLine();
            }

            Console.WriteLine($"Bu Grupta Dİğer adı bulunan balık sayısı: {digerAdsayisi}");
        }

    }



    //Balıkları bir yığıt içerisinde depolamak için kullanılacak yığıtın sınıfı ve gtüm metodları
    class StackSelf
    {
        private int maxSize;
        private EgeDeniziB[] stackArray;
        private int top;

        public StackSelf(int s)
        {
            maxSize = s;
            stackArray = new EgeDeniziB[maxSize];
            top = -1;
        }

        public void Push(EgeDeniziB j)
        {
            stackArray[++top] = j;
        }

        public EgeDeniziB Pop()
        {
            return stackArray[top--];
        }

        public EgeDeniziB Peek()
        {
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (top == maxSize - 1);
        }
    }


    class QueueSelf
    {
        private int maxSize;
        private EgeDeniziB[] QArray;
        private int front;
        private int rear;
        private int nItems;

        public QueueSelf(int s)
        {
            maxSize = s;
            QArray = new EgeDeniziB[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void Insert(EgeDeniziB i)
        {
            if (rear == maxSize - 1)
            {
                rear = -1;
            }
            QArray[++rear] = i;
            nItems++;
        }

        public EgeDeniziB Remove()
        {
            EgeDeniziB temp = QArray[front++];
            if (front == maxSize)
            {
                front = 0;
            }
            nItems--;
            return temp;
        }

        public EgeDeniziB PeekFront()
        {
            return QArray[front];
        }

        public bool isEmpty()
        {
            return (nItems == 0);
        }

        public bool isFull()
        {
            return (nItems == maxSize);
        }

        public int size()
        {
            return nItems;
        }

    }

    class PQueue
    {
        private List<EgeDeniziB> queue;

        public PQueue()
        {
            queue = new List<EgeDeniziB>();
        }

        public void Ekle(EgeDeniziB i)
        {
            queue.Add(i);
        }

        public EgeDeniziB Remove()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Kuyruk boş.");
            }

            int minIndex = 0;
            for (int i = 1; i < queue.Count; i++)
            {
                if (string.Compare(queue[i].fishName, queue[minIndex].fishName, StringComparison.Ordinal) < 0)
                {
                    minIndex = i;
                }
            }

            EgeDeniziB minEleman = queue[minIndex];
            queue.RemoveAt(minIndex);
            return minEleman;
        }

        public bool isEmpty()
        {
            return queue.Count == 0;
        }
    }


    class MarketQueue
    {
        private List<int> kuyruk;

        public MarketQueue()
        {
            kuyruk = new List<int>();
        }

        public void Ekle(int i)
        {
            kuyruk.Add(i);
        }

        public int Remove()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Kuyruk Boş.");
            }
            int minIndex = 0;
            for (int j = 1; j < kuyruk.Count; j++)
            {
                if (kuyruk[j] < kuyruk[minIndex])
                {
                    minIndex = j;
                }
            }

            int minValue = kuyruk[minIndex];
            kuyruk.RemoveAt(minIndex);
            return minValue;
        }

        public bool isEmpty()
        {
            return kuyruk.Count == 0;
        }
    }
}