using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using tour_operator.DomainModel;
using tour_operator.Model;

namespace tour_operator
{
    public partial class FormLogin : Form
    {
        TypeUsers CurrentUser;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void yt_ButtonLogin_Click(object sender, EventArgs e)
        {
            IUser User = ModelDB.GetLoginUser(CurrentUser, textBoxOLLogin.Text, "", textBoxOLPassword.Text);

            if (User.Id == -1)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Region = new Region(
                RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height), 21
                )
            );

            label1.SetCustomFont(Properties.Resources.Exo2_Medium, 27);
            label1.Location = new Point(Size.Width / 2 - label1.Size.Width / 2, 36);

            CurrentUser = TypeUsers.Operator;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxHeader.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void buttonCloseProg_Click(object sender, EventArgs e)
        {

        }
        private void labelClient_Click(object sender, EventArgs e)
        {
            CurrentUser = TypeUsers.Client;
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
    }
}
