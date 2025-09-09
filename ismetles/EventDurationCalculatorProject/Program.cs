using EventDurationCalculatorProject;

Console.WriteLine("Esemény végének kiszámítása");

DateOnly date = new DateOnly(2025, 6, 23);
int hour = 20;
int minute = 45;
int durationHours = 6;
int durationMinutes = 30;

try
{
    var (endDate, endHour, endMinute) = EventDurationCalculator.CalculateEnd(date, hour, minute, durationHours, durationMinutes);
    Console.WriteLine($"Kezdés: {date} {hour:D2}:{minute:D2}");
    Console.WriteLine($"Hossz: {durationHours} óra {durationMinutes} perc");
    Console.WriteLine($"Befejezés: {endDate} {endHour:D2}:{endMinute:D2}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Hiba: {ex.Message}");
}
