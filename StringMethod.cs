using System;
namespace App1
{
  class StringMethod
{
  static void Main4(string[]args)
  {
    string fullName = "Abhay Raj Chauhan";
    string phoneNumber = "-6386088195";
    fullName  = fullName.ToLower();
    Console.WriteLine(fullName);
    Console.WriteLine(phoneNumber);
    fullName = fullName.ToUpper();
    Console.WriteLine(fullName);
//REPLACE METHOD
    phoneNumber = phoneNumber.Replace("-","+91-");
    Console.WriteLine(phoneNumber);
//INSERT METHOD
    string ProbableUserName = fullName.Insert(0,"@");
    Console.WriteLine("ProbableUserName: "+ProbableUserName);

    // fullName = fullName.Length();
    // Console.WriteLine("Full name length: "+ fullName);
//LENGTH PROPERTY
    Console.WriteLine("length of your fullname: "+fullName.Length);


    //SUBSTRING METHOD
    string actualUserName = ProbableUserName.Substring(0,6);
    Console.WriteLine("Actual userName: "+ actualUserName);






  }
}
}