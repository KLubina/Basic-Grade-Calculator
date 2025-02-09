using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Basic_Grade_Calculator
  {
  // Model class to represent a single grade entry
  [Serializable]
  public class GradeEntry
    {
    public string Subject { get; set; }
    public double Grade { get; set; }
    public double Weight { get; set; }
    }

  // Model class to represent a grading template
  [Serializable]
  public class GradingTemplate
    {
    public List<GradeEntry> Entries { get; set; }
    public string Name { get; set; }

    public GradingTemplate()
      {
      Entries = new List<GradeEntry>();
      }

    public double CalculateAverageGrade()
      {
      if ( Entries.Count == 0 ) return 0;

      double totalWeight = 0;
      double weightedSum = 0;

      foreach ( var entry in Entries )
        {
        weightedSum += entry.Grade * entry.Weight;
        totalWeight += entry.Weight;
        }

      return totalWeight == 0 ? 0 : weightedSum / totalWeight;
      }
    }

  public class TemplateManager
    {
    private static readonly string TemplateFolder = Path.Combine(
        Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments ),
        "IPA-Notenrechner Vorlagen" );

    public TemplateManager()
      {
      if ( !Directory.Exists( TemplateFolder ) )
        {
        Directory.CreateDirectory( TemplateFolder );
        }
      }

    public void SaveTemplate( GradingTemplate template, string filename )
      {
      string fullPath = Path.Combine( TemplateFolder, filename + ".xml" );
      XmlSerializer serializer = new XmlSerializer( typeof( GradingTemplate ) );

      using ( StreamWriter writer = new StreamWriter( fullPath ) )
        {
        serializer.Serialize( writer, template );
        }
      }

    public GradingTemplate LoadTemplate( string filename )
      {
      string fullPath = Path.Combine( TemplateFolder, filename + ".xml" );
      if ( !File.Exists( fullPath ) ) return null;

      XmlSerializer serializer = new XmlSerializer( typeof( GradingTemplate ) );
      using ( StreamReader reader = new StreamReader( fullPath ) )
        {
        return (GradingTemplate) serializer.Deserialize( reader );
        }
      }

    public List<string> GetAllTemplates()
      {
      List<string> templates = new List<string>();
      if ( Directory.Exists( TemplateFolder ) )
        {
        string[] files = Directory.GetFiles( TemplateFolder, "*.xml" );
        foreach ( string file in files )
          {
          templates.Add( Path.GetFileNameWithoutExtension( file ) );
          }
        }
      return templates;
      }
    }
  }