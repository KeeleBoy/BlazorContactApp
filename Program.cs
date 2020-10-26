using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using BlazorContactApp.Data;

namespace ContactSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            // here is an attempt to create a list of the contact object
<<<<<<< HEAD
            List<contactObj> contacts = new List<contactObj>();
=======
            List<Contact> contacts = new List<Contact>();
>>>>>>> a73b6d8cbc4c77c160041d2f278d3968848614f1

            // here i'm trying to add a contact so we can see if the list is working properly
            //contacts.Add(new Contact)();
            //contacts[0].FirstName = "Jeff";
            //contacts[0].LastName = "Guy";
            //contacts[0].PhoneNumber = "123-456-7890";
            //contacts[0].BirthDate = "0:01-01-1999";
            //contacts[0].Id = "1";

            foreach (contactObj contact in contacts)
                {
            Console.WriteLine(contact.ToString);
                }

            Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });




    }
}
