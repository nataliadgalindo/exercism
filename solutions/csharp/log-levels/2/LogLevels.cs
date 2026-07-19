static class LogLine
{
    public static string Message(string logLine)
    {
        string[] messages = logLine.Split(": ");

        return messages[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] messages = logLine.Split("]");
        string level = messages[0];

        return level[1..].ToLower();
    }

    public static string Reformat(string logLine)
    {
        string level = LogLevel(logLine);
        string message = Message(logLine);

        return $"{message} ({level})";
    }
}
