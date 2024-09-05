using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string directory = args[0];
        Directory.SetCurrentDirectory(directory);

        string[] zips = Directory.GetFiles(directory, "*.zip");

        foreach (string zip in zips)
        {
            ZipFile.ExtractToDirectory(zip, Directory.GetCurrentDirectory()); 
        }

        Console.WriteLine("Files unzipped, would you like to delete the zip files? (Y/N)");
        string response = Console.ReadLine();
        response = response.ToUpper();

        if (response == "Y")
            foreach (string zip in zips)
            {
                File.Delete(zip);
            }

    }
}
