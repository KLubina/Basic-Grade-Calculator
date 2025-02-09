namespace Basic_Grade_Calculator.Forms
  {
  partial class Edit_Form
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
      this.buttonSave = new System.Windows.Forms.Button();
      this.dataGridViewEdit = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(12, 574);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(617, 67);
      this.buttonSave.TabIndex = 3;
      this.buttonSave.Text = "Save grading template";
      this.buttonSave.UseVisualStyleBackColor = true;
      // 
      // dataGridViewEdit
      // 
      this.dataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEdit.Location = new System.Drawing.Point(12, 12);
      this.dataGridViewEdit.Name = "dataGridViewEdit";
      this.dataGridViewEdit.RowHeadersWidth = 72;
      this.dataGridViewEdit.RowTemplate.Height = 31;
      this.dataGridViewEdit.Size = new System.Drawing.Size(617, 556);
      this.dataGridViewEdit.TabIndex = 2;
      // 
      // Edit_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(648, 652);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.dataGridViewEdit);
      this.Name = "Edit_Form";
      this.Text = "Edit grading template";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.DataGridView dataGridViewEdit;
    }
  }