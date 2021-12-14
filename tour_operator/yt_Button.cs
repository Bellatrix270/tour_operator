using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace tour_operator
{
    public class yt_Button : Control
    {
        #region -- Свойства --

        [Description("Цвет обводки (границы) кнопки")]
        public Color BorderColor { get; set; } = Color.Tomato;

        [Description("Указывает, включено ли использование отдельного цвета обводки (границы) кнопки")]
        public bool BorderColorEnabled { get; set; } = false;

        [Description("Цвет обводки (границы) кнопки при наведении курсора")]
        public Color BorderColorOnHover { get; set; } = Color.Tomato;

        [Description("Указывает, включено ли использование отдельного цвета обводки (границы) кнопки при наведении курсора")]
        public bool BorderColorOnHoverEnabled { get; set; } = false;

        [Description("Дополнительный фоновый цвет кнопки используемый для создания градиента (При BackColorGradientEnabled = true)")]
        public Color BackColorAdditional { get; set; } = Color.Gray;

        [Description("Указывает, включен ли градинт кнопки")]
        public bool BackColorGradientEnabled { get; set; } = false;

        [Description("Определяет направление линейного градиента шапки")]
        public LinearGradientMode BackColorGradientMode { get; set; } = LinearGradientMode.Horizontal;

        private bool roundingEnable = false;
        [Description("Вкл/Выкл закругление объекта")]
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Refresh();
            }
        }

        private int roundingPercent = 100;
        [DisplayName("Rounding [%]")]
        [DefaultValue(100)]
        [Description("Указывает радиус закругления объекта в процентном соотношении")]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;

                    Refresh();
                }
            }
        }


        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        #endregion

        #region -- Переменные --

        private StringFormat SF = new StringFormat();

        private bool MouseEntered = false;

        #endregion

        public yt_Button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);

            Font = new Font("Verdana", 8.25F, FontStyle.Regular);

            Cursor = Cursors.Hand;

            BackColor = Color.Tomato;
            BorderColor = BackColor;
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Закругление
            float roundingValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
            {
                roundingValue = Height / 100F * roundingPercent;
            }
            GraphicsPath rectPath = RoundedRectangle(rect, roundingValue);


            Brush headerBrush = new SolidBrush(BackColor);
            if (BackColorGradientEnabled)
            {
                if (rect.Width > 0 && rect.Height > 0)
                    headerBrush = new LinearGradientBrush(rect, BackColor, BackColorAdditional, BackColorGradientMode);
            }

            Brush borderBrush = headerBrush;
            if (BorderColorEnabled)
            {
                borderBrush = new SolidBrush(BorderColor);

                if (MouseEntered && BorderColorOnHoverEnabled)
                    borderBrush = new SolidBrush(BorderColorOnHover);
            }

            // Основной прямоугольник (Фон)
            graph.DrawPath(new Pen(borderBrush), rectPath);
            graph.FillPath(headerBrush, rectPath);

            graph.SetClip(rectPath);

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

        }

        private GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            gp.CloseFigure();

            return gp;
        }

    }
}
