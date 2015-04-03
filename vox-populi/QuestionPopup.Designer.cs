namespace VoxPopuli
{
  partial class QuestionPopup
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
      this.buttonRespond = new System.Windows.Forms.Button();
      this.buttonFinish = new System.Windows.Forms.Button();
      this.comboBoxResponse = new System.Windows.Forms.ComboBox();
      this.labelResponse = new System.Windows.Forms.Label();
      this.labelQuestion = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonRespond
      // 
      this.buttonRespond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRespond.Location = new System.Drawing.Point(447, 138);
      this.buttonRespond.Name = "buttonRespond";
      this.buttonRespond.Size = new System.Drawing.Size(75, 23);
      this.buttonRespond.TabIndex = 0;
      this.buttonRespond.Text = "Respond";
      this.buttonRespond.UseVisualStyleBackColor = true;
      this.buttonRespond.Click += new System.EventHandler(this.buttonRespond_Click);
      // 
      // buttonFinish
      // 
      this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonFinish.Location = new System.Drawing.Point(12, 138);
      this.buttonFinish.Name = "buttonFinish";
      this.buttonFinish.Size = new System.Drawing.Size(137, 23);
      this.buttonFinish.TabIndex = 1;
      this.buttonFinish.Text = "No Further Questions";
      this.buttonFinish.UseVisualStyleBackColor = true;
      this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
      // 
      // comboBoxResponse
      // 
      this.comboBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxResponse.DisplayMember = "text";
      this.comboBoxResponse.FormattingEnabled = true;
      this.comboBoxResponse.Location = new System.Drawing.Point(77, 111);
      this.comboBoxResponse.Name = "comboBoxResponse";
      this.comboBoxResponse.Size = new System.Drawing.Size(445, 21);
      this.comboBoxResponse.TabIndex = 3;
      this.comboBoxResponse.Text = "RESPONSE";
      // 
      // labelResponse
      // 
      this.labelResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.labelResponse.AutoSize = true;
      this.labelResponse.Location = new System.Drawing.Point(13, 114);
      this.labelResponse.Name = "labelResponse";
      this.labelResponse.Size = new System.Drawing.Size(58, 13);
      this.labelResponse.TabIndex = 4;
      this.labelResponse.Text = "Response:";
      // 
      // labelQuestion
      // 
      this.labelQuestion.AutoSize = true;
      this.labelQuestion.Location = new System.Drawing.Point(13, 13);
      this.labelQuestion.MaximumSize = new System.Drawing.Size(500, 150);
      this.labelQuestion.Name = "labelQuestion";
      this.labelQuestion.Size = new System.Drawing.Size(63, 13);
      this.labelQuestion.TabIndex = 2;
      this.labelQuestion.Text = "QUESTION";
      // 
      // QuestionPopup
      // 
      this.AcceptButton = this.buttonRespond;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonFinish;
      this.ClientSize = new System.Drawing.Size(534, 172);
      this.ControlBox = false;
      this.Controls.Add(this.labelResponse);
      this.Controls.Add(this.comboBoxResponse);
      this.Controls.Add(this.labelQuestion);
      this.Controls.Add(this.buttonFinish);
      this.Controls.Add(this.buttonRespond);
      this.Name = "QuestionPopup";
      this.Text = "Question";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonRespond;
    private System.Windows.Forms.Button buttonFinish;
    private System.Windows.Forms.ComboBox comboBoxResponse;
    private System.Windows.Forms.Label labelResponse;
    private System.Windows.Forms.Label labelQuestion;
  }
}