using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAn
{
    class MusicPlayer : IDisposable
    {
        private string fileName;

        public MusicPlayer(string fileName)
        {
            this.fileName = fileName;
        }

        public bool Repeat { get; set; }

        public void Open(string File)
        {
            const string Format = @"open ""  {0} "" type MPEGVideo alias MediaFile";
            string Command = String.Format(Format, File);
            mciSendString(Command, null, 0, IntPtr.Zero);
        }
        public void Play()
        {
            string Command = "Play MediaFile";
            if (Repeat== false)
                Command += " REPEAT";
            mciSendString(Command, null, 0, IntPtr.Zero);
        }
        public void Stop()
        {
            string Command = "Stop MediaFile";
            if (Repeat)
                Command += "REPEAT";
            mciSendString(Command, null, 0, IntPtr.Zero);
        }
        public void End()
        {
            string Command = "End MediaFile";
            if (Repeat)
                Command += "REPEAT";
            mciSendString(Command, null, 0, IntPtr.Zero);
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturnString, int iReturnLength, IntPtr hwdCallBack);

        public void Dispose()
        {
            string Command = "close MediaFile";
            mciSendString(Command, null, 0, IntPtr.Zero);
        }
    }
}
