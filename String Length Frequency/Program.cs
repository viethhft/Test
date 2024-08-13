try
{
    List<string> listInput = new List<string>();
checkpoint:
    Console.WriteLine("Enter number element, please:");
    var number = int.Parse(Console.ReadLine());
    if (number <= 0)
    {
        Console.WriteLine("Number must greate than 0!!!");
        goto checkpoint;
    }
    else
    {
        List<string> listTemp = new List<string>();
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Enter value element: " + (i + 1));
            listInput.Add(Console.ReadLine());
        }
        foreach (string input in listInput)
        {
            if (input.Length == 2)
            {
                listTemp.Add(input);
            }
        }
        Console.WriteLine("Result: " + String.Join(", ", listTemp));
    }
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}