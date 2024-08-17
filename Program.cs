using System.Diagnostics;

string SearchYoutubeLink = "https://www.youtube.com/results?search_query=";
string SearchGoogleLink = "https://www.google.com/search?q=";

while (true)
{
    Console.WriteLine("Youtube/Google (Y/G):");
    string choice = Console.ReadLine();
    if (choice == "Y") Youtube();
    else if (choice == "G") Google();
}

void Youtube()
{
    Console.WriteLine("Write Youtube Request: ");
    FindYoutube(Console.ReadLine());

    
}

void Google()
{
    Console.WriteLine("Write Google Request: ");
    FindGoogle(Console.ReadLine());

    
}

void FindYoutube(string FindRequest)
{
    string FinalRequest = FindRequest.Replace(' ', '+');
    Console.WriteLine(SearchYoutubeLink + FinalRequest);
    ProcessStartInfo psi = new ProcessStartInfo
    {
        FileName = SearchYoutubeLink + FinalRequest,
        UseShellExecute = true,
    };
    Process process = Process.Start(psi);
}

void FindGoogle(string FindRequest)
    {
        string FinalRequest = FindRequest.Replace(' ', '+');

        Console.WriteLine(SearchGoogleLink + FinalRequest);

        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = SearchGoogleLink + FinalRequest,
            UseShellExecute = true,
        };

        Process process = Process.Start(psi);
    }





