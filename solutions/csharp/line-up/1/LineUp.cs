public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numberStr = number.ToString();
        string numeral;
        
        if (number == 1 || numberStr[^1] == '1' && numberStr[^2] != '1')
        {
            numeral = "st";
        }
        else if (number == 2 || numberStr[^1] == '2' && numberStr[^2] != '1')
        {
            numeral = "nd";
        }
        else if (number == 3 || numberStr[^1] == '3' && numberStr[^2] != '1')
        {
            numeral = "rd";
        }
        else
        {
            numeral = "th";
        }

        return $"{name}, you are the {number}{numeral} customer we serve today. Thank you!";
}
}