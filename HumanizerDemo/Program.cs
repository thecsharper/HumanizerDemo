using Humanizer;

Write("Sentence casing".Transform(To.LowerCase));
Write("Sentence casing".Transform(To.SentenceCase));
Write("Sentence casing".Transform(To.TitleCase));
Write("Sentence casing".Transform(To.UpperCase));

Write("Sentence casing".Humanize(LetterCasing.Title));

static void Write(string text)
{
    Console.WriteLine(text);
}