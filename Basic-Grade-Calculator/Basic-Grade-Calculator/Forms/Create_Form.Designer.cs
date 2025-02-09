namespace Basic_Grade_Calculator.Forms
  {
  partial class Create_Form
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
      this.dataGridViewCreateTemplate = new System.Windows.Forms.DataGridView();
      this.buttonSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreateTemplate)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewCreateTemplate
      // 
      this.dataGridViewCreateTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCreateTemplate.Location = new System.Drawing.Point(12, 12);
      this.dataGridViewCreateTemplate.Name = "dataGridViewCreateTemplate";
      this.dataGridViewCreateTemplate.RowHeadersWidth = 72;
      this.dataGridViewCreateTemplate.RowTemplate.Height = 31;
      this.dataGridViewCreateTemplate.Size = new System.Drawing.Size(617, 556);
      this.dataGridViewCreateTemplate.TabIndex = 0;
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(12, 574);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(617, 67);
      this.buttonSave.TabIndex = 1;
      this.buttonSave.Text = "Save grading template";
      this.buttonSave.UseVisualStyleBackColor = true;
      // 
      // Create_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(641, 653);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.dataGridViewCreateTemplate);
      this.Name = "Create_Form";
      this.Text = "Create grading template";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreateTemplate)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.DataGridView dataGridViewCreateTemplate;
    private System.Windows.Forms.Button buttonSave;
    }
  }