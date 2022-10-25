namespace skyetechRSMS
{
    partial class dashboardreports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_ir = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_ptv = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ptv)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_ir
            // 
            this.chart_ir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chart_ir.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsInterlaced = true;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.IsInterlaced = true;
            chartArea3.AxisX2.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Empty;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart_ir.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.IsTextAutoFit = false;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.TitleForeColor = System.Drawing.Color.White;
            legend3.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart_ir.Legends.Add(legend3);
            this.chart_ir.Location = new System.Drawing.Point(12, 12);
            this.chart_ir.Name = "chart_ir";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsVisibleInLegend = false;
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_ir.Series.Add(series3);
            this.chart_ir.Size = new System.Drawing.Size(789, 482);
            this.chart_ir.TabIndex = 2;
            this.chart_ir.Text = "Incident Report";
            // 
            // chart_ptv
            // 
            this.chart_ptv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chart_ptv.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.IsInterlaced = true;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart_ptv.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart_ptv.Legends.Add(legend4);
            this.chart_ptv.Location = new System.Drawing.Point(12, 553);
            this.chart_ptv.Name = "chart_ptv";
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 6;
            this.chart_ptv.Series.Add(series4);
            this.chart_ptv.Size = new System.Drawing.Size(789, 465);
            this.chart_ptv.TabIndex = 3;
            this.chart_ptv.Text = "PTV Request";
            // 
            // dashboardreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1657, 1026);
            this.Controls.Add(this.chart_ptv);
            this.Controls.Add(this.chart_ir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardreports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardreports";
            ((System.ComponentModel.ISupportInitialize)(this.chart_ir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ptv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ptv;
    }
}