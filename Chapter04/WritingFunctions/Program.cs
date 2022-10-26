using static System.Console;
// See https://aka.ms/new-console-template for more information

static string CardinalToOrdinal(int number)
{
  switch (number)
  {
    case 11: // special cases for 11th to 13th
    case 12:
    case 13:
      return $"{number}th";
    default:
      int lastDigit = number % 10;
      string suffix = lastDigit switch
      {
        1 => "st",
        2 => "nd",
        3 => "rd",
        _ => "th"
      };
      return $"{number}{suffix}";
  }
}

static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(term: i)}.");
    }
}

RunFibImperative();