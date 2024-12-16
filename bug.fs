let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y <- y + x
    x + y

printf "%d %d" (add 10 20) (add 10 20)