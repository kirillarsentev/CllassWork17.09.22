using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CllassWork17._09._22
{
    internal class Program
    {
        enum account
        {   
            текущий,
            сберегательный
        }
        struct Bank
        {
            public string number;
            public string type;
            public double balance;
        }   
        enum Vuz
        {
            КГУ,
            КАИ,
            КХТИ
        }
        struct Worker
        {
            public string name;
            public string university;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("ДЗ 3.1");
            account account = new account();
            account = account.текущий;
            Console.WriteLine(account);

            Console.WriteLine("ДЗ 3.2");
            Bank bank = new Bank();
            bank.number = "777";
            bank.type = "сберегательный";
            bank.balance = 77777777;
            Console.WriteLine("Номер счета: " + bank.number +'\n' + "Тип:" + bank.type + '\n' + "Баланс: " + bank.balance);


            Console.WriteLine("ДЗ 3.1");
            Worker worker1 = new Worker();
            Vuz vuz1 = new Vuz();
            Worker worker2 = new Worker();
            Vuz vuz2 = new Vuz();
            Worker worker3 = new Worker();
            Vuz vuz3 = new Vuz();
            worker1.name = "Сер гей";
            vuz1 = Vuz.КХТИ;
            worker2.name = "Степан";
            vuz2 = Vuz.КАИ;
            worker3.name = "Нкита";
            vuz3 = Vuz.КГУ;
            Console.WriteLine(worker1.name + " учится в " + vuz1 + '\n' +  worker2.name + " учится в " + vuz2 + '\n' + worker3.name + " учится в " + vuz3);


        }
    }
}
