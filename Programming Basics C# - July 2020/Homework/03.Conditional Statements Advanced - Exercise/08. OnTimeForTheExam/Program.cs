using System;

namespace _08._OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveTime = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            // Calculations
            int examHourInMinutes = (examHour * 60) + examMinutes;
            int arriveTimeInMinutes = (arriveTime * 60) + arriveMinutes;
            int minutes = 0;
            int hour = 0;

            if (examHourInMinutes >= arriveTimeInMinutes)
            {
                int timeLeft = examHourInMinutes - arriveTimeInMinutes;
                minutes = timeLeft % 60;
                hour = timeLeft / 60;

                if (timeLeft > 30)
                {
                    if (hour > 0)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else
            {
                int lateTime = arriveTimeInMinutes - examHourInMinutes;
                minutes = lateTime % 60;
                hour = lateTime / 60;
                if (hour > 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
