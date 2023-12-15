/* First c# problem. Pg.25 To initiliaze project, in search bar type >.Net: New Project => answer prompts and choose console
 app => dotnet run gets things to show up in your terminal. Another way to initiliaze is by = dotnet new Console -n /project name here/
  */

//int x = 12 * 30;
//System.Console.WriteLine(x);

/* Statements in C# exequite sequentially and are terminated by a semi-colon. Statement one shows an expression that is being computed and stored as the 
   integer value "x". Statement two uses the WriteLine method on a class called Console, which is defined in a namespace called System. It should prnt the
   variable x to a textbox on screen.
   */ 

  using System;
using System.Drawing;  //Import system namespace

//int x = 12 * 30;
//Console.WriteLine (x); //No need to call on system down here. 


/* Both answers come out to 360. The next question shows a series of statements surrounded by a pair of braces and is known
as a statement block. A method recieves input data from the caller by specifying perameters. Output data is sent back using
a designated return type. */

//Console.WriteLine (FeetToInches(30)); //360
//Console.WriteLine(FeetToInches(100)); //1200

/* int FeetToInches (int feet)
{
    int inches = feet * 12;
    return inches;
}
*/

/* the numbers 30 & 100 (also known as literals) are the arguments passed. As seen below, if the method doesn't recieve 
input, use empty parenthesis. If it doesn't return anything, use the void keyword. */

//SayHello();
/*
void SayHello()
{
    Console.WriteLine("Hello, world!");
}
*/

/* By convention, parameters, local variables, and private fields should be in camel case. All other identifiers should be
pascal (MyMethod) All reserved keywords include:
-abstract  -do  -in  -protected  -throw
-as  -double  -int  -public  -true
-base      -else  -interface  -readonly  -try
-bool  -enum  -internal  -record  -typeof
-break  -event  -is  -ref  -uint
-byte  -explicit  -lock  -return  -ulong
-case  -extern  -long  -sbyte  -unchecked
-catch  -false  -namespace  -sealed  -unsafe
-char  -finally  -new  -short  -ushort
-checked  -fixed  -null  -sizeof  -using
-class  -float  -object  -stackalloc  -virtual
-const  -for  -operator  -static  -void
-continue  -foreach  -out  -string  -volatile
-decimal  -goto  -override  -struct  -while
-default  -if  -params  -switch
-delegate  -implicit  -private  -this 

Reserved keywords can be used as identifiers if an @ symbol is in front of them. There are also contextal keywords that 
you can use as identifiers without the @ symbol.
-add  -dynamic  -join  -on  -value
-alias  -equals  -let  -or  -var
-and  -from  -managed  -orderby  -with
-ascending  -get  -nameof  -partial  -when
-async  -global  -nint  -remove  -where
-await  -group  -not  -selet  -yeild 
-by  -init  -notnull  -set
-descending  -into  -nuint  -unmanaged
*/


//string message = "Hello World";
/*
string upperMessage = message.ToUpper();
Console.WriteLine (upperMessage);

Makes all the letters uppercase */
/*
int x = 2022;
message = message + x.ToString();
Console.WriteLine(message);

Combines hello world and 2022 */

/*
bool simpleVar = false;
if (simpleVar)
  Console.WriteLine("This will not print");

int x = 5000;
bool lessThanAMile = x < 5280;
if (lessThanAMile)
  Console.WriteLine("This will print");
*/

// Custom types
/*
UnitConverter feetToInchesConverter = new UnitConverter (12);
UnitConverter milesToFeetConverter = new UnitConverter (5280);

Console.WriteLine(feetToInchesConverter.Convert(30));
Console.WriteLine(feetToInchesConverter.Convert(100));
Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));

public class UnitConverter
{
  int ratio;     //Field
  
  public UnitConverter (int unitRatio)  //Constructor
  {
    ratio = unitRatio;    
  }

  public int Convert (int unit)    //Method
  {
    return unit * ratio;
  }
}
*/
/* (PI) In my process of breaking down this problem before the explanation, I'm noticing several things. The main one being
the heirarchy in which the code is written. In Javascript, except for instances and imports, things are written in chronological
order so to speak. You write the logic for your function and then call it at the bottom. However, in C# I'm noticing the 
function/method is called first and then the logic follows underneath. Kind of throwing me for a loop but overall I like it.
Also super nice how it keeps track of the number of refernces you have throughout the page. Back to the problem at hand, 
we see a new class called UnitConverter being introduced on lines 102 & 103. The first one in feetToInchesConverter, where we 
are calling a new UnitCoverter class with the param literal 12. This stands for 12 inches in a foot. The next is milesToFeet
where similarly the literal is 5280 representing the 5280 feet in a mile. Diving into the logic, I see three main focal points:
the field, constructor, and method. I'm not quite sure what the field represents to be honest, or the constructor. The method
portion is what we're going to call in our code to initiate the process in our console. 

Book EXplanation =  "In this explanation our class definition appears in the same file as our top-level statements. This is 
legal-- as long as top level statements appear first-- and is acceptable when writing small test programs. With larger programs,
the standard is to put it in a seperate file such as 'unitCoverter.cs'.

    A type contains data members and function members. The data member of UnitConverter is the field called ratio. The 
    function members of the unitConverter are the Convert method and the UnitConverter's constructor. 

  Data is created by instantiating a type. The 'new' operator creates instances of a custom type. 
*/
/*
Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Duh");

Console.WriteLine (p1.Name);
Console.WriteLine(p2.Name);

Console.WriteLine (Panda.Population);

public class Panda
{
  public string Name;
  public static int Population;

  public Panda (string n)
  {
    Name = n;
    Population = Population + 1;
  }
}
*/
/* The public keyboard exposes members to other classes. IF the name field Panda was not marked as public, it could not be
accessed from an outside class. In OOP terms, the public members encapsulate the private members of a class, like a ring of
poor peasants protecting their king. 
*/
/*
class Program
{
  static void Main() //program entry point
  {
    int x = 12 * 30;
    Console.WriteLine (x);
  }
}
*/
/* If there are no top level statements, it looks for a static method called main. You can call main in any class, but there can only
be one Main (as it should be). Defining a main inside a class can be useful if you need to reach a private member of a particular class.

Types and Conversions
  int x + 12345;  int is a 32 bit integer
  long y = x;  Implicit conversion to 64-bit integer
  short z = (short)x;  Explicit conversion to 16-bit integer.

Explicit versions are required when one of the following is true:
  The compiler cannot garuntee that they will always succeed
  Info might be lost during conversion.

Value Types VS. Reference Types
  Value = most built in types as well as struct & enum
  Reference = all class, array, delegate, and interface types.
  Generic Type Params. 
  Pointer

    You can define a custom value type with the struct keyword.
      public struct Point { public int X; public int Y;}
         or
      public struct Point { public int X,Y; }
  */
/*
Point p1 = new Point();
p1.X = 7;

Point p2 = p1; // assignment causes copy
p1.X = 9;

Console.WriteLine (p1.X);
Console.WriteLine (p2.X); // Answer changes from 7, 7 to 9, 7
*/
/* Reference Types
  Reference types have two parts, an object and a refernce to that object. Here is the previous example rewritten as a class instead of
  a struct.
    public class Point { public int X, Y};
  
  Assigning a reference type variable copies the reference, not the object. This allows multiple variables to refer to the same object. 

Predefined Types
  Value Types
    Numeric
      -signed integer
      -unsigned integer
      -real number
    Logical (bool)
    Character (char)

  Reference Types
    String
    Object

  Numeric Types
    Integeral-Signed = 
    sbyte     SByte     8 bits  -2^7 to 2^7 -1
    short     Int16     16 bits   -2^15 to 2^15 -1
    int       Int32     32 bits   -2^31 to 2^31 -1
    long      Int64     64 bits -2^63 to 2^63 -1
    nint      IntPtr    32/64 bits

    Integeral-Unsigned =
    byte      Byte      8 bits    0 to 2^8-1
    ushort    UInt16    16        0 to 2^16-1
    uint      UInt32    32        0 to 2^32-1
    ulong     UInt64    64        0 to 2^64-1
    unint UIntPtr        32/64

    Real =
    float     single    F   32 bits +- (about 10^-45 to 10^38)
    double    double    D   64 bits +- (about 10^-324 to 10^308)
    decimal   Decimal   M   128 bits +- (about 10^-28 to 10^28)
    

  */






