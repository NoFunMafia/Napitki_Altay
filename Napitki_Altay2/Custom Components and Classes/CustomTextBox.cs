using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Napitki_Altay2.Design
{
    [DefaultEvent("Изменение текста")]
    public partial class CustomTextBox : UserControl
    {
        // Поля
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        // Конструктор
        public CustomTextBox()
        {
            InitializeComponent();
        }
        // События
        public event EventHandler TextChangedEvent;
        // Свойства
        [Category("Конфигурация")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Конфигурация")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Конфигурация")]
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("Конфигурация")]
        public bool PasswordChar
        {
            get
            {
                return TextBoxForCustomSetting.UseSystemPasswordChar;
            }
            set
            {
                TextBoxForCustomSetting.UseSystemPasswordChar = value;
            }
        }
        [Category("Конфигурация")]
        public bool Multiline
        {
            get
            {
                return TextBoxForCustomSetting.Multiline;
            }
            set
            {
                TextBoxForCustomSetting.Multiline = value;
            }
        }
        [Category("Конфигурация")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                TextBoxForCustomSetting.BackColor = value;
            }
        }
        [Category("Конфигурация")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                TextBoxForCustomSetting.ForeColor = value;
            }
        }
        [Category("Конфигурация")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                TextBoxForCustomSetting.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("Конфигурация")]
        public ScrollBars ScrollBars
        {
            get
            {
                return TextBoxForCustomSetting.ScrollBars;
            }
            set
            {
                TextBoxForCustomSetting.ScrollBars = value;
            }
        }
        [Category("Конфигурация")]
        public string Texts
        {
            get
            {
                return TextBoxForCustomSetting.Text;
            }
            set
            {
                TextBoxForCustomSetting.Text = value;
            }
        }
        [Category("Конфигурация")]
        public Color BorderFocusColor { get => borderFocusColor; 
            set => borderFocusColor = value; }

        public int SelectionStart
        {
            get
            {
                return TextBoxForCustomSetting.SelectionStart;
            }
            set
            {
                TextBoxForCustomSetting.SelectionStart = value;
            }
        }


        //переопределенные методы
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //граница
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = 
                    System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!isFocused)
                {
                    if (underlinedStyle) //стиль линии
                        graph.DrawLine(penBorder, 0, this.Height - 1, 
                            this.Width, this.Height - 1);
                    else //обычный стиль
                        graph.DrawRectangle(penBorder, 0, 0, 
                            this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //стиль линии
                        graph.DrawLine(penBorder, 0, 
                            this.Height - 1, this.Width, this.Height - 1);
                    else //обычный стиль
                        graph.DrawRectangle(penBorder, 0, 0, 
                            this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (TextBoxForCustomSetting.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", 
                    this.Font).Height + 1;
                TextBoxForCustomSetting.Multiline = true;
                TextBoxForCustomSetting.MinimumSize = new Size(0, txtHeight);
                TextBoxForCustomSetting.Multiline = false;
                this.Height = TextBoxForCustomSetting.Height + 
                    this.Padding.Top + this.Padding.Bottom;
            }
        }
        private void TextBoxForCustomSetting_TextChanged
            (object sender, EventArgs e)
        {
            TextChangedEvent?.Invoke(sender, e);
        }
        private void TextBoxForCustomSetting_Click
            (object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void TextBoxForCustomSetting_MouseEnter
            (object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void TextBoxForCustomSetting_MouseLeave
            (object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void TextBoxForCustomSetting_KeyPress
            (object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        private void TextBoxForCustomSetting_Enter
            (object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }
        private void TextBoxForCustomSetting_Leave
            (object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}