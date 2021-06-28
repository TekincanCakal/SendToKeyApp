using System;
using System.Diagnostics;

namespace SendKeyToApp.Objects
{
    public class ShortcutKey
    {
        public String AppName { get; set; }
        public String MethodName { get; set; }

        public CombinedKey InputCombinedKey { get; set; }
        public CombinedKey OutputCombinedKey { get; set; }

        public bool IsEnabled { get; set; }

        public ShortcutKey(String appName, String methodName , CombinedKey inputCombinedKey, CombinedKey outputCombinedKey)
        {
            AppName = appName;
            MethodName = methodName;

            InputCombinedKey = inputCombinedKey;
            OutputCombinedKey = outputCombinedKey;

            IsEnabled = false;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(ShortcutKey))
            {
                return false;
            }
            ShortcutKey keyShortcut = (ShortcutKey)obj;
            if (!keyShortcut.InputCombinedKey.Equals(InputCombinedKey) || !keyShortcut.OutputCombinedKey.Equals(OutputCombinedKey))
            {
                return false;
            }
            return true;
        }
    }
}
