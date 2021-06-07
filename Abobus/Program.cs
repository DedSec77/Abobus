using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Media;

namespace Abobus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string User = Environment.UserName;
            Console.WriteLine(File.ReadAllText("text.txt"));
            Console.Write("Choose:");
            string accept = Console.ReadLine();

            if (accept.ToLower() == "y")
            {
                Process.Start("https://i1.sndcdn.com/artworks-TOJJyHynzM0iRSuW-9URBDA-t500x500.jpg");
                for (int i = 0; i < 64; i++)
                {
                    Directory.CreateDirectory(@"C:\Users\" + User + @"\Desktop\ABOBUS" + Convert.ToString(i));
                }
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sus.wav");
                player.Play();
                MessageBox.Show("ABOBUS");
                for (int l = 0; l < 200000; l++) {};
                Process.Start("FakeBsod.exe");
            }

            else if (accept.ToLower() == "n")
            {
                Environment.Exit(0);
            }

            else { Environment.Exit(0); }
        }
    }
}
