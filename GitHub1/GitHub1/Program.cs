namespace GitHub1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputReader reader = new InputReader();
            Sorter sorter = new Sorter();
            JsonWriter writer = new JsonWriter();

            int[] numbers = reader.ReadNumbers();

            numbers = sorter.SortNumbers(numbers);

            writer.SaveToJson(numbers, "numbers.json");

            Console.WriteLine("Всичко приключи успешно ✅");
        }
    }
    }
}
