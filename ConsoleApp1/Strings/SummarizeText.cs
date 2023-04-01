namespace ConsoleApp1;

public static class SummarizeText
{
    public static string Summarize(string input, int maxLength = 20)
    {
        var sentence = input;
        if (sentence.Length < maxLength)
            return sentence;

        var words = sentence.Split(' ');
        var totalCharacters = 0;
        var summaryWords = new List<string>();

        foreach (var word in words)
        {
            // adds the word to the list
            summaryWords.Add(word);

            // add the length of the word to the totalCharacters ahead of check
            totalCharacters += word.Length + 1;
            // breaks if totalCharacters exceeds maxLength
            if (totalCharacters > maxLength)
                break;
        }

        // once code reaches here we return the array joined with ... appended
        return string.Join(" ", summaryWords) + "...";
    }
}