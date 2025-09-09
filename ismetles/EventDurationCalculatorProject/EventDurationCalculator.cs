namespace EventDurationCalculatorProject
{
    internal static class EventDurationCalculator
    {
        public static (DateOnly, int, int) CalculateEnd(DateOnly startDate, int startHour, int startMinute, int durationHours, int durationMinutes)
        {
            int osszesperc = startMinute + durationMinutes;
            int vegperc = osszesperc % 60;                  //1 ora 15 perc plussz
            int extraora = osszesperc / 60;

            int teljesido = startHour + durationHours + extraora;
            int vegora = teljesido % 24;
            int extranap = teljesido / 24;

            DateOnly veglegesadat=startDate.AddDays(extranap);

            return (veglegesadat, vegora, vegperc);
        }
    }
}
