let add x y = 
    let x' = x + y
    let y' = y + x'
    (x', y')

let (x, y) = add 10 20
printf "%d %d" x y