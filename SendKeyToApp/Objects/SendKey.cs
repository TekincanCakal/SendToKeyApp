using SendKeyToApp.Enums;
using SendKeyToApp.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using static SendKeyToApp.Objects.WinApi;

namespace SendKeyToApp
{
    public class SendKey
    {
        public SendKey()
        {
            SendKeys = new List<Keys>();
            //A-Z
            for (int i = 65; i <= 90; i++)
            {
                SendKeys.Add((Keys)i);
            }
            //0-9
            for (int i = 48; i <= 57; i++)
            {
                SendKeys.Add((Keys)i);
            }
            //NUMPAD0-NUMPAD9
            for (int i = 96; i <= 105; i++)
            {
                SendKeys.Add((Keys)i);
            }
            //F1-F12
            for (int i = 112; i <= 123; i++)
            {
                SendKeys.Add((Keys)i);
            }
            SendKeys.Add(Keys.ControlKey);
            SendKeys.Add(Keys.ShiftKey);
            SendKeys.Add(Keys.Alt);
            SendKeys.Add(Keys.Home);
            SendKeys.Add(Keys.Delete);
            SendKeys.Add(Keys.Insert);
            SendKeys.Add(Keys.Escape);
            SendKeys.Add(Keys.PageDown);
            SendKeys.Add(Keys.PageUp);
            SendKeys.Add(Keys.End);
            SendKeys.Add(Keys.Tab);
            SendKeys.Add(Keys.Up);
            SendKeys.Add(Keys.Down);
            SendKeys.Add(Keys.Right);
            SendKeys.Add(Keys.Left);
            SendKeys.Add(Keys.PrintScreen);
            SendKeys.Add(Keys.CapsLock);
        }
        public static List<Keys> SendKeys;

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
