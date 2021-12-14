using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_operator
{
    public partial class FormWelcome : Form
    {
        string username;
        public FormWelcome()
        {
            InitializeComponent();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT UserName FROM Win32_ComputerSystem");
            ManagementObjectCollection collection = searcher.Get();
            username = (string)collection.Cast<ManagementBaseObject>().First()["UserName"];
            int index = username.IndexOf("\\");
            username = username.Remove(0, index + 1);
        }

        public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();

            // Верхний левый угол
            path.AddArc(arc, 180, 90);

            // Верхний правый угол
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Нижний правый угол
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Нижний левый угол
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private async void FormWelcome_Load(object sender, EventArgs e)
        {

            Random rnd = new Random();

            this.Region = new Region(
                RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height)
                    , 21
                )
            );

            ButtonBackground.Text += "\n";
            ButtonBackground.Text += "\n";
            ButtonBackground.Text += "\n";

            string[] welcome_str = new string[3];
            welcome_str[0] = "Добро пожаловать, " + username + "!";
            welcome_str[1] = "Рады видеть вас, " + username;
            welcome_str[2] = "Мы ждали вас, " + username;
            string welcome = welcome_str[rnd.Next(0, welcome_str.Length - 1)];

            for (int i = 0; i < welcome.Length; i++)
            {
                ButtonBackground.Text += welcome[i];

                labelShow.BackColor = ButtonBackground.BackColorAdditional;
                if (welcome[i] != ' ')
                    await Task.Delay(rnd.Next(75, 150));
            }

            labelShow.BackColor = ButtonBackground.BackColorAdditional;
            await Task.Delay(500);
            new FormLogin().Show();
            Hide();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            labelShow.ForeColor = Color.WhiteSmoke;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            labelShow.ForeColor = Color.LightGray;
        }
    }
}
