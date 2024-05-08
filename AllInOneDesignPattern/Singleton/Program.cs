// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");

var configurator = Configurator.CreateInstance();
configurator.Port = 8080;
var conf2 = Configurator.CreateInstance();
Console.WriteLine(conf2.Port);
Console.WriteLine(configurator.GetHashCode());
Console.WriteLine(conf2.GetHashCode());