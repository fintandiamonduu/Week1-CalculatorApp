//start of  code
////stores first of two number that will be added 
//int numberone = 83;
//store second number
//int numbertwo = 123;
//calling the result 
//int result = numberone + numbertwo; 
//Console.WriteLine("the combination of both numbers is " + result);

//input first num
Console.WriteLine("Type the first number followed by the eneter key");
int firstnumber = Convert.ToInt32(Console.ReadLine());
//input second num
Console.WriteLine("Type the second number followed by the eneter key");
int secondnumber = Convert.ToInt32(Console.ReadLine());
//calculation 
int result = firstnumber + secondnumber;
//output answer into console 
Console.WriteLine("adding {0} and {1} gets you {2}", firstnumber, secondnumber, result);