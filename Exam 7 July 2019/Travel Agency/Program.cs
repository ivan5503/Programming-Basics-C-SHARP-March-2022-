using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            string nameOfPacket = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int stay = int.Parse(Console.ReadLine());
            double priceForDay = 0;
            double priceForStay = 0;

            if (stay < 1)
            {
                Console.WriteLine($"Days must be positive number!");
                return;
            }
            if (nameOfTown == "Borovets")
            {

                if (nameOfPacket == "noEquipment")
                {
                    priceForDay = 80;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.05);
                        priceForStay = priceForDay * stay;

                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");

                }
                else if (nameOfPacket == "withEquipment")
                {
                    priceForDay = 100;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.1);
                        priceForStay = priceForDay * stay;


                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");

                }

            }
            else if (nameOfTown == "Bansko")
            {
                if (nameOfPacket == "noEquipment")
                {
                    priceForDay = 80;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.05);
                        priceForStay = priceForDay * stay;

                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");
                }
                else if (nameOfPacket == "withEquipment")
                {
                    priceForDay = 100;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.1);
                        priceForStay = priceForDay * stay;


                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");

                }
            }
            else if (nameOfTown == "Varna")
            {

                if (nameOfPacket == "noBreakfast")
                {
                    priceForDay = 100;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.07);
                        priceForStay = priceForDay * stay;

                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");

                }
                else if (nameOfPacket == "withBreakfast")
                {
                    priceForDay = 130;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.12);
                        priceForStay = priceForDay * stay;


                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");
                }


            }
            else if (nameOfTown == "Burgas")
            {
                if (nameOfPacket == "noBreakfast")
                {
                    priceForDay = 100;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.07);
                        priceForStay = priceForDay * stay;

                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");

                }
                else if (nameOfPacket == "withBreakfast")
                {
                    priceForDay = 130;
                    priceForStay = stay * priceForDay;
                    if (vipDiscount == "yes")
                    {
                        priceForDay = priceForDay - (priceForDay * 0.12);
                        priceForStay = priceForDay * stay;


                    }
                    if (stay > 7)
                    {
                        priceForStay -= priceForDay;
                    }
                    Console.WriteLine($"The price is {priceForStay:f2}lv! Have a nice time!");

                }

            }
            if (nameOfTown != "Borovets" && nameOfTown != "Bansko" && nameOfTown != "Varna" && nameOfTown != "Burgas")
            {
                Console.WriteLine($"Invalid input!");

            }
            else if (nameOfPacket != "noEquipment" && nameOfPacket != "withEquipment" && nameOfPacket != "noBreakfast" && nameOfPacket != "withBreakfast")
            {
                Console.WriteLine($"Invalid input!");
            }
        }
    }
}
