using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAn
{
    public partial class Form1 : Form
    {
        private MusicPlayer Music;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = " Mp3 Files | *.mp3";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                if( ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Music = new MusicPlayer(ofd.FileName);
                    Music.Repeat = true;  
                }    
            }    
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //    ofd.Filter = " MP3 Files | *.mp3";
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        Music.Open(ofd.FileName);
            //    }
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hello
            if (Music != null)
                Music.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //hello 
            if (Music != null)
                Music.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Music != null)
                Music.End();
        }
    }
}
