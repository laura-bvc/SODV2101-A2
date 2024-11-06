using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;



namespace A02_Chart
{
    public partial class ccBarChart : Control

    {

        public List<float> Data { get; set; } = new List<float>();
        private static List<Brush> colors = new List<Brush>()
        {
            // 15 colors
            Brushes.Red,
            Brushes.Yellow,
            Brushes.Blue,
            Brushes.Green,
            Brushes.Violet,
            Brushes.Orange,
            Brushes.Cyan,
            Brushes.Brown,
            Brushes.PaleVioletRed,
            Brushes.GreenYellow,
            Brushes.BlueViolet,
            Brushes.Teal,
            Brushes.DarkRed,
            Brushes.Magenta,
            Brushes.OrangeRed
        };

        public ccBarChart()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(this.BackColor);

            if (Data.Count == 0) return;

            float range;
            float margin = 40;// margin for panel top, bottom, between bars
            float y0;
            float x0 = margin;
            float barWidth = ((float)(Width - x0) / Data.Count ) - margin;

            // set up x-axis location and range for y-axis
            if (Data.Min() >= 0)
            {
                range = Data.Max();
                y0 = Height - margin;
            }
            else if (Data.Max() < 0)
            {
                range = Math.Abs(Data.Min());
                y0 = margin;
            }
            else // (Data.Max() >= 0 && Data.Min() < 0)
            {
                range = Data.Max() - Data.Min();
                y0 = margin + (Data.Max() /range)*(Height - margin - margin) ;
            }


            for (int i = 0; i < Data.Count; i++)
            {
                float value = Data[i];
                float barHeight;
                float x;
                float y;
                float yString;
                float yLabel;

                // set up bar loaction, bar label location
                if ( value >= 0 )
                {
                    barHeight = (float)(value / range) * (Height - margin - margin);
                    x = i * (barWidth + margin) + x0;
                    y = y0 - barHeight;
                    yString = y0; // label below x-axis
                    yLabel = y; //  y-axis tick label location
                }
                else // (value < 0)
                {
                    barHeight = (float)( Math.Abs(value) / range) * (Height - margin - margin);
                    x = i * (barWidth + margin) + x0;
                    y = y0;
                    yString = y0 - margin; // label on top of x-axis
                    yLabel = y + barHeight; // y-axis tick label location
                }

                g.FillRectangle(colors[i % colors.Count], x, y, barWidth, barHeight); // bar, colour repeat after 15 bars
                g.DrawString(value.ToString(), Font, Brushes.Black, (float)(x + 0.5*barWidth - margin), yString); // bar label
                
                g.DrawLine(Pens.Black, x0 - 5, yLabel, x0 + 5, yLabel); // tick mark on y-axis
                g.DrawString(value.ToString(), Font, Brushes.Black, 0, yLabel - 15); // tick label
            }
            g.DrawLine(Pens.Black, x0 - 5, y0, x0 + 5, y0); // tick mark at 0 on y-axis
            g.DrawString("0", Font, Brushes.Black, 0, y0-15); // tick label 0
            g.DrawLine(Pens.Black, x0, 0, x0, Height); // Y Axis
            g.DrawLine(Pens.Black, x0, y0, Width, y0); // X Axis


        }
    }
}
