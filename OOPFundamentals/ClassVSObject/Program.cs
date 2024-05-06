// See https://aka.ms/new-console-template for more information
using ClassVSObject;

Console.WriteLine("Hello, World!");

Product keyboard = new Product ();
keyboard.Name = "Logitech Bluetooth";
int number = 9;

Product mouse = keyboard;
mouse.Name = "MX 1";

Console.WriteLine(keyboard.Name);
/*             Logitech  Blue....    MX1  
 *                         +++         
 *                                   ++++
 * 
 */
