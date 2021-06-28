using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SendKeyToApp.Objects.WinApi;

namespace SendKeyToApp.Objects
{
    public class KeyListener
    {
        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private Dictionary<CombinedKey, KeyActions> watchingCombinedKeys;
        private LowLevelKeyboardProc _proc;
        private IntPtr _hookID = IntPtr.Zero;
        private bool isHooking = false;
        private bool isListening = false;
        private Keys listenedKey = Keys.None;

        public KeyListener()
        {
            _proc = HookCallback;
            watchingCombinedKeys = new Dictionary<CombinedKey, KeyActions>();
        }
        public async Task<Keys> ListenKey()
        {
            bool isCloseAgain = false;
            if (!isHooking)
            {
                SetHook();
                isCloseAgain = true;
            }
            isListening = true;
            await Unlisten();
            Keys temp = listenedKey;
            listenedKey = Keys.None;
            if (isCloseAgain)
            {
                UnHook();
            }
            return temp;
        }
        public async Task Unlisten()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    if(listenedKey != Keys.None)
                    {
                        break;
                    }
                }
            });
        }
        public void ListenCombinedKey(CombinedKey combinedKey, KeyActions keyActions)
        {
            if (!watchingCombinedKeys.ContainsKey(combinedKey))
            {
                watchingCombinedKeys.Add(combinedKey, keyActions);
                if (!isHooking)
                {
                    isHooking = true;
                    SetHook();
                }
            }
        }
        public void UnListenCombinedKey(CombinedKey combinedKey)
        {
            if (watchingCombinedKeys.ContainsKey(combinedKey))
            {
                watchingCombinedKeys.Remove(combinedKey);
                if (watchingCombinedKeys.Count == 0)
                {
                    isHooking = false;
                    UnHook();
                }
            }
        }
        private void SetHook()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    _hookID = SetWindowsHookEx(13, _proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }
        private void UnHook()
        {
            UnhookWindowsHookEx(_hookID);
        }
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                Keys pressedKey = (Keys)Marshal.ReadInt32(lParam);
                if (!isListening)
                {
                    foreach (var watchingCombinedKey in watchingCombinedKeys)
                    {
                        CombinedKey combinedKey = watchingCombinedKey.Key;
                        if (combinedKey.Key == pressedKey)
                        {
                            if (combinedKey.IsCtrl && !(GetAsyncKeyState(Keys.ControlKey) < 0))
                            {
                                continue;
                            }
                            if (!combinedKey.IsCtrl && (GetAsyncKeyState(Keys.ControlKey) < 0))
                            {
                                continue;
                            }
                            if (combinedKey.IsShift && !(GetAsyncKeyState(Keys.ShiftKey) < 0))
                            {

                                continue;
                            }
                            if (!combinedKey.IsShift && (GetAsyncKeyState(Keys.ShiftKey) < 0))
                            {

                                continue;
                            }
                            if (combinedKey.IsAlt && !(GetAsyncKeyState(Keys.Alt) < 0))
                            {
                                continue;
                            }
                            if (!combinedKey.IsAlt && (GetAsyncKeyState(Keys.Alt) < 0))
                            {
                                continue;
                            }
                            if (wParam == (IntPtr)WM_KEYDOWN)
                            {
                                if (watchingCombinedKey.Value.PressAction != null)
                                {
                                    watchingCombinedKey.Value.PressAction.Invoke();
                                }
                            }
                            else if (wParam == (IntPtr)WM_KEYUP)
                            {
                                if (watchingCombinedKey.Value.ReleaseAction != null)
                                {
                                    watchingCombinedKey.Value.ReleaseAction.Invoke();
                                }
                            }
                        }
                    }
                }
                else
                { 
                    listenedKey = pressedKey;
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
    }
    public class KeyActions
    {
        public Action PressAction { get; set; }
        public Action ReleaseAction { get; set; }

        public KeyActions(Action pressAction, Action releaseAction)
        {
            PressAction = pressAction;
            ReleaseAction = releaseAction;
        }
    }
    public class CombinedKey
    {
        public Keys Key { get; set; }
        public bool IsCtrl { get; set; }
        public bool IsShift { get; set; }
        public bool IsAlt { get; set; }

        public CombinedKey(Keys key, bool isCtrl = false, bool isShift = false, bool isAlt = false)
        {
            Key = key;
            IsCtrl = isCtrl;
            IsShift = isShift;
            IsAlt = isAlt;
        }

        public override string ToString()
        {
            String text = "";
            if (IsCtrl)
            {
                text += "CTRL+";
            }
            if (IsShift)
            {
                text += "SHIFT+";
            }
            if (IsAlt)
            {
                text += "ALT+";
            }
            text += Key.ToString();
            return text;
        }
        public override bool Equals(object obj)
        {
            return obj.ToString() == ToString();
        }
    }
}
