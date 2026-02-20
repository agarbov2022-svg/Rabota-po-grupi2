using System.IO;
using System.Text.Json;

public class Jsonwrite
{
	public Jsonwrite()
	{
		static void Main()
		{

            public void SaveToJson(int[] numbers, string fileName)
    {
        string json = JsonSerializer.Serialize(numbers,
            new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(fileName, json);
    }
}
	}
}
