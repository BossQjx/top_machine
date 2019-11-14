
namespace Fengji
{
    partial class Chart1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
 

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.通道隔离 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.通道隔离)).BeginInit();
            this.SuspendLayout();
            // 
            // 通道隔离
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "/℃";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Rockwell Condensed", 10F);
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 87.61723F;
            chartArea1.InnerPlotPosition.Width = 80.17905F;
            chartArea1.InnerPlotPosition.X = 12.70393F;
            chartArea1.InnerPlotPosition.Y = 2.99756F;
            chartArea1.Name = "ChartArea1";
            this.通道隔离.ChartAreas.Add(chartArea1);
            this.通道隔离.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.通道隔离.Legends.Add(legend1);
            this.通道隔离.Location = new System.Drawing.Point(0, 0);
            this.通道隔离.Name = "通道隔离";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "进口温度";
            this.通道隔离.Series.Add(series1);
            this.通道隔离.Size = new System.Drawing.Size(654, 400);
            this.通道隔离.TabIndex = 0;
            this.通道隔离.Text = "进口温度";
            title1.Name = "通道隔离";
            title1.Text = "4-20mA电流曲线";
            this.通道隔离.Titles.Add(title1);
            this.通道隔离.Click += new System.EventHandler(this.进口温度_Click);
            // 
            // Chart1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 400);
            this.Controls.Add(this.通道隔离);
            this.Name = "Chart1";
            this.Text = "通道隔离";
            ((System.ComponentModel.ISupportInitialize)(this.通道隔离)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart 通道隔离;
    }
}