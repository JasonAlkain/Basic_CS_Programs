using System;

class Program
{
    public static void Main()
    {
        Person p1 = new Person(true);
        Person p2 = new Person(true);

        // Set up person 1
        Console.WriteLine("\n~~< Person 1 >~~");
        Console.WriteLine("Hourly Rate?");
        p1._Rate = int.Parse(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        p1._Wk_Hr = int.Parse(Console.ReadLine());

        // Set up person 2
        Console.WriteLine("\n~~< Person 2 >~~");
        Console.WriteLine("Hourly Rate?");
        p2._Rate = int.Parse(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        p2._Wk_Hr = int.Parse(Console.ReadLine());

        // Return the results from the calculations
        Console.WriteLine("\n");
        Console.WriteLine($"Annual salary of Person 1:\n{p1.Annual}");
        Console.WriteLine($"Annual salary of Person 2:\n{p2.Annual}");

        Console.WriteLine($"\nDoes Person 1 make more money than Person 2?\n{(p1.Annual > p2.Annual)}");
        Console.ReadLine();
    }
}

class Person
{
    // The rate of pay
    public int _Rate;
    // The weekly hours worked
    public int _Wk_Hr;
    // Used to calculate the number of pay days
    private bool isHolidays = true;
    // Number of work days in a year
    private int annualWorkDays = (isHolidays) ? 235 : 260;
    // Return the annual salary
    public int Annual => (_Rate * _Wk_Hr) * (annualWorkDays);

    public Person(bool includeHolidays)
    {
        isHolidays = includeHolidays;
    }
}