using System;
using System.Runtime.InteropServices;

namespace flintlock
{
    /// <summary>
    /// Wrapper for media control functionality.
    /// </summary>
    static class MediaControl
    {
        /* For information on the data and datatypes used here, see
         * http://msdn.microsoft.com/en-us/library/windows/desktop/ms646271(v=vs.85).aspx and
         * http://msdn.microsoft.com/en-us/library/windows/desktop/dd375731(v=vs.85).aspx
         */

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KEYBDINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            HARDWAREINPUT hi;
        }

        [DllImport("user32.dll")]
        public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        /// <summary>
        /// Send a "Play/Pause" keyboard event.
        /// </summary>
        public static void PlayPause()
        {
            SendKey(0xB3);
        }

        /// <summary>
        /// Send a "Next track" keyboard event.
        /// </summary>
        public static void Next()
        {
            SendKey(0xB0);
        }

        /// <summary>
        /// Send a "Previous track" keyboard event.
        /// </summary>
        public static void Prev()
        {
            SendKey(0xB1);
        }

        static void SendKey(short keycode)
        {
            INPUT ip = new INPUT();
            ip.type = 1; // Indicates a keyboard event
            ip.ki.time = 0;
            ip.ki.wScan = 0;
            ip.ki.dwExtraInfo = (IntPtr)0;

            ip.ki.wVk = keycode;
            ip.ki.dwFlags = 0;
            INPUT[] ips = { ip };
            // Press the key...
            SendInput(1, ips, Marshal.SizeOf(ip));

            ip.ki.dwFlags = 2;
            // structs are passed by value, so pass it again
            ips[0] = ip;
            // And let go.
            SendInput(1, ips, Marshal.SizeOf(ip));
        }

    }
}
