using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\myText.txt";
            Console.WriteLine("您好");
            if(File.Exists(filePath))
            {
                string str = File.ReadAllText(filePath);
                Console.WriteLine("文件读取："+str);
            }
            else
            {
                string str = "无可奈何花落去，\n 似曾相识燕归来，\n 小园香径独徘徊。";
                File.WriteAllText(filePath, str);
                Console.WriteLine("文件已写入");
            }
            Console.WriteLine("Hello World!");
            string str1 = "无可奈何花落去,似曾相识燕归来，小园香径独徘徊";
            char[] sep = new char[] { ',','，' };
            string[] str1s = str1.Split(sep);
            foreach(string str in str1s)
            {
                Console.WriteLine(str);
            }
            string str2 = "56dD[word]k gagh hahj";
            Regex expression = new Regex(@"\d\d[a-zA-Z][a-zA-Z]\[\w\w\w\w\]\w");
            MatchCollection matches= expression.Matches(str2);
            foreach(Match match in matches)
            {
                Console.WriteLine(match.ToString());
                Console.WriteLine("Test modify");
            }

        }
    }
}
