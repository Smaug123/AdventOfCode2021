namespace AdventOfCode2021.Test

open AdventOfCode
open Xunit
open FsUnitTyped

module TestDay1 =
    
    [<Fact>]
    let ``Part 1`` () =
        Day1.part1 ()
        |> shouldEqual 1766

    [<Fact>]
    let ``Part 2`` () =
        Day1.part2 ()
        |> shouldEqual 1797
