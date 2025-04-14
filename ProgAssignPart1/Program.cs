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
        static void Main(string[] args)
        {
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
                            Console.WriteLine($"Playing greeting: {audio}");
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

           
            
        }
    }
}
