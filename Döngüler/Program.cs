//Arkadaş Sayı Problemi
Console.Write("1. Sayıyı giriniz : ");
int number = Convert.ToInt32(Console.ReadLine());
//Console.Write("2. Sayıyı giriniz : ");
//int number2 = Convert.ToInt32(Console.ReadLine());

int toplamBolen = 0;

for (int i = 1; i < number; i++)
{
    if ((number % i) == 0)
    {
        toplamBolen += i;
    }
}
//if (toplamBolen == number2)
//{
    //Console.WriteLine(number + "'in tam bölenlerinin toplamı : " + toplamBolen + "=" + number2 + " olduğundan, girdiğiniz iki sayı arkadaş sayıdır.");
    Console.WriteLine("Ya da şunu diyebilirdik : " + number + " ve " + toplamBolen + " arkadaş sayılardır.");
//}
