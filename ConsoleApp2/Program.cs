//1--------------------
//using System;
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> telebeler = new Dictionary<int, string>() { { 1, "Asif" }, { 2, "Vasif" }, { 3, "Agasif" }, { 4, "Adil" }, { 5, "Amil" } };
//            Console.WriteLine("Menyu: ");
//            Console.WriteLine("1) Telebe elave edin");
//            Console.WriteLine("2) Telebeni ID ile axtar");
//            Console.WriteLine("3) Butun telebeleri goster");
//            Console.WriteLine("4) Cixis");

//            Console.WriteLine("Secimini: ");
//            string secim = Console.ReadLine();
//            switch (secim)
//            {
//                case "1":
//                    Console.WriteLine("Telebe id daxil edin: ");
//                    int.TryParse(Console.ReadLine(),out int yeniId);

//                    Console.WriteLine("Telebe adi daxil edin: ");
//                    string yeniad = Console.ReadLine();
//                    if (!telebeler.ContainsKey(yeniId))
//                    {
//                        telebeler.Add(yeniId, yeniad);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Bu id artiq var");
//                    }
//                    break;
//                case "2":
//                            Console.Write("Axtarilan id: ");
//                            int axtarilanId = int.Parse(Console.ReadLine());
//                            if (telebeler.TryGetValue(axtarilanId, out string tapilanAd))
//                            {
//                                Console.WriteLine($"tapilan telebe: {tapilanAd}");
//                            } else
//                            {
//                                Console.WriteLine("Bu id uygun telebe yoxdur");
//                            } break;
//                        case "3":
//                            Console.WriteLine("Butun Telebeler:");
//                            foreach (var item in telebeler)
//                            {
//                                Console.WriteLine($"Id: {item.Key}, ad: {item.Value}");
//                            } break;
//                        case "4":
//                            Console.WriteLine("Cixilir...");
//                        break;
//                        default:
//                            Console.WriteLine("yanlis secim");
//                            break;
//                        }
//        }
//    }
//}

//2------------------------------
//using System;
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("fiqur secin: ");
//            Console.WriteLine("1-daire,2-duzbucaqli,3-ucbucaq");
//            string secim = Console.ReadLine();
//            switch (secim)
//            {

//                case "1":
//                    Console.WriteLine("dairenin radiusunu daxil edin: ");
//                    double.TryParse(Console.ReadLine(), out double radius);
//                    double sahe1 = Math.Pow(radius,2) * Math.PI;
//                    double sahe = Math.Round(sahe1,2);
//                    Console.WriteLine(sahe);
//                    break;

//                case "2":
//                    Console.WriteLine("Duzbucaglinin tereflerini daxil edin: ");
//                    double.TryParse(Console.ReadLine(), out double teref1);
//                    double.TryParse(Console.ReadLine(), out double teref2);
//                    double sahe2 = teref1 * teref2;
//                    double ysahe = Math.Round(sahe2,2);
//                    Console.WriteLine(ysahe);
//                    break;

//                case "3":
//                    Console.WriteLine("Ucbucagin tereflerini daxil edin: ");
//                    double.TryParse(Console.ReadLine(), out double tteref1);
//                    double.TryParse(Console.ReadLine(), out double tteref2);
//                    double.TryParse(Console.ReadLine(), out double tteref3);
//                    double p = (tteref1 + tteref2 + tteref3) / 2.0;
//                    double sahe4 = Math.Sqrt(p * (p - tteref1) * (p - tteref2) * (p - tteref3));
//                    double sssahe = Math.Round(sahe4,2);
//                    Console.WriteLine(sssahe);
//                    break;
//                default:
//                    Console.WriteLine("yanlis secim");
//                    break;

//            }
//        }
//    }
//}

//3----------------------------
//using System;
//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> eded = new List<int>();
//            Console.WriteLine("10 eded daxil edin: ");
//            for (int i = 0; i < 10; i++)
//            {
//                int.TryParse(Console.ReadLine(), out int yenieded);
//                eded.Add(yenieded);

//            }
//            int enboyuk = eded[0];
//            int enkicik = eded[0];
//            foreach (int item in eded)
//            {
//                enboyuk = Math.Max(enboyuk, item);
//                enkicik = Math.Min(enkicik, item);
//            }
//            int cutsay = 0;
//            int teksay = 0;
//            foreach (int item in eded)
//            {
//                if (item % 2 == 0)
//                {
//                    cutsay++;
//                }
//                else
//                {
//                    teksay++;
//                }
//            }
//            Console.WriteLine($"En boyuk eded: {enboyuk}");
//            Console.WriteLine($"En kicik eded: {enkicik}");
//            Console.WriteLine($"Cutlerin sayi: {cutsay}");
//            Console.WriteLine($"teklerin sayi: {teksay}");
//        }
//    }
//}

//4------------------------
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand= new Random();
            int teyinedileneded = rand.Next(1, 101);
            
            int sizineded;
            do
            {
                Console.WriteLine("Ededi tapin: ");
                int.TryParse(Console.ReadLine(), out sizineded);
                if (sizineded > teyinedileneded)
                {
                    Console.WriteLine("Daha kicik eded cehd edin");
                }
                else if(sizineded<teyinedileneded)
                {
                    Console.WriteLine("Daha boyuk eded cehd edin");
                }

            } while (sizineded != teyinedileneded);
            
            Console.WriteLine("Tebrikler ededi tapdiniz!");
        }
    }
}