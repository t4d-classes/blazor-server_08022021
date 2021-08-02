using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Features.CodeGenerators.PartialMethods
{
  public partial class Person
  {
    private string _fullName;

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
      get
      {
        buildFullName();
        return _fullName;
      }
    }

    partial void buildFullName();

    public partial string GetFullName();
  }
}
