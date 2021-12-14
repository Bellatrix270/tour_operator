using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tour_operator.View;
using tour_operator.Presenter;

namespace tour_operator
{
    public partial class FormLogin : Form, ILoginOperator
    {
        PresenterLoginOperator presenter;
        bool _isExistOperator;

        public string EmailOperator { get => textBoxOLLogin.Text; set => textBoxOLLogin.Text = value; }
        public string PasswordOperator { get => textBoxOLPassword.Text; set => textBoxOLPassword.Text = value; }
        public bool IsExistOperator { get => _isExistOperator; set => _isExistOperator = value; }

        public FormLogin()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public new void Close()
        {
            Application.Exit();
        }

        private void yt_ButtonLogin_Click(object sender, EventArgs e)
        {
            presenter = new PresenterLoginOperator(this);
            presenter.isExistOperator();
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Region = new Region(
                RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height) , 21
                )
            );

            label1.SetCustomFont(Properties.Resources.Exo2_Medium, 27);
            label1.Location = new Point(Size.Width / 2 - label1.Size.Width / 2, 36);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxHeader.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void buttonCloseProg_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
