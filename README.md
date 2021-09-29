# Protobuf

* Navigate to the protobuf from GitHub [`releases page`](https://github.com/protocolbuffers/protobuf/releases/latest) and download the `protoc-<VERSION>-win64.zip` for Windows, this includes a pre-built binary of the protoc tool, compiler etc.

* Extract it, place it in some folder like `C:\` and add the directory `C:\protoc-<VERSION>-win64\bin` to the path variable.

* Verify whether added properly to path variable or not by typing in command prompt - `protoc -help`

* Follow Google [tutorial](https://developers.google.com/protocol-buffers/docs/csharptutorial) for Protobuf using C#.

* Compile the .proto file to C# class
    >  protoc -I. --csharp_out=. ./addressbook.proto
    "This generates Addressbook.cs in the solution folder".

* To compile this code, we need to reference the [`Google.Protobuf`](https://www.nuget.org/packages/google.protobuf) assembly.
    > PM > Install-Package Google.Protobuf

* Add using directives to Program.cs for generated class form compiler (if namespace if different), and `Google.Protobuf`.
