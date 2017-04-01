namespace VoxPopuli
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageApproval = new System.Windows.Forms.TabPage();
      this.buttonOption1 = new System.Windows.Forms.Button();
      this.groupBoxRight = new System.Windows.Forms.GroupBox();
      this.labelScoreR = new System.Windows.Forms.Label();
      this.scoreBindingSourceR = new System.Windows.Forms.BindingSource(this.components);
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.trackBarRApproval = new System.Windows.Forms.TrackBar();
      this.groupBoxCentre = new System.Windows.Forms.GroupBox();
      this.labelScoreC = new System.Windows.Forms.Label();
      this.scoreBindingSourceC = new System.Windows.Forms.BindingSource(this.components);
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.trackBarCApproval = new System.Windows.Forms.TrackBar();
      this.groupBoxLeft = new System.Windows.Forms.GroupBox();
      this.labelScoreL = new System.Windows.Forms.Label();
      this.scoreBindingSourceL = new System.Windows.Forms.BindingSource(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.trackBarLApproval = new System.Windows.Forms.TrackBar();
      this.label4 = new System.Windows.Forms.Label();
      this.tabPageQuestions = new System.Windows.Forms.TabPage();
      this.textBoxPmLog = new System.Windows.Forms.TextBox();
      this.listBoxPmLog = new System.Windows.Forms.ListBox();
      this.pmQuestions = new VoxPopuli.PMQuestions_Table();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.groupBoxFLeft = new System.Windows.Forms.GroupBox();
      this.labelScoreFarL = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.trackBarFLApproval = new System.Windows.Forms.TrackBar();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBoxFRight = new System.Windows.Forms.GroupBox();
      this.label1ScoreFRight = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.trackBarFRApproval = new System.Windows.Forms.TrackBar();
      this.tabControl1.SuspendLayout();
      this.tabPageApproval.SuspendLayout();
      this.groupBoxRight.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSourceR)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarRApproval)).BeginInit();
      this.groupBoxCentre.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSourceC)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarCApproval)).BeginInit();
      this.groupBoxLeft.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSourceL)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarLApproval)).BeginInit();
      this.tabPageQuestions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pmQuestions)).BeginInit();
      this.groupBoxFLeft.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarFLApproval)).BeginInit();
      this.groupBoxFRight.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarFRApproval)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageApproval);
      this.tabControl1.Controls.Add(this.tabPageQuestions);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(784, 599);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPageApproval
      // 
      this.tabPageApproval.Controls.Add(this.groupBoxFRight);
      this.tabPageApproval.Controls.Add(this.groupBoxFLeft);
      this.tabPageApproval.Controls.Add(this.buttonOption1);
      this.tabPageApproval.Controls.Add(this.groupBoxRight);
      this.tabPageApproval.Controls.Add(this.groupBoxCentre);
      this.tabPageApproval.Controls.Add(this.groupBoxLeft);
      this.tabPageApproval.Location = new System.Drawing.Point(4, 22);
      this.tabPageApproval.Name = "tabPageApproval";
      this.tabPageApproval.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageApproval.Size = new System.Drawing.Size(776, 573);
      this.tabPageApproval.TabIndex = 0;
      this.tabPageApproval.Text = "Approval";
      this.tabPageApproval.UseVisualStyleBackColor = true;
      // 
      // buttonOption1
      // 
      this.buttonOption1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOption1.Location = new System.Drawing.Point(658, 536);
      this.buttonOption1.Name = "buttonOption1";
      this.buttonOption1.Size = new System.Drawing.Size(110, 23);
      this.buttonOption1.TabIndex = 3;
      this.buttonOption1.Text = "PM Questions";
      this.buttonOption1.UseVisualStyleBackColor = true;
      this.buttonOption1.Click += new System.EventHandler(this.buttonOption1_Click);
      // 
      // groupBoxRight
      // 
      this.groupBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxRight.Controls.Add(this.labelScoreR);
      this.groupBoxRight.Controls.Add(this.label7);
      this.groupBoxRight.Controls.Add(this.label8);
      this.groupBoxRight.Controls.Add(this.trackBarRApproval);
      this.groupBoxRight.Location = new System.Drawing.Point(8, 324);
      this.groupBoxRight.Name = "groupBoxRight";
      this.groupBoxRight.Size = new System.Drawing.Size(760, 100);
      this.groupBoxRight.TabIndex = 2;
      this.groupBoxRight.TabStop = false;
      this.groupBoxRight.Text = "Conservatist";
      // 
      // labelScoreR
      // 
      this.labelScoreR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelScoreR.AutoSize = true;
      this.labelScoreR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoreBindingSourceR, "RStr", true));
      this.labelScoreR.Location = new System.Drawing.Point(364, 67);
      this.labelScoreR.Name = "labelScoreR";
      this.labelScoreR.Size = new System.Drawing.Size(27, 13);
      this.labelScoreR.TabIndex = 11;
      this.labelScoreR.Text = "50%";
      this.labelScoreR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // scoreBindingSourceR
      // 
      this.scoreBindingSourceR.DataSource = typeof(VoxPopuli.Score);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(678, 67);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(76, 13);
      this.label7.TabIndex = 5;
      this.label7.Text = "Total Approval";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(7, 67);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(84, 13);
      this.label8.TabIndex = 4;
      this.label8.Text = "Total Opposition";
      // 
      // trackBarRApproval
      // 
      this.trackBarRApproval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarRApproval.BackColor = System.Drawing.SystemColors.Window;
      this.trackBarRApproval.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scoreBindingSourceR, "R", true));
      this.trackBarRApproval.Location = new System.Drawing.Point(7, 15);
      this.trackBarRApproval.Maximum = 100;
      this.trackBarRApproval.Name = "trackBarRApproval";
      this.trackBarRApproval.Size = new System.Drawing.Size(747, 45);
      this.trackBarRApproval.TabIndex = 3;
      this.trackBarRApproval.TickFrequency = 5;
      this.trackBarRApproval.ValueChanged += new System.EventHandler(this.trackBarRApproval_ValueChanged);
      // 
      // groupBoxCentre
      // 
      this.groupBoxCentre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxCentre.Controls.Add(this.labelScoreC);
      this.groupBoxCentre.Controls.Add(this.label5);
      this.groupBoxCentre.Controls.Add(this.label6);
      this.groupBoxCentre.Controls.Add(this.trackBarCApproval);
      this.groupBoxCentre.Location = new System.Drawing.Point(8, 218);
      this.groupBoxCentre.Name = "groupBoxCentre";
      this.groupBoxCentre.Size = new System.Drawing.Size(760, 100);
      this.groupBoxCentre.TabIndex = 2;
      this.groupBoxCentre.TabStop = false;
      this.groupBoxCentre.Text = "Central";
      // 
      // labelScoreC
      // 
      this.labelScoreC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelScoreC.AutoSize = true;
      this.labelScoreC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoreBindingSourceC, "CStr", true));
      this.labelScoreC.Location = new System.Drawing.Point(362, 67);
      this.labelScoreC.Name = "labelScoreC";
      this.labelScoreC.Size = new System.Drawing.Size(27, 13);
      this.labelScoreC.TabIndex = 10;
      this.labelScoreC.Text = "50%";
      this.labelScoreC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // scoreBindingSourceC
      // 
      this.scoreBindingSourceC.DataSource = typeof(VoxPopuli.Score);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(678, 67);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(76, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Total Approval";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 67);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(84, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "Total Opposition";
      // 
      // trackBarCApproval
      // 
      this.trackBarCApproval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarCApproval.BackColor = System.Drawing.SystemColors.Window;
      this.trackBarCApproval.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scoreBindingSourceC, "C", true));
      this.trackBarCApproval.Location = new System.Drawing.Point(7, 15);
      this.trackBarCApproval.Maximum = 100;
      this.trackBarCApproval.Name = "trackBarCApproval";
      this.trackBarCApproval.Size = new System.Drawing.Size(747, 45);
      this.trackBarCApproval.TabIndex = 6;
      this.trackBarCApproval.TickFrequency = 5;
      this.trackBarCApproval.ValueChanged += new System.EventHandler(this.trackBarCApproval_ValueChanged);
      // 
      // groupBoxLeft
      // 
      this.groupBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxLeft.Controls.Add(this.labelScoreL);
      this.groupBoxLeft.Controls.Add(this.label3);
      this.groupBoxLeft.Controls.Add(this.trackBarLApproval);
      this.groupBoxLeft.Controls.Add(this.label4);
      this.groupBoxLeft.Location = new System.Drawing.Point(8, 112);
      this.groupBoxLeft.Name = "groupBoxLeft";
      this.groupBoxLeft.Size = new System.Drawing.Size(760, 100);
      this.groupBoxLeft.TabIndex = 1;
      this.groupBoxLeft.TabStop = false;
      this.groupBoxLeft.Text = "Liberal";
      // 
      // labelScoreL
      // 
      this.labelScoreL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelScoreL.AutoSize = true;
      this.labelScoreL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoreBindingSourceL, "LStr", true));
      this.labelScoreL.Location = new System.Drawing.Point(362, 67);
      this.labelScoreL.Name = "labelScoreL";
      this.labelScoreL.Size = new System.Drawing.Size(27, 13);
      this.labelScoreL.TabIndex = 9;
      this.labelScoreL.Text = "50%";
      this.labelScoreL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // scoreBindingSourceL
      // 
      this.scoreBindingSourceL.DataSource = typeof(VoxPopuli.Score);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(678, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Total Approval";
      // 
      // trackBarLApproval
      // 
      this.trackBarLApproval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarLApproval.BackColor = System.Drawing.SystemColors.Window;
      this.trackBarLApproval.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scoreBindingSourceL, "L", true));
      this.trackBarLApproval.Location = new System.Drawing.Point(7, 15);
      this.trackBarLApproval.Maximum = 100;
      this.trackBarLApproval.Name = "trackBarLApproval";
      this.trackBarLApproval.Size = new System.Drawing.Size(747, 45);
      this.trackBarLApproval.TabIndex = 6;
      this.trackBarLApproval.TickFrequency = 5;
      this.trackBarLApproval.ValueChanged += new System.EventHandler(this.trackBarLApproval_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(7, 67);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(84, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Total Opposition";
      // 
      // tabPageQuestions
      // 
      this.tabPageQuestions.Controls.Add(this.textBoxPmLog);
      this.tabPageQuestions.Controls.Add(this.listBoxPmLog);
      this.tabPageQuestions.Location = new System.Drawing.Point(4, 22);
      this.tabPageQuestions.Name = "tabPageQuestions";
      this.tabPageQuestions.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageQuestions.Size = new System.Drawing.Size(776, 548);
      this.tabPageQuestions.TabIndex = 1;
      this.tabPageQuestions.Text = "Prime Ministers Questions";
      this.tabPageQuestions.UseVisualStyleBackColor = true;
      // 
      // textBoxPmLog
      // 
      this.textBoxPmLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxPmLog.BackColor = System.Drawing.SystemColors.Window;
      this.textBoxPmLog.Location = new System.Drawing.Point(8, 378);
      this.textBoxPmLog.Multiline = true;
      this.textBoxPmLog.Name = "textBoxPmLog";
      this.textBoxPmLog.Size = new System.Drawing.Size(760, 130);
      this.textBoxPmLog.TabIndex = 2;
      // 
      // listBoxPmLog
      // 
      this.listBoxPmLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBoxPmLog.BackColor = System.Drawing.SystemColors.Window;
      this.listBoxPmLog.DisplayMember = "Question";
      this.listBoxPmLog.FormattingEnabled = true;
      this.listBoxPmLog.Location = new System.Drawing.Point(8, 13);
      this.listBoxPmLog.Name = "listBoxPmLog";
      this.listBoxPmLog.ScrollAlwaysVisible = true;
      this.listBoxPmLog.Size = new System.Drawing.Size(760, 355);
      this.listBoxPmLog.TabIndex = 1;
      this.listBoxPmLog.SelectedIndexChanged += new System.EventHandler(this.listBoxPmLog_SelectedIndexChanged);
      // 
      // pmQuestions
      // 
      this.pmQuestions.DataSetName = "PMQuestions_Table";
      this.pmQuestions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 599);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(784, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // groupBoxFLeft
      // 
      this.groupBoxFLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxFLeft.Controls.Add(this.labelScoreFarL);
      this.groupBoxFLeft.Controls.Add(this.label2);
      this.groupBoxFLeft.Controls.Add(this.trackBarFLApproval);
      this.groupBoxFLeft.Controls.Add(this.label9);
      this.groupBoxFLeft.Location = new System.Drawing.Point(8, 6);
      this.groupBoxFLeft.Name = "groupBoxFLeft";
      this.groupBoxFLeft.Size = new System.Drawing.Size(760, 100);
      this.groupBoxFLeft.TabIndex = 10;
      this.groupBoxFLeft.TabStop = false;
      this.groupBoxFLeft.Text = "Far-Left";
      // 
      // labelScoreFarL
      // 
      this.labelScoreFarL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelScoreFarL.AutoSize = true;
      this.labelScoreFarL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoreBindingSourceL, "FLStr", true));
      this.labelScoreFarL.Location = new System.Drawing.Point(362, 67);
      this.labelScoreFarL.Name = "labelScoreFarL";
      this.labelScoreFarL.Size = new System.Drawing.Size(27, 13);
      this.labelScoreFarL.TabIndex = 9;
      this.labelScoreFarL.Text = "50%";
      this.labelScoreFarL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(678, 67);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Total Approval";
      // 
      // trackBarFLApproval
      // 
      this.trackBarFLApproval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarFLApproval.BackColor = System.Drawing.SystemColors.Window;
      this.trackBarFLApproval.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scoreBindingSourceL, "FL", true));
      this.trackBarFLApproval.Location = new System.Drawing.Point(7, 15);
      this.trackBarFLApproval.Maximum = 100;
      this.trackBarFLApproval.Name = "trackBarFLApproval";
      this.trackBarFLApproval.Size = new System.Drawing.Size(747, 45);
      this.trackBarFLApproval.TabIndex = 6;
      this.trackBarFLApproval.TickFrequency = 5;
      this.trackBarFLApproval.VisibleChanged += new System.EventHandler(this.trackBarFLApproval_VisibleChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(7, 67);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(84, 13);
      this.label9.TabIndex = 7;
      this.label9.Text = "Total Opposition";
      // 
      // groupBoxFRight
      // 
      this.groupBoxFRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxFRight.Controls.Add(this.label1ScoreFRight);
      this.groupBoxFRight.Controls.Add(this.label11);
      this.groupBoxFRight.Controls.Add(this.label12);
      this.groupBoxFRight.Controls.Add(this.trackBarFRApproval);
      this.groupBoxFRight.Location = new System.Drawing.Point(8, 430);
      this.groupBoxFRight.Name = "groupBoxFRight";
      this.groupBoxFRight.Size = new System.Drawing.Size(760, 100);
      this.groupBoxFRight.TabIndex = 12;
      this.groupBoxFRight.TabStop = false;
      this.groupBoxFRight.Text = "Far-Right";
      // 
      // label1ScoreFRight
      // 
      this.label1ScoreFRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1ScoreFRight.AutoSize = true;
      this.label1ScoreFRight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scoreBindingSourceR, "FRStr", true));
      this.label1ScoreFRight.Location = new System.Drawing.Point(364, 67);
      this.label1ScoreFRight.Name = "label1ScoreFRight";
      this.label1ScoreFRight.Size = new System.Drawing.Size(27, 13);
      this.label1ScoreFRight.TabIndex = 11;
      this.label1ScoreFRight.Text = "50%";
      this.label1ScoreFRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(678, 67);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(76, 13);
      this.label11.TabIndex = 5;
      this.label11.Text = "Total Approval";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(7, 67);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(84, 13);
      this.label12.TabIndex = 4;
      this.label12.Text = "Total Opposition";
      // 
      // trackBarFRApproval
      // 
      this.trackBarFRApproval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarFRApproval.BackColor = System.Drawing.SystemColors.Window;
      this.trackBarFRApproval.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scoreBindingSourceR, "FR", true));
      this.trackBarFRApproval.Location = new System.Drawing.Point(7, 15);
      this.trackBarFRApproval.Maximum = 100;
      this.trackBarFRApproval.Name = "trackBarFRApproval";
      this.trackBarFRApproval.Size = new System.Drawing.Size(747, 45);
      this.trackBarFRApproval.TabIndex = 3;
      this.trackBarFRApproval.TickFrequency = 5;
      this.trackBarFRApproval.VisibleChanged += new System.EventHandler(this.trackBarFRApproval_VisibleChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 621);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.statusStrip1);
      this.MinimumSize = new System.Drawing.Size(800, 660);
      this.Name = "MainForm";
      this.Text = "The Voice Of The People";
      this.tabControl1.ResumeLayout(false);
      this.tabPageApproval.ResumeLayout(false);
      this.groupBoxRight.ResumeLayout(false);
      this.groupBoxRight.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSourceR)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarRApproval)).EndInit();
      this.groupBoxCentre.ResumeLayout(false);
      this.groupBoxCentre.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSourceC)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarCApproval)).EndInit();
      this.groupBoxLeft.ResumeLayout(false);
      this.groupBoxLeft.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSourceL)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarLApproval)).EndInit();
      this.tabPageQuestions.ResumeLayout(false);
      this.tabPageQuestions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pmQuestions)).EndInit();
      this.groupBoxFLeft.ResumeLayout(false);
      this.groupBoxFLeft.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarFLApproval)).EndInit();
      this.groupBoxFRight.ResumeLayout(false);
      this.groupBoxFRight.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarFRApproval)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageApproval;
    private System.Windows.Forms.TabPage tabPageQuestions;
    private System.Windows.Forms.TextBox textBoxPmLog;
    private System.Windows.Forms.ListBox listBoxPmLog;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.GroupBox groupBoxLeft;
    private System.Windows.Forms.GroupBox groupBoxRight;
    private System.Windows.Forms.GroupBox groupBoxCentre;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TrackBar trackBarRApproval;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TrackBar trackBarCApproval;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar trackBarLApproval;
    private System.Windows.Forms.Label label4;
    private PMQuestions_Table pmQuestions;
    private System.Windows.Forms.Button buttonOption1;
    private System.Windows.Forms.BindingSource scoreBindingSourceR;
    private System.Windows.Forms.BindingSource scoreBindingSourceC;
    private System.Windows.Forms.BindingSource scoreBindingSourceL;
    private System.Windows.Forms.Label labelScoreR;
    private System.Windows.Forms.Label labelScoreC;
    private System.Windows.Forms.Label labelScoreL;
    private System.Windows.Forms.GroupBox groupBoxFRight;
    private System.Windows.Forms.Label label1ScoreFRight;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TrackBar trackBarFRApproval;
    private System.Windows.Forms.GroupBox groupBoxFLeft;
    private System.Windows.Forms.Label labelScoreFarL;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar trackBarFLApproval;
    private System.Windows.Forms.Label label9;
  }
}

