using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sayıları girin: ");
        string input = Console.ReadLine();
        string[] numbersStr = input.Split(' ');
        int[] numbers = new int[numbersStr.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersStr[i]);
        }

        Array.Sort(numbers);

        Console.WriteLine("Sayılarınız küçükten büyüğe sıralanmıştır:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.Write("Aramak istediğiniz sayıyı girin: ");
        int searchNumber = int.Parse(Console.ReadLine());

        int index = BinarySearch(numbers, searchNumber);

        if (index == -1)
        {
            Console.WriteLine("Sayı dizide bulunamadı.");
        }
        else
        {
            Console.WriteLine("{0} sayısı dizinin {1}. sırasında bulundu.", searchNumber, index + 1);
        }

        Console.ReadKey();
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}