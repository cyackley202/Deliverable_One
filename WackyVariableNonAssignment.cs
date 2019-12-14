using System;

namespace Delivarable_One_for_Grand_Circus_Draft_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Would you prefer a tropical, musical, or adventurous vacation?");
            string travelType;
            string vacationDestination;
            string vacationType = Console.ReadLine(); 
            if (vacationType == "tropical")
            {
                vacationDestination = "Mexico";
            }
            else if (vacationType == "musical")
            {
                vacationDestination = "New Orleans";
            }
            else
            {
                vacationDestination = "The Grand Canyon";
            }
        

            Console.WriteLine("Please enter, in numerical form, the number of people (including you!) who will be traveling.");
            int groupSize = int.Parse(Console.ReadLine());
            if (groupSize >= 6)
            {
                travelType = "Charter Flight";
            }
            else if (groupSize >= 3)
            {
                travelType = "Helicopter";
            }
            else
            {
                travelType = "a First Class flight";
            }

            string result = "Because you prefer a " + vacationType + " vacation, and you have " + groupSize + " person/people going on the trip, we recommend a " + travelType + " to " + vacationDestination + ".";

            Console.WriteLine(result);
        }
    }
}
