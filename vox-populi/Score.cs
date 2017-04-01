using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuli
{
  [Serializable]
  public class Score : INotifyPropertyChanged
  {
    private int l = 50;
    public int L
    {
      get
      {
        return l;
      }
      set
      {
        l = value;
        OnPropertyChanged("L");
        OnPropertyChanged("LStr");
      }
    }

    private int c = 50;
    public int C
    {
      get
      {
        return c;
      }
      set
      {
        c = value;
        OnPropertyChanged("C");
        OnPropertyChanged("CStr");
      }
    }

    private int r = 50;
    public int R
    {
      get
      {
        return r;
      }
      set
      {
        r = value;
        OnPropertyChanged("R");
        OnPropertyChanged("RStr");
      }
    }

    private int fr = 50;
    public int FR
    {
      get
      {
        return fr;
      }
      set
      {
        fr = value;
        OnPropertyChanged("FR");
        OnPropertyChanged("FRStr");
      }
    }

    private int fl = 50;
    public int FL
    {
      get
      {
        return fl;
      }
      set
      {
        fl = value;
        OnPropertyChanged("FL");
        OnPropertyChanged("FLStr");
      }
    }

    public string LStr
    {
      get
      {
        return $"{L}%";
      }
    }

    public string CStr
    {
      get
      {
        return $"{c}%";
      }
    }

    public string RStr
    {
      get
      {
        return $"{R}%";
      }
    }

    public string FLStr
    {
      get
      {
        return $"{FL}%";
      }
    }

    public string FRStr
    {
      get
      {
        return $"{FR}%";
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string name)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
  }
}
