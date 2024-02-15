// See https://aka.ms/new-console-template for more information

using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

Console.WriteLine("Hello, World!");

//metinsel veri tipleri string ile tutulur
string message1 = "Krediler";

//tam sayilar int veri tipiyle tutulur
int term = 12;

//ondalik sayilar tutulur
double amount = 100000.5;

//sadece iki durum tutulur. True ya da false
bool isAuthenticated = true; 

//variables --> camelCase 


//condition
//suslu parantez olmadan da blogun icini yazabilirsin ancak tek satir olmak koşuluyla.
if (isAuthenticated) //if (isAuthenticated == true) ayni seydir.
{
    Console.WriteLine("Buton-->Hoşgeldin Seca");

}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

//arrays
//benzer tipteki verileri dizilerle tutarız

string[] loans = { "Kredi 1","Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; //dbden gelecek
//string[] loans2 = new string[6];
//loans2[0] = "Kredi1";

//donguler-loops
//bir islemi istedigimiz kadar belli bir sarta gore tekrar ettirmeye yarar
    //start        condition      increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}
//CTRL+K+C  yorum satiri
//Course tipinde course1
//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".NET 8 vs ...";
//course1.Price = 0;

//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "Java 17 vs ...";
//course2.Price = 10;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Python 3.12 ...";
//course3.Price = 20;

//Course[] courses = { course1, course2, course3 };

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}

CourseManager courseManager = new(new DapperCourseDal());
List<Course> courses2 = courseManager.GetAll();

//liste olunca lenght yerine count koyuyorsun
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");

IndividualCustomer  customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Secanur";
customer1.LastName ="Kalfaoğlu";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345688922";
customer2.FirstName = "Çiğdem";
customer2.LastName = "Kalfaoğlu";
customer2.CustomerNumber = "123457";

CorporateCustomer  customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654987";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "654989";
customer4.TaxNumber = "12345678985";

//Stack Heap mevzusu
//value types -->int, bool, double...
int number1 = 10;//20
int number2 = 20;
number1 = number2 ;
number2 = 50;
Console.WriteLine(number1);

//reference types -->arrays, class, interface...
string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };
cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2 [0]);//Adana
                            //101           102         103        104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}



