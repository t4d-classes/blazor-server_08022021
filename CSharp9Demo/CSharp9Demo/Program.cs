using System;
using System.Collections;

// ----------------------------------------------------------------------------------------------------------
// C# 9 Feature Demo 1: Top-Level Statements
// 
// No namespace, class or Main method are needed, almost like writing a script in JavaScript or Python
// Note: Using statements can be used to import namespaces if desired

// Console.WriteLine("Hello World!");


//using CSharp9Demo.Features.TypelessNewOperator;

////Person p = new Person() {
////  FirstName="Bob",
////  LastName="Smith",
////};

////var p;

////p = new Person()
////{
////  FirstName = "Bob",
////  LastName = "Smith",
////};

//Person p;

//p = new(new() {
//  Street="123 Oak Lane",
//  City="Mountain View",
//  State="CA",
//  ZipCode="12345" })
//{
//  FirstName = "Bob",
//  LastName = "Smith",
//};

//p.FirstName

//using CSharp9Demo.Features.TypelessNewOperator;
//Person p1 = new() { FirstName = "Bob", LastName = "Smith" };
//Person p2 = new() { FirstName = "Bob", LastName = "Smith" };

//using CSharp9Demo.Features.Records;

//Person p1 = new("Bob", "Smith");
//Person p2 = new("Bob", "Smith");

////Console.WriteLine(p1 == p2);
////Console.WriteLine(ReferenceEquals(p1, p2));

//var (fName, lName) = p1;

//Console.WriteLine(fName);
//Console.WriteLine(lName);



//Console.WriteLine(person.FirstName);

////person.FirstName = "Tim";

//Person p2 = person with {  FirstName="Tim" };

//Console.WriteLine(p2.FirstName);
//Console.WriteLine(p2.LastName);


//using CSharp9Demo.Features.Records;

//Address addr = new() {
//  Street = "123 Oak Lane",
//  City = "Santa Fe",
//  State = "NM",
//  ZipCode="12345",
//};

//addr.State = "MN";

//bool isLetter(char c)
//{
//  return c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
//}

//Console.WriteLine(isLetter('g'));
//Console.WriteLine(isLetter('1'));


////ArrayList items = new();
//ArrayList items = null;

//if (items is not null)
//{
//  Console.WriteLine("items is not null");
//} else {
//  Console.WriteLine("items is null");
//}


// ----------------------------------------------------------------------------------------------------------
// C# 9 Feature Demo 6: Performance and Interop

// New Native Types: nint and nunit

//nint num = 10;

//System.Console.WriteLine(num);

//// Max and Min are resolved at runtime because are the dependent upon the native values
//System.Console.WriteLine(nint.MaxValue);
//System.Console.WriteLine(nint.MinValue);

//nuint num2 = 10;

//System.Console.WriteLine(num2);

//// Max and Min are resolved at runtime because are the dependent upon the native values
//System.Console.WriteLine(nuint.MaxValue);
//System.Console.WriteLine(nuint.MinValue);

//// Max and Min are compile-time constants because they are the same across all platforms
//System.Console.WriteLine(int.MaxValue);
//System.Console.WriteLine(int.MinValue);


//using CSharp9Demo.Features.Performance;

//DemoContainer.RunDemo("2");


//using CSharp9Demo.Features.Performance;

//new SkipLocalsInitDemo().ZeroLocals();
//new SkipLocalsInitDemo().SkipZeroLocals();

//using CSharp9Demo.Features.CodeGenerators.PartialMethods;

//Person p = new() {
//  FirstName = "Bob",
//  LastName ="Smith",
//};

//Console.WriteLine(p.FullName);
//Console.WriteLine(p.GetFullName());

using CSharp9Demo.Features.CodeGenerators.ModuleInitializers;

Console.WriteLine(ModuleInitializerDemo.Text);




