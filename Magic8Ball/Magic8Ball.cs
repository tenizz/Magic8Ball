using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Magic8Ball : Form
    {
        public Magic8Ball()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myArray = { "It is certain", "It is decidedly so", "Without a doubt", "Yes — definitely", "You may rely on it", "As I see it, yes", "Most likely", "Outlook good", "Signs point to yes", "Yes", "Reply hazy, try again", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don’t count on it", "My reply is no", "My sources say no", "Outlook not so good", "Very doubtful"};

            Random rand = new Random();
            int a = rand.Next(0, 19);

            MessageBox.Show(myArray[a]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
