using System;
using System.Windows.Forms;

namespace Basic_Grade_Calculator.Forms
  {
  public partial class Edit_Form: Form
    {
    private readonly GradingTemplate template;
    private readonly TemplateManager templateManager;
    private readonly string originalTemplateName;

    public Edit_Form( GradingTemplate templateToEdit )
      {
      InitializeComponent();
      template = templateToEdit;
      originalTemplateName = template.Name;
      templateManager = new TemplateManager();
      SetupDataGridView();
      LoadTemplateData();
      }

    private void SetupDataGridView()
      {
      // Add columns
      dataGridViewEdit.Columns.Add( "Subject", "Fach" );
      dataGridViewEdit.Columns.Add( "Grade", "Note" );
      dataGridViewEdit.Columns.Add( "Weight", "Gewichtung" );

      // Configure grid
      dataGridViewEdit.AllowUserToAddRows = true;
      dataGridViewEdit.AllowUserToDeleteRows = true;
      dataGridViewEdit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      // Add event handlers
      buttonSave.Click += ButtonSave_Click;
      }

    private void LoadTemplateData()
      {
      // Load existing entries into the DataGridView
      foreach ( var entry in template.Entries )
        {
        int rowIndex = dataGridViewEdit.Rows.Add();
        var row = dataGridViewEdit.Rows[ rowIndex ];
        row.Cells[ "Subject" ].Value = entry.Subject;
        row.Cells[ "Grade" ].Value = entry.Grade;
        row.Cells[ "Weight" ].Value = entry.Weight;
        }
      }

    private void ButtonSave_Click( object sender, EventArgs e )
      {
      try
        {
        // Validate and collect data
        template.Entries.Clear();
        bool hasErrors = false;

        foreach ( DataGridViewRow row in dataGridViewEdit.Rows )
          {
          if ( row.IsNewRow ) continue;

          if ( row.Cells[ "Subject" ].Value == null ||
              row.Cells[ "Grade" ].Value == null ||
              row.Cells[ "Weight" ].Value == null )
            {
            hasErrors = true;
            break;
            }

          var entry = new GradeEntry
            {
            Subject = row.Cells[ "Subject" ].Value.ToString(),
            Grade = Convert.ToDouble( row.Cells[ "Grade" ].Value ),
            Weight = Convert.ToDouble( row.Cells[ "Weight" ].Value )
            };

          if ( entry.Grade < 1 || entry.Grade > 6 || entry.Weight <= 0 )
            {
            hasErrors = true;
            break;
            }

          template.Entries.Add( entry );
          }

        if ( hasErrors || template.Entries.Count == 0 )
          {
          MessageBox.Show( "Bitte überprüfen Sie Ihre Eingaben. Noten müssen zwischen 1 und 6 liegen und Gewichtungen müssen positiv sein.",
              "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning );
          return;
          }

        // Create a temporary form for name input
        using ( Form prompt = new Form() )
          {
          prompt.Width = 400;
          prompt.Height = 150;
          prompt.Text = "Vorlage speichern";
          prompt.StartPosition = FormStartPosition.CenterParent;
          prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
          prompt.MaximizeBox = false;
          prompt.MinimizeBox = false;

          Label textLabel = new Label() { Left = 20, Top = 20, Text = "Geben Sie einen Namen für die Vorlage ein:" };
          TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = template.Name };
          Button confirmation = new Button() { Text = "OK", Left = 200, Width = 75, Top = 80, DialogResult = DialogResult.OK };
          Button cancel = new Button() { Text = "Abbrechen", Left = 285, Width = 75, Top = 80, DialogResult = DialogResult.Cancel };

          prompt.Controls.Add( textBox );
          prompt.Controls.Add( confirmation );
          prompt.Controls.Add( cancel );
          prompt.Controls.Add( textLabel );
          prompt.AcceptButton = confirmation;
          prompt.CancelButton = cancel;

          if ( prompt.ShowDialog() == DialogResult.OK )
            {
            string templateName = textBox.Text;
            if ( string.IsNullOrWhiteSpace( templateName ) )
              {
              MessageBox.Show( "Bitte geben Sie einen gültigen Namen ein.",
                  "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning );
              return;
              }

            // If name changed, delete old template file
            if ( templateName != originalTemplateName )
              {
              try
                {
                // Delete old template file if name changed
                var oldTemplatePath = System.IO.Path.Combine(
                    Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments ),
                    "IPA-Notenrechner Vorlagen",
                    originalTemplateName + ".xml" );
                if ( System.IO.File.Exists( oldTemplatePath ) )
                  {
                  System.IO.File.Delete( oldTemplatePath );
                  }
                }
              catch ( Exception )
                {
                // Ignore deletion errors
                }
              }

            template.Name = templateName;
            templateManager.SaveTemplate( template, templateName );

            MessageBox.Show( "Vorlage wurde erfolgreich gespeichert.",
                "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information );

            DialogResult = DialogResult.OK;
            Close();
            }
          }
        }
      catch ( Exception ex )
        {
        MessageBox.Show( $"Fehler beim Speichern der Vorlage: {ex.Message}",
            "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
      }
    }
  }