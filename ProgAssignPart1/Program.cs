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
                    return "As your cyber security assistant bot, i am operating at optimal performance so that i can help you stay safe online";
                case "what is your purpose":
                    return "My purpose is to help you with knowledge regarding cybersecurity so that you can protect yourself form cyber theats";
                case "what can i ask about you":
                    return "You can ask me anything related to staying safe online. I can assist you with the follwing: \n" +
                        "Creating a strong and unique password \n " +
                        "Identifying and avoiding phishing attemps \n"
                        + "understanding multifactor authentification \n" +
                        "preventing malware infections \n" +
                        "Portecing of personal information \n" +
                        "safe browsing practice\n"+
                        "this is a general idea of what you can ask me";
                default:
                    return "sorry but i dont quite understand that could you rephrase";
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
                    if(stream != null)
                    {
                        using(SoundPlayer player = new SoundPlayer(stream))
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
            catch(Exception ex)
            {
                Console.WriteLine($"error : {ex.Message}");


            }

            Console.WriteLine("");
            Console.WriteLine("");
           
            Console.WriteLine("What is your name");

            Console.WriteLine("");

            var name = Console.ReadLine();

            Console.WriteLine("Greetings " + name + " how can i help you stay safer online "+ "(enter exit to close program");

            string input;
            do
            {
                Console.WriteLine("> ");
                input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                {
                    Console.WriteLine("stay safe online, goodbye");
                    break;
                }
                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine(GetBasicResponse(input));


                }
                else
                {
                    Console.WriteLine("please enter your cyber security question.");
                }

            } while (true);








        }
       
    }
}
