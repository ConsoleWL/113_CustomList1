namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> str = new CustomList<string>();
            str.Add("hello1");
            str.Add("hello2");
            str.Add("hello3");
            str.Add("hello4");
            //str.Add("hello5");
            //str.Add("hello6");
            //str.Add("hello7");
            //str.Add("hello8");
            //str.Add("hello9");
            //str.Add("hello10");
            

            int t = 0;

            str[3] = "hahah";

            Console.WriteLine(str.ToString());

            List<string> numbers = new List<string>();
            
            
            
        }
    }
}