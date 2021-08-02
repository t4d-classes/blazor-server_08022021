using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Features.Performance
{
  public unsafe class Utils
  {

    public static void DoIt1()
    {
      System.Console.WriteLine("did it one!");
    }

    public static void DoIt2()
    {
      System.Console.WriteLine("did it two!");
    }

    public delegate*<void> GetDoIt(string version = "1")
    {

      if (version == "1")
      {
        return &DoIt1;
      }
      else
      {
        return &DoIt2;
      }

    }
  }
}