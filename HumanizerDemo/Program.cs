using Humanizer;

// From: https://github.com/Humanizr/Humanizer

Write("Sentence casing".Transform(To.LowerCase));
Write("Sentence casing".Transform(To.SentenceCase));
Write("Sentence casing".Transform(To.TitleCase));
Write("Sentence casing".Transform(To.UpperCase));

Write("Sentence casing".Humanize(LetterCasing.Title));

Write("Long text to truncate".Truncate(10, "---", Truncator.FixedLength));

DateTime.UtcNow.AddHours(-30).Humanize();
DateTime.UtcNow.AddHours(-2).Humanize();

DateTime.UtcNow.AddHours(30).Humanize();
DateTime.UtcNow.AddHours(2).Humanize();

DateTimeOffset.UtcNow.AddHours(1).Humanize();

static void Write(string text)
{
    Console.WriteLine(text);
}