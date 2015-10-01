﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.view
{
    class Console
    {
        public void ViewMenu() 
        {
            System.Console.WriteLine("MENU:");
            System.Console.WriteLine("1. Register new member");
            System.Console.WriteLine("2. List all members");
            System.Console.WriteLine("3. View specifik member");
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
        public void ViewErrorMessage(string prompt)         //???
         {
             System.Console.WriteLine(prompt);
             System.Console.ReadKey();
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

        public void ListAllMembers(string line)
        {
            System.Console.WriteLine(line);            
        }

        public void AskForMember(string prompt)
        {
            System.Console.WriteLine("Choose member to " + prompt + " (memberID): ");
        }

        public void ViewSpecifikMember(string member)
        {
            System.Console.WriteLine(member);
        }

        
    }
}
