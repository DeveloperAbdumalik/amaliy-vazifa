/*System.Console.WriteLine("Doira yuzi va aylana uzunligini hisoblash:");
System.Console.Write("Radiusni kiriting r=");
double  r = Convert.ToDouble(Console.ReadLine());
double s,l,pi=3.14d;
s=pi*r*r;
l=2*pi*r; 
System.Console.WriteLine($"Doira yuzi S = {s},\nAylana uzunligi {l}");*/



/*System.Console.WriteLine("Valyuta konvertri:");
System.Console.Write("Qiymat summani kiriting q = ");
double q = Convert.ToDouble(Console.ReadLine());
System.Console.Write("SUM dagi valyuta kursini kiriting sum = ");
double sum = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Sumga kanvertatsiya qilingan qiymat: {q*sum}");*/



/*System.Console.WriteLine("Yoshni hisoblash:");
System.Console.WriteLine("Foydalanuvchining tug'ilgan kunini kiriting: ");
int age = Convert.ToInt32(Console.ReadLine());
int year = 2023;
System.Console.WriteLine($"Foydalanuvchi {(year-age)*365} kun yashagan.");*/



/*System.Console.WriteLine("String ustida amallar: ");
System.Console.Write("Satir kiriting: ");
string str = Console.ReadLine();
System.Console.WriteLine("Butun son kiriting: ");
int x = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(str.Length);

string result = (x>=a)
    ? str.ToUpper()
    : str.ToLower();
System.Console.WriteLine(result);**/



/*int x = 15;
int y = 10;
if(x > y)
{
    System.Console.WriteLine("x is greater than y");
}
else if(x < y)
{
    System.Console.WriteLine("x is less then y");
}
else if(x==y)
{
    System.Console.WriteLine("x is equal to y");
}
else
    System.Console.WriteLine("x and y are not comparable");*/



System.Console.WriteLine("Hafta kunlari:");
System.Console.Write("Hafta kunini kiriting: ");
string str = Console.ReadLine();
string day = str.ToLower();
switch(day)
{
    case "dushanba": System.Console.WriteLine("monday");
        break;
    case "seshanba": System.Console.WriteLine("tuesday");
        break;
    case "chorshanba": System.Console.WriteLine("wednesday");
        break;
    case "payshanba": System.Console.WriteLine("thursday");
        break;
    case "juma": System.Console.WriteLine("friday");
        break;
    case "shanba": System.Console.WriteLine("saturday");
        break;
    case "yakshanba": System.Console.WriteLine("sunday");
        break;
    default:
        System.Console.WriteLine("Bunaqa hafta kuni yuq:");
        break;
}
