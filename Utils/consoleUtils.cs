
/// <summary>
/// Writes a long story to the console, splitting it into multiple lines if necessary.
/// </summary>
/// <param name="story">The long story to write.</param>
public static void WriteLongStory(string story)
{
    var lines = SplitStory(story);

    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}

/// <summary>
/// Splits a story into multiple lines, ensuring that each line does not exceed 80 characters.
/// </summary>
/// <param name="story">The story to split.</param>
/// <returns>A list of lines containing the split story.</returns>
public static List<string> SplitStory(string story)
{
    var words = story.Split(' ');
    var lines = new List<string>();
    var currentLine = "";

    foreach (var word in words)
    {
        if ((currentLine + word).Length > 80)
        {
            lines.Add(currentLine.Trim());
            currentLine = "";
        }

        currentLine += word + " ";
    }

    if (!string.IsNullOrWhiteSpace(currentLine))
    {
        lines.Add(currentLine.Trim());
    }

    return lines;
}