using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System.Views.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class Input : UserControl
    {
        private Color borderColor = Color.DimGray;
        private int borderSize = 1;
        private bool underlined = false;
        private Color borderFocusColor = Color.DodgerBlue;
        private bool isFocused = false;

        public Input()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public bool Underlined { get => underlined; set { underlined = value; this.Invalidate(); } }

        public bool Multiline { get => txtInput.Multiline; set => txtInput.Multiline = value; }
        public bool ReadOnly { get => txtInput.ReadOnly; set { txtInput.ReadOnly = value; this.Invalidate(); } }
        public bool PasswordChar { get => txtInput.UseSystemPasswordChar; set => txtInput.UseSystemPasswordChar = value; }


        public override Color BackColor
        {
            get => txtInput.BackColor;
            set
            {
                base.BackColor = value;
                txtInput.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get => txtInput.ForeColor;
            set
            {
                base.ForeColor = value;
                txtInput.ForeColor = value;
            }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                txtInput.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        public string Texts
        {
            get => txtInput.Text;
            set => txtInput.Text = value;
        }

        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set => borderFocusColor = value;
        }
        private void UpdateControlHeight()
        {
            if (txtInput.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txtInput.Multiline = true;
                txtInput.MinimumSize = new Size(0, txtHeight);
                txtInput.Multiline = false;
                this.Height = txtInput.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;
                if (underlined) graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void txtInput_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void txtInput_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void txtInput_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
