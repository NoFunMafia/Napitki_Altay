using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Napitki_Altay2.DesignComponents
{
    public partial class CustomForm : Component
    {
        // Получение доступа к форме приложения
        public Form Form { get;set;}
        private fStyle formStyle = fStyle.None;
        public fStyle FormStyle
        {
            get => formStyle;
            set
            {
                formStyle = value;
                Sign();
            }
        }
        public enum fStyle 
        {
            None = 0,
        }
        // Высота верхнего "бордюра" рабочего окна
        private int HeaderHeight = 25;
        // Цвет верхнего "бордюра" рабочего окна
        private Color HeaderColor = Color.RoyalBlue;
        // Мышка нажата?
        bool MouseIsPressed = false;
        // Координаты курсора во время клика
        Point CursorClickPosition;
        // Позиция формы во время клика
        Point StartMovePosition;
        // Кнопка закрытия окна приложения
        Rectangle rectangleCloseButton = new Rectangle();
        // Кнопка сворачивания окна приложения
        Rectangle rectangleCollapseButton = new Rectangle();
        // Кнопка разворачивания окна приложения
        Rectangle rectangleStandartButton = new Rectangle();
        // Кисть
        Pen penW = new Pen(Color.White)
        {
            Width = 1.6F
        };
        // Проверка наводки курсора на кнопку закрытия
        bool buttonCloseCursor = false;
        // Проверка наводки курсора на кнопку разворачивания
        bool buttonStandartCursor = false;
        // Проверка наводки курсора на кнопку сворачивания
        bool buttonCollapseCursor = false;
        public CustomForm()
        {
            InitializeComponent();
        }
        public CustomForm(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        private void Sign()
        {
            if(Form != null)
            {
                Form.Load += formLoad;
            }
        }
        // Событие загрузки формы
        private void formLoad(object sender, EventArgs e)
        {
            Apply();
        }
        private void Apply()
        {
            Form.FormBorderStyle = FormBorderStyle.None;
            OffsetControls();
            Form.Paint += Form_Paint;
            Form.MouseDown += Form_MouseDown;
            Form.MouseUp += Form_MouseUp;
            Form.MouseMove += Form_MouseMove;
            Form.MouseLeave += Form_MouseLeave;
        }
        private void Form_MouseLeave(object sender, EventArgs e)
        {
            buttonCloseCursor = false;
            buttonCollapseCursor = false;
            buttonStandartCursor = false;
            Form.Invalidate();
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsPressed)
            {
                Size FormOffSet = new Size(Point.Subtract
                    (Cursor.Position, new Size(CursorClickPosition)));
                Form.Location = Point.Add(StartMovePosition, 
                    FormOffSet);
            }
            else
            {
                if (rectangleCloseButton.Contains(e.Location))
                {
                    if(buttonCloseCursor == false)
                    {
                        buttonCloseCursor = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (buttonCloseCursor == true)
                    {
                        buttonCloseCursor = false;
                        Form.Invalidate();
                    }
                }
                if (rectangleStandartButton.Contains(e.Location))
                {
                    if (buttonStandartCursor == false)
                    {
                        buttonStandartCursor = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (buttonStandartCursor == true)
                    {
                        buttonStandartCursor = false;
                        Form.Invalidate();
                    }
                }
                if (rectangleCollapseButton.Contains(e.Location))
                {
                    if (buttonCollapseCursor == false)
                    {
                        buttonCollapseCursor = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (buttonCollapseCursor == true)
                    {
                        buttonCollapseCursor = false;
                        Form.Invalidate();
                    }
                }
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsPressed = false;
            if(e.Button == MouseButtons.Left)
            {
                if (rectangleCloseButton.Contains(e.Location))
                {
                    Application.Exit();
                }
                if (rectangleStandartButton.Contains(e.Location))
                {
                    if(Form.WindowState == FormWindowState.Normal)
                    {
                        Form.WindowState = FormWindowState.Maximized;
                    }
                    else
                        Form.WindowState = FormWindowState.Normal;
                }
                if (rectangleCollapseButton.Contains(e.Location))
                {
                    Form.WindowState = FormWindowState.Minimized;
                }
            }
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= HeaderHeight
                && !rectangleStandartButton.Contains(e.Location)
                && !rectangleCollapseButton.Contains(e.Location)
                && !rectangleCloseButton.Contains(e.Location))
            {
                MouseIsPressed = true;
                CursorClickPosition = Cursor.Position;
                StartMovePosition = Form.Location;
            }
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }
        // Метод рисовки стиля DrawStyle
        private void DrawStyle(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            // Рисовка "бордюра" окна
            Rectangle rectangleHeader = new Rectangle(0, 0, 
                Form.Width - 1, HeaderHeight);
            // Рисовка обводки окна
            Rectangle rectangleBorder = new Rectangle(0, 0, 
                Form.Width - 1, Form.Height - 1);
            // Рисовка кнопки закрытия окна
            rectangleCloseButton = new Rectangle
                (rectangleHeader.Width - rectangleHeader.Height - 1, 
                rectangleHeader.Y + 1, rectangleHeader.Height, 
                rectangleHeader.Height - 1);
            // Рисовка кнопки разворачивания окна
            rectangleStandartButton = new Rectangle
                (rectangleHeader.Width  - rectangleHeader.Height - 25,
                rectangleHeader.Y + 1, rectangleHeader.Height,
                rectangleHeader.Height - 1);
            // Рисовка кнопки сворачивания окна
            rectangleCollapseButton = new Rectangle
                (rectangleHeader.Width - rectangleHeader.Height - 49,
                rectangleHeader.Y + 1, rectangleHeader.Height,
                rectangleHeader.Height - 1);
            // Крестик на кнопку закрытия
            Rectangle rectangleCross = new Rectangle
                (rectangleCloseButton.X + 
                rectangleCloseButton.Width / 2 - 4,
                rectangleCloseButton.Height / 2 - 4, 10, 10);
            // Квадрат на кнопку разворачивания
            Rectangle rectangleCube = new Rectangle
                (rectangleStandartButton.X +
                rectangleStandartButton.Width / 2 - 4,
                rectangleStandartButton.Height / 2 - 4, 10, 10);
            // Линия на кнопку сворачивания
            Rectangle rectangleStick = new Rectangle
                (rectangleCollapseButton.X + 
                rectangleCollapseButton.Width / 2 - 4,
                rectangleCollapseButton.Height / 2 - 4, 10, 10);
            // Верхняя "бровь" окна
            graphics.DrawRectangle(new Pen(HeaderColor), rectangleHeader);
            graphics.FillRectangle(new SolidBrush(HeaderColor), 
                rectangleHeader);
            // Обводка верхней "брови" окна
            graphics.DrawRectangle(new Pen(Color.Black), rectangleBorder);
            // Кнопка закрытия окна
            graphics.DrawRectangle(new Pen(buttonCloseCursor ? 
                Color.FromArgb(227, 38, 54) : HeaderColor), 
                rectangleCloseButton);
            graphics.FillRectangle(new SolidBrush
                (buttonCloseCursor ?
                Color.FromArgb(227, 38, 54) : HeaderColor), 
                rectangleCloseButton);
            // Кнопка разворачивания окна
            graphics.DrawRectangle(new Pen(buttonStandartCursor ?
                Color.FromArgb(47, 147, 255) : HeaderColor),
                rectangleStandartButton);
            graphics.FillRectangle(new SolidBrush
                (buttonStandartCursor ? 
                Color.FromArgb(47, 147, 255) : HeaderColor),
                rectangleStandartButton);
            // Кнопка сворачивания окна
            graphics.DrawRectangle(new Pen(buttonCollapseCursor ?
                Color.FromArgb(47, 147, 255) : HeaderColor),
                rectangleCollapseButton);
            graphics.FillRectangle(new SolidBrush
                (buttonCollapseCursor ?
                Color.FromArgb(47, 147, 255) : HeaderColor),
                rectangleCollapseButton);
            // Рисовка крестика
            DrawCrosshair(graphics, rectangleCross, penW);
            DrawCube(graphics, rectangleCube, penW);
            DrawStick(graphics, rectangleStick, penW);
        }
        private void DrawStick(Graphics graphics, 
            Rectangle rectangle, Pen pen)
        {
            graphics.DrawLine(pen,
                    rectangle.X - 1,
                    rectangle.Y + 9,
                    rectangle.X + rectangle.Width,
                    rectangle.Y + 9);
        }
        private void DrawCube(Graphics graphics, 
            Rectangle rectangle, Pen pen)
        {
            if (Form.WindowState == FormWindowState.Maximized)
            {
                // Доп. линии для развёрнутого окна
                // Левая линия
                graphics.DrawLine(pen,
                   rectangle.X,
                   rectangle.Y,
                   rectangle.X,
                   rectangle.Height + rectangle.Y);
                // Левая верхняя линия
                graphics.DrawLine(pen,
                   rectangle.X + 3,
                   rectangle.Y - 3,
                   rectangle.X + 3,
                   rectangle.Height + rectangle.Y - 3);
                // Верхняя линия 2 квадрата
                graphics.DrawLine(pen,
                    rectangle.X + 3,
                    rectangle.Y - 3, 
                    rectangle.X + rectangle.Width + 3,
                    rectangle.Y - 3);
                // Верхняя линия
                graphics.DrawLine(pen,
                    rectangle.X,
                    rectangle.Y, 
                    rectangle.X + rectangle.Width,
                    rectangle.Y);
                // Нижняя линия 2 квадрата
                graphics.DrawLine(pen,
                    rectangle.X + 2,
                    rectangle.Y + 7, 
                    rectangle.X + rectangle.Width + 3,
                    rectangle.Y + 7);
                // Нижняя линия
                graphics.DrawLine(pen,
                    rectangle.X,
                    rectangle.Y + 10, 
                    rectangle.X + rectangle.Width,
                    rectangle.Y + 10);
                // Правая верхняя линия
                graphics.DrawLine(pen,
                   rectangle.X + 13,
                   rectangle.Y - 3,
                   rectangle.X + 13,
                   rectangle.Height + rectangle.Y - 3);
                // Правая линия
                graphics.DrawLine(pen,
                   rectangle.X + 10,
                   rectangle.Y,
                   rectangle.X + 10,
                   rectangle.Height + rectangle.Y);
            }
            else if (Form.WindowState == FormWindowState.Normal)
            {
                // Левая линия
                graphics.DrawLine(pen,
                   rectangle.X,
                   rectangle.Y,
                   rectangle.X,
                   rectangle.Height + rectangle.Y);
                // Верхняя линия
                graphics.DrawLine(pen,
                    rectangle.X,
                    rectangle.Y, rectangle.X + rectangle.Width,
                    rectangle.Y);
                // Нижняя линия
                graphics.DrawLine(pen,
                    rectangle.X,
                    rectangle.Y + 10, rectangle.X + rectangle.Width,
                    rectangle.Y + 10);
                // Правая линия
                graphics.DrawLine(pen,
                   rectangle.X + 10,
                   rectangle.Y,
                   rectangle.X + 10,
                   rectangle.Height + rectangle.Y);
            }
        }
        private void DrawCrosshair(Graphics graphics, 
            Rectangle rectangle, Pen pen)
        {
            graphics.DrawLine(pen, 
                rectangle.X, rectangle.Y, 
                rectangle.Width + rectangle.X, 
                rectangle.Height + rectangle.Y);
            graphics.DrawLine(pen, 
                rectangle.X + rectangle.Width, 
                rectangle.Y, rectangle.X, 
                rectangle.Y + rectangle.Height);
        }
        // Смещение элементов управления
        private void OffsetControls()
        {
            Form.Height = Form.Height + HeaderHeight;
            // Смещение элементов на форме
            foreach(Control control in Form.Controls)
            {
                control.Location = new Point(control.Location.X, 
                    control.Location.Y + HeaderHeight);
                control.Refresh();
            }
        }
    }
}