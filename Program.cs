using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int counter = 0;
            int IndexOfSubstruct=0;
            string CurrentStr;
            string IntStr="";
            string TryToFindThis = "pу";
            FileStream file = new FileStream("C:\\Users\\masli\\Desktop\\TryToCount.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                CurrentStr = reader.ReadLine();
                Console.WriteLine(CurrentStr);
               // Console.Write(sum);
                IndexOfSubstruct = CurrentStr.IndexOf(TryToFindThis);
                if (IndexOfSubstruct>0)
                {
                    counter++;
                    for (int i = 0; i < IndexOfSubstruct; i++)
                    {
                        IntStr += CurrentStr[i];
                    }
                    sum += Convert.ToInt32(IntStr);
                    IntStr = "";
                }

                
            }
            Console.WriteLine("summa");
            Console.Write(sum);
            Console.WriteLine("counter");
            Console.Write(counter);
            Console.ReadKey();
            reader.Close();

        }
    }
}
