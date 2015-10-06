﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class Console
    {
        public void ChooseListType()
        {
            
        }

        public void ConfirmMessage(string prompt)
        {

        }

        public void Continue()
        {

        }

        public void ViewErrorMessage(string prompt)
        {

        }

        public void ViewMenu()
        {

        }














        /*
        private model.Member m;

        public Console()
        {
            m = new model.Member();
        }

        public void ViewMenu()
        {
            System.Console.WriteLine("MENU:");
            System.Console.WriteLine("1. Register new member");
            System.Console.WriteLine("2. List all members");
            System.Console.WriteLine("3. View specific member");
            System.Console.WriteLine("4. Edit member");
            System.Console.WriteLine("5. Delete member");
            System.Console.WriteLine("6. Register boat");
            System.Console.WriteLine("7. Edit boat");
            System.Console.WriteLine("8. Delete boat");
            System.Console.WriteLine("9. Exit");
        }

        public void Continue()
        {
            System.Console.WriteLine("Press any key to continue.");
            System.Console.ReadKey();
        }

        public void ConfirmMessage(string prompt)
        {
            System.Console.WriteLine(prompt);
        }

        public void ViewErrorMessage(string prompt)
        {
            System.Console.WriteLine(prompt);
        }

        public void RegisterName()
        {
            System.Console.Clear();
            System.Console.WriteLine("REGISTER MEMBER");
            System.Console.WriteLine("Name: ");
        }

        public void RegisterPersonalIdentityNumber()
        {
            System.Console.WriteLine("Personal identity number: ");
        }

        public void ChooseListType()
        {
            System.Console.WriteLine("Choose type of list:");
            System.Console.WriteLine("1. Compact list");
            System.Console.WriteLine("2. Verbose list");
        }

        public void ListMembers(List<model.Member> memberRegister, List<model.Boat> boatRegister, int listType)
        {
            if (listType == 1)
            {
                System.Console.WriteLine("COMPACT LIST");
                System.Console.WriteLine("------------------------");
                foreach (var member in memberRegister)
                {
                    System.Console.WriteLine("Member id: " + member.Id);
                    System.Console.WriteLine("Name: " + member.Name);
                    System.Console.WriteLine("Number of boats: " + boatRegister.Count);
                    System.Console.WriteLine("------------------------");
                }
            }
            else if (listType == 2)
            {
                System.Console.WriteLine("VERBOSE LIST");
                System.Console.WriteLine("------------------------");
                foreach (var member in memberRegister)
                {
                    System.Console.WriteLine("Member id: " + member.Id);
                    System.Console.WriteLine("Name: " + member.Name);
                    System.Console.WriteLine("Personal identity number: " + member.PersonalIdentityNumber);
                    System.Console.WriteLine("Number of boats: " + member.BoatRegister.Count);
                    System.Console.WriteLine("------------------------");
                    // }
                    if (member.BoatRegister.Count > 0)
                    {
                        foreach (var boat in member.BoatRegister)
                        {
                            System.Console.WriteLine("Boats length: " + boat.Length);
                            System.Console.WriteLine("Boattype: " + boat.BoatType);
                        }
                    }
                }
            }
            else
            {
                //fixa något
            }
        }


        public int AskForMember(string prompt)
        {
            System.Console.WriteLine("Choose member to " + prompt + " (memberID): ");
            return int.Parse(System.Console.ReadLine());
        }

        public void ViewSpecificMember(model.Member member)
        {
            System.Console.WriteLine("VIEW MEMBER");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine(member.Id);
            System.Console.WriteLine(member.Name);
            System.Console.WriteLine(member.PersonalIdentityNumber);
            System.Console.WriteLine("-------------------------");
        }

        public void IfEditName()
        {
            System.Console.WriteLine("Change name? (y/n)");
        }

        public void EditName()
        {
            System.Console.WriteLine("Name: ");
        }

        public void IfEditPN()
        {
            System.Console.WriteLine("Change personal identity number? (y/n)");
        }

        public void EditPN()
        {
            System.Console.WriteLine("Personal identity number: ");
        }

        public void DeleteMember()
        {
            System.Console.WriteLine("Are you sure you want to delete member? (y/n)");
        }
          
         * */
    }
}
