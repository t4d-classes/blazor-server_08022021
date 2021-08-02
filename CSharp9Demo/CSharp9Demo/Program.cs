using System;
using System.Collections;

// ----------------------------------------------------------------------------------------------------------
// C# 9 Feature Demo 1: Top-Level Statements
// 
// No namespace, class or Main method are needed, almost like writing a script in JavaScript or Python
// Note: Using statements can be used to import namespaces if desired

// Console.WriteLine("Hello World!");

// ----------------------------------------------------------------------------------------------------------
// C# 9 Feature Demo 2: Typeless New Operator
//
// A number useful language features have been added to make working with types easier
//
// For example, the `new` operator can be used to create new instances based upon the type of the variable

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

// ----------------------------------------------------------------------------------------------------------
// C# 9 Feature Demo 3: Record Types

using CSharp9Demo.Features.Records;

Person p1 = new("Bob", "Smith");
Person p2 = new("Bob", "Smith");

//Person p1 = new() {
//  FirstName = "Bob",
//  LastName = "Smith",
//};

//Person p2 = new()
//{
//  FirstName = "Bob",
//  LastName = "Smith",
//};


System.Console.WriteLine(p1.FirstName);

// p1.FirstName = "Sally"; // by default, record properties are readonly

// different objects, but fields have the same values
// for fields that point to objects, only the object reference is compared
System.Console.WriteLine(p1 == p2);

// different object references
System.Console.WriteLine(ReferenceEquals(p1, p2)); // false

// create a new record with a copy of the field from p1 and a new value for FirstName
var p3 = p1 with { FirstName = "Sally" };

System.Console.WriteLine(p1 == p3); // false
System.Console.WriteLine(p1.LastName == p3.LastName); //  true

// deconstructing
var (fName, lName) = p3;

System.Console.WriteLine(fName);
System.Console.WriteLine(lName);

// ----------------------------------------------------------------------------------------------------------
// C# 9 Feature Demo 5: Pattern Matching Enhancements

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

// ----------------------------------------------------------------------------------------------------------
// C# 9 Feature Demo 7: Support for Code Generators
//

//using CSharp9Demo.Features.CodeGenerators.PartialMethods;

//Person p = new() {
//  FirstName = "Bob",
//  LastName ="Smith",
//};

//Console.WriteLine(p.FullName);
//Console.WriteLine(p.GetFullName());

//using CSharp9Demo.Features.CodeGenerators.ModuleInitializers;

//Console.WriteLine(ModuleInitializerDemo.Text);




