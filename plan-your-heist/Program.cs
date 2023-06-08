using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
/*
Phase One
The program should...

\1) Print the message "Plan Your Heist!".
\2) Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
\3) Prompt the user to enter a team member's name and save that name.
\4) Prompt the user to enter a team member's skill level and save that skill level with the name.
\5) Prompt the user to enter a team member's courage factor and save that courage factor with the name.
\6) Display the team member's information.
*/

public class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");
        Console.WriteLine("Would you like to add a team member? (y/n)");
        string response = Console.ReadLine();
        if (response == "y")
        {
            Console.WriteLine("Please input team member name: ");
            response = Console.ReadLine();
            string newMemberName = response;
            Console.WriteLine($"Please input a skill level for {newMemberName}.");
            response = Console.ReadLine();
            int newMemberSkillLevel = int.Parse(response);
            Console.WriteLine($"What is {newMemberName}'s courage factor?");
            response = Console.ReadLine();
            double newMemberCourageFactor = double.Parse(response);
            Console.WriteLine($"You are adding {newMemberName} as a team member, with a skill level of {newMemberSkillLevel} and a courage factor of {newMemberCourageFactor}. Is this correct? (y/n)");
            response = Console.ReadLine();
            if (response == "y")
            {
                TeamMember newMember = new TeamMember(newMemberName, newMemberSkillLevel, newMemberCourageFactor);
                Console.WriteLine($"{newMemberName} has been added to the team.");
            }
        }
        else if (response == "n") 
        {
            Console.WriteLine("Please rerun the program when you are ready to add a team member.");
        }
        else
        {
            Console.WriteLine("Something went wrong. Please run the program again to add a team member");
        }
    }
}

public class TeamMember
{
    public TeamMember(string name, int skill, double courage)
    {
        Name = name;
        SkillLevel = skill;
        CourageFactor = courage;
    }

    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public double CourageFactor { get; set; }

}