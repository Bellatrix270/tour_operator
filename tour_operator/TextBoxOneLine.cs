using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_operator
{
    public class TexBoxOneLine : Control
    {

        private TextBox tbInput = new TextBox();

        [Description("Цвет нижней линии")]
        public Color ColorLine { get; set; } = Color.White;

        [Description("Текст подсказка")]
        private string hintText;

        public string HintText
        {
            get { return hintText; }
            set 
            {
                hintText = value;
                if (tbInput.Text.Length == 0)
                {
                    tbInput.Text = value;
                    tbInput.ForeColor = ColorHintText;
                }
            }
        }
        
        [Description("Цвет текста подсказки")]
        public Color ColorHintText { get; set; } = Color.Gray;

        public override string Text { get => tbInput.Text; set => tbInput.Text = value; }

        public override Font Font { get => tbInput.Font; set => tbInput.Font = value; }

        [Description("Толщина нижней линии")]
        public float WidthLine { get; set; } = 1;

        [Description("Смещение по y относительно textbox для нижней линии")]
        public int OffsetYLine { get; set; } = 25;

        [Description("Проверка заполнения на наличие определённых символов")]
        public validateState ValidateState { get; set; } = validateState.None;

        public enum validateState
        {
            OnlyLetters,
            OnlyNumbers,
            None
        }

        public TexBoxOneLine()
        {
            Size = new Size(150, 40);
            Font = new Font("Arial", 11.25F, FontStyle.Regular);
            ForeColor = Color.White;
            BackColor = Color.FromArgb(30,30,30);

            AdjustTextBoxInput();
            Controls.Add(tbInput);
        }

        private void AdjustTextBoxInput()
        {
            tbInput = new TextBox();
            tbInput.Name = "InputBox";
            tbInput.BorderStyle = BorderStyle.None;
            tbInput.BackColor = BackColor;
            tbInput.ForeColor = ForeColor;
            tbInput.Font = Font;

            tbInput.TextChanged += TbInput_TextChanged;
            tbInput.GotFocus += TbInput_GotFocus;
            tbInput.LostFocus += TbInput_LostFocus;

            tbInput.Location = new Point(Location.X, Location.Y);
            tbInput.Size = new Size(Width, Height);
        }

        private void TbInput_LostFocus(object sender, EventArgs e)
        {
            if (tbInput.Text.Length == 0)
            {
                tbInput.Text = HintText;
                tbInput.ForeColor = ColorHintText;
            }
        }

        private void TbInput_GotFocus(object sender, EventArgs e)
        {
            if (tbInput.Text == HintText)
            {
                tbInput.Clear();
                tbInput.ForeColor = Color.White;
            }
        }

        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            if (tbInput.Text == HintText)
                return;

            if (ValidateState == validateState.OnlyLetters)
            {
                if (Regex.IsMatch(tbInput.Text, @"\d"))
                {
                    int index = tbInput.SelectionStart - 1;
                    tbInput.Text = tbInput.Text.Remove(index, 1);
                    tbInput.SelectionStart = index;
                }
            }
            else if (ValidateState == validateState.OnlyNumbers)
            {
                if (Regex.IsMatch(tbInput.Text, @"\D"))
                {
                    int index = tbInput.SelectionStart - 1;
                    tbInput.Text = tbInput.Text.Remove(index, 1);
                    tbInput.SelectionStart = index;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;

            graph.Clear(Parent.BackColor);

            Pen p = new Pen(ColorLine, WidthLine);
            Point p1 = new Point(tbInput.Location.X, tbInput.Location.Y + OffsetYLine);
            Point p2 = new Point(tbInput.Location.X + tbInput.Size.Width, tbInput.Location.Y + OffsetYLine);
            graph.DrawLine(p, p1, p2);

            graph.Dispose();
        }
    }
}
