using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnWindowsForm
{
    class MusicPlayer
    {
        [DllImport("winm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpsReturnString, int uReturnLength, int hwdCallBack);
        public void Open(string File)
        {
            string Format = @"open "" {0} "" type MPEGVideo alias MediaFile";
            string Command = string.Format(Format, File);
            mciSendString(Command, null, 0, 0);
        }
        public void Play()
        {
            string Command = "play MediaFile";
            mciSendString(Command, null, 0, 0);
        }
        public void Stop()
        {
            string Command = "stop MediaFile";
            mciSendString(Command, null, 0, 0);
        }
        public void End()
        {
            string Command = "end MediaFile";
            mciSendString(Command, null, 0, 0);
        }
    }
}
