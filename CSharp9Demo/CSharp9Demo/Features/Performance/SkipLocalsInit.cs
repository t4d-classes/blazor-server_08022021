using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CSharp9Demo.Features.Performance
{
  public unsafe class SkipLocalsInitDemo
  {

    public void ZeroLocals()
    {
      int t;

      int* ptr1 = &t;

      Console.WriteLine(*ptr1);
    }

    [SkipLocalsInit]
    public void SkipZeroLocals()
    {
      int t;

      int* ptr1 = &t;

      Console.WriteLine(*ptr1);
    }

  }
}
