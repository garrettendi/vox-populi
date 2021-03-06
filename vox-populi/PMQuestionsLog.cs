﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuli
{
  [Serializable]
  public class PMQuestionsLogEntry
  {
    public PMQuestionsLogEntry(string q, string r)
    {
      Question = q;
      Response = r;
    }

    public string Question { get; set; }
    public string Response { get; set; }
  }

  public class PMQuestionsLog : BindingList<PMQuestionsLogEntry>
  {
  }
}
