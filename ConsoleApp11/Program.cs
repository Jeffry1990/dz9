using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int grandmotherCount;  
            int grandmotherTime = 10;    
            int hourCount;         
            int minutesCount;      
            int timeWait;
            int minutesPerHour = 60;


            Console.Write("Введите кол-во старушек: ");
            grandmotherCount = Convert.ToInt32(Console.ReadLine());

            timeWait = grandmotherCount * grandmotherTime;
            hourCount = timeWait / minutesPerHour;
            minutesCount = timeWait % minutesPerHour;

            Console.WriteLine("Вы должны отстоять в очереди " + hourCount + " часа и " + minutesCount + " минут.");
        }
    }
}
