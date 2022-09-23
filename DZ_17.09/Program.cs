using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_17._09
{
    class Program
    {
        struct People
        {
            public string date;
            public string name;
            public string surname;
            public int Id;
            public string alcohol;
            public int volume;

        }
        struct user
        {
            public string name;
            public string town;
            public int age;
            public int pin;
        }

        static void Main(string[] args)
        {
              Console.WriteLine();
              People stud1 = new People();
              stud1.name = "Вася";
              stud1.surname = "Иванов";
              stud1.date = "12.10.1999";
              stud1.alcohol = "b";
              stud1.Id = 4756375;
              stud1.volume = 5;
              People stud2 = new People();
              stud2.name = "Алексей";
              stud2.surname = "Смирнов";
              stud2.date = "16.09.1986";
              stud2.alcohol = "a";
              stud2.Id = 7756275;
              stud2.volume = 7;
              People stud3 = new People();
              stud3.name = "Вадим";
              stud3.surname = "Попово";
              stud3.date = "06.11.2000";
              stud3.alcohol = "c";
              stud3.Id = 5766375;
              stud3.volume = 3;
              People stud4 = new People();
              stud4.name = "Владимир";
              stud4.surname = "Соколов";
              stud4.date = "14.10.1982";
              stud4.alcohol = "d";
              stud4.Id = 4702375;
              stud4.volume = 1;
              People stud5 = new People();
              stud5.name = "Данил";
              stud5.surname = "Новиков";
              stud5.date = "11.05.1799";
              stud5.alcohol = "a";
              stud5.Id = 4756375;
              stud5.volume = 8;
              double volume_alco = stud1.volume + stud2.volume + stud3.volume + stud4.volume + stud5.volume;
              double percent1 = Math.Round((stud1.volume / volume_alco) * 100);
              double percent2 = Math.Round((stud2.volume / volume_alco) * 100);
              double percent3 = Math.Round((stud3.volume / volume_alco) * 100);
              double percent4 = Math.Round((stud4.volume / volume_alco) * 100);
              double percent5 = Math.Round((stud5.volume / volume_alco) * 100);
              Console.WriteLine("Всего алкоголя выпито: " + volume_alco);
              Console.WriteLine("Из них первый студент выпил: " + percent1 + '\n' + "Второй выпил : " + percent2 + '\n' + "Третий выпил :" + percent3 + '\n' + "Четвертый выпил : " + percent4 + '\n' + " Пятый выпил: " + percent5);

              Console.WriteLine("ДЗ.Задача 2");
              Console.WriteLine("byte : " + byte.MinValue + "..." + byte.MaxValue + '\n' +
                                "sbyte : " + sbyte.MinValue + "..." + sbyte.MaxValue + '\n' +
                                "short : " + short.MinValue + "..." + short.MaxValue + '\n' +
                                "ushort : " + ushort.MinValue + "..." + ushort.MaxValue + '\n' +
                                "int :" + int.MinValue + "..." + int.MaxValue + '\n' +
                                "uint : " + uint.MinValue + "..." + uint.MaxValue + '\n' +
                                "long : " + long.MinValue + "..." + long.MaxValue + '\n' +
                                "ulong : " + ulong.MinValue + "..." + ulong.MaxValue + '\n' +
                                "char : " + char.MinValue + "..." + char.MaxValue + '\n' +
                                "float : " + float.MinValue + "..." + float.MaxValue + '\n' +
                                "decimal : " + decimal.MinValue + "..." + decimal.MaxValue + '\n' +
                                "string : ограничено внутреней памятью" + '\n' +
                                " bool : True ... False" + '\n' +
                                "object : принимает практические все значения");


              Console.WriteLine("ДЗ.Задача 3");
              user new_user = new user();
              Console.WriteLine("Введите имя");
              new_user.name = Console.ReadLine();
              Console.WriteLine("Введите город");
              new_user.town = Console.ReadLine();
              Console.WriteLine("Введите возраст");
              new_user.age = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите PIN");
              new_user.pin = int.Parse(Console.ReadLine());
              Console.WriteLine(new_user.name + '\n' + new_user.town + '\n' + new_user.age + '\n' + new_user.pin);

              Console.WriteLine("ДЗ.Задача 4");
              string[] str = Console.ReadLine().Split(' ');
              Console.WriteLine((Convert.ToString(str[0][0]).ToUpper() + " . " + Convert.ToString(str[1][0]).ToUpper()));

              Console.WriteLine("ДЗ.Задача 5");
              Console.WriteLine("Введите нормальную цену на бутылку : ");
              int normpraiсe = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Введите скидку : ");
              int sale = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Введите стоимость отпуска : ");
              int vacation = Convert.ToInt32(Console.ReadLine());
              int new_sale = normpraiсe * sale / 100;
              int new_praice = normpraiсe - new_sale;
              Console.WriteLine(vacation / (normpraiсe - new_praice)); 

              Console.WriteLine("ДЗ. Задача 6");
              Console.WriteLine("Ведите скорость таракана в км / ч");
              double speed = Convert.ToDouble(Console.ReadLine()) * 100000 / 3600;
              Console.WriteLine(speed); 


            Console.WriteLine("ДЗ. Задача 7");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

        }
    }
}
