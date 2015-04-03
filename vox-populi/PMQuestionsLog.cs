using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuli
{
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

  public class PMQuestionsLog : List<PMQuestionsLogEntry>
  {
  }
}
