using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorTools
{
    public partial class CursorTool : Form
    {

        public CursorTool()
        {
            InitializeComponent();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                CursorPositionLabel.Text = string.Format("Position: {{X: {0}, Y: {1}}}", Cursor.Position.X, Cursor.Position.Y);
                Color color = GetPixel(Cursor.Position);
                CursorColorLabel.Text = string.Format("Color: RGB({0}, {1}, {2})", color.R, color.G, color.B);
                Measuring.Text = "Measuring: True";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Measuring.Text = "Measuring: False";
            }
        }

        private void nonSelectableButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Format("{{{0},{1}}}", CursorPositionLabel.Text, CursorColorLabel.Text));
        }

        static Color GetPixel(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }
    }
}
