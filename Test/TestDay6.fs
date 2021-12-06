namespace AdventOfCode2021.Test

open AdventOfCode
open Xunit
open FsUnitTyped

module TestDay6 =

    [<Fact>]
    let ``Part 1`` () = Day6.part1 () |> shouldEqual 365131UL

    [<Fact>]
    let ``Part 2`` () =
        Day6.part2 () |> shouldEqual 1650309278600UL
