// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
new DbFactoryCreator<MSSQLDbFactory>().ConnectAndExecute();
new DbFactoryCreator<OracleDbFactory>().ConnectAndExecute();