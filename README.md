# ClassyExtensions
Demonstration of Method Extension of C# Classes

C# supports "Method extension" -- a way that new functionality can be "lashed on" to an existing class without requiring the original class to be recompiled.  This simple projet illustrates that feature.


This project was built and run on a 64-bit Windows 10 Pro, with dotnet version 1.0.0-preview2-003131 and VisualStudo 2015 release 3.

Retrieve the source from GitHub: `git clone git@github.com:rstinejr/ClassyExtensions.git`

## Project Structure

Note that there are three separate C# projects:

* MyFooPoco: Class definition of class Foo, a POCO. Has field FooNum.
* MyExtensions: Extensions to Foo.  Adds method `PlusOne`.
* MyMain: A minimal console app that demonstrates Foo and extension method PlusOne.


## Build and Run

To build using VisualStudio, open solution file `MyExtensions.sln`.

To build using `dotnet`, within directories *MyFooPoco*, *MyExtensions*, and *MyMain*, in turn, 
execute `dotnet restore` and then `dotnet build`.  Each project should build with no errors or warnings.

To run the console app, execute `dotnet run` from directory *MyMain*.

