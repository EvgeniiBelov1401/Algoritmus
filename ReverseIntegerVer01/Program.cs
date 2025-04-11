using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите число: ");
            try
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    var numRev = Reverse(num);
                    Console.WriteLine(numRev);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректные данные...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
    static int Reverse(int x)
    {
        int sign=1;
        var xStr = x.ToString();
        var xStrLength = xStr.Length;
        int num = 0;

        if (xStr[0] == '-')
        {
            sign = -1;
            xStr.Skip('-');
        }
        for (int i=xStrLength-1;i>=0;i--)
        {
            var x1 = Convert.ToInt32(xStr[i]);
            var step = Math.Pow(10, i);
            num += (int)(x1 * step);
        }
        if (sign != -1) return num;
        else return num * -1;

    }
}