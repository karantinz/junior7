int minutesPerPerson = 10;
int minutesInHour = 60;
int peopleCount;
int currentMinutes;
int currentHours;

Console.Write("Введите количество людей в очереди: ");
peopleCount = Convert.ToInt32(Console.ReadLine());

currentMinutes = peopleCount * minutesPerPerson;
currentHours = currentMinutes / minutesInHour;
currentMinutes %= minutesInHour;

Console.WriteLine($"Вы должны отстоять в очереди {currentHours} час и {currentMinutes} минут");