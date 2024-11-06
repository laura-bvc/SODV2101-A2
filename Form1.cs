using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A02_Chart
{
    public partial class Form1 : Form
    {

        private ccBarChart BarChart;
        private List<float> data;

        public Form1()
        {
            InitializeComponent();

            data = new List<float>();

            btnAdd.Click += BtnAdd_Click;
            btnGenerate.Click += BtnGenerate_Click;

            BarChart = new ccBarChart() { Dock = DockStyle.Fill };

            pnlBarChart.Controls.Add(BarChart);

            Text = "Bar Chart Generator";
            Width = 1900;
            Height = 1300;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtNumber.Text, out float number))
            {
                data.Add(number);
                lblData.Text += number.ToString() + "\n";
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            BarChart.Data = new List<float>(data);
            BarChart.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            data.Clear();
            lblData.Text = "";
            BarChart.Data.Clear();
            BarChart.Invalidate();
        }
    }
}





