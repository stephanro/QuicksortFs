module Tests

open Xunit


// Quicksort.partition has been made private
// [<Fact>]
// let ``Pivot moves to index 3`` () =
//     let a : int array = [| 5; 2; 3; 6; 1; 8; 4 |]
//     let p : int = Array.length a - 1
//     let expected : int = 3
//     let actual = Quicksort.partition a 0 p
//     Assert.Equal (expected, actual)

[<Fact>]
let ``Sort empty array`` () =
    let a : int array = [| |]
    let expected : int array = [| |]
    let actual : int array = Quicksort.quicksort a
    let condition : bool = expected = actual
    Assert.True (condition)

[<Fact>]
let ``Sort array with unique values`` () =
    let a : int array = [|5; 2; 3; 6; 1; 8; 4|]
    let expected : int array = Array.sort a
    let actual : int array = Quicksort.quicksort a
    let condition : bool = expected = actual
    Assert.True (condition)

[<Fact>]
let ``Sort array of values with multiple occurrences`` () =
    let a : int array = [|5; 2; 2; 6; 2; 8; 4; 8; 5; 1; 4; 5; 4|]
    let expected : int array = Array.sort a
    let actual : int array = Quicksort.quicksort a
    let condition : bool = expected = actual
    Assert.True (condition)
