using LinqToObject;
using System.Buffers.Text;
using System.Runtime.InteropServices;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//// Language Integrated Query
List<Bolum> bolumler = new List<Bolum> {
    new Bolum(1, "Bilgisayar Mühendisliği"),
    new Bolum(2, "Elektrik Elektronik Mühendisliği"),
    new Bolum(3, "Yazılım Mühendisliği"),
    new Bolum(4, "Endüstri Mühendisliği"),
    new Bolum(5, "Mimarlık"),
    new Bolum(6, "İnşaat Mühendisliği"),
    new Bolum(7, "Makine Mühendisliği"),
    new Bolum(8, "Yönetim Bilişim Sistemleri"),
    new Bolum(9, "İktisat"),
    new Bolum(10, "İşletme"),
    new Bolum(1, "Bilgisayar Mühendisliği"),
    new Bolum(2, "Elektrik Elektronik Mühendisliği"),
    new Bolum(3, "Yazılım Mühendisliği"),
    new Bolum(4, "Endüstri Mühendisliği"),
    new Bolum(5, "Mimarlık"),
    new Bolum(6, "İnşaat Mühendisliği"),
    new Bolum(7, "Makine Mühendisliği"),
    new Bolum(8, "Yönetim Bilişim Sistemleri"),
    new Bolum(9, "İktisat"),
    new Bolum(10, "İşletme"),  
    new Bolum(1, "Bilgisayar Mühendisliği"),
    new Bolum(2, "Elektrik Elektronik Mühendisliği"),
    new Bolum(3, "Yazılım Mühendisliği"),
    new Bolum(4, "Endüstri Mühendisliği"),
    new Bolum(5, "Mimarlık"),
    new Bolum(6, "İnşaat Mühendisliği"),
    new Bolum(7, "Makine Mühendisliği"),
    new Bolum(8, "Yönetim Bilişim Sistemleri"),
    new Bolum(9, "İktisat"),
    new Bolum(10, "İşletme"),  
    new Bolum(1, "Bilgisayar Mühendisliği"),
    new Bolum(2, "Elektrik Elektronik Mühendisliği"),
    new Bolum(3, "Yazılım Mühendisliği"),
    new Bolum(4, "Endüstri Mühendisliği"),
    new Bolum(5, "Mimarlık"),
    new Bolum(6, "İnşaat Mühendisliği"),
    new Bolum(7, "Makine Mühendisliği"),
    new Bolum(8, "Yönetim Bilişim Sistemleri"),
    new Bolum(9, "İktisat"),
    new Bolum(10, "İşletme")
};


List<Student> students = new List<Student>
{
    new Student("Ali Keser", "OGR001", "05055005050", "Erkek", 1),
    new Student("Mustafa Keser", "OGR002", "05425005050", "Erkek", 2),
    new Student("Elif Eylül", "OGR003", "05325003232", "Kadın", 3),
    new Student("Ayşe Deniz", "OGR004", "05455005050", "Kadın", 4),
    new Student("Mehtap Demir", "OGR005", "05055005054", "Kadın", 5),
    new Student("Abuzer Kadayıf", "OGR006", "05055005555", "Erkek", 6),
    new Student("Ahmet Yılmaz", "OGR007", "05321234567", "Erkek", 7),
    new Student("Zeynep Kaya", "OGR008", "05431234568", "Kadın", 8),
    new Student("Mehmet Demir", "OGR009", "05541234569", "Erkek", 9),
    new Student("Fatma Çelik", "OGR01", "05061234570", "Kadın", 10),

    new Student("Burak Şahin", "OGR011", "05361234571", "Erkek", 1),
    new Student("Ece Aydın", "OGR012", "05461234572", "Kadın", 2),
    new Student("Emre Koç", "OGR013", "05561234573", "Erkek", 3),
    new Student("Seda Arslan", "OGR014", "05071234574", "Kadın", 4),
    new Student("Can Özdemir", "OGR015", "05371234575", "Erkek", 5),
    new Student("Buse Kılıç", "OGR016", "05471234576", "Kadın", 6),
    new Student("Oğuzhan Kurt", "OGR017", "05571234577", "Erkek", 7),
    new Student("Derya Aksoy", "OGR018", "05081234578", "Kadın", 8),
    new Student("Kerem Yıldız", "OGR019", "05381234579", "Erkek", 9),
    new Student("Sinem Güneş", "OGR020", "05481234580", "Kadın", 10),

    new Student("Murat Öztürk", "OGR021", "05581234581", "Erkek", 1),
    new Student("Ceren Polat", "OGR022", "05091234582", "Kadın", 2),
    new Student("Serkan Erdem", "OGR023", "05391234583", "Erkek", 3),
    new Student("İrem Taş", "OGR024", "05491234584", "Kadın", 4),
    new Student("Tolga Yalçın", "OGR025", "05591234585", "Erkek", 5),
    new Student("Gizem Şimşek", "OGR026", "0511234586", "Kadın", 6),
    new Student("Hakan Doğan", "OGR027", "05301234587", "Erkek", 7),
    new Student("Nisa Karaca", "OGR028", "05401234588", "Kadın", 8),
    new Student("Kaan Eren", "OGR029", "05501234589", "Erkek", 9),
    new Student("Melis Bulut", "OGR030", "05111234590", "Kadın", 10),

    new Student("Onur Kaplan", "OGR031", "05311234591", "Erkek", 1),
    new Student("Bahar Yıldırım", "OGR032", "05411234592", "Kadın", 2),
    new Student("Umut Çetin", "OGR033", "05511234593", "Erkek", 3),
    new Student("Selin Keskin", "OGR034", "05121234594", "Kadın", 4),
    new Student("Eren Özkan", "OGR035", "05321234595", "Erkek", 5),
    new Student("Damla Korkmaz", "OGR036", "05421234596", "Kadın", 6),
    new Student("Berkay Tunç", "OGR037", "05521234597", "Erkek", 7),
    new Student("Nazlı Ergin", "OGR038", "05131234598", "Kadın", 8),
    new Student("Furkan Acar", "OGR039", "05331234599", "Erkek", 9),
    new Student("Aslıhan Kaya", "OGR040", "05431234600", "Kadın", 10),

    new Student("Barış Yavuz", "OGR041", "05531234601", "Erkek", 1),
    new Student("Merve Can", "OGR042", "05141234602", "Kadın", 2),
    new Student("Kadir Duman", "OGR043", "05341234603", "Erkek", 3),
    new Student("Pelin Aksu", "OGR044", "05441234604", "Kadın", 4),
    new Student("Emirhan Öz", "OGR045", "05541234605", "Erkek", 5),
    new Student("Tuğba Ateş", "OGR046", "05151234606", "Kadın", 6),
    new Student("Yiğit Sönmez", "OGR047", "05351234607", "Erkek", 7),
    new Student("Esra Karaman", "OGR048", "05451234608", "Kadın", 8),
    new Student("Sinan Dursun", "OGR049", "05551234609", "Erkek", 9),
    new Student("Büşra Uçar", "OGR050", "0516123461", "Kadın", 10),

    new Student("Alperen Kaya", "OGR051", "05361234611", "Erkek", 1),
    new Student("Gülşah Demir", "OGR052", "05461234612", "Kadın", 2),
    new Student("Ömer Faruk Çetin", "OGR053", "05561234613", "Erkek", 3),
    new Student("Sibel Yılmaz", "OGR054", "05171234614", "Kadın", 4),
    new Student("Yusuf Arslan", "OGR055", "05371234615", "Erkek", 5),
    new Student("Rabia Şen", "OGR056", "05471234616", "Kadın", 6),
    new Student("Mert Can", "OGR057", "05571234617", "Erkek", 7),
    new Student("Nehir Aydın", "OGR058", "05181234618", "Kadın", 8),
    new Student("Arda Demir", "OGR059", "05381234619", "Erkek", 9),
    new Student("Cansu Koç", "OGR060", "05481234620", "Kadın", 10),

    new Student("Enes Yıldız", "OGR061", "05581234621", "Erkek", 1),
    new Student("Şeyma Kaya", "OGR062", "05191234622", "Kadın", 2),
    new Student("İbrahim Şahin", "OGR063", "05391234623", "Erkek", 3),
    new Student("Nurgül Çelik", "OGR064", "05491234624", "Kadın", 4),
    new Student("Batuhan Aydın", "OGR065", "05591234625", "Erkek", 5),
    new Student("Sude Arslan", "OGR066", "05201234626", "Kadın", 6),
    new Student("Efe Kılıç", "OGR067", "05301234627", "Erkek", 7),
    new Student("Yağmur Özdemir", "OGR068", "05401234628", "Kadın", 8),
    new Student("Bora Aksoy", "OGR069", "05501234629", "Erkek", 9),
    new Student("İlayda Kurt", "OGR070", "05211234630", "Kadın", 10),

    new Student("Doruk Erdem", "OGR071", "05311234631", "Erkek", 1),
    new Student("Melike Polat", "OGR072", "05411234632", "Kadın", 2),
    new Student("Kubilay Yalçın", "OGR073", "05511234633", "Erkek", 3),
    new Student("Hazal Şimşek", "OGR074", "05221234634", "Kadın", 4),
    new Student("Taha Doğan", "OGR075", "05321234635", "Erkek", 5),
    new Student("Beyza Karaca", "OGR076", "05421234636", "Kadın", 6),
    new Student("Mete Eren", "OGR077", "05521234637", "Erkek", 7),
    new Student("Elvan Bulut", "OGR078", "05231234638", "Kadın", 8),
    new Student("Koral Kurt", "OGR079", "05331234639", "Erkek", 9),
    new Student("Damla Güneş", "OGR080", "05431234640", "Kadın", 10),

    new Student("Okan Öztürk", "OGR081", "05531234641", "Erkek", 1),
    new Student("Pınar Yıldırım", "OGR082", "05241234642", "Kadın", 2),
    new Student("Serhat Çetin", "OGR083", "05341234643", "Erkek", 3),
    new Student("Eylül Taş", "OGR084", "05441234644", "Kadın", 4),
    new Student("Levent Yalçın", "OGR085", "05541234645", "Erkek", 5),
    new Student("Dilan Keskin", "OGR086", "05251234646", "Kadın", 6),
    new Student("Mahir Özkan", "OGR087", "05351234647", "Erkek", 7),
    new Student("İpek Korkmaz", "OGR088", "05451234648", "Kadın", 8),
    new Student("Berk Tunç", "OGR089", "05551234649", "Erkek", 9),
    new Student("Ceyda Ergin", "OGR090", "05261234650", "Kadın", 10),

    new Student("Fırat Acar", "OGR091", "05361234651", "Erkek", 1),
    new Student("Gözde Kaya", "OGR092", "05461234652", "Kadın", 2),
    new Student("Yasin Yavuz", "OGR093", "05561234653", "Erkek", 3),
    new Student("Mina Can", "OGR094", "05271234654", "Kadın", 4),
    new Student("Kürşat Duman", "OGR095", "05371234655", "Erkek", 5),
    new Student("Elif Aksu", "OGR096", "05471234656", "Kadın", 6),
    new Student("Emir Öz", "OGR097", "05571234657", "Erkek", 7),
    new Student("Berrak Ateş", "OGR098", "05281234658", "Kadın", 8),
    new Student("Yiğit Sönmez", "OGR099", "05381234659", "Erkek", 9),
    new Student("Merve Karaman", "OGR10", "05481234660", "Kadın", 10),

    new Student("Cem Dursun", "OGR11", "05581234661", "Erkek", 1),
    new Student("Aylin Uçar", "OGR12", "05291234662", "Kadın", 2),
    new Student("İsmail Kaya", "OGR13", "05391234663", "Erkek", 3),
    new Student("Rana Demir", "OGR14", "05491234664", "Kadın", 4),
    new Student("Mert Çetin", "OGR15", "05591234665", "Erkek", 5),
    new Student("Defne Yılmaz", "OGR16", "05301234666", "Kadın", 6),
    new Student("Ahmet Can", "OGR17", "05301234667", "Erkek", 7),
    new Student("Sena Arslan", "OGR18", "05401234668", "Kadın", 8),
    new Student("Kaan Şahin", "OGR19", "05501234669", "Erkek", 9),
    new Student("Nehir Çelik", "OGR11", "05311234670", "Kadın", 10),

    new Student("Murat Aydın", "OGR111", "05311234671", "Erkek", 1),
    new Student("Duygu Koç", "OGR112", "05411234672", "Kadın", 2),
    new Student("Hüseyin Yıldız", "OGR113", "05511234673", "Erkek", 3),
    new Student("Selma Kılıç", "OGR114", "05321234674", "Kadın", 4),
    new Student("Eray Özdemir", "OGR115", "05321234675", "Erkek", 5),
    new Student("Buse Aksoy", "OGR116", "05421234676", "Kadın", 6),
    new Student("Oğuz Kurt", "OGR117", "05521234677", "Erkek", 7),
    new Student("Lale Erdem", "OGR118", "05331234678", "Kadın", 8),
    new Student("Rıza Polat", "OGR119", "05331234679", "Erkek", 9),
    new Student("Selen Yalçın", "OGR120", "05431234680", "Kadın", 10),

    new Student("Ulaş Şimşek", "OGR121", "05531234681", "Erkek", 1),
    new Student("Ekin Doğan", "OGR122", "05341234682", "Kadın", 2),
    new Student("Cihan Karaca", "OGR123", "05341234683", "Erkek", 3),
    new Student("Duru Eren", "OGR124", "05441234684", "Kadın", 4),
    new Student("Baran Bulut", "OGR125", "05541234685", "Erkek", 5),
    new Student("Lina Güneş", "OGR126", "05351234686", "Kadın", 6),
    new Student("Kuzey Öztürk", "OGR127", "05351234687", "Erkek", 7),
    new Student("Ece Yıldırım", "OGR128", "05451234688", "Kadın", 8),
    new Student("Taner Çetin", "OGR129", "05551234689", "Erkek", 9),
    new Student("Nazan Taş", "OGR130", "05361234690", "Kadın", 10),

    new Student("Gökhan Keskin", "OGR131", "05361234691", "Erkek", 1),
    new Student("Asena Özkan", "OGR132", "05461234692", "Kadın", 2),
    new Student("Volkan Korkmaz", "OGR133", "05561234693", "Erkek", 3),
    new Student("Pelin Tunç", "OGR134", "05371234694", "Kadın", 4),
    new Student("Erhan Ergin", "OGR135", "05371234695", "Erkek", 5),
    new Student("Sıla Acar", "OGR136", "05471234696", "Kadın", 6),
    new Student("Kıvanç Kaya", "OGR137", "05571234697", "Erkek", 7),
    new Student("Ceren Yavuz", "OGR138", "05381234698", "Kadın", 8),
    new Student("Alp Duman", "OGR139", "05381234699", "Erkek", 9),
    new Student("Nehir Aksu", "OGR140", "05481234700", "Kadın", 10),

    new Student("Bora Ateş", "OGR141", "05581234701", "Erkek", 1),
    new Student("İrem Sönmez", "OGR142", "05391234702", "Kadın", 2),
    new Student("Mete Karaman", "OGR143", "05391234703", "Erkek", 3),
    new Student("Cansu Dursun", "OGR144", "05491234704", "Kadın", 4),
    new Student("Kadir Uçar", "OGR145", "05591234705", "Erkek", 5),
    new Student("Gizem Kaya", "OGR146", "05301234706", "Kadın", 6),
    new Student("Eren Demir", "OGR147", "05301234707", "Erkek", 7),
    new Student("Nazlı Çelik", "OGR148", "05401234708", "Kadın", 8),
    new Student("Furkan Yıldız", "OGR149", "05501234709", "Erkek", 9),
    new Student("Zehra Arslan", "OGR150", "0531123471", "Kadın", 10)
};



List<Person> persons = new List<Person> {
new Person("Zeynep","Akıllı",35000),
new Person("Zeynep","Abacı",40000),
new Person("Şule","Demir",38000),
new Person("Şukufe","Deniz",75000),
new Person("Aydın","Zehir",528500),
new Person("Ali","Abacı",32500),
new Person("Ece","Demir",55000),
new Person("Elif","Aydın",4100),
new Person("Elif","Akın",37000),
new Person("Abuzer","Akın",39000),
new Person("Cem","Bahadır",90000),
new Person("Cemile","Baytar",40000),
};

//List<Student> maleStudents= new List<Student>();

//foreach(Student student in students)
//{
//    if (student.Gender.Equals("Erkek"))
//    {

//        maleStudents.Add(student);
//    }
//}
//Console.WriteLine(string.Join("\n",maleStudents));
//List<Student> femaleStudents = students.Where(s => s.Gender.Equals("Kadın")).ToList();
//Console.WriteLine(string.Join("\n", femaleStudents));

//// Query Syntax

//var sonuc=(from s in students
//           where s.Gender.Equals("Erkek")
//           orderby s.FullName
//           select s
//           ).ToList();

//Console.WriteLine(string.Join("\n", sonuc));

//// Method Syntax

//var sonuc2=students.Where(s=>s.Gender.Equals("Kadın")).OrderBy(s=> s.FullName).ToList();
//Console.WriteLine(string.Join("\n", sonuc2));

//List<int> numbers=new List<int> { 45,-9,88,1274,-962,856,741,235,6357,895,458,22,-5892 };

//List<int> sortNumber=numbers.Where(x=>x%2==0).OrderByDescending(s=>s).ToList();
//Console.WriteLine(string.Join(", ",sortNumber));



//List<Person> sortedPersons = persons.OrderBy(p => p.Name).ToList();


//Console.WriteLine(string.Join("\n",sortedPersons));
//Console.WriteLine();

//List<Person> sortedPersons2 = persons.OrderBy(p => p.Name).ThenBy(p=>p.LastName).ToList();
//Console.WriteLine(string.Join("\n", sortedPersons2));

//double personelSayisi = persons.Count();
//double toplamMaas=persons.Sum(p=>p.Salary);
//double ortalamaMaas=persons.Average(p=>p.Salary);
//double max=persons.Max(p=>p.Salary);
//double min=persons.Min(p=>p.Salary);
//Console.WriteLine($"Toplm Personel Sayısı: {personelSayisi}\nToplam Ödenen Maaş: {toplamMaas:C2} \nOrtalama Maaş: {ortalamaMaas:C2}\nMaximum Maaş: {max:C2}\nMinimum Maaş: {min:C2} ");

//Person maxMaas = persons.MaxBy(p => p.Salary);
//Person minMaas = persons.MinBy(p => p.Salary);
//Console.WriteLine(maxMaas);
//Console.WriteLine(minMaas);
//bool varMi = persons.Any(p => p.Salary > 100000);
//Console.WriteLine(varMi);
//bool hepsiMi = persons.All(p => p.Salary > 50000);
//Console.WriteLine(hepsiMi);

//Person person = persons.First(p => p.Salary > 50000);
//Person person1 = persons.FirstOrDefault(p => p.Salary > 50000);
//Person person2 = persons.Single(p => p.Salary > 400000);
//Person person3 = persons.SingleOrDefault(p => p.Salary > 400000);
//Person person4 = persons.Last(p => p.Salary > 50000);
//Person person5 = persons.LastOrDefault(p => p.Salary > 50000);
//Console.WriteLine("First: "+person);
//Console.WriteLine("FirstOrDefault: " + person1);
//Console.WriteLine("Single: " + person2);
//Console.WriteLine("SingleOrDefault: " + person3);
//Console.WriteLine("Last: " + person4);
//Console.WriteLine("LastOrDefault: " + person5);

//var bolumler = students.GroupBy(s=>s.Bolum).ToList();
//foreach (var item in bolumler)
//{

//    int count = students.Count(s => s.Bolum == item.Key);
//    Console.WriteLine($"Bölüm: {item.Key}({count})");
//    List<Student> bolumOgrenci=students.Where(s=>s.Bolum==item.Key).ToList();
//    Console.Write("     ");
//    Console.WriteLine(string.Join("\n     ",bolumOgrenci));
//}



//var ogrenciBolum = students.Join(
//    bolumler, // Birleştirilecek Liste
//    s => s.Bolum, // İki listenin kesişimi
//    bol => bol.Id, // İki listenin kesişimi
//    (s, bol) => new { s.FullName, bol.Name }
//    ).ToList();

//Console.WriteLine(string.Join("\n", ogrenciBolum));
//List<int> numbers = new List<int> { 1, 1, 2, 5, 4, 2, 5, 2, 9, 1, 9 };
//var tekil = numbers.Distinct().ToList();
//Console.WriteLine(string.Join(", ", tekil));

//Console.WriteLine(string.Join("\n", bolumler));
//var tekrarsizBolumler = bolumler.DistinctBy(b=>b.Id).ToList();
//Console.WriteLine();
//Console.WriteLine(string.Join("\n", tekrarsizBolumler));

//Console.WriteLine(string.Join("\n",students));

//List<int> range=Enumerable.Range(50,20).ToList();
//List<Student> student2 = new List<Student>();
//foreach(int i in range)
//{
//    string ogrNo = "OGR0" + i;
//    var match=students.Where(s=>s.Number==ogrNo).ToList();
//    student2.AddRange(match);
//}


//Console.WriteLine(string.Join("\n", student2));

//List<Student> sayfalama = students.Skip(10).Take(5).ToList();
//Console.WriteLine(string.Join("\n", sayfalama));

List<int> number = new List<int> { 5, 6, 7, 8, 9 };
List<int> number2 = new List<int>() {6,7,3,4,9 };

var birlesim = number.Union(number2).ToList();
var kesisim = number.Intersect(number2).ToList();
var fark = number.Except(number2).ToList();

Console.WriteLine(string.Join(", ", birlesim));
Console.WriteLine(string.Join(", ", kesisim));
Console.WriteLine(string.Join(", ", fark));
