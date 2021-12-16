using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using tour_operator.Properties;

namespace tour_operator
{
    public static class Extensions
    {
        public static void SetCustomFont <T> (this T control, byte[] fontResources, float emSize)
        {
            
            PrivateFontCollection myfont = new PrivateFontCollection();

            using (MemoryStream fontStream = new MemoryStream(fontResources))
            {
                var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontdata = new byte[fontStream.Length];
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                myfont.AddMemoryFont(data, (int)fontStream.Length);
                Marshal.FreeCoTaskMem(data);
            }
            
            switch (control)
            {
                case Label lb:
                    lb.Font = new Font(myfont.Families[0], emSize);
                    lb.UseCompatibleTextRendering = true;
                    break;

                case Button btn:
                    btn.Font = new Font(myfont.Families[0], emSize);
                    btn.UseCompatibleTextRendering = true;
                    break;

                case TexBoxOneLine tbOL:
                    tbOL.Font = new Font(myfont.Families[0], emSize, tbOL.Font.Style, tbOL.Font.Unit);
                    break;

                case TextBox tb:
                    tb.Font = new Font(myfont.Families[0], emSize);
                    break;
            }

        }

        public static string GetMD5(string value)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider my_pass = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(value);
            data = my_pass.ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }

        /// <summary>
        /// Will get the string value for a given enums value, this will
        /// only work if you assign the StringValue attribute to
        /// the items in your enum.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetStringValue(this Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }
    }
}