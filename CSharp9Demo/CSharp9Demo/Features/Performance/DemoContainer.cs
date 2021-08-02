using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Features.Performance
{
  public unsafe class DemoContainer
  {
    public static void RunDemo(string version = "1")
    {
      var doIt = new Utils().GetDoIt(version);
      doIt();
    }
  }
}
