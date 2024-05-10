//1


//using System;

//public static class Program
//{
//    static void Main()
//    {
//        int num1 = 2;
//        int num2 = 3;
//        int result = FindMultiply(num1, num2);
//        Console.WriteLine("The result is: " + result);
//    }

//    static int FindMultiply(int a, int b)
//    {
//        return a * b;
//    }
//}


//2


//using System;

//public static class Program
//{
//    static void Main()
//    {
//        int number = 5;
//        int square = FindSquare(number);
//        Console.WriteLine("Verilmis ededin kvadrati: " + square);
//    }

//    static int FindSquare(int num)
//    {
//        return num * num;
//    }
//}


//3


//using System;

//public static class Program
//{
//    static void Main()
//    {
//int[] array = { 1, 2, 3, 4, 5 };
//int sum = FindSum(array);
//Console.WriteLine("Arraydaki ededlerin cemi: " + sum);
//    }

//    static int FindSum(int[] arr)
//{
//    int cem = 0;
//    foreach (int num in arr)
//    {
//        cem += num;
//    }
//    return cem;


//}
//}


//4


//using System;

//public static class Program
//{

//    static void Main()
//    {
//        string name = "Ayhan";
//        string surname = "Qasimli";
//        string welcomeMessage = PrintWelcomeMessage(name, surname);
//        Console.WriteLine(welcomeMessage);
//    }

//    static string PrintWelcomeMessage(string name, string surname)
//    {
//        return "Welcome, " + name + " " + surname;
//    }
//}

//5

//using System;

//public static class Program
//{
//    static void Main()
//    {
//        string word = "Ayhan";
//        Console.WriteLine(ReverseWord(word));
//    }

//    static string ReverseWord(string word)
//    {
//        string reversedWord = string.Empty;
//       for (int i = word.Length - 1;i>=0;i-- )
//        {
//            reversedWord += word[i];

//        }
//        return reversedWord;
//    }
//}


//6



//class Program
//{
//    static void Main()
//    {
//        int parametr = 20;
//        Console.WriteLine(CheckNumber(parametr));
//    }

//    static string CheckNumber(int parametr)
//    {
//        if (parametr % 7 == 0)
//        {
//            return "Daxil edilen ədəd 7-e bolunur";
//        }
//        else
//        {
//            int yaxineded = (parametr / 7 + 1) * 7;
//            return "7-e bolunmur, en yaxın eded: " + yaxineded;
//        }
//    }
//}

//7.1

//class Program
//{
//    public static void Main()
//    {
//        int a = 6;
//        int b = 3;
//        int c = 9;

//        int perimeter1 = FindPerimetr(a, b, c);
//        Console.WriteLine("Üçbucağın perimetri: " + perimeter1);


//        int perimeter2 = FindPerimetr(a);
//        Console.WriteLine("Kvadratın perimetri: " + perimeter2);
//    }
//    public static int FindPerimetr(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public static int FindPerimetr(int a)
//    {
//        return 4 * a;
//    }
//}

//7.2
//class Program
//{
//    public static void Main()
//    {
//        int sum = FindPerimetr(7, 4, 9);
//        Console.WriteLine(sum);
//    }
//    public static int FindPerimetr(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public static int FindPerimetr(int a)
//    {
//        return 4 * a;
//    }
//}


//8
//using System;

//class Program
//{
//    static void Main()
//    {
//        string sentence = " Ayhan kod yazir .";
//        int bosluqsayi = CountSpaces(sentence);
//        Console.WriteLine("Cumledeki boşluq sayı: " + bosluqsayi);
//    }

//    static int CountSpaces(string sentence)
//    {
//        int bosluqsayi = 0;
//        foreach (var bosluq in sentence)
//        {
//            if (bosluq == ' ')
//            {
//                bosluqsayi++;
//            }
//        }
//        return bosluqsayi;
//    }
//}



