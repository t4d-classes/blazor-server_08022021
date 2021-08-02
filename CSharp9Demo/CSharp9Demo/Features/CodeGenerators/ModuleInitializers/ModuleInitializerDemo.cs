using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Features.CodeGenerators.ModuleInitializers
{
  class ModuleInitializerDemo
  {
    public static string? Text { get; set; }

    [ModuleInitializer]
    public static void Init1()
    {
      Text += "Hello from Init1! ";
    }

    [ModuleInitializer]
    public static void Init2()
    {
      Text += "Hello from Init2! ";
    }
  }
}
