// See https://aka.ms/new-console-template for more information
using SerializationDemo;

Console.WriteLine("Hello, World!");
BinarySerialization obj = new BinarySerialization();
obj.Serialization();
BinaryDeSerialization obj1 = new BinaryDeSerialization();
obj1.DeSerialization();