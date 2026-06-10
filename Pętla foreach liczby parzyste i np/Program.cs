class Program
{
    static void Main (string[] args)
    {
        int n = 101;
        int[] dane = new int[n];
        int sumap = 0;
        int sumanp = 0;

        for(int i = 1; i < n; i++)
        {
            dane[i] = i;
        }
        for (int i = 1; i <n; i++)
        {
            Console.WriteLine($"{dane[i]}");


        }

        foreach (int i in dane)
        {
            if (dane[i] % 2 != 0)
            {
                sumanp += dane[i];

            } else
            {
                sumap += dane[i];
            }



        }
        Console.WriteLine($"Suma nieparzystych: {sumanp}");
        Console.WriteLine($"Suma parzystych: {sumap}");





    }




}