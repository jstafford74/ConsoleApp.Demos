// See https://aka.ms/new-console-template for more information
Console.WriteLine("********** - String Manipulation - **********");

// Initialize with string literal
string s1 = "this is a string literal";
String s2 = " Also a string";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");

// Declare without initialization(possible null exception);
string s3;

// Nullable string;
string? s4 = null;
Console.WriteLine($"{nameof(s4)}: {s4}");

// Initialize as empty string;
string s5 = String.Empty;
string s6 = " ";
Console.WriteLine($"{nameof(s5)}: {s5}");
Console.WriteLine($"{nameof(s6)}: {s6}");

//Escape sequences and characters
string sentence = " She said, \"I am a C# programmer\" \r\n This is the next line";
Console.WriteLine($"{nameof(sentence)}: {sentence}");

//Verbatim string literal;
string oldPath = "C:\\Program Files\\Microsoft\\";
string newPath = @"C:\Program Files\Microsoft\";
Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");

// Use a const string to prevent modification to a string
const string path = @"C:\Program Files\Microsoft\";
Console.WriteLine($"{nameof(path)}: {path}");

// Raw string literals
string rawLiteral = """ - This is a literal string - She said, "I have your phone" """;
string rawLiteral1 = """
    - This is a literal string - She said, "I have your phone" 
    This is the next line
    And another one
    Path = "C:\Program Files\Microsoft\"
    """;
Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)}: {rawLiteral1}");

// Review concatenation and interpolation
s1 += s2;

string newString = $"{s1} {s2} more characters";
string newString1 = s1 + s2 + "more characters";
string newString2 = String.Format("Litera; string {0} {1}", s1, s2);
Console.WriteLine($"{nameof(newString)}: {newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");

// String manipulation methods and properties

// Null or empty checks
// find the length of a string
if (string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} is null or empty");
}
else
{
    Console.WriteLine($"Length of {nameof(s4)}: {s4.Length}");
}

if (!string.IsNullOrEmpty(s5))
{
    Console.WriteLine($"Length of {nameof(s5)}: {s5.Length}");
}
else
{
    Console.WriteLine($"{nameof(s5)} is null or empty");
}

Console.WriteLine($"Length of {nameof(s1)}: {s1.Length}");
Console.WriteLine($"Length of {nameof(s6)}: {s6.Length}");

// Substrings
string substring = s1.Substring(5, 5);
Console.WriteLine($"{nameof(substring)}: {substring}");
substring = s1.Substring(5);
Console.WriteLine($"{nameof(substring)}: {substring}");

//Splitting strings
var splitStrings = s2.Split('s');

for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine($"Split {i}: {splitStrings[i]}");
}

// Replace
string replacements = s1.Replace("s", "v");
string replacements2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacements)}: {replacements}");
Console.WriteLine($"{nameof(replacements2)}: {replacements2}");

// Convert to string
string salary = 1234567.ToString();
int value = 987654;
string valueString = value.ToString();
bool chosen = true;
string chosenString = chosen.ToString();

// Change formatting
Console.WriteLine($"{nameof(salary)}: {value:C}");
Console.WriteLine(nameof(salary) + " :" + value.ToString("C"));
