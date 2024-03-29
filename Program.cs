﻿using System;

namespace TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PhoneListModel.PhoneNumberList.Add(new NumberModel("Ömer", "Pala", "123"));
            PhoneListModel.PhoneNumberList.Add(new NumberModel("Faruk", "Pala", "456"));
            PhoneListModel.PhoneNumberList.Add(new NumberModel("Ömer Faruk", "Pala", "789"));
            PhoneListModel.PhoneNumberList.Add(new NumberModel("Sedat", "Can", "123"));
            PhoneListModel.PhoneNumberList.Add(new NumberModel("Anıl", "Cano", "852"));

            Operation.StartPrint();
            int select = int.Parse(Console.ReadLine());
            while(Operation.ControlNumber(select))
            {
                if(select == 1)
                {
                    Operation.SaveNumber();
                }else if(select == 2)
                {
                    Operation.DeleteNumber();
                }else if (select == 3)
                {
                    Operation.UpdateNumber();
                }else if(select == 4)
                {
                    Operation.PrintNumberList();
                }else if (select == 5)
                {
                    Operation.SearchNumber();
                }
                else
                {
                    Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girildi, Çıkılıyor...");
                    break;
                }
                Operation.StartPrint();
                select = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Rehberin Son Hali: ");
            Operation.PrintNumberList();
            Console.WriteLine("Program Sona Erdi, Çıkmak İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();
        }
    }
}
