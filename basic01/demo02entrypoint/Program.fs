open System

let ask stu ``a question`` =
    printf "I ask %s: %s\n" stu ``a question``

let askJohn = ask "John"

// 变量可以看作特殊的函数，也就是常数函数，即不需要参数的函数
// 也就是下面这一行可以写作 let f = 1
let f x = 1

askJohn "How old are you?"
printfn $"{f 100}"
