using SendKeyToApp.Enums;
using System;

namespace SendKeyToApp.Objects
{
    public class Method
    {
        public String MessageMethod { get; set; }
        public String HandleMethod { get; set; }
        public String AppClass { get; set; }
        public String Name { get; set; }

        public Method(MessageMethod messageMethod, HandleMethod handleMethod, String appClass, String name)
        {
            MessageMethod = messageMethod.ToString();
            HandleMethod = handleMethod.ToString();
            AppClass = appClass;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Method))
            {
                return false;
            }
            Method method = (Method)obj;
            if (method.AppClass != AppClass || method.MessageMethod != MessageMethod || method.HandleMethod != HandleMethod)
            {
                return false;
            }
            return true;
        }
    }
}
