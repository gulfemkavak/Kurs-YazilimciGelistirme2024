
using Intro.Business;
using Intro.Entities;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

          string message1 = "Krediler";
          int term = 12;
          double amount = 100000;
bool isAuthenticated = true;
          //variables-değişkenler-->camelCase yazılır.       bool isAuthenticated = false;
  Console.WriteLine(message1);
  Console.WriteLine(term);
//condition

if (isAuthenticated)

{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{ 
    Console.WriteLine("Buton-->Sisteme giriş yap.");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3","Kredi4","Kredi5","Kredi6" };//normalde db den gelecek
//string[] loans2 = new string[] 
//{
//};
//string[] loans3 = new string[6];
//loans2[0]= "Kredi 1";
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine($"{loans[i]} {amount}");
    Console.WriteLine(loans[i] );
}


CourseManager courseManager = new();

Courses[] courses2=courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}


Console.WriteLine("Kod Bitti.");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalityIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalityIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.TaxNumber = "123456788987";

CorporateCustomer customer4 = new CorporateCustomer();
customer3.Id = 4;
customer3.Name = "Abc";
customer3.TaxNumber = "123456788985";

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };
cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);
foreach (string city in cities2)
{
    Console.WriteLine(city);
}

//value types ->int, bool, double...
//reference types-> array, class, interface... 
                                //101      //102    //103       //104
BaseCustomer[] customers= { customer1, customer2, customer3, customer4 };

//polymorphism
foreach(BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
