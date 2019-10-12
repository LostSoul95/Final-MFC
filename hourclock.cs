using System;


public class Hourclock{

    static String ConvertToMilitaryTime(string input_time)
    {

         // Initialize a variable for output time

         string outputTime;

         // Get the Hours on the given time input.   

         int hour = Convert.ToInt32(input_time.Substring(0,2));

         // Check if the input time is in AM or PM

         // The 9th character is always indicative of AM or PM   

         // AM check.

         if(input_time[8] == 'A')
         {
             if(hour == 12)
             {
                 hour = 0;

             }

            outputTime =  string.Format("{0:00}", hour) + input_time.Substring(2,6);

            return outputTime;
             
         }

         // PM check

         else if (input_time[8] == 'P')
         {
             if(hour ==  12)
             {
                 hour =  12;
             }
             else
             {
                 
                 hour = hour + 12;
             }

              outputTime =string.Format("{0:00}", hour) + input_time.Substring(2,6);

              return outputTime;
         }

         else
         {

             return "invalid input";
         }


    }

    public static void Main()
    {

        string inputTime = Console.ReadLine();

        string outputMillitaryTime = ConvertToMilitaryTime(inputTime);

    
        Console.Write(outputMillitaryTime);


    }

}
