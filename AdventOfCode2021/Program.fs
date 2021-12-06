namespace AdventOfCode

module Program =
    [<EntryPoint>]
    let main (argv : string []) : int =
        match argv.[0] with
        | "1" ->
            printfn $"{Day1.part1 ()}"
            printfn $"{Day1.part2 ()}"
        | "6" ->
            printfn $"{Day6.part1 ()}"
            printfn $"{Day6.part2 ()}"
        | s -> failwithf $"Unexpected argument: %s{s}"

        0
