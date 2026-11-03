// OOP - Week 6 Homework: Weekly temperatures

double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];

// 1. Average
double avg = Average(week);
Console.WriteLine($"Average temperature: {avg:F1}");

// 2. Hottest day
int hottest = 0;
for (int i = 1; i < week.Length; i++)
{
    if (week[i] > week[hottest])
        hottest = i;
}
Console.WriteLine($"Hottest day: Day {hottest + 1} ({week[hottest]:F1})");

// 3. Days warmer than the average
Console.WriteLine("Days above average:");
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > avg)
        Console.WriteLine($"  Day {i + 1}: {week[i]:F1}");
}

// Bonus: last three days using a range
double[] lastThree = week[^3..];
Console.WriteLine($"Last three days: {string.Join(", ", lastThree)}");

static double Average(double[] t)
{
    double sum = 0;
    foreach (double v in t)
        sum += v;
    return sum / t.Length;
}