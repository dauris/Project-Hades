using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Athena
{
    class Program
    {
        static readonly List<string> ResponseOptions = new List<string>()
        {
            "Y (Yes)",
            "N (No)"
        };

        static readonly List<string> TaskListing = new List<string>()
        {
            "Search File and Provide Response",
            "Search and Find Data,",
            "Find Data"
        };

        static void Main(string[] args)
        {
            
             
            Console.WriteLine("What do you wish to do?");
            Console.WriteLine($"{TaskListing.IndexOf(TaskListing[0])} : {TaskListing[0]}");
            Console.WriteLine($"{TaskListing.IndexOf(TaskListing[1])} : {TaskListing[1]}");
            Console.WriteLine($"{TaskListing.IndexOf(TaskListing[2])} : {TaskListing[2]}");

            var userTaskResponse = Console.ReadLine();

            if  (!string.IsNullOrEmpty(userTaskResponse))
            {
                var userSelectedResponse = Convert.ToInt32(userTaskResponse);
                //TODO: create a help option to provide 

                //TODO: update and convert into a switch statement
                if (userSelectedResponse == 0)
                {
                    var file = string.Empty;
                    Console.Write("please provide a file for review (please provide directory, file or extension)");
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
                if (Array.Exists(temps, element => element.Contains(file)))
                {
                    foreach (var recordLine in File.ReadLines($@"{useDirectory}/checkRecord.txt", Encoding.UTF8))
                    {
                        ScreenWriter(recordLine, TaskListing,true, false,false);
                    }
                    
                }
                else
                {
                    ScreenWriter("Requested File not found, do wish to review alternative options", ResponseOptions, true, true);
                    var userActionResponse = Console.ReadLine();

                    if (userActionResponse != null && (userActionResponse.ToUpperInvariant() == "Y" || userActionResponse =="Yes"))
                    {
                        foreach (var temp in temps)
                        {
                            Console.WriteLine($"{temp.IndexOf(temp)} : {temp}");
                        }

                    }
                    else
                    {
                        ScreenWriter("Exiting function, thank you sir", ResponseOptions, true, false, true);
                    }
                    
                }
                
                

                
            }
            else
            {
                useDirectory = file;


            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">Message to share wit the user</param>
        /// <param name="responseMessages">User list response</param>
        /// <param name="newline">boolean: to display content with a new line</param>
        /// <param name="responses">boolean:  after message is written are responses need</param>
        /// <param name="closeApp">boolean: close application after message</param>
        private static void ScreenWriter(string message, List<string> responseMessages, bool newline = true, bool responses = false, bool closeApp = false)
        {
            if (newline)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }

            if (closeApp)
            {
                Console.ReadKey();
                return;
            }
            if (!responses) return;
            foreach (var responseMessage in responseMessages)
            {
                Console.WriteLine(responseMessage);
            }
        }
    }
}
