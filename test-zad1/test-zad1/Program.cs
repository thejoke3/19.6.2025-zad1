namespace test_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string People = Console.ReadLine();
           
            bool StopNotFound = true;
            Dictionary<string, int> pair = new Dictionary<string, int>();
            while (StopNotFound)
            {
                if (People == "stop")
                {

                    break;
                }

                if (pair.ContainsKey(People))
                {
                    pair[People] += 1;
                }
                else
                {
                    pair.Add(People, 1);
                }


                People = Console.ReadLine();
            }
                
            
            foreach (var item in pair)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
