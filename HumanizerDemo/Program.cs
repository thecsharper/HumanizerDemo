using Humanizer;
using Humanizer.Localisation;

// From: https://github.com/Humanizr/Humanizer

Write("Sentence casing".Transform(To.LowerCase));
Write("Sentence casing".Transform(To.SentenceCase));
Write("Sentence casing".Transform(To.TitleCase));
Write("Sentence casing".Transform(To.UpperCase));

Write("Sentence casing".Humanize(LetterCasing.Title));

Write("Long text to truncate".Truncate(10, "---", Truncator.FixedLength));

Write(DateTime.UtcNow.AddHours(-30).Humanize());
Write(DateTime.UtcNow.AddHours(-2).Humanize());

Write(DateTime.UtcNow.AddHours(30).Humanize());
Write(DateTime.UtcNow.AddHours(2).Humanize());

Write(DateTimeOffset.UtcNow.AddHours(1).Humanize());

Write(TimeSpan.FromDays(486).Humanize(maxUnit: TimeUnit.Year, precision: 7));

Write("Man".Pluralize(inputIsKnownToBeSingular: false));

Write("some_titsize something".Camelize());

var size = (10.505).Kilobytes();

Write(size.ToString("KB"));
Write(size.Humanize("MB"));
Write(size.Humanize("b"));

Write(122.ToWords());

static void Write(string text)
{
    Console.WriteLine(text);
}