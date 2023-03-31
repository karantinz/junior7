int minutesPerPerson = 10;
int minutesInHour = 60;
int peopleCount;
int minutes;
int hours;
int totalMinutes;

Console.Write("Введите количество людей в очереди: ");
peopleCount = Convert.ToInt32(Console.ReadLine());

totalMinutes = peopleCount * minutesPerPerson;
hours = totalMinutes / minutesInHour;
minutes = totalMinutes % minutesInHour;

Console.WriteLine($"Вы должны отстоять в очереди {hours} час и {minutes} минут");