namespace Aowu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ?str;
            if (args.Length >= 1)
            {
                Console.WriteLine("抱歉！暂不支持接受任何参数和文件。");
                Console.WriteLine("尔等可愿支持吾的小说，吾现在虽是一个小作家，假以时日必定是传说级作家。吾名百里征途");
                return;
            }
            Console.Write("Welcome to Aowu v0.0.0\n为统治世界而诞生的编程语言，由传说级作家联合世界的力量打造。吾需要诸位的力量，待吾君临天下之日，封尔等贡献者当大将。\n");
            while (true)
            {
                Console.Write(">>>");
                str= Console.ReadLine();
                if (str == "exit()")
                    break;
                Console.WriteLine(str);
            }
        }
    }
}
