# Discussion chapter 2
# Week 2 - we were in chaper two
     
## Overview


   # in the last week we discussed: clearing textbox and label controls

    we can clear three ways
    -first way: using clear function
    -second way: assigning empty string. " ";
    -third way: using string.empty;

    note : you can use all of these ways at the textbox control, but in the label control you can not use clear() function. you can use other two ways remained.

  # The following screenshot shows how we can clear textbox in C#. 

![clearing textbox](<screanshots/Clearing textboxes.png>)

    -this screanshot shows clearing textbox using clear()function only. but you can use other two ways if you want.

  # The following screenshot shows how we can clear label control in C#. 

![clearing label](<screanshots/Clearing label control.png>)

    -this screanshot shows clearing label control, but note in c# you cant use clear() function, only you can use two other ways.



  #  also,we discussed this concept: exiting form

  when you want to exit the from you can use this method.
  this keyword plus .operator plus close() method

  -sytax:
  this.close();

 # The following screenshot shows how we can close the form in C#.

 ![close form](<screanshots/Exit form.png>)


   # also,we discussed this concept: datatypes & their types

    primitive data types are claasified in three categories

    -integral types: byte,short,int,long etc
    -floating point types: float,double,decimal
    -other basic types:char,boolean,string

  also, non primitive data types are classified in three types
        -collections: array,list,dictionary
        -user defined types: class,interface,struct
        -special types: objects,dynamic,var,delagte


  # also we discussed this concept: Assignment Ccompatibility
    
    -string= only accept string
    -int= only accept integer
    -double = accept int, and double
    -decimal= accept int, and decimal

 .compiler makes automatic conversion, it happens as implicity.
 . if you add num at the end that means that number is decimal
 for xexample:
 ------------
 650m --this means decimal datatype.

 # also,we discussed this concept:  Explicit conversion

 c# allows you to explicity convert among types which is known as "type casting". 
 like this : int=decimal -- we use : cast operator();

 # example type casting
 int wholenumber;
 decimal money=4500m;
 wholenumber = money ;
 wholenumber= (int)money;

  # parse methods
  converts string to numeric data type,
  also used cast operator

  -syntax:
  datatype.parse().
  .when you make changing datatypes you must use same datatype.

  # The following screenshot shows how we can make explicit conversion in C#.

  ![Explicit conversion](<screanshots/Explicit conversion.png>)


  All of those concepts were discussed last week which was our second week at the university



  


