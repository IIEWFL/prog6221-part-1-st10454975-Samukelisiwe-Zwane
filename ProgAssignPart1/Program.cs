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
        //created a method that takes in a string arg

        //stucture of code taken from stack overflow
        //https://stackoverflow.com/questions/444798/case-insensitive-containsstring
        //Pradeep Asanka
        //https://stackoverflow.com/users/6601199/pradeep-asanka
        public static string GetBasicResponse(string question)
        {
            // changed the string to lower and remove spection char to make the equating the string easier later
            string changeStringToLowerCase = question.ToLower().TrimEnd('?');

            Console.ForegroundColor = ConsoleColor.Cyan;
            string defaultResponse = "Sorry, I don't have a specific answer for that. Could you rephrase your cyber security question?";
            Console.ResetColor();

            // Check for keywords to provide more flexible responses
            if (changeStringToLowerCase.Contains("strong password") || changeStringToLowerCase.Contains("create password"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "To create a strong password, use a combination of uppercase and lowercase letters, numbers, and special characters. Aim for a password that is at least 12 characters long and avoid using personal information or common words.";
            }
            else if (changeStringToLowerCase.Contains("phishing") || changeStringToLowerCase.Contains("identify scam"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Be cautious of emails or messages that ask for personal information, have a sense of urgency, contain suspicious links or attachments, or have poor grammar and spelling. Always verify the sender's authenticity through official channels.";
            }
            else if (changeStringToLowerCase.Contains("multi-factor") || changeStringToLowerCase.Contains("mfa") || changeStringToLowerCase.Contains("two factor"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Multi-factor authentication (MFA) is a security system that requires more than one method of authentication from independent categories of credentials to verify the user's identity for a login or other transaction. This adds an extra layer of security beyond just a password.";
            }
            else if (changeStringToLowerCase.Contains("malware") || changeStringToLowerCase.Contains("virus") || changeStringToLowerCase.Contains("infection"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "To prevent malware infections, install and regularly update antivirus and anti-malware software, be cautious about downloading files or clicking links from unknown sources, keep your operating system and applications updated, and use a firewall.";
            }
            else if (changeStringToLowerCase.Contains("personal information") || changeStringToLowerCase.Contains("protect data") || changeStringToLowerCase.Contains("online safety"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Protect your personal information by being mindful of what you share online, using strong and unique passwords, enabling multi-factor authentication, keeping your software updated, using secure websites (HTTPS), and being cautious of phishing attempts.";
            }
            else if (changeStringToLowerCase.Contains("safe browsing") || changeStringToLowerCase.Contains("browse safely") || changeStringToLowerCase.Contains("secure internet"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Safe browsing practices include using secure websites (HTTPS), being cautious about clicking on unfamiliar links, avoiding suspicious downloads, keeping your browser updated, using privacy-focused browser extensions, and being aware of website permissions.";
            }
            else
            {
                //this code structer was taken from stack overflow
                //https://stackoverflow.com/questions/37569197/is-it-valid-to-return-from-inside-a-switch
                //author = msl
                //https://stackoverflow.com/users/3279825/msl?tab=profile
                switch (changeStringToLowerCase)
                {
                    case "how are you":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        return "As your cyber security assistant bot, I am operating at optimal performance so that I can help you stay safe online.";

                    case "what is your purpose":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        return "My purpose is to help you with knowledge regarding cybersecurity so that you can protect yourself from cyber threats.";

                    case "what can i ask about you":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("You can ask me anything related to staying safe online! Here are some key areas I can assist you with:\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("------------------------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string askAboutResponse = "You can ask me anything related to staying safe online. I can assist you with the following: \n" +
                                                    "⋆ Creating a strong and unique password \n " +
                                                    "⋆ Identifying and avoiding phishing attempts \n"
                                                    + "⋆ Understanding multi-factor authentication \n" +
                                                    "⋆ Preventing malware infections \n" +
                                                    "⋆ Protecting of personal information \n" +
                                                    "⋆ Safe browsing practices";
                        Console.Write(askAboutResponse);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("This is a general idea of what you can ask me.");
                        Console.ResetColor();
                        return "";

                    default:
                        return defaultResponse;
                }
            }
        }
        static void Main(string[] args)
        {
            // this art was created using ascir art
            //https://www.asciiart.eu/
            //Kenneth Knowlton 
            //https://www.kenknowlton.com/

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

            //this code structure was taken from a youtube video
            //https://www.youtube.com/watch?v=wAYN2BABnG0&ab_channel=MichaelHadley
            //micheal hadely
            //https://www.youtube.com/@mikewesthad
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

            Console.WriteLine("Greetings " + name + " how can i help you stay safer online " + "(enter exit to close program)");
            Console.WriteLine(name + " here is a list of some of the question i am able to answere \n" +
                "how are you, what can i ask about you and what is your purpose");




            string input;

            //the structure of code was taken from in class examples
            //mr. gologo

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
                // Console.ForegroundColor = ConsoleColor.Red;

                //Console.WriteLine("please enter your cyber security question");

            } while (true);
        }

    }
}
