using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Speech;
using System.Speech.Synthesis;


namespace Experimental
{
    class Program
    {
        public static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();

            Console.WriteLine("What is 2+1?");

            int Answer = Convert.ToInt32(Console.ReadLine());

            if (Answer == 4)
            {

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("The answer is not 4! Reconsider your brain...");
                SystemSounds.Hand.Play();
                synth.Speak("you suck");


                Console.WriteLine(" ");
                Console.Write(" recommendation");

                System.Threading.Thread.Sleep(500);
                Console.Write(" .");

                System.Threading.Thread.Sleep(500);
                Console.Write(" .");

                System.Threading.Thread.Sleep(500);
                Console.Write(" .");

                System.Threading.Thread.Sleep(100);
                synth.Speak("stop shopping at pep stores");

                System.Threading.Thread.Sleep(500);
                synth.Speak("yes you may try again");


                System.Threading.Thread.Sleep(2000);

/* Figure out how to loop back to 
 * user input when 4 is typed 
 * in as an answer so that
 * the user can try again*/
        {

        }
            }


            else if (Answer == 3)

            {
                Console.WriteLine(" It's 3 and you know it,  now get down and booogy wooogy wooogywooooooooogy !!!");

                synth.Speak("It's 3 and you know it, now get down and booogy wooogy wooogy wooogywooooooooogy !!!");

                Console.WriteLine("");
                Console.WriteLine(" LOL");
                synth.Speak("Lool");
                Console.WriteLine(" ");
                Console.WriteLine("   :)");
                Console.WriteLine(" ");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
    