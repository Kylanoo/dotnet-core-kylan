using System;
using dotnetkylan;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string>? strList = null;
new ArgumentNull().ThrowIfNull(strList);