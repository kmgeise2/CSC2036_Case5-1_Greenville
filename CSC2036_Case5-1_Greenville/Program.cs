// MindTap Case 5-1 Greenville Revenue 
// Modify the program so that the user must enter a number between 0 and 30,
// inclusive, for the number of contestants each year.
// If the user enters an incorrect number, the program prompts for a valid value.
//

using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
    static void Main()
    {
        const int ENTRANCE_FEE = 25;
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        string entryString;
        int numThisYear;
        int numLastYear;
        int revenue;
        Write("Enter number of contestants last year >> ");
        entryString = ReadLine();
        numLastYear = Convert.ToInt32(entryString);
        while (numLastYear < MIN_CONTESTANTS || numLastYear > MAX_CONTESTANTS)
        {
            WriteLine("Number must be between {0} and {1}", MIN_CONTESTANTS, MAX_CONTESTANTS);
            Write("Enter number of contestants last year >> ");
            entryString = ReadLine();
            numLastYear = Convert.ToInt32(entryString);
        }

        Write("Enter number of contestants this year >> ");
        entryString = ReadLine();
        numThisYear = Convert.ToInt32(entryString);
        while (numThisYear < MIN_CONTESTANTS || numThisYear > MAX_CONTESTANTS)
        {
            WriteLine("Number must be between {0} and {1}", MIN_CONTESTANTS, MAX_CONTESTANTS);
            Write("Enter number of contestants this year >> ");
            entryString = ReadLine();
            numThisYear = Convert.ToInt32(entryString);
        }
        revenue = numThisYear * ENTRANCE_FEE;
        WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",
           numLastYear, numThisYear);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        if (numThisYear > 2 * numLastYear)
            WriteLine("The competition is more than twice as big this year!");
        else
           if (numThisYear > numLastYear)
            WriteLine("The competition is bigger than ever!");
        else
              if (numThisYear < numLastYear)
            WriteLine("A tighter race this year! Come out and cast your vote!");
    }
}
