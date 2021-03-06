﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoxPopuli
{
  public enum QuestionType
  {
    PrimeMinister,
    Journalist,
    Voter,
    Debate
  }

  public partial class QuestionPopup : Form
  {
    public QuestionPopup(QuestionType type, string question, List<VoxPopuli.PMQuestions_Table.responseRow> responses)
    {
      InitializeComponent();
     

      if (type != QuestionType.PrimeMinister)
        this.buttonFinish.Visible = false;

      this.labelQuestion.Text = question;

      this.comboBoxResponse.DataSource = responses;
      this.comboBoxResponse.DropDownWidth = DropDownWidth(comboBoxResponse);
    }

    // Javed Akram - cc by-sa 3.0 - https://creativecommons.org/licenses/by-sa/3.0/
    // http://stackoverflow.com/questions/4842160/auto-width-of-comboboxs-content
    int DropDownWidth(ComboBox myCombo)
    {
      int maxWidth = 0, temp = 0;
      foreach (DataRow obj in myCombo.Items)
      {
        temp = TextRenderer.MeasureText(obj["text"].ToString(), myCombo.Font).Width;
        if (temp > maxWidth)
        {
          maxWidth = temp;
        }
      }
      return maxWidth;
    }

    private VoxPopuli.PMQuestions_Table.responseRow response;
    public VoxPopuli.PMQuestions_Table.responseRow ResponseSelected
    {
      get { return response; }
    }

    private void buttonRespond_Click(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }

    private void buttonFinish_Click(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Close();
    }

    private void comboBoxResponse_SelectedValueChanged(object sender, EventArgs e)
    {
      response = comboBoxResponse.SelectedItem as VoxPopuli.PMQuestions_Table.responseRow;
    }
  }
}
