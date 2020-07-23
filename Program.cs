using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {

        public static void options()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("Options");
            Console.WriteLine("1. Add another Team Member");

            int optionInput = 0;
            optionInput = Int32.Parse(Console.ReadLine());
            if (optionInput == 1)
            {
                AddPlayer();
            }
        }

        public static void AddPlayer()
        {
            Console.WriteLine("What is your TeamMate's Name ");

            string NameInput = Console.ReadLine();

            Console.WriteLine("What is their skill level?");


            int SkillInput = 0;
            bool SkillBool = false;
            while (SkillBool == false)
            {

                try
                {
                    SkillInput = Int32.Parse(Console.ReadLine());
                    if (SkillInput > 0)
                    {
                        SkillBool = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than 0");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a whole number");
                }

            }

            Console.WriteLine("How much courage do they posess?");
            double CourageInput = 0;
            bool CourageBool = false;
            while (CourageBool == false)
            {

                try
                {
                    CourageInput = double.Parse(Console.ReadLine());
                    if (CourageInput > 0.0 && CourageInput < 2.0)
                    {
                        CourageBool = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter number as a decimal greater than 0 but less than 2");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number as a decimal");
                }

            }


            TeamMember userMember = new TeamMember()
            {
                Name = NameInput,
                Skill = SkillInput,
                Courage = CourageInput
            };

            
            allTheTeamMembers.Add(userMember);

            allTheTeamMembers.ForEach((member) => Console.WriteLine(member));

            Console.WriteLine($"Their name is {NameInput},");
            Console.WriteLine($"they have {SkillInput} levels of skill,");
            Console.WriteLine($"and posess {CourageInput} amount of courage!!!");



            options();
        }
        static void Main(string[] args)
        {
            List<TeamMember> allTheTeamMembers = new List<TeamMember>();

            Console.WriteLine("Plan your heist!");
            Console.WriteLine("-----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("What is your name ");

            string NameInput = Console.ReadLine();

            Console.WriteLine("What is your skill level?");


            int SkillInput = 0;
            bool SkillBool = false;
            while (SkillBool == false)
            {

                try
                {
                    SkillInput = Int32.Parse(Console.ReadLine());
                    if (SkillInput > 0)
                    {
                        SkillBool = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than 0");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a whole number");
                }

            }

            Console.WriteLine("How much courage do you posess?");
            double CourageInput = 0;
            bool CourageBool = false;
            while (CourageBool == false)
            {

                try
                {
                    CourageInput = double.Parse(Console.ReadLine());
                    if (CourageInput > 0.0 && CourageInput < 2.0)
                    {
                        CourageBool = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter number as a decimal greater than 0 but less than 2");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number as a decimal");
                }

            }







            TeamMember userMember = new TeamMember()
            {
                Name = NameInput,
                Skill = SkillInput,
                Courage = CourageInput
            };

            
            allTheTeamMembers.Add(userMember);

            Console.WriteLine($"Your name is {NameInput},");
            Console.WriteLine($"you have {SkillInput} levels of skill,");
            Console.WriteLine($"and posess {CourageInput} amount of courage!!!");



            options();









        }
    }
}

