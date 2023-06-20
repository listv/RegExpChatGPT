# Regular Expression for string validation

## Application Description

The `RegExpChatGpt` application is a C# program that focuses on string complexity validation. It provides a method called `ValidateStringComplexity` which takes an input string and a maximum length as parameters. The method checks whether the input string meets certain complexity requirements. The requirements state that the string should contain at least one uppercase letter, one lowercase letter, one digit, and one special character from the set `!"#$%&'()*+,-./:;<=>?@[]^_`{|}~`. Additionally, the string should not contain any whitespace characters.

The program includes a test method called `TestValidateStringComplexity` which demonstrates the functionality of the `ValidateStringComplexity` method. It provides various test cases with different inputs and edge cases, including null input, empty input, inputs of different lengths, inputs with missing complexity elements, and inputs with whitespace characters. The test cases help ensure that the `ValidateStringComplexity` method behaves correctly and handles different scenarios appropriately.

## Regex Implementation Description

The ValidateStringComplexity method uses regular expressions to check for the complexity of the input string. Here's how the regex patterns are applied:

1. The method first checks if the input is null or exceeds the maximum length. If either condition is true, the method returns false.

2. Next, the method uses the regex pattern \s to check if the input contains any whitespace characters. If it does, the method returns false. This ensures that the input does not have any leading, trailing, or consecutive whitespace.

3. The method then uses the following regex patterns to check for specific complexity requirements:

   * [A-Z]: Checks if the input has at least one uppercase letter.
   * [a-z]: Checks if the input has at least one lowercase letter.
   * \d: Checks if the input has at least one digit (0-9).
   * [!\"#$%&'()*+,-./:;<=>?@[\]^_{|}~]`: Checks if the input has at least one special character.

4. Finally, if all the complexity requirements are met, the method returns true, indicating that the input string is considered complex.

The regex patterns allow for efficient and flexible validation of the input string's complexity. By leveraging regex, the method can easily check for specific character types and patterns without the need for complex manual string manipulation.

## Running the Application Locally

To run the `RegExpChatGpt` application locally, follow these steps:

1. Ensure you have the .NET6 SDK installed on your machine. You can download it from the official .NET website (https://dotnet.microsoft.com/download).

2. Clone from [github](https://github.com/listv/RegExpChatGPT.git) an existing project using your preferred Integrated Development Environment (IDE) that supports C# development (e.g., Visual Studio, Visual Studio Code with C# extensions).

4. Build the project to compile the code and resolve any dependencies.

5. Once the project is built successfully, you can run the `Main` method to execute the `TestValidateStringComplexity` method and see the test results in the console.

Note: Make sure to review and adjust the test cases or modify the code as needed to fit your specific requirements.
