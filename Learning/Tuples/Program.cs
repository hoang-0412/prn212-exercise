namespace Tuples;

public class Tuples
{
    static (int sum, int count) MyMethod(int[] values)
    {

        //khai báo một tuple
        var r = (sum: 0, count: 0);
        for (int i = 0; i < values.Length; i++)
        {

            if (IsEvenNumber(values[i]))
            {

                r.sum += values[i];
                r.count++;
            }
        }
        return r;

        bool IsEvenNumber(int n)
        {
            return n % 2 == 0;
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
        var (sum, count) = MyMethod(numbers);
        Console.WriteLine($"Sum: {sum}, Count: {count}");
        Console.ReadLine();
    }

    //Su dung bien tuple de thong ke cho 1 mang so nguyen:
    //Tong so chan, so luong so chan
    //Tong so le, so luong so le > 3
    //Tong binh phuong so nguyen to, so luong so nguyen to
}