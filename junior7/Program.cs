int minutesPerPerson = 10;
int minutesInHour = 60;
int peopleCount;
int currentMinutes;
int currentHours;
int totalMinutes;

Console.Write("Введите количество людей в очереди: ");
peopleCount = Convert.ToInt32(Console.ReadLine());

totalMinutes = peopleCount * minutesPerPerson;
currentHours = totalMinutes / minutesInHour;
currentMinutes = totalMinutes % minutesInHour;

Console.WriteLine($"Вы должны отстоять в очереди {currentHours} час и {currentMinutes} минут");