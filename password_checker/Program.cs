using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
    int minLength = 8;
    string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string lowercase = "abcdefghijklmnopqrstuvwxyz";
    string digits = "1234567890";
    string specialChars = "!@£$%^&*()_-=+[{]};:'|<,.>/?`~";

    Console.Write("Enter Password: ");
    string password = Console.ReadLine();

    int score = 0;
    if (password.Length >= minLength) {
        score++;
    };

    if (Tools.Contains(password, uppercase)) {
        score++;
    };

    if (Tools.Contains(password, lowercase)) {
        score++;
    };

    if (Tools.Contains(password, uppercase)) {
        score++;
    };

    if (Tools.Contains(password, specialChars)) {
        score++;
    };

    Console.WriteLine(score);

    }
  }
}
