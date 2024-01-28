internal class Program
{
    static void Main(string[] args)
    {
        int[] tablica1 = new int[10]; //size board: 10

        for (int i = 0; i < tablica1.Length; i++)// indeks
        {
            tablica1[i] = i;
        }
        Console.WriteLine("Index value:  Table value:");
        for (int i = 0; i < tablica1.Length; i++)
        {
            Console.WriteLine($"{i}             {tablica1[i]}");
        }
    }
}