using System.ComponentModel.Design;
using System.Diagnostics;

Console.WriteLine("Hej");
string userInput = Console.ReadLine().Trim().ToLower();

if (userInput == "hej")
{
    Console.WriteLine("Du är en hora");
}
else
{
    Console.WriteLine("Vill du öppna stackoverflow");
    string JaNej = Console.ReadLine().Trim().ToLower();
    if (JaNej == "ja")
    {
        string url = "https://youtube.com";
        Process.Start(new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });
    }
    else if (JaNej == "nej")
    {
        Console.WriteLine("Okej som du vill");
        Environment.Exit(0);
    }
    else
    {
        Process.Start("C:\\Users\\Makan\\AppData\\Roaming\\Spotify\\spotify.exe");
    }
}


