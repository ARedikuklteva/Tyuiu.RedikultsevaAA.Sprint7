
namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction_RAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOen_RAA = new System.Windows.Forms.Button();
            this.groupBoxFirstSum_RAA = new System.Windows.Forms.GroupBox();
            this.groupBoxThirdSum_RAA = new System.Windows.Forms.GroupBox();
            this.groupBoxSecondSum_RAA = new System.Windows.Forms.GroupBox();
            this.toolTip_RAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_RAA = new System.Windows.Forms.OpenFileDialog();
            this.textBoxSecond_RAA = new System.Windows.Forms.TextBox();
            this.textBoxThird_RAA = new System.Windows.Forms.TextBox();
            this.textBoxFirst_RAA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).BeginInit();
            this.groupBoxFirstSum_RAA.SuspendLayout();
            this.groupBoxThirdSum_RAA.SuspendLayout();
            this.groupBoxSecondSum_RAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_RAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_RAA.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunction_RAA.Legends.Add(legend2);
            this.chartFunction_RAA.Location = new System.Drawing.Point(453, 12);
            this.chartFunction_RAA.Name = "chartFunction_RAA";
            this.chartFunction_RAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_RAA.Series.Add(series2);
            this.chartFunction_RAA.Size = new System.Drawing.Size(300, 300);
            this.chartFunction_RAA.TabIndex = 0;
            this.chartFunction_RAA.Text = "chart1";
            // 
            // buttonOen_RAA
            // 
            this.buttonOen_RAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonOen_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOen_RAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.buttonOen_RAA.Location = new System.Drawing.Point(55, 72);
            this.buttonOen_RAA.Name = "buttonOen_RAA";
            this.buttonOen_RAA.Size = new System.Drawing.Size(122, 69);
            this.buttonOen_RAA.TabIndex = 1;
            this.buttonOen_RAA.Text = "Выберите файл";
            this.toolTip_RAA.SetToolTip(this.buttonOen_RAA, "Выберите, нужный файл, \r\nчтобы посмотреть элементы статистики");
            this.buttonOen_RAA.UseVisualStyleBackColor = false;
            this.buttonOen_RAA.Click += new System.EventHandler(this.buttonOen_RAA_Click);
            // 
            // groupBoxFirstSum_RAA
            // 
            this.groupBoxFirstSum_RAA.Controls.Add(this.textBoxFirst_RAA);
            this.groupBoxFirstSum_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFirstSum_RAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.groupBoxFirstSum_RAA.Location = new System.Drawing.Point(13, 162);
            this.groupBoxFirstSum_RAA.Name = "groupBoxFirstSum_RAA";
            this.groupBoxFirstSum_RAA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFirstSum_RAA.TabIndex = 2;
            this.groupBoxFirstSum_RAA.TabStop = false;
            this.groupBoxFirstSum_RAA.Text = "Кол-во преподователей 1-ой кафедры";
            // 
            // groupBoxThirdSum_RAA
            // 
            this.groupBoxThirdSum_RAA.Controls.Add(this.textBoxThird_RAA);
            this.groupBoxThirdSum_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxThirdSum_RAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.groupBoxThirdSum_RAA.Location = new System.Drawing.Point(230, 162);
            this.groupBoxThirdSum_RAA.Name = "groupBoxThirdSum_RAA";
            this.groupBoxThirdSum_RAA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxThirdSum_RAA.TabIndex = 2;
            this.groupBoxThirdSum_RAA.TabStop = false;
            this.groupBoxThirdSum_RAA.Text = "Кол-во преподователей 3-ей кафедры";
            // 
            // groupBoxSecondSum_RAA
            // 
            this.groupBoxSecondSum_RAA.Controls.Add(this.textBoxSecond_RAA);
            this.groupBoxSecondSum_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSecondSum_RAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.groupBoxSecondSum_RAA.Location = new System.Drawing.Point(230, 56);
            this.groupBoxSecondSum_RAA.Name = "groupBoxSecondSum_RAA";
            this.groupBoxSecondSum_RAA.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSecondSum_RAA.TabIndex = 2;
            this.groupBoxSecondSum_RAA.TabStop = false;
            this.groupBoxSecondSum_RAA.Text = "Кол-во преподователей 2-ой кафедры";
            // 
            // toolTip_RAA
            // 
            this.toolTip_RAA.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_RAA
            // 
            this.openFileDialog_RAA.FileName = "openFileDialog1";
            // 
            // textBoxSecond_RAA
            // 
            this.textBoxSecond_RAA.Location = new System.Drawing.Point(6, 54);
            this.textBoxSecond_RAA.Name = "textBoxSecond_RAA";
            this.textBoxSecond_RAA.Size = new System.Drawing.Size(188, 22);
            this.textBoxSecond_RAA.TabIndex = 0;
            // 
            // textBoxThird_RAA
            // 
            this.textBoxThird_RAA.Location = new System.Drawing.Point(6, 59);
            this.textBoxThird_RAA.Name = "textBoxThird_RAA";
            this.textBoxThird_RAA.Size = new System.Drawing.Size(188, 22);
            this.textBoxThird_RAA.TabIndex = 0;
            // 
            // textBoxFirst_RAA
            // 
            this.textBoxFirst_RAA.Location = new System.Drawing.Point(6, 59);
            this.textBoxFirst_RAA.Name = "textBoxFirst_RAA";
            this.textBoxFirst_RAA.Size = new System.Drawing.Size(188, 22);
            this.textBoxFirst_RAA.TabIndex = 0;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(766, 333);
            this.Controls.Add(this.groupBoxSecondSum_RAA);
            this.Controls.Add(this.groupBoxThirdSum_RAA);
            this.Controls.Add(this.groupBoxFirstSum_RAA);
            this.Controls.Add(this.buttonOen_RAA);
            this.Controls.Add(this.chartFunction_RAA);
            this.Name = "FormStatistic";
            this.Text = "FormStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).EndInit();
            this.groupBoxFirstSum_RAA.ResumeLayout(false);
            this.groupBoxFirstSum_RAA.PerformLayout();
            this.groupBoxThirdSum_RAA.ResumeLayout(false);
            this.groupBoxThirdSum_RAA.PerformLayout();
            this.groupBoxSecondSum_RAA.ResumeLayout(false);
            this.groupBoxSecondSum_RAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_RAA;
        private System.Windows.Forms.Button buttonOen_RAA;
        private System.Windows.Forms.GroupBox groupBoxFirstSum_RAA;
        private System.Windows.Forms.GroupBox groupBoxThirdSum_RAA;
        private System.Windows.Forms.GroupBox groupBoxSecondSum_RAA;
        private System.Windows.Forms.ToolTip toolTip_RAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_RAA;
        private System.Windows.Forms.TextBox textBoxFirst_RAA;
        private System.Windows.Forms.TextBox textBoxThird_RAA;
        private System.Windows.Forms.TextBox textBoxSecond_RAA;
    }
}