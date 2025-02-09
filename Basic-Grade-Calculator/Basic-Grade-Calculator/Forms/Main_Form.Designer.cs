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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.richTextBox2 = new System.Windows.Forms.RichTextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
      this.button5 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
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
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 361);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(226, 36);
      this.button1.TabIndex = 2;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 403);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(226, 36);
      this.button2.TabIndex = 3;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
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
      // chart2
      // 
      chartArea2.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chart2.Legends.Add(legend2);
      this.chart2.Location = new System.Drawing.Point(651, 12);
      this.chart2.Name = "chart2";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart2.Series.Add(series2);
      this.chart2.Size = new System.Drawing.Size(490, 427);
      this.chart2.TabIndex = 6;
      this.chart2.Text = "chart2";
      // 
      // chart3
      // 
      chartArea3.Name = "ChartArea1";
      this.chart3.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart3.Legends.Add(legend3);
      this.chart3.Location = new System.Drawing.Point(1147, 15);
      this.chart3.Name = "chart3";
      series3.ChartArea = "ChartArea1";
      series3.Legend = "Legend1";
      series3.Name = "Series1";
      this.chart3.Series.Add(series3);
      this.chart3.Size = new System.Drawing.Size(401, 342);
      this.chart3.TabIndex = 8;
      this.chart3.Text = "chart3";
      // 
      // richTextBox2
      // 
      this.richTextBox2.Location = new System.Drawing.Point(1147, 364);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new System.Drawing.Size(401, 78);
      this.richTextBox2.TabIndex = 7;
      this.richTextBox2.Text = "";
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(1554, 406);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(226, 36);
      this.button3.TabIndex = 11;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(1554, 364);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(226, 36);
      this.button4.TabIndex = 10;
      this.button4.Text = "button4";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // checkedListBox2
      // 
      this.checkedListBox2.FormattingEnabled = true;
      this.checkedListBox2.Location = new System.Drawing.Point(1554, 15);
      this.checkedListBox2.Name = "checkedListBox2";
      this.checkedListBox2.Size = new System.Drawing.Size(226, 342);
      this.checkedListBox2.TabIndex = 9;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(12, 445);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(1768, 54);
      this.button5.TabIndex = 12;
      this.button5.Text = "button5";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1788, 513);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.checkedListBox2);
      this.Controls.Add(this.chart3);
      this.Controls.Add(this.richTextBox2);
      this.Controls.Add(this.chart2);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.checkedListBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.CheckedListBox checkedListBox2;
    private System.Windows.Forms.Button button5;
    }
  }

