// The program determines if the day of the week is day off

using System;
class Program
{
    public int GetNumber(string VarName)
    {
        int res;
        string input;
        bool is_number = false;
        bool is_day_of_week = false;
        do
        {
            Console.WriteLine(String.Format("Enter number day of week: {0} = ", VarName));
            input = Console.ReadLine();
            
            is_number = int.TryParse(input, out res);
            if(is_number) {
                is_day_of_week = res >=1 && res <=7;
                if (!is_day_of_week) {
                    Console.WriteLine(String.Format("The {0} is not a day of week!", res));
                }
            }
            
        } while (!is_number || !is_day_of_week);

        return res;
    }
    
    public bool TestNumber_3c(int num) {
        
        if (num >= 100 && num < 1000) {
            return true;
        } else {
            return false;
        }
    }

    public List<int> ConvertNumberToArrayOfDigit(int num)
    {
        int Size = 3;
        List<int> DigitOfNumber = new List<int>();
        int Rest = 0;
        int LastNumber = num;
        int Base = 10;
        while(LastNumber != 0)
        {
            Rest = LastNumber % Base;
            DigitOfNumber.Add(Rest);
            LastNumber = (LastNumber - Rest) / Base;
        }
        return DigitOfNumber;
    }
    public void PrintNumberInDecimalNotation(int Number, List<int> NumberInDecimalNotation)
    {
        string Result = GetStringToPrintNumberInDecimalNotation(NumberInDecimalNotation);
        Console.WriteLine(String.Format("{0} = {1}", Number, Result));
    }

    public string GetStringToPrintNumberInDecimalNotation(List<int> NumberInDecimalNotation)
    {
        string Result = "";
        bool is_first_row = true;
        int MaxPower = 0;
        foreach(int digit in NumberInDecimalNotation) {
            
            if(is_first_row) {
                Result = Result + String.Format("{0}", digit, MaxPower);
                is_first_row = false;
                MaxPower = MaxPower + 1;
                continue;
            }
            string text_format = "{0}*10^{1} + ";
            if (MaxPower == 1) {
                text_format = "{0}*10 + ";
            }
            Result = String.Format(text_format, digit, MaxPower) + Result;
            MaxPower = MaxPower + 1;
        }
        return Result;
    }

    public static void Main(string[] args)
    {
        Program pr = new Program(); // Creating a class Object  
        Console.WriteLine("The program calculates the parity of a numbers.");

        string VarName_N = "N";
        int N = pr.GetNumber(VarName_N);
        bool is_day_off = N == 6 || N == 7;
        string text_msg_format = "The {0} is a day off!";
        if(!is_day_off) {
         text_msg_format = "The {0} is not a day off!";
        }
        Console.WriteLine(String.Format(text_msg_format, N));

        
    }
}