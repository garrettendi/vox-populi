using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoxPopuli
{
  public partial class MainForm : Form
  {
    Score score;

    public MainForm(Score sc)
    {
      score = sc;

      InitializeComponent();
      pmQuestions.ReadXml(@"..\..\PMQuestions.xml");

      scoreBindingSourceL.DataSource = score;
      scoreBindingSourceC.DataSource = score;
      scoreBindingSourceR.DataSource = score;
    }

    private PMQuestionsLog pmlog = null;
    public PMQuestionsLog PMLog
    {
      get 
      {
        if (pmlog == null)
          pmlog = new PMQuestionsLog();
        return pmlog; 
      }
    }

    private void StartPMQuestions()
    {
      QuestionPopup popup = null;
      PMQuestions_Table.questionRow q = null;
      DialogResult res = DialogResult.None;
      PMQuestionsLogEntry entry = null;
      Random rand = new Random();
      int qn = 0;
      List<int> done = new List<int>();

      for (int i = 0; i < 3; i++)
      {
        qn = rand.Next(0, pmQuestions.question.Count);
        while (done.Contains(qn))
        {
          qn = rand.Next(0, pmQuestions.question.Count);
        }
        q = pmQuestions.question[qn];
        popup = new QuestionPopup(QuestionType.PrimeMinister, q.text, q.GetresponsesRows().First().GetresponseRows().ToList());
        res = popup.ShowDialog();
        if (res == System.Windows.Forms.DialogResult.OK)
        {
          done.Add(qn);
          ApplyScore(popup);
          entry = new PMQuestionsLogEntry(q.text, popup.ResponseSelected.text);
          PMLog.Add(entry);
        }
        else if (res == System.Windows.Forms.DialogResult.Cancel)
        {
          done.Add(qn);
          ApplyScore(popup);
          entry = new PMQuestionsLogEntry(q.text, "No further questions!");
          PMLog.Add(entry);
          break;
        }
      }
    }

    private void ApplyScore(QuestionPopup popup)
    {
      decimal fl, l, c, r, fr;

      fl = score.FL * (1 + popup.ResponseSelected.fl);
      l = score.L * (1 + popup.ResponseSelected.l);
      c = score.C * (1 + popup.ResponseSelected.c);
      r = score.R * (1 + popup.ResponseSelected.r);
      fr = score.FR * (1 + popup.ResponseSelected.fr);

      score.FL = (int)Math.Round(fl, MidpointRounding.AwayFromZero);
      score.L = (int)Math.Round(l, MidpointRounding.AwayFromZero);
      score.C = (int)Math.Round(c, MidpointRounding.AwayFromZero);
      score.R = (int)Math.Round(r, MidpointRounding.AwayFromZero);
      score.FR = (int)Math.Round(fr, MidpointRounding.AwayFromZero);

      if (score.FL > 100) score.FL = 100;
      if (score.L > 100) score.L = 100;
      if (score.C > 100) score.C = 100;
      if (score.R > 100) score.R = 100;
      if (score.FR > 100) score.FR = 100;

      if (score.FL < 0) score.FL = 0;
      if (score.L < 0) score.L = 0;
      if (score.C < 0) score.C = 0;
      if (score.R < 0) score.R = 0;
      if (score.FR < 0) score.FR = 0;
    }

    private void listBoxPmLog_SelectedIndexChanged(object sender, EventArgs e)
    {
      PMQuestionsLogEntry entry = listBoxPmLog.SelectedItem as PMQuestionsLogEntry;

      if (entry != null)
      {
        this.textBoxPmLog.Text = string.Format("Question: \"{0}\"\r\n\r\nResponse: \"{1}\"", entry.Question, entry.Response);
        return;
      }

      this.textBoxPmLog.Text = "";
    }

    private void buttonOption1_Click(object sender, EventArgs e)
    {
      this.StartPMQuestions();

      listBoxPmLog.DataSource = PMLog;
    }
    
    private void trackBarRApproval_ValueChanged(object sender, EventArgs e)
    {
      trackBarRApproval.Value = score.R;
    }

    private void trackBarLApproval_ValueChanged(object sender, EventArgs e)
    {
      trackBarLApproval.Value = score.L;
    }

    private void trackBarCApproval_ValueChanged(object sender, EventArgs e)
    {
      trackBarCApproval.Value = score.C;
    }

    private void trackBarFRApproval_VisibleChanged(object sender, EventArgs e)
    {
      trackBarFRApproval.Value = score.FR;
    }

    private void trackBarFLApproval_VisibleChanged(object sender, EventArgs e)
    {
      trackBarFLApproval.Value = score.FL;
    }
  }
}
