using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace Fengji
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            ""}, -1);
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation1 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel1 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel2 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation2 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation2 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.开始采集 = new System.Windows.Forms.Button();
            this.停止采集 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.端口号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.本机IP = new System.Windows.Forms.Label();
            this.本机端口号 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.button5 = new System.Windows.Forms.Button();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.退出 = new DevExpress.XtraEditors.SimpleButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl4 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // 开始采集
            // 
            this.开始采集.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(136)))));
            this.开始采集.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.开始采集.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.开始采集.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.开始采集.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.开始采集.Font = new System.Drawing.Font("楷体", 18F);
            this.开始采集.ForeColor = System.Drawing.Color.White;
            this.开始采集.Location = new System.Drawing.Point(1488, 868);
            this.开始采集.Margin = new System.Windows.Forms.Padding(4);
            this.开始采集.Name = "开始采集";
            this.开始采集.Size = new System.Drawing.Size(169, 70);
            this.开始采集.TabIndex = 0;
            this.开始采集.Text = "开始采集";
            this.开始采集.UseVisualStyleBackColor = false;
            this.开始采集.Visible = false;
            this.开始采集.Click += new System.EventHandler(this.开始采集_Click);
            // 
            // 停止采集
            // 
            this.停止采集.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(136)))));
            this.停止采集.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.停止采集.Font = new System.Drawing.Font("楷体", 18F);
            this.停止采集.ForeColor = System.Drawing.Color.Red;
            this.停止采集.Location = new System.Drawing.Point(1488, 946);
            this.停止采集.Margin = new System.Windows.Forms.Padding(4);
            this.停止采集.Name = "停止采集";
            this.停止采集.Size = new System.Drawing.Size(169, 70);
            this.停止采集.TabIndex = 1;
            this.停止采集.Text = "停止采集";
            this.停止采集.UseVisualStyleBackColor = false;
            this.停止采集.Visible = false;
            this.停止采集.Click += new System.EventHandler(this.停止采集_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "D:\\VS\\Project";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.端口号,
            this.STATUS,
            this.ID});
            this.listView1.Font = new System.Drawing.Font("楷体", 15F);
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(279, 868);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(1140, 140);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            // 
            // IP
            // 
            this.IP.Text = "         IP";
            this.IP.Width = 337;
            // 
            // 端口号
            // 
            this.端口号.Tag = "";
            this.端口号.Text = "    端口号";
            this.端口号.Width = 296;
            // 
            // STATUS
            // 
            this.STATUS.Text = "    状态";
            this.STATUS.Width = 319;
            // 
            // ID
            // 
            this.ID.Text = "节点ID";
            this.ID.Width = 198;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1697, 946);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 36);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "192.168.1.122";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(1755, 848);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 36);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "1400";
            // 
            // 本机IP
            // 
            this.本机IP.AutoSize = true;
            this.本机IP.Font = new System.Drawing.Font("楷体", 20F);
            this.本机IP.ForeColor = System.Drawing.Color.White;
            this.本机IP.Location = new System.Drawing.Point(1739, 903);
            this.本机IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.本机IP.Name = "本机IP";
            this.本机IP.Size = new System.Drawing.Size(96, 27);
            this.本机IP.TabIndex = 22;
            this.本机IP.Text = "本机IP";
            // 
            // 本机端口号
            // 
            this.本机端口号.AutoSize = true;
            this.本机端口号.Font = new System.Drawing.Font("楷体", 20F);
            this.本机端口号.ForeColor = System.Drawing.Color.White;
            this.本机端口号.Location = new System.Drawing.Point(1718, 796);
            this.本机端口号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.本机端口号.Name = "本机端口号";
            this.本机端口号.Size = new System.Drawing.Size(152, 27);
            this.本机端口号.TabIndex = 23;
            this.本机端口号.Text = "本机端口号";
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl1.BorderOptions.Thickness = 3;
            xyDiagram1.AxisX.Color = System.Drawing.Color.White;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Millisecond;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.InterlacedColor = System.Drawing.Color.White;
            xyDiagram1.AxisX.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.White;
            xyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.White;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            xyDiagram1.AxisY.Color = System.Drawing.Color.White;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.InterlacedColor = System.Drawing.Color.White;
            xyDiagram1.AxisY.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.White;
            xyDiagram1.AxisY.Title.Text = "g";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Title.WordWrap = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "3";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "-3";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "70";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "-70";
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram1.DefaultPane.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.TextColor = System.Drawing.Color.White;
            this.chartControl1.Location = new System.Drawing.Point(266, 599);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(4);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.Name = "垂直振动";
            lineSeriesView1.Color = System.Drawing.Color.White;
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(1108, 250);
            this.chartControl1.TabIndex = 67;
            // 
            // chartControl2
            // 
            this.chartControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl2.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl2.BorderOptions.Thickness = 3;
            this.chartControl2.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisX.Color = System.Drawing.Color.White;
            xyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Millisecond;
            xyDiagram2.AxisX.GridLines.MinorVisible = true;
            xyDiagram2.AxisX.GridLines.Visible = true;
            xyDiagram2.AxisX.InterlacedColor = System.Drawing.Color.White;
            xyDiagram2.AxisX.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram2.AxisX.Label.TextColor = System.Drawing.Color.White;
            xyDiagram2.AxisX.MinorCount = 10;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.VisualRange.Auto = false;
            xyDiagram2.AxisX.VisualRange.MaxValueSerializable = "11/11/2019 15:34:11.001";
            xyDiagram2.AxisX.VisualRange.MinValueSerializable = "11/11/2019 15:34:11.000";
            xyDiagram2.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            xyDiagram2.AxisY.Color = System.Drawing.Color.White;
            xyDiagram2.AxisY.GridLines.MinorVisible = true;
            xyDiagram2.AxisY.InterlacedColor = System.Drawing.Color.White;
            xyDiagram2.AxisY.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram2.AxisY.Label.TextColor = System.Drawing.Color.White;
            xyDiagram2.AxisY.MinorCount = 3;
            xyDiagram2.AxisY.Title.Text = "g";
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisualRange.Auto = false;
            xyDiagram2.AxisY.VisualRange.MaxValueSerializable = "3";
            xyDiagram2.AxisY.VisualRange.MinValueSerializable = "-3";
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram2.AxisY.WholeRange.Auto = false;
            xyDiagram2.AxisY.WholeRange.MaxValueSerializable = "70";
            xyDiagram2.AxisY.WholeRange.MinValueSerializable = "-70";
            xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram2.DefaultPane.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            xyDiagram2.EnableAxisYScrolling = true;
            xyDiagram2.EnableAxisYZooming = true;
            this.chartControl2.Diagram = xyDiagram2;
            this.chartControl2.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Legend.TextColor = System.Drawing.Color.White;
            this.chartControl2.Location = new System.Drawing.Point(266, 313);
            this.chartControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.chartControl2.Margin = new System.Windows.Forms.Padding(4);
            this.chartControl2.Name = "chartControl2";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series2.LegendName = "Default Legend";
            series2.Name = "水平振动";
            lineSeriesView2.Color = System.Drawing.Color.White;
            xySeriesUnwindAnimation1.Duration = System.TimeSpan.Parse("00:00:00.0200000");
            lineSeriesView2.SeriesAnimation = xySeriesUnwindAnimation1;
            xyMarkerWidenAnimation1.Duration = System.TimeSpan.Parse("00:00:00.0200000");
            lineSeriesView2.SeriesPointAnimation = xyMarkerWidenAnimation1;
            series2.View = lineSeriesView2;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(1108, 250);
            this.chartControl2.TabIndex = 106;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(155)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1293, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 71);
            this.button1.TabIndex = 119;
            this.button1.Text = "连接数据库";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("楷体", 20F);
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(1706, 355);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(168, 31);
            this.textBox7.TabIndex = 120;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("楷体", 20F);
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(1706, 677);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(168, 31);
            this.textBox8.TabIndex = 121;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(136)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("楷体", 18F);
            this.button2.Location = new System.Drawing.Point(29, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 70);
            this.button2.TabIndex = 122;
            this.button2.Text = "历史数据查询";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("楷体", 20F);
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(1706, 511);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(168, 31);
            this.textBox9.TabIndex = 123;
            this.textBox9.Text = "0";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 20F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1718, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 27);
            this.label8.TabIndex = 124;
            this.label8.Text = "收到数据包";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 20F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1718, 597);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 27);
            this.label9.TabIndex = 125;
            this.label9.Text = "存储数据量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 20F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1729, 445);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 27);
            this.label10.TabIndex = 126;
            this.label10.Text = "总数据量";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1382, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 64);
            this.label2.TabIndex = 153;
            this.label2.Text = "水平振动";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(1408, 460);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 73);
            this.textBox3.TabIndex = 153;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent2});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 469, 332);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent2});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent2});
            // 
            // arcScaleBackgroundLayerComponent2
            // 
            this.arcScaleBackgroundLayerComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleBackgroundLayerComponent2.Name = "bg1";
            this.arcScaleBackgroundLayerComponent2.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.2F);
            this.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style5;
            this.arcScaleBackgroundLayerComponent2.Size = new System.Drawing.SizeF(250F, 112F);
            this.arcScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.arcScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 205F);
            this.arcScaleComponent2.EndAngle = -30F;
            scaleLabel1.AppearanceText.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scaleLabel1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel1.Name = "Label0";
            scaleLabel1.Size = new System.Drawing.SizeF(80F, 30F);
            scaleLabel1.Text = "水平振动:";
            this.arcScaleComponent2.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel1});
            this.arcScaleComponent2.MajorTickCount = 7;
            this.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent2.MajorTickmark.ShapeOffset = -15.5F;
            this.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1;
            this.arcScaleComponent2.MajorTickmark.TextOffset = -30F;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 100F;
            this.arcScaleComponent2.MinorTickCount = 4;
            this.arcScaleComponent2.MinorTickmark.ShapeOffset = -3F;
            this.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent2.MinValue = -100F;
            this.arcScaleComponent2.Name = "scale1";
            this.arcScaleComponent2.RadiusX = 125F;
            this.arcScaleComponent2.RadiusY = 125F;
            this.arcScaleComponent2.StartAngle = -150F;
            this.arcScaleComponent2.Value = 50F;
            // 
            // arcScaleNeedleComponent2
            // 
            this.arcScaleNeedleComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleNeedleComponent2.Name = "needle1";
            this.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style5;
            this.arcScaleNeedleComponent2.StartOffset = 75F;
            this.arcScaleNeedleComponent2.ZOrder = -50;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.AutoLayout = false;
            this.gaugeControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge2});
            this.gaugeControl2.Location = new System.Drawing.Point(1460, 1052);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(364, 253);
            this.gaugeControl2.TabIndex = 130;
            this.gaugeControl2.Visible = false;
            // 
            // circularGauge2
            // 
            this.circularGauge2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent3});
            this.circularGauge2.Bounds = new System.Drawing.Rectangle(-15, 11, 384, 241);
            this.circularGauge2.Name = "circularGauge2";
            this.circularGauge2.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent3});
            this.circularGauge2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent3});
            // 
            // arcScaleBackgroundLayerComponent3
            // 
            this.arcScaleBackgroundLayerComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleBackgroundLayerComponent3.Name = "bg1";
            this.arcScaleBackgroundLayerComponent3.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.2F);
            this.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularWide_Style5;
            this.arcScaleBackgroundLayerComponent3.Size = new System.Drawing.SizeF(250F, 112F);
            this.arcScaleBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // arcScaleComponent3
            // 
            this.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.arcScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleComponent3.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 205F);
            this.arcScaleComponent3.EndAngle = -30F;
            scaleLabel2.AppearanceText.Font = new System.Drawing.Font("楷体", 24F);
            scaleLabel2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel2.Name = "Label0";
            scaleLabel2.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(120F, 10F);
            scaleLabel2.Size = new System.Drawing.SizeF(300F, 50F);
            scaleLabel2.Text = "垂直振动：";
            this.arcScaleComponent3.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel2});
            this.arcScaleComponent3.MajorTickCount = 7;
            this.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent3.MajorTickmark.ShapeOffset = -15.5F;
            this.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_1;
            this.arcScaleComponent3.MajorTickmark.TextOffset = -30F;
            this.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent3.MaxValue = 70F;
            this.arcScaleComponent3.MinorTickCount = 4;
            this.arcScaleComponent3.MinorTickmark.ShapeOffset = -3F;
            this.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent3.MinValue = -70F;
            this.arcScaleComponent3.Name = "scale1";
            this.arcScaleComponent3.RadiusX = 125F;
            this.arcScaleComponent3.RadiusY = 125F;
            this.arcScaleComponent3.StartAngle = -150F;
            // 
            // arcScaleNeedleComponent3
            // 
            this.arcScaleNeedleComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleNeedleComponent3.Name = "needle1";
            this.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularWide_Style5;
            this.arcScaleNeedleComponent3.StartOffset = 75F;
            this.arcScaleNeedleComponent3.ZOrder = -50;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(1408, 730);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 73);
            this.textBox4.TabIndex = 154;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1382, 597);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 64);
            this.label3.TabIndex = 154;
            this.label3.Text = "垂直振动";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.labelControl1.Location = new System.Drawing.Point(630, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(564, 60);
            this.labelControl1.TabIndex = 132;
            this.labelControl1.Text = "舱内设备振动数据监测";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(136)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("楷体", 18F);
            this.button3.Location = new System.Drawing.Point(329, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 70);
            this.button3.TabIndex = 138;
            this.button3.Text = "故障分析";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(136)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("楷体", 18F);
            this.button4.Location = new System.Drawing.Point(975, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 71);
            this.button4.TabIndex = 139;
            this.button4.Text = "绑定节点";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.LineThickness = 10;
            this.separatorControl1.Location = new System.Drawing.Point(152, 138);
            this.separatorControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(28, 908);
            this.separatorControl1.TabIndex = 146;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton6.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseBorderColor = true;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton6.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton6.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton6.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton6.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton6.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton6.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton6.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton6.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton6.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton6.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton6.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton6.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton6.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton6.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton6.Location = new System.Drawing.Point(28, 584);
            this.simpleButton6.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton6.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(118, 39);
            this.simpleButton6.TabIndex = 136;
            this.simpleButton6.Text = "节点6";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton7.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton7.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseBorderColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton7.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton7.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton7.AppearanceDisabled.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton7.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton7.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton7.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton7.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton7.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton7.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton7.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton7.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton7.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton7.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton7.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton7.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton7.Location = new System.Drawing.Point(28, 629);
            this.simpleButton7.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton7.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton7.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton7.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(118, 39);
            this.simpleButton7.TabIndex = 140;
            this.simpleButton7.Text = "节点7";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton5.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseBorderColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton5.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton5.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton5.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton5.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton5.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton5.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton5.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton5.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton5.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton5.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton5.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton5.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton5.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton5.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton5.Location = new System.Drawing.Point(28, 539);
            this.simpleButton5.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton5.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton5.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(118, 39);
            this.simpleButton5.TabIndex = 137;
            this.simpleButton5.Text = "节点5";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton8.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton8.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.Appearance.Options.UseBorderColor = true;
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton8.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton8.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton8.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton8.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton8.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton8.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton8.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton8.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton8.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton8.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton8.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton8.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton8.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton8.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton8.Location = new System.Drawing.Point(28, 674);
            this.simpleButton8.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton8.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton8.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton8.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(118, 39);
            this.simpleButton8.TabIndex = 141;
            this.simpleButton8.Text = "节点8";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseBorderColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton4.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton4.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton4.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton4.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton4.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton4.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton4.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton4.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton4.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton4.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton4.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton4.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton4.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton4.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton4.Location = new System.Drawing.Point(29, 494);
            this.simpleButton4.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton4.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(118, 39);
            this.simpleButton4.TabIndex = 134;
            this.simpleButton4.Text = "节点4";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton9.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton9.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton9.Appearance.Options.UseBackColor = true;
            this.simpleButton9.Appearance.Options.UseBorderColor = true;
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton9.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton9.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton9.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton9.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton9.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton9.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton9.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton9.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton9.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton9.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton9.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton9.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton9.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton9.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton9.Location = new System.Drawing.Point(28, 719);
            this.simpleButton9.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton9.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton9.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton9.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(118, 39);
            this.simpleButton9.TabIndex = 142;
            this.simpleButton9.Text = "节点9";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton3.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton3.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton3.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton3.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton3.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton3.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton3.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton3.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton3.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton3.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton3.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton3.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton3.Location = new System.Drawing.Point(28, 449);
            this.simpleButton3.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton3.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(118, 39);
            this.simpleButton3.TabIndex = 135;
            this.simpleButton3.Text = "节点3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton10.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton10.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton10.Appearance.Options.UseBackColor = true;
            this.simpleButton10.Appearance.Options.UseBorderColor = true;
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton10.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton10.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton10.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton10.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton10.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton10.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton10.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton10.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton10.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton10.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton10.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton10.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton10.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton10.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton10.Location = new System.Drawing.Point(28, 764);
            this.simpleButton10.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton10.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton10.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton10.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(118, 39);
            this.simpleButton10.TabIndex = 143;
            this.simpleButton10.Text = "节点10";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearanceDisabled.BackColor = System.Drawing.Color.Red;
            this.simpleButton2.AppearanceDisabled.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton2.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton2.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton2.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton2.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton2.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton2.Location = new System.Drawing.Point(28, 404);
            this.simpleButton2.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton2.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(118, 39);
            this.simpleButton2.TabIndex = 133;
            this.simpleButton2.Text = "节点2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(253)))));
            this.simpleButton1.AppearanceDisabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.simpleButton1.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.AppearanceDisabled.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton1.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.simpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.Lime;
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.Location = new System.Drawing.Point(28, 359);
            this.simpleButton1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.simpleButton1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 39);
            this.simpleButton1.TabIndex = 128;
            this.simpleButton1.Text = "节点1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(136)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("楷体", 18F);
            this.button5.Location = new System.Drawing.Point(650, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 70);
            this.button5.TabIndex = 148;
            this.button5.Text = "报警日志";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // separatorControl3
            // 
            this.separatorControl3.AutoSizeMode = true;
            this.separatorControl3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
            this.separatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl3.LineThickness = 10;
            this.separatorControl3.Location = new System.Drawing.Point(1662, 138);
            this.separatorControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(28, 916);
            this.separatorControl3.TabIndex = 149;
            // 
            // separatorControl2
            // 
            this.separatorControl2.AutoSizeMode = true;
            this.separatorControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
            this.separatorControl2.LineThickness = 10;
            this.separatorControl2.Location = new System.Drawing.Point(-3, 1028);
            this.separatorControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(1915, 28);
            this.separatorControl2.TabIndex = 150;
            // 
            // separatorControl4
            // 
            this.separatorControl4.AutoSizeMode = true;
            this.separatorControl4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
            this.separatorControl4.LineThickness = 10;
            this.separatorControl4.Location = new System.Drawing.Point(0, 138);
            this.separatorControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(1915, 28);
            this.separatorControl4.TabIndex = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(929, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 152;
            this.label1.Text = "当前显示节点：";
            // 
            // 退出
            // 
            this.退出.Appearance.ForeColor = System.Drawing.Color.White;
            this.退出.Appearance.Options.UseForeColor = true;
            this.退出.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.退出.Location = new System.Drawing.Point(1861, 34);
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(25, 25);
            this.退出.TabIndex = 127;
            this.退出.Text = "X";
            this.退出.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1850, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 155;
            this.label4.Text = "label4";
            // 
            // chartControl3
            // 
            this.chartControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl3.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl3.BorderOptions.Thickness = 3;
            xyDiagram3.AxisX.Color = System.Drawing.Color.White;
            xyDiagram3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Millisecond;
            xyDiagram3.AxisX.GridLines.MinorVisible = true;
            xyDiagram3.AxisX.GridLines.Visible = true;
            xyDiagram3.AxisX.InterlacedColor = System.Drawing.Color.White;
            xyDiagram3.AxisX.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram3.AxisX.Label.TextColor = System.Drawing.Color.White;
            xyDiagram3.AxisX.Title.TextColor = System.Drawing.Color.White;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            xyDiagram3.AxisY.Color = System.Drawing.Color.White;
            xyDiagram3.AxisY.GridLines.MinorVisible = true;
            xyDiagram3.AxisY.InterlacedColor = System.Drawing.Color.White;
            xyDiagram3.AxisY.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram3.AxisY.Label.TextColor = System.Drawing.Color.White;
            xyDiagram3.AxisY.Title.Text = "g";
            xyDiagram3.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.AxisY.Title.WordWrap = true;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisualRange.Auto = false;
            xyDiagram3.AxisY.VisualRange.MaxValueSerializable = "3";
            xyDiagram3.AxisY.VisualRange.MinValueSerializable = "-3";
            xyDiagram3.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram3.AxisY.WholeRange.Auto = false;
            xyDiagram3.AxisY.WholeRange.MaxValueSerializable = "70";
            xyDiagram3.AxisY.WholeRange.MinValueSerializable = "-70";
            xyDiagram3.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram3.DefaultPane.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            xyDiagram3.EnableAxisYScrolling = true;
            xyDiagram3.EnableAxisYZooming = true;
            this.chartControl3.Diagram = xyDiagram3;
            this.chartControl3.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Legend.TextColor = System.Drawing.Color.White;
            this.chartControl3.Location = new System.Drawing.Point(266, 599);
            this.chartControl3.Margin = new System.Windows.Forms.Padding(4);
            this.chartControl3.Name = "chartControl3";
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series3.Name = "垂直振动";
            lineSeriesView3.Color = System.Drawing.Color.White;
            series3.View = lineSeriesView3;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl3.Size = new System.Drawing.Size(1108, 250);
            this.chartControl3.TabIndex = 156;
            // 
            // chartControl4
            // 
            this.chartControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl4.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl4.BorderOptions.Thickness = 3;
            this.chartControl4.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram4.AxisX.Color = System.Drawing.Color.White;
            xyDiagram4.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Millisecond;
            xyDiagram4.AxisX.GridLines.MinorVisible = true;
            xyDiagram4.AxisX.GridLines.Visible = true;
            xyDiagram4.AxisX.InterlacedColor = System.Drawing.Color.White;
            xyDiagram4.AxisX.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram4.AxisX.Label.TextColor = System.Drawing.Color.White;
            xyDiagram4.AxisX.MinorCount = 10;
            xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisX.VisualRange.Auto = false;
            xyDiagram4.AxisX.VisualRange.MaxValueSerializable = "11/11/2019 15:34:12.001";
            xyDiagram4.AxisX.VisualRange.MinValueSerializable = "11/11/2019 15:34:12.000";
            xyDiagram4.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            xyDiagram4.AxisY.Color = System.Drawing.Color.White;
            xyDiagram4.AxisY.GridLines.MinorVisible = true;
            xyDiagram4.AxisY.InterlacedColor = System.Drawing.Color.White;
            xyDiagram4.AxisY.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram4.AxisY.Label.TextColor = System.Drawing.Color.White;
            xyDiagram4.AxisY.MinorCount = 3;
            xyDiagram4.AxisY.Title.Text = "g";
            xyDiagram4.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram4.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisY.VisualRange.Auto = false;
            xyDiagram4.AxisY.VisualRange.MaxValueSerializable = "3";
            xyDiagram4.AxisY.VisualRange.MinValueSerializable = "-3";
            xyDiagram4.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram4.AxisY.WholeRange.Auto = false;
            xyDiagram4.AxisY.WholeRange.MaxValueSerializable = "70";
            xyDiagram4.AxisY.WholeRange.MinValueSerializable = "-70";
            xyDiagram4.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            xyDiagram4.DefaultPane.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            xyDiagram4.EnableAxisYScrolling = true;
            xyDiagram4.EnableAxisYZooming = true;
            this.chartControl4.Diagram = xyDiagram4;
            this.chartControl4.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.chartControl4.Legend.Name = "Default Legend";
            this.chartControl4.Legend.TextColor = System.Drawing.Color.White;
            this.chartControl4.Location = new System.Drawing.Point(266, 313);
            this.chartControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.chartControl4.Margin = new System.Windows.Forms.Padding(4);
            this.chartControl4.Name = "chartControl4";
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series4.LegendName = "Default Legend";
            series4.Name = "水平振动";
            lineSeriesView4.Color = System.Drawing.Color.White;
            xySeriesUnwindAnimation2.Duration = System.TimeSpan.Parse("00:00:00.0200000");
            lineSeriesView4.SeriesAnimation = xySeriesUnwindAnimation2;
            xyMarkerWidenAnimation2.Duration = System.TimeSpan.Parse("00:00:00.0200000");
            lineSeriesView4.SeriesPointAnimation = xyMarkerWidenAnimation2;
            series4.View = lineSeriesView4;
            this.chartControl4.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartControl4.Size = new System.Drawing.Size(1108, 250);
            this.chartControl4.TabIndex = 157;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.chartControl4);
            this.Controls.Add(this.chartControl3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.退出);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.simpleButton10);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.gaugeControl2);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.本机端口号);
            this.Controls.Add(this.本机IP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.停止采集);
            this.Controls.Add(this.开始采集);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            Point tPoint = new Point();
            Font tFont = new Font("楷体", this.Width/110, FontStyle.Regular);
            
            SolidBrush myBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#E00004B"));
            SolidBrush tFrontBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFFFFF"));
            tPoint.X = e.Bounds.X + 3;
            tPoint.Y = e.Bounds.Y + 2;
            e.Graphics.FillRectangle(myBrush, e.Bounds);    //采用特定颜色绘制标题列,这里我用的#e292929色
            e.Graphics.DrawString(e.Header.Text, tFont, tFrontBrush, tPoint);  //采用默认方式绘制标题文本
        }
        // 实际上Item和SubItem也可以自己来画外观的，使用DrawItem和DrawSubItem事件就可以了：

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#E00004B"));
            e.Graphics.FillRectangle(myBrush, e.Bounds);    //采用特定颜色绘制标题列,这里我用的红色
            //e.DrawText();   //采用默认方式绘制标题文本
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#E00004B"));
            e.Graphics.FillRectangle(myBrush, e.Bounds);    //采用特定颜色绘制标题列,这里我用的红色
            e.DrawText();   //采用默认方式绘制标题文本
        }
        #endregion
        private System.Windows.Forms.Button 开始采集;
        private System.Windows.Forms.Button 停止采集;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader 端口号;
        private System.Windows.Forms.ColumnHeader STATUS;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label 本机IP;
        private System.Windows.Forms.Label 本机端口号;
        //private fjdataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        //private fjdataDataSet fjdataDataSet2;
        //private fengji_dataDataSet fengji_dataDataSet1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent3;
        private LabelControl labelControl1;
        private Button button3;
        private Button button4;
        private SeparatorControl separatorControl1;
        private SimpleButton simpleButton6;
        private SimpleButton simpleButton7;
        private SimpleButton simpleButton5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private SimpleButton simpleButton8;
        private SimpleButton simpleButton4;
        private SimpleButton simpleButton9;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton10;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton1;
        private Button button5;
        private SeparatorControl separatorControl3;
        private SeparatorControl separatorControl2;
        private SeparatorControl separatorControl4;
        private Label label1;
        private SimpleButton 退出;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Timer timer3;
        private Label label4;
        private ChartControl chartControl3;
        private ChartControl chartControl4;
    }
}