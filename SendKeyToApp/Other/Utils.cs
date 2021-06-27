using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

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
    }
}
