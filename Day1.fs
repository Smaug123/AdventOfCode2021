namespace AdventOfCode

open AdventOfCode.Internals

[<RequireQualifiedAccess>]
module Day1 =

    let part1 () =
        Utils.readResource "Day1.txt"
        |> Seq.map int
        |> Seq.pairwise
        |> Seq.filter (fun (a, b) -> a < b)
        |> Seq.length
        
    let part2 () =
        Utils.readResource "Day1.txt"
        |> Seq.map int
        |> Seq.windowed 4
        |> Seq.filter (fun arr -> arr.[0] < arr.[3])
        |> Seq.length
