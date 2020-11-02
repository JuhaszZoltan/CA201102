using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201102
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "alma";

            //ÉRTÉK típus ként működnek rajta az operátorok!!!
            var s2 = s1;
            s2 += 'k';

            //STRING és CHAR[] tkp. ua.

            //str <- c[]
            char[] ct = new char[] { 'a', 'b', 'c' };
            string s3 = new string(ct);
            Console.WriteLine(s3);

            //c[] <- str
            char[] ct2 = s1.ToCharArray();
            foreach (var c in ct2)
                Console.WriteLine(c);

            //str mint c[]: így CSAK OLVASHATÓ
            Console.WriteLine($"Az {s1} első betűje az {s1[0]}");
            for (int i = 0; i < s1.Length; i++)
                Console.Write($"{s1[i]} ");

            //sintax error
            /*
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] == 'a') s1[i] = 'd';
            */

            //első variáció:
            var ujS1 = "";
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] == 'a') ujS1 += 'd';
                else ujS1 += s1[i];

            //s1 = ujS1;
            Console.WriteLine($"\n{ujS1}");

            //második var.
            var ujS1t = s1.ToCharArray();
            for (int i = 0; i < ujS1t.Length; i++)
                if (ujS1t[i] == 'a') ujS1t[i] = 'd';

            //s1 = new string(ujS1t);
            var ujs1_2 = new string(ujS1t);
            Console.WriteLine(ujs1_2);

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1);
            s2 = s1.Replace("a", "d");
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
