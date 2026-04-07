# Class Zoo: A Demonstration of Object Oriented Programming

### Information

This is a demonstration of object oriented programming using a few features.

Right now, there are Java, C#, VB.NET and C++ implementations. However, in the future, I plan on adding other object-oriented languages so you can see the difference between how the same program is implemented in different languages.

Other languages may be added if I feel like doing so.

I learned a lot about how each programming language implements object-oriented programming. For example, I learned that while Java uses the super() keyword, C# requires base() to be called manually, and C++ has a concept called object slicing, which means that you need to use something like a smart pointer to store the objects into an `std::vector`. Both C# and C++ also use the `virtual` keyword. I also learned a lot about using `std::move` in C++ to transfer ownership of smart pointers.

### How to build

The Java implementation is implemented with Eclipse and targets Java 21.

The C# and VB.NET implementations require .NET 10 or later. To compile, type `dotnet run` on the command line. It should open on Visual Studio, however this is not tested yet.

The C++ implementation is tested on Clang++. Use make build to build it. Requires a C++20 compiler or better.

### License

This is licensed under the MIT license.