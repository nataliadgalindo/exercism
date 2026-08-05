using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder newIdentifier = new StringBuilder(identifier);
        newIdentifier.Replace(' ', '_');

        for (int i = 0; i < newIdentifier.Length; i++)
        {
            if (char.IsControl(newIdentifier[i]))
            {
                newIdentifier.Remove(i,1);
                newIdentifier.Insert(i,"CTRL");
                i+=3;
                continue;
            }

            if (newIdentifier[i] == '-')
            {
                newIdentifier.Remove(i,1);
                newIdentifier.Replace(newIdentifier[i],Char.ToUpper(newIdentifier[i]),i,1);
                i--;
                continue;
            }

            if (!Char.IsLetter(newIdentifier[i]) && newIdentifier[i] != '_')
            {
                newIdentifier.Remove(i,1);
                i--;    
                continue;
            }

            if (newIdentifier[i] >= 0x03B1 && newIdentifier[i] <= 0x03C9)
            {
                newIdentifier.Remove(i,1);
                i--;
                continue;    
            }
        }

    
        return newIdentifier.ToString();
    }
}
