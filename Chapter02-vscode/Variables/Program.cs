﻿using System.Xml;

object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} meteres tall.");
// int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.\n");

// storing a string in a dynamic object
// string has a Length property
dynamic something = "Ahmed";
// int does not have a Length property
something = 12;
// an array of any type has a Length property
something = new[] { 3, 5, 7 };
// Add a statement to output the length of the dynamic variable, as shown in the following code:  

// this compiles but would throw an exception at run-time
// if you later store a data type that does not have a
// property named Length
Console.WriteLine($"Length is {something.Length}.\n");

var population = 66_000_000; // 66 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // Booleans have value of true or false

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument(); 
XmlDocument xml2 = new XmlDocument();
// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt"); 
StreamWriter file2 = File.CreateText("something2.txt");
Console.WriteLine();
Console.WriteLine($"default(int) = {default(int)}"); 
Console.WriteLine($"default(bool) = {default(bool)}"); 
Console.WriteLine($"default(DateTime) = {default(DateTime)}"); 
Console.WriteLine($"default(string) = {default(string)}");
Console.WriteLine();

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");
Console.WriteLine();

string[] names; // can reference any size array of strings
// allocating memory for four strings in an array
names = new string[4];
// storing items at index positions
names[0] = "Kate";
names[1] = "Jack"; 
names[2] = "Rebecca"; 
names[3] = "Tom";
// looping through the names
for (int i = 0; i < names.Length; i++)
{
  // output the item at index position i
  Console.WriteLine(names[i]);
}