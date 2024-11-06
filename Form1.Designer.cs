namespace A02_Chart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnGenerate = new Button();
            txtNumber = new TextBox();
            pnlBarChart = new Panel();
            lblDesc = new Label();
            lblData = new Label();
            btnReset = new Button();
            lblNumList = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(354, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(241, 58);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add number";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(1096, 142);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(346, 58);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Chart";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(74, 142);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(250, 47);
            txtNumber.TabIndex = 2;
            // 
            // pnlBarChart
            // 
            pnlBarChart.AutoSize = true;
            pnlBarChart.Location = new Point(572, 339);
            pnlBarChart.Name = "pnlBarChart";
            pnlBarChart.Size = new Size(1200, 800);
            pnlBarChart.TabIndex = 3;
            // 
            // lblDesc
            // 
            lblDesc.AllowDrop = true;
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(55, 42);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(891, 54);
            lblDesc.TabIndex = 4;
            lblDesc.Text = "Enter numbers below to be put on a Bar Chart";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(74, 300);
            lblData.Name = "lblData";
            lblData.Size = new Size(0, 54);
            lblData.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(629, 142);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(406, 58);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset Numbers and Chart";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblNumList
            // 
            lblNumList.AutoSize = true;
            lblNumList.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNumList.Location = new Point(74, 238);
            lblNumList.Name = "lblNumList";
            lblNumList.Size = new Size(355, 54);
            lblNumList.TabIndex = 7;
            lblNumList.Text = "Numbers entered";
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1868, 1212);
            Controls.Add(lblNumList);
            Controls.Add(btnReset);
            Controls.Add(lblData);
            Controls.Add(lblDesc);
            Controls.Add(pnlBarChart);
            Controls.Add(txtNumber);
            Controls.Add(btnGenerate);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnGenerate;
        private TextBox txtNumber;
        private Panel pnlBarChart;
        private Label lblDesc;
        private Label lblData;
        private Button btnReset;
        private Label lblNumList;
    }
}
