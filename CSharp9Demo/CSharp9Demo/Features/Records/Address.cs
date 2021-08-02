using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Demo.Features.Records
{
  public class Address
  {
    public string Street { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string ZipCode { get; init; }
  }
}
