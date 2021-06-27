using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SendKeyToApp.Objects
{
    public class WinApi
    {
        public static UInt32 WM_KEYDOWN = 0x0100;
        public static UInt32 WM_KEYUP = 0x0101;
        public static UInt32 WM_CHAR = 0x102;
        public static UInt32 WM_SYSKEYDOWN = 0x104;
        public static UInt32 WM_SYSKEYUP = 0x105;

        public static byte VK_SHIFT = 0x10;
        public static byte VK_CONTROL = 0x11;
        public static byte VK_MENU = 0x12;

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(IntPtr Handle, string Caption);
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        public static string GetActiveWindowTitle()
        {
            StringBuilder Buff = new StringBuilder(256);
            IntPtr handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, 256) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner  
            public int Top;         // y position of upper-left corner  
            public int Right;       // x position of lower-right corner  
            public int Bottom;      // y position of lower-right corner  
        }
    }
}
