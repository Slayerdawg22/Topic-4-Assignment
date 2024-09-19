// See https://aka.ms/new-console-template for more information

//Raine DeVries

string name;
int age;
double rate;

string firstname;
string lastName;
int grade;
int idNumber;
double login;

double averge;
string name2;
int age2;

double num1;
double num2;   
double num3;

string item1;

string item2;


Console.WriteLine("Hey, What's your name?");
name =  Console.ReadLine();
Console.WriteLine("Your name is " + name + ", What a cool name!");
Console.WriteLine("How old are you?");
int.TryParse(Console.ReadLine(), out age);
Console.WriteLine("That's cool " + name + ", you're " + age + " years old");
Console.WriteLine("How much do you make " + name+"?");
double.TryParse(Console.ReadLine(), out rate);
Console.WriteLine(rate.ToString("C") + "! Hope thats per hour and not per year!");
Console.ReadLine();
Console.Clear();


Console.WriteLine("Hey what's your name?");
firstname = Console.ReadLine();
Console.WriteLine("What's your last name");
lastName = Console.ReadLine();
Console.WriteLine("What grade are you in?");
int.TryParse(Console.ReadLine(), out grade);
Console.WriteLine("What's your school ID");
int.TryParse(Console.ReadLine(),out idNumber);
Console.WriteLine("What's your login?");
double.TryParse(Console.ReadLine(), out login);
Console.WriteLine("What's you average?");
double.TryParse(Console.ReadLine(), out averge);
Console.WriteLine(firstname + lastName + grade + idNumber + login + averge);
Console.ReadLine();
Console.Clear();

Console.WriteLine("Hey, what's your name?");
name2 = Console.ReadLine();
Console.WriteLine("Hey " + name2 + " what's your age?");
int.TryParse(Console.ReadLine(), out age2);
Console.WriteLine("Did you know that in 5 years you will be " + (age2 + 5) + "? And 5 years ago you were " + (age2 - 5) + "?");
Console.ReadLine();
Console.Clear();



Console.WriteLine("I'm a calculator, give me numbers and ill do some math!");
num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Next number?");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Next number?");
num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1+num2+num3/ 3);
Console.ReadLine();
Console.Clear();






Console.WriteLine("Give me the name of an item");
item1 = Console.ReadLine();
Console.WriteLine("What's the price?");
double item1price = Convert.ToDouble(Console.ReadLine());
//item1price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give me another item");
item2 = Console.ReadLine();
Console.WriteLine("What's it's price?");
double item2price=Convert.ToDouble(Console.ReadLine());
//item2price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sales receipt");
Console.WriteLine();
Console.WriteLine("Item 1: " + item1);
Console.WriteLine("price: " + item1price.ToString("C"));
Console.WriteLine("Item 2: " + item2);
Console.WriteLine("price: " + item2price.ToString("C"));
Console.WriteLine("=============");
Console.WriteLine("Total: " + (item1price + item2price).ToString("C"));
Console.WriteLine("Discount (20%): " + ((item1price + item2price) * .2).ToString("C"));
Console.WriteLine("Subtotal: " + ((item1price + item2price) * 0.8).ToString("C"));
Console.WriteLine("Tax (13%): " + (item1price + item2price) * .13);
Console.WriteLine("=============");
Console.WriteLine("Total Owed: " + ((item1price + item2price) * 0.8) * 1.13);









