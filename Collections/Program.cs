namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Iki reqemli eded daxil edin");
            //int eded=Convert.ToInt32(Console.ReadLine());

            //while (eded <= 100)
            //{

            //    eded += 10;

            //    Console.WriteLine(eded);
            //}

            //for (int i = 100; i <1000; i++) { 
            //    if (i % 10 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Console.WriteLine("Zehmet olmasa eded daxil edin");
            //int result = 0;
            // for (int i = 11; i <= 99; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         result=result+i;

            //     }


            // }
            // Console.WriteLine(result);
            // Console.ReadLine();


            #region task6
            //        Sadə ədədləri çıxaran proqram yazın.
            //İstifadəçidən n ədədini soruşan və n-dən 0-a kimi
            //            bütün sadə ədədləri azalan ardıcıllıqla çıxaran proqram yazın.

            //Console.WriteLine("Enter a number:");
            //int n = int.Parse(Console.ReadLine() ?? "");

            //for (int i = n; 2 <= i; i--)
            //{
            //    if (n == 2)
            //    {
            //        Console.WriteLine(n);
            //    }
            //    else
            //    {
            //        int k = i - 1;
            //        while(i%k != 0 && k>=2)
            //        {
            //            k--;
            //            if (k==1)
            //            {
            //                Console.WriteLine(i);
            //
            //
            //
            //            }



            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine() ?? "");

            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
          

        }

    }
            }
         
                   

         


#endregion 

