# TDDpractice_PrimeFactor
TDD practice example

Write a class named “PrimeFactors” that has one static method: generate.

The generate method takes an integer argument and returns a List. That list contains the prime factors in numerical sequence.

For example:
- 100 should return 2, 2, 5, 5
- 2 should return 2
- Smaller than 2 should return an empty list

TEST -> IMPLEMENT -> REFACTOR

Solution (TDD way):
	Test cases:
		- 1
		- 2
		- 3
		- 2, 2
		- 2, 3
		- 2, 2, 2
		- 3, 3
