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
    //Yeu cau so 1
    static (long sumEven, int countEven) ThongKeSoChan(int[] values)
    {
        //Khoi tao Tuple
        var result = (sumEven: 0L, countEven: 0);

        foreach (int n in values)
        {
            if (IsEvenNumber(n))
            {
                result.sumEven += n;
                result.countEven++;
            }
        }

        return result;

        //Local function kiem tra so chan
        bool IsEvenNumber(int x) => x % 2 == 0;
    }
    //Yeu cau so 2
    static (long productOdd, int countOddGreaterThan3) ThongKeSoLe(int[] values)
    {
        long product = 1;
        int countOdd = 0;
        int countOddGreaterThan3 = 0;

        foreach (int n in values)
        {
            if (IsOddNumber(n))
            {
                product *= n;
                countOdd++;

                if (n > 3)
                {
                    countOddGreaterThan3++;
                }
            }
        }

        // Truong hop khong co so le, tich se la 0
        if (countOdd == 0)
        {
            product = 0;
        }

        return (product, countOddGreaterThan3);

        //Local function kiem tra so le
        bool IsOddNumber(int x) => x % 2 != 0;
    }
    static (long sumSquaresPrime, int countPrime) ThongKeSoNguyenTo(int[] values)
    {
        var result = (sumSquaresPrime: 0L, countPrime: 0);

        foreach (int n in values)
        {
            if (IsPrime(n))
            {
                result.sumSquaresPrime += (long)n * n;
                result.countPrime++;
            }
        }
        return result;

        //Local function kiem tra so nguyen to
        bool IsPrime(int x)
        {
            if (x < 2) return false;
            if (x == 2 || x == 3) return true;
            if (x % 2 == 0 || x % 3 == 0) return false;

            for (int i = 5; i * i <= x; i += 6)
            {
                if (x % i == 0 || x % (i + 2) == 0)
                    return false;
            }
            return true;
        }
    }
    static void Main(string[] args)
    {
        int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
        var (sum, count) = MyMethod(numbers);
        Console.WriteLine($"Sum: {sum}, Count: {count}");
        //Su dung kieu tuple de thong ke cho 1 mang so nguyen:
        //Tong so chan, so luong so chan
        var (sumEven, countEven) = ThongKeSoChan(numbers);
        Console.WriteLine($"Tong so chan: {sumEven}");
        Console.WriteLine($"So luong so chan: {countEven}");
        //Tich so le, so luong so le > 3
        var (tichSoLe, soLuongLeLonHon3) = ThongKeSoLe(numbers);
        Console.WriteLine($"Tich cac so le: {tichSoLe}");
        Console.WriteLine($"So luong so le > 3: {soLuongLeLonHon3}");
        //Tong binh phuong so nguyen to, so luong so nguyen to
        var (tongBinhPhuongNT, soLuongNT) = ThongKeSoNguyenTo(numbers);
        Console.WriteLine($"Tong binh phuong so nguyen to: {tongBinhPhuongNT}");
        Console.WriteLine($"So luong so nguyen to: {soLuongNT}");
        Console.ReadLine();
    }
}