using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsLab
{
    public interface IResizeble
    {
        public void ResizeObject(int width);
    }
    public partial class MessageForm : UserControl, IResizeble
    {
        // public event EventHandler? OnNewText;
        public MessageForm(string userName, string message)
        {
            InitializeComponent();

            messageText.Text = message;
            timeLabel.Text = DateTime.Now.ToString("hh:mm");
            userLabel.Text = userName;
            if (userName == "You")
            {
                this.Margin = new Padding(10, 5, 50, 5);
            } 
            else
            {
                this.Margin = new Padding(50, 5, 10, 5);
            }
        }

        public MessageForm(string userName, string message, string time)
        {
            InitializeComponent();

            messageText.Text = message;
            timeLabel.Text = time;
            userLabel.Text = userName;
            if (userName == "You")
            {
                this.Margin = new Padding(10, 5, 50, 5);
            }
            else
            {
                this.Margin = new Padding(50, 5, 10, 5);
            }
        }

        public void ResizeObject(int panelWidth)
        {
            this.Height = 60 + TextRenderer.MeasureText(messageText.Text, messageText.Font, 
                new Size(messageText.Width, 0), TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl).Height;
            this.Width = panelWidth - this.Margin.Left - this.Margin.Right - SystemInformation.VerticalScrollBarWidth;
        }

        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

    }


    public class StatusMessage : Label, IResizeble
    {


        public void ResizeObject(int panelWidth)
        {
            this.Margin = new Padding((panelWidth / 2) - 30, 5, 50, 5);
        }
    }
}
