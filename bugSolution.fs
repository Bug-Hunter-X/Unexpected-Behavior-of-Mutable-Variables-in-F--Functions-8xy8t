let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

let x2 = ref 10
let y2 = ref 20

//To fix this, you must pass the references by reference
let swap3 (x:byref<int>) (y:byref<int>) = 
    let temp = x
    x <- y
    y <- temp

swap3 &x2 &y2
printf "%d %d" !x2 !y2 // This will print 20 10