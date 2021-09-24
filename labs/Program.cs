﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs

{
    enum TypeAccount
    {
        accountCurrent = 1,
        accountSavings
    }
    enum University
    {
        КГУ = 1,
        КАИ,
        КХТИ
    }
    struct Account
    {
        public ulong number;
        public TypeAccount type;
        public double balance;
    }
    struct Worker
    {
        public string name;
        public University place;
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task3.1");
            TypeAccount client;
            client = TypeAccount.accountCurrent;
            Console.WriteLine(client);

            Console.WriteLine("task3.2");
            Account user;
            Console.Write("1.Текущий счет.\n2.Сберегательный счет.\nВыберите тип счета(1 или 2): ");
            user.type = (TypeAccount)Convert.ToByte(Console.ReadLine());
            Console.Write("Введите номер счета-");
            user.number = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Введите баланс-");
            user.balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Информация о счете:\nТип счета: {user.type}\nНомер счета: {user.number}\nБаланс: {user.balance}");

            Console.WriteLine("task3.2home");
            Worker person;
            Console.Write("1.КГУ\n2.КАИ\n3.КХТИ\nВыберите место будущей работы (1,2,3): ");
            person.place = (University)Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите свое имя-");
            person.name = Console.ReadLine();
            Console.WriteLine($"Информация о работнике\nИмя: {person.name}\nМесто работы: {person.place}");

            Console.ReadKey();


        }
    }
}
