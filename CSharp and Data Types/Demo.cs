internal class Program
{
    private static void Main(string[] args)
    {
        //Creating an integer.
        int number;
        //Assigning a number to the variable.
        number = 500;
        //Overloading the variable.
        int number = 500;
        //Creating a const value.
        const int DAYS_IN_WEEK = 7;
        //Using defined enumerations as a data type.
        Language lan = Language.PL;
        switch (Language)
        {
            case Language.PL:/* Polish version */ break;
            case Language.DE:/* German Version */ break;
        }
    }
}

//Creating an enumeration.
enum Language {PL, EN, DE}