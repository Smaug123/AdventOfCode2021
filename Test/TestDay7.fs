namespace AdventOfCode2021.Test

open AdventOfCode
open Xunit
open FsUnitTyped

module TestDay7 =

    [<Fact>]
    let ``Part 1`` () = Day7.part1 () |> shouldEqual 356992

    [<Fact>]
    let ``Part 2`` () = Day7.part2 () |> shouldEqual 101268110
