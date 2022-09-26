using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exlauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool tutus;
        int FareX, FareY;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C explorer fivem://connect/" + "185.250.241.156";
            process.StartInfo = startInfo;
            process.Start();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/88uRQsZVNT");
        }

        private void panel13_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
            
        }

        private void panel13_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {

                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult islem = MessageBox.Show("Do you want to exit the application?", "ExDF Launcher", MessageBoxButtons.YesNo);
            if (islem == DialogResult.Yes)
            {
                MessageBox.Show("See you later! (^o^) ", "Thank you for using ExDF Launcher", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
           
            MessageBox.Show("Im just kidding xd Have fun","I'm Sorry for this xD");
       
        }
    }
}
