namespace AdventOfCode

open AdventOfCode.Internals

[<RequireQualifiedAccess>]
module Day7 =

    let input () =
        Utils.readResource "Day7.txt"
        |> List.exactlyOne
        |> fun s -> s.Split ','
        |> Array.map int
        |> Array.toList

    let minMax (input : 'a list) : 'a * 'a =
        input
        |> List.fold
            (fun (currMin, currMax) elt ->
                if elt < currMin then (elt, currMax)
                elif elt > currMax then (currMin, elt)
                else (currMin, currMax)
            )
            (List.head input, List.head input)

    let part1 () =
        let input = input ()
        let min, max = minMax input

        seq { min .. max }
        |> Seq.map (fun alignTo ->
            input
            |> List.map (fun elt -> abs (elt - alignTo))
            |> List.sum
        )
        |> Seq.min

    let inline triangle (i : int) : int = i * (i + 1) / 2

    let part2 () =
        let input = input ()
        let min, max = minMax input

        seq { min .. max }
        |> Seq.map (fun alignTo ->
            input
            |> List.map (fun elt -> abs (elt - alignTo) |> triangle)
            |> List.sum
        )
        |> Seq.min
