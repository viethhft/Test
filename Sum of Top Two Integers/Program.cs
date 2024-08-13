try
{
    Console.WriteLine("Enter number element, please:");
    var number = int.Parse(Console.ReadLine());
    int[] lstInput = new int[number];

    for (int i = 0; i < number; i++)
    {
        lstInput[i] = int.Parse(Console.ReadLine());
    }
    int maxItem1 = 0;
    int maxItem2 = 0;
    for (int i = 0; i < lstInput.Length; i++)
    {
        for (int j = 0; j < lstInput.Length; j++)
        {
            if (i == j)
            {
                continue;
            }
            else
            {
                if (lstInput[j] > lstInput[i])
                {
                    maxItem1 = lstInput[j];
                }
                else if (lstInput[j] > maxItem2)
                {
                    maxItem2 = lstInput[j];
                }
            }
        }
    }
    Console.WriteLine("Result: " + (maxItem1 + maxItem2));
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}