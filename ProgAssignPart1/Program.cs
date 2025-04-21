using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;


namespace ProgAssignPart1
{
    public class Program
    {
        public static string GetBasicResponse(string question)
        {
            string changeStringToLowerCase = question.ToLower().TrimEnd('?');

            switch (changeStringToLowerCase)
            {
                case "how are you":

                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    string howAreYouResponse = "As your cyber security assistant bot, i am operating at optimal performance so that i can help you stay safe online";

                    return howAreYouResponse;

                case "what is your purpose":

                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    string purposeResponse = "My purpose is to help you with knowledge regarding cybersecurity so that you can protect yourself form cyber theats";

                    return purposeResponse;

                case "what can i ask about you":

                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.Write("you can ask me anything related to staying safe online! here are some key areas i can assist you with:\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("------------------------------------------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.Cyan;

                    string askAboutResponse = "You can ask me anything related to staying safe online. I can assist you with the follwing: \n" +
                        "Creating a strong and unique password \n " +
                        "Identifying and avoiding phishing attemps \n"
                        + "understanding multifactor authentification \n" +
                        "preventing malware infections \n" +
                        "Portecing of personal information \n" +
                        "safe browsing practice";

                    Console.Write(askAboutResponse);

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("");

                    Console.WriteLine("----------------------------------------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write("this is a general idea of what you can ask me");

                    Console.ResetColor();

                    return "";

                default:

                    Console.ForegroundColor = ConsoleColor.Cyan;

                    string defaultResponse = "sorry but i dont quite understand that could you rephrase";

                    Console.ResetColor();

                    return defaultResponse;
            }
        }

        static void Main(string[] args)
        {
            string asciiArt = @"    
  ____      _                                        _ _            
 / ___|   _| |__   ___ _ __ ___  ___  ___ _   _ _ __(_) |_ _   _    
| |  | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | '__| | __| | | |   
| |__| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | |  | | |_| |_| |   
 \____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|  |_|\__|\__, |   
   / \|___/   ____ _ _ __ ___ _ __   ___  ___ ___  | |__   |___/ |_ 
  / _ \ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __/ __| | '_ \ / _ \| __|
 / ___ \ V  V / (_| | | |  __/ | | |  __/\__ \__ \ | |_) | (_) | |_ 
/_/   \_\_/\_/ \__,_|_|  \___|_| |_|\___||___/___/ |_.__/ \___/ \__|
";

            Console.WriteLine(asciiArt);

            try
            {
                string audio = "ProgAssignPart1.greeting audio.wav";

                Assembly currentAssembly = Assembly.GetExecutingAssembly();

                using (Stream stream = currentAssembly.GetManifestResourceStream(audio))
                {
                    if (stream != null)
                    {
                        using (SoundPlayer player = new SoundPlayer(stream))
                        {
                            player.PlaySync();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: audio '{audio}' was not found");
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"error : {ex.Message}");
            }

            Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine("What is your name");

            Console.WriteLine("");

            var name = Console.ReadLine();

            Console.WriteLine("Greetings " + name + " how can i help you stay safer online " + "(enter exit to close program");

            string input;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(" ");

                input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("stay safe online, goodbye");

                    break;
                }
                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine(GetBasicResponse(input));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("please enter your cyber security question.");
                }
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("please enter your cyber security question");

            } while (true);
        }

    }
}
