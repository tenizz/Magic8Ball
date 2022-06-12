using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Magic8Ball());

            /*string[] myArray = new string[19];
            myArray[0] = "It is certain";
            myArray[1] = "It is decidedly so";
            myArray[2] = "Without a doubt";
            myArray[3] = "Yes — definitely";
            myArray[4] = "You may rely on it";
            myArray[5] = "As I see it, yes";
            myArray[6] = "Most likely";
            myArray[7] = "Outlook good";
            myArray[8] = "Signs point to yes";
            myArray[9] = "Yes";
            myArray[10] = "Reply hazy, try again";
            myArray[11] = "Ask again later";
            myArray[12] = "Better not tell you now";
            myArray[13] = "Cannot predict now";
            myArray[14] = "Concentrate and ask again";
            myArray[15] = "Don’t count on it";
            myArray[16] = "My reply is no";
            myArray[17] = "My sources say no";
            myArray[18] = "Outlook not so good";
            myArray[19] = "Very doubtful";*/

        }
    }
}
