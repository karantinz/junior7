int minutesPerPerson = 10;
int minutesInHour = 60;
int peopleCount;
int minutes;
int hours;

Console.Write("Введите количество людей в очереди: ");
peopleCount = Convert.ToInt32(Console.ReadLine());

minutes = peopleCount * minutesPerPerson;
hours = minutes / minutesInHour;
minutes %= minutesInHour;

Console.WriteLine($"Вы должны отстоять в очереди {hours} час и {minutes} минут");