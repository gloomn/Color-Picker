using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            screen_timer.Enabled = true;
            Load += mainForm_Load;
            FormClosing += mainForm_FormClosing;
            KeyDown += mainForm_KeyDown;
            rScroll.Maximum = 255;
            gScroll.Maximum = 255;
            bScroll.Maximum = 255;
        }

        private void screen_timer_Tick(object sender, EventArgs e)
        {
            Size size = new Size(screen.Width, screen.Height);

            Bitmap bitmap = new Bitmap((int)(size.Width), (int)(size.Height));
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.CopyFromScreen(MousePosition.X - 50, MousePosition.Y - 50, 0, 0, size, CopyPixelOperation.SourceCopy);

            screen.Image = bitmap;
            xPosition.Text = "X: " + MousePosition.X.ToString();
            yPosition.Text = "Y: " + MousePosition.Y.ToString();
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawLine(Pens.Red, 50, 100, 50, 0);
            g.DrawLine(Pens.Red, -50, 50, 100, 50);
            g.DrawLine(Pens.Red, 0, 0, 100, 0);
            g.DrawLine(Pens.Red, 0, 0, 0, 100);
            g.DrawLine(Pens.Red, 0, 99, 99, 99);
            g.DrawLine(Pens.Red, 99, 0, 99, 99);
        }

        private void screen_color_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawLine(Pens.Red, 0, 0, 100, 0);
            g.DrawLine(Pens.Red, 0, 0, 0, 100);
            g.DrawLine(Pens.Red, 0, 49, 99, 49);
            g.DrawLine(Pens.Red, 99, 0, 99, 99);
        }

        private delegate void SetColorDelegate(int x, int y, Color color);
        private Thread thread;

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.thread = new Thread(new ThreadStart(ProcessThread));
            this.thread.Start();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread != null && this.thread.IsAlive)
            {
                this.thread.Abort();
            }
        }

        private Color GetMousePointColor(Point mousePoint)
        {
            Size size = new Size(1, 1);
            Bitmap bitmap = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(mousePoint.X, mousePoint.Y, 0, 0, size);
            return bitmap.GetPixel(0, 0);
        }

        private string GetHexadecimalString(int value)
        {
            byte[] byteArray = BitConverter.GetBytes(value);
            int byteArrayLength = byteArray.Length;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < byteArrayLength; i++)
            {
                stringBuilder.Append(byteArray[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        private void SetColor(int x, int y, Color color)
        {
            if (InvokeRequired)
            {
                SetColorDelegate setColorDelegate = new SetColorDelegate(SetColor);
                Invoke(setColorDelegate, x, y, color);
            }
            else
            {
                this.rgb_R.Text = "R: " + color.R.ToString();
                this.rgb_G.Text = "G: " + color.G.ToString();
                this.rgb_B.Text = "B: " + color.B.ToString();
                this.screen_color.BackColor = color;
                this.hexcode.Text = GetHexadecimalString(color.R).Substring(0, 2) + GetHexadecimalString(color.G).Substring(0, 2) + GetHexadecimalString(color.B).Substring(0, 2);
            }
        }



        private void ProcessThread()
        {
            while (true)
            {
                Point mousePoint = Control.MousePosition;
                int x = mousePoint.X;
                int y = mousePoint.Y;
                Color color = GetMousePointColor(mousePoint);
                SetColor(x, y, color);
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                Point mousePoint = Control.MousePosition;
                int x = mousePoint.X;
                int y = mousePoint.Y;
                Color color = GetMousePointColor(mousePoint);
                SetColor(x, y, color);
                color_list.Items.Add(hexcode.Text);
                this.color_list.DrawItem += color_list_DrawItem;
            }
        }
        

        private void 화면모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (화면모드ToolStripMenuItem.Checked == false)
            {
                화면모드ToolStripMenuItem.Checked = true;
                this.BackColor = Color.FromArgb(50, 50, 50);
                menuBar.BackColor = Color.FromArgb(50, 50, 50);
                옵션ToolStripMenuItem.ForeColor = Color.White;
                색목록ToolStripMenuItem.ForeColor = Color.White;
                도움말ToolStripMenuItem.ForeColor = Color.White;
                rgb_R.ForeColor = Color.White;
                rgb_B.ForeColor = Color.White;
                rgb_G.ForeColor = Color.White;
                hexcode.ForeColor = Color.White;
                xPosition.ForeColor = Color.White;
                yPosition.ForeColor = Color.White;
                selected_R.ForeColor = Color.White;
                selected_G.ForeColor = Color.White;
                selected_B.ForeColor = Color.White;
            }
            else
            {
                화면모드ToolStripMenuItem.Checked = false;
                this.BackColor = Color.White;
                menuBar.BackColor = Color.FromArgb(240, 240, 240);
                옵션ToolStripMenuItem.ForeColor = Color.Black;
                색목록ToolStripMenuItem.ForeColor = Color.Black;
                도움말ToolStripMenuItem.ForeColor = Color.Black;
                rgb_R.ForeColor = Color.Black;
                rgb_B.ForeColor = Color.Black;
                rgb_G.ForeColor = Color.Black;
                hexcode.ForeColor = Color.Black;
                xPosition.ForeColor = Color.Black;
                yPosition.ForeColor = Color.Black;
                selected_R.ForeColor = Color.Black;
                selected_G.ForeColor = Color.Black;
                selected_B.ForeColor = Color.Black;
            }
        }

        private void color_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void color_list_MouseClick(object sender, MouseEventArgs e)
        {
            if (color_list.SelectedItem != null) 
            {
                int red = 0;
                int green = 0;
                int blue = 0;
                selected_hexcode.Text = color_list.SelectedItem.ToString();
                if (selected_hexcode.Text.Length == 6)
                {
                    //#RRGGBB
                    red = int.Parse(selected_hexcode.Text.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                    green = int.Parse(selected_hexcode.Text.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                    blue = int.Parse(selected_hexcode.Text.Substring(4, 2), NumberStyles.AllowHexSpecifier);
                }
                else if (selected_hexcode.Text.Length == 3)
                {
                    //#RGB
                    red = int.Parse(selected_hexcode.Text[0].ToString() + selected_hexcode.Text[0].ToString(), NumberStyles.AllowHexSpecifier);
                    green = int.Parse(selected_hexcode.Text[1].ToString() + selected_hexcode.Text[1].ToString(), NumberStyles.AllowHexSpecifier);
                    blue = int.Parse(selected_hexcode.Text[2].ToString() + selected_hexcode.Text[2].ToString(), NumberStyles.AllowHexSpecifier);
                }
                selected_color.BackColor = Color.FromArgb(red, green, blue);
                selected_R.Text = "R: " + red.ToString();
                selected_G.Text = "G: " + green.ToString();
                selected_B.Text = "B: " + blue.ToString();
                rScroll.Value = red;
                gScroll.Value = green;
                bScroll.Value = blue;
            }
        }

        private void selected_color_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawLine(Pens.Red, 0, 0, 100, 0);
            g.DrawLine(Pens.Red, 0, 0, 0, 100);
            g.DrawLine(Pens.Red, 0, 49, 99, 49);
            g.DrawLine(Pens.Red, 99, 0, 99, 99);
        }

        private void copy_color_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(selected_hexcode.Text);
        }

        private void rScroll_Scroll(object sender, ScrollEventArgs e)
        {
            selected_R.Text = "R: " + rScroll.Value.ToString();
            selected_color.BackColor = Color.FromArgb(rScroll.Value, gScroll.Value, bScroll.Value);
        }

        private void gScroll_Scroll(object sender, ScrollEventArgs e)
        {
            selected_G.Text = "G: " + gScroll.Value.ToString();
            selected_color.BackColor = Color.FromArgb(rScroll.Value, gScroll.Value, bScroll.Value);
        }

        private void bScroll_Scroll(object sender, ScrollEventArgs e)
        {
            selected_B.Text = "B: " + bScroll.Value.ToString();
            selected_color.BackColor = Color.FromArgb(rScroll.Value, gScroll.Value, bScroll.Value);
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/gloomn/Color-Picker");
        }
    }
}
