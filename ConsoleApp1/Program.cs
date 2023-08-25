using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Threading.Channels;

int score = 68;

if (88 <= score && score <= 100)
{
    Console.WriteLine("Success - AA");
}
else if (81 <= score && score < 88)
{
    Console.WriteLine("Success - BA");
}

else if (74 <= score && score < 81)
{
    Console.WriteLine("Success -BB");
}

else if (67 <= score && score < 74)
{
    Console.WriteLine("Success - CB");
}
else if (60 <= score && score < 67)
{
    Console.WriteLine("Success - CC");
}
else if (0 <= score && score < 60)
{
    Console.WriteLine("Fail-FF");
}

else { Console.WriteLine("Invalide Score"); }





string command = "wait";

switch (command)
{
    case "start":
        Console.WriteLine("Game is stating");
        break;
    case "stop":
        Console.WriteLine("Game is stopped");
        break;
    case "wait":
        Console.WriteLine("Game Paused");
        break;

    default:
        Console.WriteLine("Command not Found");
        break;


}