
namespace RegExpChatGpt;

public static class Program
{
    public static void Main(string[] args)
    {
        
    }


    static bool ValidateStringComplexity(string? input, int maxLength)
    {
        if (input == null || input.Length > maxLength)
            return false;

        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasDigit = false;
        bool hasSpecialChar = false;

        foreach (char c in input)
        {
            if (char.IsUpper(c))
                hasUppercase = true;
            else if (char.IsLower(c))
                hasLowercase = true;
            else if (char.IsDigit(c))
                hasDigit = true;
            else if ("!\"#$%&'()*+,-./:;<=>?@[]^_`{|}~".Contains(c))
                hasSpecialChar = true;

            if (char.IsWhiteSpace(c))
                return false;
        }

        return hasUppercase && hasLowercase && hasDigit && hasSpecialChar;
    }
}
