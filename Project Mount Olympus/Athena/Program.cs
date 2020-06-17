using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
                var userSelectedResponse = Convert.ToInt32(userTaskResponse);
                if (userSelectedResponse == 0)
                {
                    var file = string.Empty;
                    Console.Write("plese provide a file for review (please provide directory and extension)");
                    file = Console.ReadLine();
                    SearchForFileData(file);
                } else if (userSelectedResponse == 1)
                {
                    
                    var request = string.Empty;
                    FindContentOfInterest(request);

                }
                else if (userSelectedResponse == 3)
                {
                    
                    var item = string.Empty;
                    FindMyStuff(item);
                }
                else
                {
                    
                }
            }
            else
            {
                Console.WriteLine("Process request could not be executed correctly");
            }

        }

        /// <summary>
        /// search the computer for a file
        /// </summary>
        /// <param name="item"></param>
        private static void FindMyStuff(string item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provide a string and the system will search the web
        /// </summary>
        /// <param name="request"></param>
        private static void FindContentOfInterest(string request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// consider adding an ability to select an interested directories/file
        /// </summary>
        /// <param name="file"></param>
        private static void SearchForFileData(string file)
        {
            //TODO: Create a method that will write to the screen (hopefully reduce the amount of time console)
            var useDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!file.Contains(@"C:\"))
            {
                
                var temps = Directory.GetFiles(useDirectory);
                if (temps.Contains(file))
                {
                    
                }
                else
                {
                    Console.WriteLine("File not found do ");
                    Console.WriteLine("Y (Yes)");
                    Console.WriteLine("N (No)");
                    var userActionResponse = Console.ReadLine();

                    if (userActionResponse.ToUpperInvariant() == "Y" || userActionResponse =="Yes")
                    {
                        foreach (var temp in temps)
                        {
                            Console.WriteLine($"{temp.IndexOf(temp)} : {temp}");
                        }

                    }
                    else
                    {
                        
                        return;
                    }
                    
                }
                
                

                Console.ReadLine();
            }
            else
            {
                useDirectory = file;


            }
            //throw new NotImplementedException();
        }
    }
}
