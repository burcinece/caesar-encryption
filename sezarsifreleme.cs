using System;

class SezarCipher
{
    // Sezar şifreleme metodu
    static string Encrypt(string plainText, int shift)
    {
        string result = "";

        foreach (char character in plainText)
        {
            if (char.IsLetter(character))
            {
                char shiftedChar = (char)(character + shift);

                if (char.IsUpper(character))
                {
                    if (shiftedChar > 'Z')
                        shiftedChar = (char)(shiftedChar - 26);
                    else if (shiftedChar < 'A')
                        shiftedChar = (char)(shiftedChar + 26);
                }
                else
                {
                    if (shiftedChar > 'z')
                        shiftedChar = (char)(shiftedChar - 26);
                    else if (shiftedChar < 'a')
                        shiftedChar = (char)(shiftedChar + 26);
                }

                result += shiftedChar;
            }
            else
            {
                result += character;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("BURCİN ECE SAHİN");
        string input = Console.ReadLine();

        Console.WriteLine("+3");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(input, shift);
        Console.WriteLine("Şifrelenmiş metin: " + encryptedText);
    }
}