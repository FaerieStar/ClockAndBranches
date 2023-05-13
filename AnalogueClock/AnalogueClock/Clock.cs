namespace AnalogueClock
{
    class Clock
    {
        public int calculate(int hour, int minute)
        {
            if(hour < 0 || hour > 12 || minute < 0 || minute > 60)
            {
                Console.WriteLine("Input invalid.");
                return -1;
            }
            int hourAngle = (minute / 60 * hour % 12) * 30;
            int minuteAngle = minute * 6;

            int angle = Math.Abs(hourAngle - minuteAngle);
            return angle > 180 ? (360 - angle) : angle;
        }
    }
    class Program
    {
        public static void Main()
        {
            Clock clock = new Clock();
            int hour, minute;

            Console.WriteLine("Please input hours: ");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input minutes: ");
            minute = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(clock.calculate(hour, minute) + "°");
        }
    }
}
