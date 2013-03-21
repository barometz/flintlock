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

        [StructLayout(LayoutKind.Explicit)]
        public struct INPUT64
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(8)]
            public MOUSEINPUT mi;
            [FieldOffset(8)]
            public KEYBDINPUT ki;
            [FieldOffset(8)]
            public HARDWAREINPUT hi;
        }

        [DllImport("user32.dll")]
        public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT64[] pInputs, int cbSize);

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
            KEYBDINPUT ki = new KEYBDINPUT()
            {
                time = 0,
                wScan = 0,
                dwExtraInfo = (IntPtr)0,
                wVk = keycode,
                dwFlags = 0
            };
            if (IntPtr.Size > 4)
            {
                // 64-bit environment
                INPUT64 ip = new INPUT64();
                ip.type = 1; // Indicates a keyboard event
                ip.ki = ki;
                SendInput(1, new INPUT64[] { ip }, Marshal.SizeOf(ip));
                ip.ki.dwFlags = 2;
                SendInput(1, new INPUT64[] { ip }, Marshal.SizeOf(ip));
            }
            else
            {
                // 32-bit environment
                INPUT ip = new INPUT();
                ip.type = 1; // Indicates a keyboard event
                ip.ki = ki;
                // Press..
                SendInput(1, new INPUT[] { ip }, Marshal.SizeOf(ip));
                ip.ki.dwFlags = 2;
                // And let go.
                SendInput(1, new INPUT[] { ip }, Marshal.SizeOf(ip));
            }
        }

    }
}
