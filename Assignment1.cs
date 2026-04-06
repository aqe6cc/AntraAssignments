/* Question 1
What type would you choose for the following "numbers"?
A person's telephone number: string
A person's height: float or double
A person's age: int
A person's gender: enum or string
A person's salary: decimal
A book's ISBN: string
A book's price: decimal
A book's shipping weight: float or double
A country's population: long
The numbers of stars in the universe: double
The number of employees in each of the small or medium business in the United Kingdom: int */


/*Question 2
What are the difference between value type and reference type variables? What is boxing and unboxing?
Value types stores actual data, while Reference types stores memory address.
Value types are stacks, and Reference types are heaps.

As for boxing vs unboxing, boxing is setting a value to an object, and unboxing is setting an object to a value. */

/* Question 3
What is meant by the terms managed resource and unmanaged resource in .NET?
Managed is handled by .NET, while unmanaged is handled by OS resources.  */

/*
Question 4
What's the purpose of Garbage Collector in .NET?
Garbage collectors automatically frees unused memory, prevents memory leaks, and only handles managed memory.

*/

/* Controlling Flow and Converting Types

1. What happens when you divide an int variable by 0?
Error: Division by constant zero
2. What happens when you divide a double variable by 0?
Returns infinity
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
It becomes negative
4. What is the difference between x = y++; and x = ++y;?
y++ is used first before it increments, and ++y is increment first before using it.
5. What is the difference between break, continue, and return when used inside a loop
statement?
Break exits loop, continue skips current iteration, and return exits methods.
6. What are the three parts of a for statement and which of them are required?
In a for loop, it goes like this: for (init; condition; update). Only condition is required.
7. What is the difference between the = and == operators?
= is assignment, == is comparison
8. Does the following statement compile? for ( ; true; ) ;
It does, and it results in an infinite loop.
9. What does the underscore _ represent in a switch expression?
_ is a default case.
10. What interface must an object implement to be enumerated over by using the foreach
statement?
IEnumerable must be implemented. 
*/