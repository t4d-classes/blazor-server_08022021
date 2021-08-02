using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Features.CodeGenerators.PartialMethods
{
  public partial class Person
  {

    //partial void buildFullName()
    //{
    //  _fullName = LastName + ", " + FirstName;
    //}

    // this is what code generator would implement
    public partial string GetFullName()
    {
      return FirstName + " " + LastName;
    }
  }
}
