using System;

public class Program
{
	public Program()
	{
		static void Main()
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
