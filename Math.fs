module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let N = uint64 n
  let rec operate N count=
    if N = 1UL then count
    elif N % 2UL = 0UL then
      operate (N / 2UL) (count + 1)
    else
      operate (3UL * N + 1UL) (count + 1)
  operate N 0