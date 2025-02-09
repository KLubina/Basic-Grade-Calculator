namespace Basic_Grade_Calculator
  {
  partial class Main_Form
    {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
      {
      if ( disposing && ( components != null ) )
        {
        components.Dispose();
        }
      base.Dispose( disposing );
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.buttonDisplay1 = new System.Windows.Forms.Button();
      this.buttonEdit1 = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chartBig = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.richTextBox2 = new System.Windows.Forms.RichTextBox();
      this.buttonEdit2 = new System.Windows.Forms.Button();
      this.buttonDisplay2 = new System.Windows.Forms.Button();
      this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
      this.buttonCreateTemplate = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartBig)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      this.SuspendLayout();
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(226, 342);
      this.checkedListBox1.TabIndex = 1;
      // 
      // buttonDisplay1
      // 
      this.buttonDisplay1.Location = new System.Drawing.Point(12, 361);
      this.buttonDisplay1.Name = "buttonDisplay1";
      this.buttonDisplay1.Size = new System.Drawing.Size(226, 36);
      this.buttonDisplay1.TabIndex = 2;
      this.buttonDisplay1.Text = "Display";
      this.buttonDisplay1.UseVisualStyleBackColor = true;
      // 
      // buttonEdit1
      // 
      this.buttonEdit1.Location = new System.Drawing.Point(12, 403);
      this.buttonEdit1.Name = "buttonEdit1";
      this.buttonEdit1.Size = new System.Drawing.Size(226, 36);
      this.buttonEdit1.TabIndex = 3;
      this.buttonEdit1.Text = "Edit";
      this.buttonEdit1.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(244, 361);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(401, 78);
      this.richTextBox1.TabIndex = 4;
      this.richTextBox1.Text = "";
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(244, 12);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(401, 342);
      this.chart1.TabIndex = 5;
      this.chart1.Text = "chart1";
      // 
      // chartBig
      // 
      chartArea2.Name = "ChartArea1";
      this.chartBig.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chartBig.Legends.Add(legend2);
      this.chartBig.Location = new System.Drawing.Point(651, 12);
      this.chartBig.Name = "chartBig";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chartBig.Series.Add(series2);
      this.chartBig.Size = new System.Drawing.Size(490, 427);
      this.chartBig.TabIndex = 6;
      this.chartBig.Text = "chart2";
      // 
      // chart2
      // 
      chartArea3.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart2.Legends.Add(legend3);
      this.chart2.Location = new System.Drawing.Point(1147, 15);
      this.chart2.Name = "chart2";
      series3.ChartArea = "ChartArea1";
      series3.Legend = "Legend1";
      series3.Name = "Series1";
      this.chart2.Series.Add(series3);
      this.chart2.Size = new System.Drawing.Size(401, 342);
      this.chart2.TabIndex = 8;
      this.chart2.Text = "chart3";
      // 
      // richTextBox2
      // 
      this.richTextBox2.Location = new System.Drawing.Point(1147, 364);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new System.Drawing.Size(401, 78);
      this.richTextBox2.TabIndex = 7;
      this.richTextBox2.Text = "";
      // 
      // buttonEdit2
      // 
      this.buttonEdit2.Location = new System.Drawing.Point(1554, 406);
      this.buttonEdit2.Name = "buttonEdit2";
      this.buttonEdit2.Size = new System.Drawing.Size(226, 36);
      this.buttonEdit2.TabIndex = 11;
      this.buttonEdit2.Text = "Edit";
      this.buttonEdit2.UseVisualStyleBackColor = true;
      // 
      // buttonDisplay2
      // 
      this.buttonDisplay2.Location = new System.Drawing.Point(1554, 364);
      this.buttonDisplay2.Name = "buttonDisplay2";
      this.buttonDisplay2.Size = new System.Drawing.Size(226, 36);
      this.buttonDisplay2.TabIndex = 10;
      this.buttonDisplay2.Text = "Display";
      this.buttonDisplay2.UseVisualStyleBackColor = true;
      // 
      // checkedListBox2
      // 
      this.checkedListBox2.FormattingEnabled = true;
      this.checkedListBox2.Location = new System.Drawing.Point(1554, 15);
      this.checkedListBox2.Name = "checkedListBox2";
      this.checkedListBox2.Size = new System.Drawing.Size(226, 342);
      this.checkedListBox2.TabIndex = 9;
      // 
      // buttonCreateTemplate
      // 
      this.buttonCreateTemplate.Location = new System.Drawing.Point(12, 445);
      this.buttonCreateTemplate.Name = "buttonCreateTemplate";
      this.buttonCreateTemplate.Size = new System.Drawing.Size(1768, 54);
      this.buttonCreateTemplate.TabIndex = 12;
      this.buttonCreateTemplate.Text = "Create new grading template";
      this.buttonCreateTemplate.UseVisualStyleBackColor = true;
      // 
      // Main_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1788, 513);
      this.Controls.Add(this.buttonCreateTemplate);
      this.Controls.Add(this.buttonEdit2);
      this.Controls.Add(this.buttonDisplay2);
      this.Controls.Add(this.checkedListBox2);
      this.Controls.Add(this.chart2);
      this.Controls.Add(this.richTextBox2);
      this.Controls.Add(this.chartBig);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.buttonEdit1);
      this.Controls.Add(this.buttonDisplay1);
      this.Controls.Add(this.checkedListBox1);
      this.Name = "Main_Form";
      this.Text = "Grading Overview";
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chartBig)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.Button buttonDisplay1;
    private System.Windows.Forms.Button buttonEdit1;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartBig;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.Button buttonEdit2;
    private System.Windows.Forms.Button buttonDisplay2;
    private System.Windows.Forms.CheckedListBox checkedListBox2;
    private System.Windows.Forms.Button buttonCreateTemplate;
    }
  }

