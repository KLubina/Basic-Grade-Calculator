using System;
using System.Windows.Forms;

namespace Basic_Grade_Calculator.Forms
  {
  public partial class Create_Form: Form
    {
    private readonly GradingTemplate template;
    private readonly TemplateManager templateManager;

    public Create_Form()
      {
      InitializeComponent();
      template = new GradingTemplate();
      templateManager = new TemplateManager();
      SetupDataGridView();
      }

    private void SetupDataGridView()
      {
      // Add columns
      dataGridViewCreateTemplate.Columns.Add( "Subject", "Fach" );
      dataGridViewCreateTemplate.Columns.Add( "Grade", "Note" );
      dataGridViewCreateTemplate.Columns.Add( "Weight", "Gewichtung" );

      // Configure grid
      dataGridViewCreateTemplate.AllowUserToAddRows = true;
      dataGridViewCreateTemplate.AllowUserToDeleteRows = true;
      dataGridViewCreateTemplate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      // Add event handlers
      buttonSave.Click += ButtonSave_Click;
      }

    private void ButtonSave_Click( object sender, EventArgs e )
      {
      try
        {
        // Validate and collect data
        template.Entries.Clear();
        bool hasErrors = false;

        foreach ( DataGridViewRow row in dataGridViewCreateTemplate.Rows )
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
          TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
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