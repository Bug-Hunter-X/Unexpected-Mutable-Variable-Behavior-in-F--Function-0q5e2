let x = 10
let y = 20

let add x y = 
    let sum = x + y
    (sum, y)

let (result, y) = add x y
printf "%d %d" x result