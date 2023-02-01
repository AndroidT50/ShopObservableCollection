using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Shop shop = new Shop(customer.OnItemChanged);
            Console.WriteLine("Для добавления товара нажмите 'A', для удаления товара - 'D', для выхода - 'X'");

            var flag = true;

            while (flag)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'A':
                        Console.WriteLine();
                        
                        shop.Add();
                        break;
                    case 'D':
                        Console.WriteLine();
                       
                        RemoveId(shop);
                        break;
                    case 'X':
                       
                        flag = false;
                        break;
                }
            }
        }
        private static void RemoveId(Shop shop)
        {
            Console.WriteLine("Введите id товара для удаления:");
            var flag = false;
            int id = -1;
            while (!flag)
            {
                if (Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine();
                    if (shop.Remove(id))
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("С указанным id  товара не существует, попробуйте другой id");
                        continue;
                    }
                }
                Console.WriteLine("Введите корректный id");
            }

        }

    }
}
