
public delegate bool Filter(int number);
class Program
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 };
        int[] evenArray = GetFiltered(array, IsEven);
        int[] notEvenArray = GetFiltered(array, IsNotEven);
        int[] has3Array = GetFiltered(array, Has3);
        int[] hasSameNumberArray = GetFiltered(array, HasSameNumberSequance);
        //
        System.Console.WriteLine("Original array items:");
        Print(array);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Even array items:");
        Print(evenArray);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Not even array items:");
        Print(notEvenArray);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Has 3 array items:");
        Print(has3Array);
        System.Console.WriteLine("\n********************");
        System.Console.WriteLine("Has same number array items:");
        Print(hasSameNumberArray);
        System.Console.WriteLine("\n********************");
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool IsNotEven(int number)
    {
        return !IsEven(number);
    }

    static bool Has3(int number)//1,3,12,424,23
    {
        return number.ToString().IndexOf('3') > -1;
    }

    static bool HasSameNumberSequance(int number)//1,3,12,424,23,666
    {
        string text = number.ToString();
        char firstNumber = text[0];
        for (int i = 1; i < text.Length; i++)
            if (firstNumber != text[i]) return false;
        return true;
    }

    static int[] GetFiltered(int[] array, Filter filter)
    {
        int[] newArray = new int[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (filter(array[i]))
            {
                System.Array.Resize(ref newArray, newArray.Length + 1);
                newArray[newArray.Length - 1] = array[i];
            }
        }
        return newArray;
    }

    static void Print(int[] array)
    {
        System.Console.WriteLine(string.Join(',', array));
    }

}