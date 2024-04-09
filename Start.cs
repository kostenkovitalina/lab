using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть гілку для відкриття (Vitalina або Kristina):");
        string branchName = Console.ReadLine();

        RunGitBranch(branchName);

        if (branchName == "Vitalina")
        {
            string filePath = "https://github.com/kostenkovitalina/lab/blob/Vitalina/start-programs.cs";
            OpenFile(filePath);

        }
        else
        {
            Console.WriteLine("Невідома гілка");
        }
    }

    static void RunGitBranch(string branchName)
    {
        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = "git";
        psi.Arguments = "checkout " + branchName;
        Process.Start(psi).WaitForExit();
    }

    static void OpenFile(string filePath)
    {
        Process.Start("code", filePath);
    }
}
