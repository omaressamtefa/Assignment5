using System;

class Program
{
    static void Main()
    {
        #region Task 1 - Difference between Value Type by Value and by Reference
        //int a = 10;
        //Console.WriteLine($"Before Modify: a = {a}");
        //ModifyValue(a);
        //Console.WriteLine($"After Modify: a = {a}"); 

        //int b = 10;
        //Console.WriteLine($"Before ModifyRef: b = {b}");
        //ModifyRef(ref b);
        //Console.WriteLine($"After ModifyRef: b = {b}"); 
        //Console.WriteLine();
        #endregion

        #region Task 2 - Difference between Reference Type by Value and by Reference
        //Person person1 = new Person { Name = "OMar" };
        //Console.WriteLine($"Before ModifyPerson: {person1.Name}");
        //ModifyPerson(person1);
        //Console.WriteLine($"After ModifyPerson: {person1.Name}"); 

        //Person person2 = new Person { Name = "Essam" };
        //Console.WriteLine($"Before ModifyRef: {person2.Name}");
        //ModifyRefPerson(ref person2);
        //Console.WriteLine($"After ModifyRef: {person2.Name}"); 
        //Console.WriteLine();
        #endregion

        #region Task 3 - Function for Summation and Subtraction
        //Console.Write("Enter first number: ");
        //if (int.TryParse(Console.ReadLine(), out int a1))
        //{
        //    Console.Write("Enter second number: ");
        //    if (int.TryParse(Console.ReadLine(), out int b1))
        //    {
        //        Console.Write("Enter third number: ");
        //        if (int.TryParse(Console.ReadLine(), out int c1))
        //        {
        //            Console.Write("Enter fourth number: ");
        //            if (int.TryParse(Console.ReadLine(), out int d1))
        //            {
        //                var result = CalculateOperations(a1, b1, c1, d1);
        //                Console.WriteLine($"Sum of {a1} and {b1} = {result.sum}");
        //                Console.WriteLine($"Difference of {c1} and {d1} = {result.difference}");
        //            }
        //        }
        //    }
        //}
        //Console.WriteLine("Invalid input");
        //Console.WriteLine();
        #endregion

        #region Task 4 - Function to Calculate Sum of Digits
        //Console.Write("Enter a number: ");
        //if (int.TryParse(Console.ReadLine(), out int number))
        //{
        //    int result = SumOfDigits(number);
        //    Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
        //}
        //else Console.WriteLine("Invalid input");
        Console.WriteLine();
        #endregion

        #region Task 5 - Function to Check if Number is Prime
        //Console.Write("Enter a number: ");
        //if (int.TryParse(Console.ReadLine(), out int primeNum))
        //    Console.WriteLine($"Is {primeNum} prime? {IsPrime(primeNum)}");
        //else Console.WriteLine("Invalid input");
        //Console.WriteLine();
        #endregion

        #region Task 6 - Function to Find Min and Max in Array
        //Console.Write("Enter number of elements: ");
        //if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
        //{
        //    int[] arr = new int[size];
        //    Console.WriteLine("Enter array elements:");
        //    for (int i = 0; i < size; i++)
        //        if (!int.TryParse(Console.ReadLine(), out arr[i])) { Console.WriteLine("Invalid input"); return; }
        //    int min = 0, max = 0;
        //    MinMaxArray(arr, ref min, ref max);
        //    Console.WriteLine($"Minimum: {min}, Maximum: {max}");
        //}
        //else Console.WriteLine("Invalid input");
        //Console.WriteLine();
        #endregion

        #region Task 7 - Iterative Function to Calculate Factorial
        //Console.Write("Enter a number: ");
        //if (int.TryParse(Console.ReadLine(), out int factNum) && factNum >= 0)
        //    Console.WriteLine($"Factorial of {factNum} is: {Factorial(factNum)}");
        //else Console.WriteLine("Invalid input");
        //Console.WriteLine();
        #endregion

        #region Task 8 - Function to Modify a Character in a String
        //Console.Write("Enter a string: ");
        //string str = Console.ReadLine();
        //Console.Write("Enter position (0-based): ");
        //if (int.TryParse(Console.ReadLine(), out int pos) &&
        //    char.TryParse(Console.ReadLine(), out char newChar))
        //{
        //    string result = ChangeChar(str, pos, newChar);
        //    Console.WriteLine(result != "Invalid input" ? $"Modified string: {result}" : result);
        //}
        //else Console.WriteLine("Invalid input");
        #endregion
    }

    #region  Methods
    ////static void ModifyValue(int x) 
    ////{
    ////    x = 20; 
    ////}

    ////static void ModifyRef(ref int x)
    ////{
    ////    x = 20; 
    ////}

    //static void ModifyPerson(Person p) 
    //{
    //    p.Name = "Ali"; 
    //    p = new Person { Name = "Ahmed" }; 
    //}

    //static void ModifyRefPerson(ref Person p) 
    //{
    //    p.Name = "Essam"; 
    //    p = new Person { Name = "Mohamed" }; 
    //}

    //static (int sum, int difference) CalculateOperations(int a, int b, int c, int d)
    //{
    //    return (a + b, c - d);
    //}

    //static int SumOfDigits(int number)
    //{
    //    number = Math.Abs(number);
    //    int sum = 0;
    //    while (number > 0)
    //    {
    //        sum += number % 10;
    //        number /= 10;
    //    }
    //    return sum;
    //}

    //static bool IsPrime(int number)
    //{
    //    if (number < 2) return false;
    //    for (int i = 2; i <= Math.Sqrt(number); i++)
    //        if (number % i == 0) return false;
    //    return true;
    //}

    //static void MinMaxArray(int[] arr, ref int min, ref int max)
    //{
    //    min = arr[0];
    //    max = arr[0];
    //    foreach (int num in arr)
    //    {
    //        if (num < min) min = num;
    //        if (num > max) max = num;
    //    }
    //}

    //static long Factorial(int number)
    //{
    //    if (number < 0) return -1;
    //    long result = 1;
    //    for (int i = 2; i <= number; i++)
    //        result *= i;
    //    return result;
    //}

    //static string ChangeChar(string str, int position, char newChar)
    //{
    //    if (string.IsNullOrEmpty(str) || position < 0 || position >= str.Length)
    //        return "Invalid input";
    //    char[] chars = str.ToCharArray();
    //    chars[position] = newChar;
    //    return new string(chars);
    //}
    #endregion
}

