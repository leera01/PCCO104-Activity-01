using System;

class Program {
  public static void Main (string[] args) {
    string firstName = "Ralph";
    string lastName = "Lee";
    int age = 18;
    Console.WriteLine ($"Hello World {firstName} {lastName} Age: {age}");
    Console.WriteLine ("Hello World " +  firstName + " " + lastName + " " + age);
  }
}