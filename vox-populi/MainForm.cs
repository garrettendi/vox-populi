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
    public MainForm()
    {
      InitializeComponent();
      pmQuestions.ReadXml(@"..\..\PMQuestions.xml");

      this.StartPMQuestions();

      //PMQuestionsLogEntry entry = null;
      //for (int i = 0; i < pmQuestions.question.Count; i++)
      //{
      //  entry = new PMQuestionsLogEntry();
      //  entry.Question = pmQuestions.question[i].text;
      //  entry.Response = pmQuestions.question[i].GetresponsesRows().First().GetresponseRows().First().text;

      //  PMLog.Add(entry);
      //}

      listBoxPmLog.DataSource = PMLog;
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
      for (int i = 0; i < pmQuestions.question.Count; i++)
      {
        q = pmQuestions.question[i];
        popup = new QuestionPopup(QuestionType.PrimeMinister, q.text, q.GetresponsesRows().First().GetresponseRows().ToList());
        res = popup.ShowDialog();
        if (res == System.Windows.Forms.DialogResult.OK)
        {
          entry = new PMQuestionsLogEntry(q.text, "RESPONSE");
          PMLog.Add(entry);
        }
        else if (res == System.Windows.Forms.DialogResult.Cancel)
        {
          entry = new PMQuestionsLogEntry(q.text, "No futher questions!");
          PMLog.Add(entry);
          break;
        }
      }
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
  }
}
