using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Athena
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskListing = new List<string>()
            {
                "Search File and Provide Response",
                "Search and Find Data,",
                "Find Data"
            }; 
            Console.WriteLine("What do you wish to do?");
            Console.WriteLine($"{taskListing.IndexOf(taskListing[0])} : {taskListing[0]}");
            Console.WriteLine($"{taskListing.IndexOf(taskListing[1])} : {taskListing[1]}");
            Console.WriteLine($"{taskListing.IndexOf(taskListing[2])} : {taskListing[2]}");

            var userTaskResponse = Console.ReadLine();

            if  (!string.IsNullOrEmpty(userTaskResponse))
            {

            }
            else
            {
                Console.WriteLine("Process request could not be executed correctly");
            }

        }
    }
}
