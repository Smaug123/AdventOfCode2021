namespace AdventOfCode

open System.Collections.Generic
open AdventOfCode.Internals

[<RequireQualifiedAccess>]
module Day6 =

    let input () =
        Utils.readResource "Day6.txt"
        |> List.exactlyOne
        |> fun s -> s.Split ','
        |> Array.map int
        |> Array.toList

    // The answer is defined by the following relation:
    // g(days) = (if days > 7 then g(days - 7) else 1) + (if days > 9 then g(days - 9) else 1)
    // where g is the number of fish given that the only existing fish is on day 0 of its cycle (that is, it's about
    // to spawn).

    /// Memoise an arbitrary recursive function, expressed in a form that takes an explicit
    /// `recurse` function argument.
    /// (I did this for fun.)
    let memoise (f : ('a -> 'b) -> 'a -> 'b) : 'a -> 'b =
        let d = Dictionary<'a, 'b> ()

        let rec answer (a : 'a) =
            match d.TryGetValue a with
            | false, _ ->
                let result = f answer a
                d.Add (a, result)
                result
            | true, v -> v

        f answer

    /// (If you don't want to memoise it, just don't!)
    let resolveUnmemoised (f : ('a -> 'b) -> 'a -> 'b) : 'a -> 'b =
        let rec answer a = f answer a
        f answer

    let g : int -> uint64 =
        let go (recurse : int -> uint64) (i : int) =
            if i > 9 then
                recurse (i - 9) + recurse (i - 7)
            elif i > 7 then
                recurse (i - 7) + 1UL
            else
                2UL

        memoise go

    let part1 () =
        input ()
        |> List.map (fun i -> g (80 - i))
        |> List.sum

    let part2 () =
        input ()
        |> List.map (fun i -> g (256 - i))
        |> List.sum
