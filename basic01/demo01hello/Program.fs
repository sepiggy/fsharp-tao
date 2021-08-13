// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom = sprintf "from %s" whom

// 小孩票价3块，大人票价5块，求总价
let familyCost child adult =
    let result = child * 3 + adult * 5
    result

[<Measure>]
type 元

[<Measure>]
type 小孩

[<Measure>]
type 大人

let kidPrice = 3<元/小孩>
let adultPrice = 5<元/大人>

let familyCost2 (child: int<小孩>) (adult: int<大人>) =
    let result = kidPrice * child + adultPrice * adult
    result

[<EntryPoint>]
let main argv =
    let message: string = from "F#" // Call the function
    printfn "Hello world %s" message
    let cost = familyCost 2 2
    printfn $"total cost = {cost}"
    let cost2 = familyCost2 2<小孩> 2<大人>
    printfn $"total cost2 = {cost2}"
    0 // return an integer exit code
