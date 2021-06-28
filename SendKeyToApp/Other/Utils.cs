using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SendKeyToApp.Enums;
using SendKeyToApp.Objects;
using System.Diagnostics;
using static SendKeyToApp.Objects.WinApi;

namespace SendKeyToApp.Other
{
    public class Utils
    {
        public static String BitmapToBase64(Bitmap bitmap)
        {
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Icon);
            byte[] byteImage = ms.ToArray();
            return Convert.ToBase64String(byteImage);
        }
        public static Icon Base64ToBitmap(String base64)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                using (Bitmap bitmap = (Bitmap)Image.FromStream(ms, true))
                {
                    //bitmap.MakeTransparent(Color.White);
                    IntPtr icH = bitmap.GetHicon();
                    Icon ico = Icon.FromHandle(icH);
                    return ico;
                }
            }
        }
        public static Keys ChartToKeys(Char c)
        {
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                if (key.ToString() == c + "")
                {
                    return key;
                }
            }
            return Keys.None;
        }
        public static void SendKeyPressToApp(Process process, CombinedKey combinedKey, Method method)
        {
            IntPtr handle = new IntPtr(0);
            if (method.HandleMethod == HandleMethod.FindWindow.ToString())
            {
                handle = FindWindow(process.MainWindowHandle, process.MainWindowTitle);
            }
            else if (method.HandleMethod == HandleMethod.FindWindowEx.ToString())
            {
                handle = FindWindowEx(process.MainWindowHandle, new IntPtr(0), method.AppClass, null);
            }
            else if (method.HandleMethod == HandleMethod.ProcessHandle.ToString())
            {
                handle = process.MainWindowHandle;
            }
            if (handle != new IntPtr(0))
            {
                if (GetActiveWindowTitle() != process.MainWindowTitle)
                {
                    if (combinedKey.IsCtrl)
                    {
                        keybd_event(VK_CONTROL, 0, 0, 0);
                    }
                    if (combinedKey.IsShift)
                    {
                        keybd_event(VK_SHIFT, 0, 0, 0);
                    }
                    if (combinedKey.IsAlt)
                    {
                        keybd_event(VK_MENU, 0, 0, 0);
                    }
                    if (method.MessageMethod == MessageMethod.Post.ToString())
                    {
                        PostMessage(handle, WM_KEYDOWN, new IntPtr((int)combinedKey.Key), new IntPtr(0));
                    }
                    else if (method.MessageMethod == MessageMethod.Send.ToString())
                    {
                        SendMessage(handle, WM_KEYDOWN, new IntPtr((int)combinedKey.Key), new IntPtr(0));
                    }
                    if (combinedKey.IsCtrl)
                    {
                        keybd_event(VK_CONTROL, 0, 2, 0);
                    }
                    if (combinedKey.IsShift)
                    {
                        keybd_event(VK_SHIFT, 0, 2, 0);
                    }
                    if (combinedKey.IsAlt)
                    {
                        keybd_event(VK_MENU, 0, 2, 0);
                    }
                }
            }
        }
    }
}
