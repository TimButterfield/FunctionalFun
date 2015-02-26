#load "Aggregate.fs"
open ProjectEuler

// Define your library scripting code here
module Problem1 = 
//    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//    Find the sum of all the multiples of 3 or 5 below 1000.
    
    //Answer 233168
    let foo = new ProjectEuler.Aggregate()
    let multiples = foo.multiplesOf(3, 5)