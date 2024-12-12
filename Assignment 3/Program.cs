namespace Assignment_3
{

    #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.


    /* class Program
     {
         static void Main()
         {
             Console.Write("Enter a number: ");
             int number = int.Parse(Console.ReadLine());

             if (number % 3 == 0 && number % 4 == 0)
             {
                 Console.WriteLine("Yes");
             }
             else
             {
                 Console.WriteLine("No");
             }
         }
     }*/
}
#endregion


#region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

/*
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
*/
#endregion




#region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.


/*
class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int maxElement = Math.Max(num1, Math.Max(num2, num3));
        int minElement = Math.Min(num1, Math.Min(num2, num3));

        Console.WriteLine($"Max element = {maxElement}");
        Console.WriteLine($"Min element = {minElement}");
    }
}*/

#endregion




#region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
/*
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}*/

#endregion





#region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).


/*

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char character = char.Parse(Console.ReadLine().ToLower());

        if ("aeiou".Contains(character))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("consonant");
        }
    }
}*/

#endregion




//Alot questions ARE MISSING
#region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

/*

class Program
{
    static void Main()
    {
      
        Console.Write("Enter a number for the multiplication table: ");
        int tableNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Multiplication table for {tableNumber}:");
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{tableNumber} x {i} = {tableNumber * i}");
        }
    }
}

*/

#endregion






#region 9- Write a program that takes two integers then prints the power.

/*
class Program
{
    static void Main()
    {
     
        string[] inputs = Console.ReadLine().Split();
        int baseNumber = int.Parse(inputs[0]);
        int exponent = int.Parse(inputs[1]);

 
        int result = (int)Math.Pow(baseNumber, exponent);
        Console.WriteLine(result);
    }
}*/
// Write 4 Space Then 3
#endregion


#region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

/*

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter Marks of five subjects: ");
        string[] marksInput = Console.ReadLine().Split();

        int[] marks = Array.ConvertAll(marksInput, int.Parse);


        int totalMarks = 0;
        foreach (int mark in marks)
        {
            totalMarks += mark;
        }

        double averageMarks = totalMarks / 5.0;
        double percentage = (totalMarks / 500.0) * 100;

     
        Console.WriteLine($"Total marks = {totalMarks}");
        Console.WriteLine($"Average Marks = {averageMarks}");
        Console.WriteLine($"Percentage = {percentage}");
    }
} 
// Input: - Enter Marks of five subjects: 95 76 58 90 89
*/
#endregion





#region 11- Write a program to input the month number and print the number of days in that month.


/*
class Program
{
    static void Main()
    {
       
        Console.Write("Month Number: ");
        int monthNumber = int.Parse(Console.ReadLine());

     
        int daysInMonth;

        switch (monthNumber)
        {
            case 1:  // January
            case 3:  // March
            case 5:  // May
            case 7:  // July
            case 8:  // August
            case 10: // October
            case 12: // December
                daysInMonth = 31;
                break;
            case 4:  // April
            case 6:  // June
            case 9:  // September
            case 11: // November
                daysInMonth = 30;
                break;
            case 2:  // February
           
                Console.Write("Enter Year: ");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))  
                {
                    daysInMonth = 29;
                }
                else
                {
                    daysInMonth = 28;
                }
                break;
            default:
                Console.WriteLine("Invalid month number!");
                return;
        }

    
        Console.WriteLine($"Days in Month: {daysInMonth}");
    }
}
*/
#endregion



#region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

/*
class Program
{
    static void Main()
    {

        Console.Write("Enter x1, y1: ");
        string[] point1 = Console.ReadLine().Split();
        double x1 = double.Parse(point1[0]);
        double y1 = double.Parse(point1[1]);

        Console.Write("Enter x2, y2: ");
        string[] point2 = Console.ReadLine().Split();
        double x2 = double.Parse(point2[0]);
        double y2 = double.Parse(point2[1]);

        Console.Write("Enter x3, y3: ");
        string[] point3 = Console.ReadLine().Split();
        double x3 = double.Parse(point3[0]);
        double y3 = double.Parse(point3[1]);
        double determinant = (x2 - x1) * (y3 - y2) - (y2 - y1) * (x3 - x2);

        if (determinant == 0)
        {
            Console.WriteLine("The points lie on a single straight line.");
        }
        else
        {
            Console.WriteLine("The points do not lie on a single straight line.");
        }
    }
}

*/

#endregion



#region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
/*
class Program
{
    static void Main()
    {
   
        Console.Write("Enter the time taken to complete the task (in hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

    
        if (timeTaken >= 2 && timeTaken <= 3)
        {
            Console.WriteLine("The worker is highly efficient.");
        }
        else if (timeTaken > 3 && timeTaken <= 4)
        {
            Console.WriteLine("The worker needs to increase their speed.");
        }
        else if (timeTaken > 4 && timeTaken <= 5)
        {
            Console.WriteLine("The worker needs training to improve speed.");
        }
        else if (timeTaken > 5)
        {
            Console.WriteLine("The worker is required to leave the company.");
        }
        else
        {
            Console.WriteLine("Invalid input. Time taken should be 2 hours or more.");
        }
    }
}

*/
// 4 = The worker needs training to improve speed
#endregion



#region 21-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

/*
class Program
{
    static void Main()
    {
      
        int originalValue = 10;
        Console.WriteLine($"Original Value: {originalValue}");

   
        int copiedValue = originalValue;
        Console.WriteLine($"Copied Value: {copiedValue}");


        originalValue = 20;
        Console.WriteLine("\nAfter modifying the Original Value:");

   
        Console.WriteLine($"Original Value: {originalValue}");
        Console.WriteLine($"Copied Value: {copiedValue}");
    }
}
*/
// subsequently modify one of the variables, the other variable will remain unaffected because they are stored in separate memory locations.

#endregion

#region 22-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen int d; d = Convert.ToInt32(!(30 < 20));




/*
class Program
{
    class Person
    {
        public string Name { get; set; }
    }

    static void Main()
    {
      
        Person person1 = new Person { Name = "Ali" };
        Console.WriteLine($"person1 Name: {person1.Name}");


        Person person2 = person1;
        Console.WriteLine($"person2 Name: {person2.Name}");


        person1.Name = "Mohamed";
        Console.WriteLine("\nAfter modifying person1 Name:");

       
        Console.WriteLine($"person1 Name: {person1.Name}");
        Console.WriteLine($"person2 Name: {person2.Name}");
    }
}
*/
//When Ali is assigned to Mohamed, both variables point to the same memory location
//Changes made through one reference are reflected in all references pointing to the same object.
#endregion



#region 23-Which of the following statements is correct about the C#.NET code snippet given below?
//false+false = true
//Convert.ToInt32 method converts True = 1
//A value 1 will be assigned to d.

#endregion



#region 24-Which of the following is the correct output for the C# code given below? Console.WriteLine(13 / 2 + " " + 13 % 2); 




//13 / 2 evaluates to 6
//13 % 2 evaluates to 1
//6 (from 13 / 2) is concatenated with " " and 1 (from 13 % 2).
// D "6 1"

#endregion





#region 25-What will be the output of the C# code given below?



class Program
{
    static void Main()
    {
        int num = 1, z = 5;

        if (!(num <= 0))
            Console.WriteLine(++num + z++ + " " + ++z);
        else
            Console.WriteLine(--num + z-- + " " + --z);
    }
}
// 7 7
//The result of ++num + z++ is calculated as 2 + 5, resulting in 7
//
#endregion