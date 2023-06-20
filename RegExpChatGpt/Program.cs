
namespace RegExpChatGpt;

public static class Program
{
    public static void Main()
    {
        TestValidateStringComplexity();
    }

    static void TestValidateStringComplexity()
    {
        // Test cases with different inputs and edge cases
        string[] testInputs = {
            // Existing test cases
            null,                 // Null input
            "",                   // Empty input
            "abc",                // Too short input (less than maxLength)
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",  // Missing lowercase
            "abcdefghijklmnopqrstuvwxyz",  // Missing uppercase
            "1234567890",         // Missing special character
            "!@#$%^&*()_+",       // Missing digit
            "Abcdef!1",           // Matching input length
            " Abcdef!1",          // Leading whitespace
            "Abcdef!1 ",          // Trailing whitespace
            " Abcdef!1 ",         // Leading and trailing whitespace
            "A bcdef!1",          // Whitespace in between
            "Abcdef !1",          // Whitespace before special character
            "Abcdef! 1",          // Whitespace after special character
            "A b c d e f! 1",     // Whitespace in various positions
            "A  b  c  d  e  f!1", // Multiple consecutive whitespaces

            // Additional test cases for tabulation symbols, newline symbols, and line break symbols
            "Abc\tdef!1",         // Tabulation symbol
            "Abc\ndef!1",         // Newline symbol
            "Abc\rdef!1",         // Carriage return symbol
            "Abc\n\rdef!1",       // Newline and carriage return symbols
            "A\nb\rc\td\ne\r\nf!1" // Mix of whitespace symbols
        };

        int maxLength = 10;

        foreach (string input in testInputs)
        {
            bool isValid = ValidateStringComplexity(input, maxLength);
            Console.WriteLine($"Input: \"{input}\" | Valid: {isValid}");
        }
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
