
using Intro.Business;
using Intro.Entities;

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

Course[] courses2=courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}


Console.WriteLine("Kod Bitti.");