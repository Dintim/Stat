using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, " +
                "Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            string[] tmp = str.Split(' ');
            
            Dictionary<string, int> dic = new Dictionary<string, int>();            
            foreach (string i in tmp)
            {
                if (dic.ContainsKey(i))
                    dic[i] += 1;
                else
                    dic.Add(i, 1);
            }

            Console.WriteLine("\tСлово:\t\tКол-во:");
            int k = 1;
            foreach (var i in dic)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}", k+".", i.Key, i.Value);
                k++;
            }
            Console.WriteLine("Всего слов: {0} из них уникальных: {1}", tmp.Length, dic.Count);
        }
    }
}
