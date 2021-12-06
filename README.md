# Advent of Code 2021, in F#

I'm not promising to actually do this; my [main attempt](https://github.com/Smaug123/advent-of-code-2021) is in Rust.

These solutions are not designed for great speed (I wouldn't be using .NET if they were!).

A reasonable commit to grab a copy of this repo from is 71832bb0355c2afa5abc1d157b3c8f0cfc9f5f9d, which is in a fully usable state with Day 1 complete and tested.

# Development tips

There are pull request checks on this repo, enforcing [Fantomas](https://github.com/fsprojects/fantomas/)-compliant formatting.
After checking out the repo, you may wish to add a pre-push hook to ensure locally that formatting is complete, rather than having to wait for the CI checks to tell you that you haven't formatted your code.
Consider performing the following command to set this up in the repo:
```bash
git config core.hooksPath hooks/
```
Before your first push (but only once), you will need to install the [.NET local tools](https://docs.microsoft.com/en-us/dotnet/core/tools/local-tools-how-to-use) which form part of the pre-push hook:
```bash
dotnet tool restore
```
