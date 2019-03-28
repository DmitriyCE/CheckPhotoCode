using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPhotoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, укажите через запятую список документов.");
            String docs = Console.ReadLine();
            if (docs.Length != 0)
            {
                if (docs.Contains("фото"))
                {
                    Console.WriteLine("Фотография сделана более 3-х месяцев назад?(да/нет)");
                    if (Console.ReadLine() == "нет")
                    {
                        Console.WriteLine("Использовалась ли эта фотография на паспорт?(да/нет)");
                        if (Console.ReadLine() == "нет")
                        {
                            Console.WriteLine("Фотография вклеена?(да/нет)");
                            if (Console.ReadLine() == "нет")
                            {
                                Console.WriteLine("Вклейте фотографию");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Проходите на оплату");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Эта фотография не должна быть использована для паспорта.Пройдите в фотокомнату");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Фотография должна быть не старше 3-х месяцев.Пройдите в фотокомнату");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("У вас нет фотографии.Пройдите в фотокомнату");
                    Console.ReadLine();
                    //dkjhdkjfghdfsgh
                }
            }
        }
    }
}
