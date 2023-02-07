datatypes in c#
boolean
string
float
decimal
double

types in c#
value types- int,float,struct,enums,etc
reference types- interface, class,delegates,arrays,strings,etc

reference types can have null values but value cannot.
we use ? with value types to make them nullable
like-
int? a=null;
bool? b=null;

we want this nullable concept to deal with the problems where databases are also involved
like
if we want to allow nulll value to any variable or column in databse than we can use it there.

Null calescing operator
??
we can assign say default value or a variable that is null to a variable like
bool? a=Null;
bool b= a??0;

type conversion

implicit conversion

implicit conversion is done where there is no lose of information if the conversion is done
and also if there is no possibility of throwing an exception
like-
int i=100;
float f=i;
but in case of
float f=1.2;
int i=f;
cannot be done as there will be a lose of data

explicit converion

here in this case we use explicit conversion
float f=1.2;
int i=(int)f;
or 
int i=convert.ToInt32(f);

in case of string
string s="1100";
int i=int.Parse(s);

but in case of
string s="100cvg";
bool isconversionsuc=int.TryParse(s,out Result);

arrays

int[] num=new[int[10]];
num[0]=1;
num[1]=2;
...
...

comments
single line //
multiline /* comment*/
xml documentation comment ///

conditional statement syntax is same as c,c++
like
if(conditon){
    //statement
}
else if(condition){
    //statement
}
else{
    //statement
}

switch statement

switch(unerinput){
    case case_name:
     //statement
      break;
    case case_name2:
      //statement
      break;
    default:
     //statement  
}
 if we want to input integer
 int a=int.parse(conole.readine());

loops
while
while(condition)
{
    //statement
}

do while
do{
    //statement 
}
while(condition)
for
for(condition){
    //statement
}
for each
foreach(int i in collection){
    //statement
}

methods
 access_modifier return_type name(){
    //method body
 } 
 if we don't add static keyword to the method then that method is a instance 
 method and we have call it using instance of that class in which it is defined

 if the function is defined with static keyword like
 punlic static void fun(int num){
    //method
 }
 we can call directly using class name we don't have to call it using the instance 
like-
class_name.fun(parameter);


call by value
fun(parameter);
call by reference
fun(ref parameter);
ref keyword is used to specify that the function is callled by reference
ref keyword is also used with the function defintion

output parameter  
used
when we want to have more then one return value 
 we just have to add out keyword to the output parameter in the function def

 public static void fun(int a,int b, out int c,out int d){
    //method def
 }

parameter arrays
here we use params keyword to pass array as parameter
and when we pass some other parameter with the array we have to specify before array
parameter means array parameter should be the last one
public static void fun(int a,int b,params int[] arr){
   //method def 
}

namespaces 
used to organise the program
and provide assistance in avoiding name clashes
we can use the system designed namespaces as well as we can create one and use it same way
creating namespace
namespace project1{
    namespace teamA{
        class classA{
            //variables
            //methods
        }
    }
}

using project1.teamA
or
using a=project1.teamA//giving alias to namespace

----------------------------------

classes
class is a blue print of an object that 
consist of data and its behavior

constructor

it is a function with same name as class
but does not have return type 
it is used to initialise the object

destructor

it is also a function with same 
name as class with a tild~ sign before the name
it is used to destroy the objects

object creation for class customer
customer c1=new customer();

static member allocates memory once for all the instance created

lists 
list is one of the generic collection class present in system.collection.generic namespace
all the generic collections are atrongly typed
means if you specify a datatype of the list you cannot insert another datatype in that collection
you can only insert object of the same class

lists grow in size at run time but array cannot
list<data_type or class name> ls=new list<data_type or class name>(size)
data type can be any predefined or the user defined

example
list<int> ls= new list<int>(3);
list.add(1);
list.add(2);
list.add(3);
list.add(4); //this will not give error for pushing more item than size because list grow in size at run time

list are index based data structure soo excessing element becomes fast

ls.count is a property that gives total no of elements

ls.insert(index,object name);
if we want to insert at some specific location
ls.IndexOf(object name);
to get the index of any object inserted in a list collection

ls.contains(obj name) gives whether that obj is present or not
its return type is boolean

ls.Exists(condition)
if we want to ckeck if there exists a obj with certain or specified pattern or condition given then we use exists method

ls.find(condition or say lambda expression)
it check for an element based on the specified lambda expression and returns first found element

ls.findlast(lambda expression)
finds nd returns last found item

ls.findall(lambda expression)
finds and returns all the matching items from the list
ls.FindIndex(lambda expression,start,end) //start and end specifies  from where we want to start the search and where to stop
return the first matching element index
ls.FindLastIndex(lambda expression,start,end)
returns index of last matched element

how to convert array to list?

use ToList() like
list<type or class name> listName=arrayname.ToList();
AddRange() allows us to insert a range of items at the end of the list
GetRange(start,end) allows us to get a range of items from the list 
InsertRangestart,listname)allows us to add a range of item to the list with a specified index

RemoveRange(start,no of elements to remove) allows us to remove a range of items










