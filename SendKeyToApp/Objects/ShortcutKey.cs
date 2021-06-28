using System;

namespace SendKeyToApp.Objects
{
    public class ShortcutKey
    {
        public String AppName { get; set; }
        public Method Method { get; set; }

        public CombinedKey InputCombinedKey { get; set; }
        public CombinedKey OutputCombinedKey { get; set; }

        public bool IsEnabled { get; set; }

        public ShortcutKey(String appName, Method method, CombinedKey inputCombinedKey, CombinedKey outputCombinedKey)
        {
            AppName = appName;
            Method = method;

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
