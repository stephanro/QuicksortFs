module Quicksort

open Queue

let rec private partition (a : 'a array) (i : int) (p : int) : int =
    if i >= p then
        p
    else
        if a.[i] <= a.[p] then
            partition a (i+1) p
        else
            let i' : 'a = a.[i]
            a.[i] <- a.[p-1]
            a.[p-1] <- a.[p]
            a.[p] <- i'
            partition a i (p-1)


let rec private sort (a : 'a array) (q : (int * int) queue) : 'a array =
    match dequeue q with
    | (_, None) -> a
    | (q', Some (i, p)) ->
        if i >= p then
            sort a q'
        else
            let p' : int = partition a i p
            in q'
                |> enqueue (i, p'-1)
                |> enqueue (p'+1, p)
                |> sort a

let quicksort (a : 'a array) : 'a array =
    let q : (int * int) queue = Queue.init (0, Array.length a - 1)
    in sort a q
