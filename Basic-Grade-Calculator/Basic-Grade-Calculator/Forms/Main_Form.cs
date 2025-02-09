using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Basic_Grade_Calculator
  {
  public partial class Main_Form: Form
    {
    private readonly TemplateManager templateManager;
    private List<GradingTemplate> loadedTemplates;

    public Main_Form()
      {
      InitializeComponent();
      templateManager = new TemplateManager();
      loadedTemplates = new List<GradingTemplate>();
      SetupEventHandlers();
      SetupCharts();
      LoadTemplates();
      }

    private void SetupEventHandlers()
      {
      // Button event handlers
      buttonCreateTemplate.Click += ButtonCreateTemplate_Click;
      buttonDisplay1.Click += ButtonDisplay1_Click;
      buttonDisplay2.Click += ButtonDisplay2_Click;
      buttonEdit1.Click += ButtonEdit1_Click;
      buttonEdit2.Click += ButtonEdit2_Click;

      // CheckedListBox event handlers
      checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;
      checkedListBox2.ItemCheck += CheckedListBox2_ItemCheck;

      // Form event handlers
      this.Load += Main_Form_Load;
      }

    private void SetupCharts()
      {
      // Setup left chart
      chart1.Series.Clear();
      var series1 = new Series( "Template 1" )
        {
        ChartType = SeriesChartType.Line,
        Color = Color.FromArgb( 65, 140, 240 ),
        MarkerStyle = MarkerStyle.Circle,
        MarkerSize = 8,
        BorderWidth = 3
        };
      chart1.Series.Add( series1 );
      ConfigureChartArea( chart1.ChartAreas[ 0 ] );

      // Setup center chart
      chartBig.Series.Clear();
      var seriesBig1 = new Series( "Template 1" )
        {
        ChartType = SeriesChartType.Line,
        Color = Color.FromArgb( 65, 140, 240 ),
        MarkerStyle = MarkerStyle.Circle,
        MarkerSize = 8,
        BorderWidth = 3
        };
      var seriesBig2 = new Series( "Template 2" )
        {
        ChartType = SeriesChartType.Line,
        Color = Color.FromArgb( 252, 180, 65 ),
        MarkerStyle = MarkerStyle.Circle,
        MarkerSize = 8,
        BorderWidth = 3
        };
      chartBig.Series.Add( seriesBig1 );
      chartBig.Series.Add( seriesBig2 );
      ConfigureChartArea( chartBig.ChartAreas[ 0 ] );

      // Setup right chart
      chart2.Series.Clear();
      var series2 = new Series( "Template 2" )
        {
        ChartType = SeriesChartType.Line,
        Color = Color.FromArgb( 252, 180, 65 ),
        MarkerStyle = MarkerStyle.Circle,
        MarkerSize = 8,
        BorderWidth = 3
        };
      chart2.Series.Add( series2 );
      ConfigureChartArea( chart2.ChartAreas[ 0 ] );
      }

    private void ConfigureChartArea( ChartArea chartArea )
      {
      chartArea.AxisY.Minimum = 0;
      chartArea.AxisY.Maximum = 6;
      chartArea.AxisY.Interval = 1;
      chartArea.AxisX.Interval = 1;
      chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
      chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
      }

    private void LoadTemplates()
      {
      checkedListBox1.Items.Clear();
      checkedListBox2.Items.Clear();
      loadedTemplates.Clear();

      foreach ( string templateName in templateManager.GetAllTemplates() )
        {
        var template = templateManager.LoadTemplate( templateName );
        if ( template != null )
          {
          loadedTemplates.Add( template );
          checkedListBox1.Items.Add( template.Name );
          checkedListBox2.Items.Add( template.Name );
          }
        }
      }

    private void ButtonCreateTemplate_Click( object sender, EventArgs e )
      {
      using ( var createForm = new Forms.Create_Form() )
        {
        if ( createForm.ShowDialog() == DialogResult.OK )
          {
          LoadTemplates();
          }
        }
      }

    private void ButtonEdit1_Click( object sender, EventArgs e )
      {
      EditTemplate( checkedListBox1 );
      }

    private void ButtonEdit2_Click( object sender, EventArgs e )
      {
      EditTemplate( checkedListBox2 );
      }

    private void EditTemplate( CheckedListBox listBox )
      {
      if ( listBox.SelectedItem == null )
        {
        MessageBox.Show( "Bitte wählen Sie eine Vorlage aus.",
            "Keine Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        return;
        }

      string templateName = listBox.SelectedItem.ToString();
      var template = loadedTemplates.Find( t => t.Name == templateName );

      if ( template != null )
        {
        using ( var editForm = new Forms.Edit_Form( template ) )
          {
          if ( editForm.ShowDialog() == DialogResult.OK )
            {
            LoadTemplates();
            UpdateCharts();
            }
          }
        }
      }

    private void UpdateCharts()
      {
      UpdateChart( checkedListBox1, chart1, richTextBox1 );
      UpdateChart( checkedListBox2, chart2, richTextBox2 );
      UpdateCombinedChart();
      }

    private void UpdateChart( CheckedListBox listBox, Chart chart, RichTextBox textBox )
      {
      chart.Series[ 0 ].Points.Clear();
      textBox.Clear();

      var selectedTemplate = GetSelectedTemplate( listBox );
      if ( selectedTemplate != null )
        {
        var sortedEntries = selectedTemplate.Entries
            .OrderBy( e => ExtractTestNumber( e.Subject ) )
            .ToList();

        for ( int i = 0; i < sortedEntries.Count; i++ )
          {
          var entry = sortedEntries[ i ];
          chart.Series[ 0 ].Points.AddXY( i + 1, entry.Grade );
          }

        double average = selectedTemplate.CalculateAverageGrade();
        textBox.AppendText( $"Durchschnittsnote: {average:F2}" );
        }
      }

    private void UpdateCombinedChart()
      {
      chartBig.Series[ 0 ].Points.Clear();
      chartBig.Series[ 1 ].Points.Clear();

      var template1 = GetSelectedTemplate( checkedListBox1 );
      var template2 = GetSelectedTemplate( checkedListBox2 );

      if ( template1 != null && template2 != null )
        {
        var entries1 = template1.Entries
            .OrderBy( e => ExtractTestNumber( e.Subject ) )
            .ToList();
        var entries2 = template2.Entries
            .OrderBy( e => ExtractTestNumber( e.Subject ) )
            .ToList();

        int maxCount = Math.Max( entries1.Count, entries2.Count );
        for ( int i = 0; i < maxCount; i++ )
          {
          if ( i < entries1.Count )
            {
            chartBig.Series[ 0 ].Points.AddXY( i + 1, entries1[ i ].Grade );
            }
          if ( i < entries2.Count )
            {
            chartBig.Series[ 1 ].Points.AddXY( i + 1, entries2[ i ].Grade );
            }
          }
        }
      }

    private int ExtractTestNumber( string subject )
      {
      try
        {
        var numbers = new string( subject.Where( c => char.IsDigit( c ) ).ToArray() );
        if ( !string.IsNullOrEmpty( numbers ) )
          {
          return int.Parse( numbers );
          }
        }
      catch { }
      return 999;
      }

    private GradingTemplate GetSelectedTemplate( CheckedListBox listBox )
      {
      if ( listBox.SelectedItem == null ) return null;
      string templateName = listBox.SelectedItem.ToString();
      return loadedTemplates.Find( t => t.Name == templateName );
      }

    private void ButtonDisplay1_Click( object sender, EventArgs e )
      {
      UpdateChart( checkedListBox1, chart1, richTextBox1 );
      UpdateCombinedChart();
      }

    private void ButtonDisplay2_Click( object sender, EventArgs e )
      {
      UpdateChart( checkedListBox2, chart2, richTextBox2 );
      UpdateCombinedChart();
      }

    private void CheckedListBox1_ItemCheck( object sender, ItemCheckEventArgs e )
      {
      for ( int i = 0; i < checkedListBox1.Items.Count; i++ )
        {
        if ( i != e.Index )
          {
          checkedListBox1.SetItemChecked( i, false );
          }
        }
      }

    private void CheckedListBox2_ItemCheck( object sender, ItemCheckEventArgs e )
      {
      for ( int i = 0; i < checkedListBox2.Items.Count; i++ )
        {
        if ( i != e.Index )
          {
          checkedListBox2.SetItemChecked( i, false );
          }
        }
      }

    private void Main_Form_Load( object sender, EventArgs e )
      {
      LoadTemplates();
      }
    }
  }