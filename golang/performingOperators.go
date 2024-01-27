package main

import "fmt"

func main() {

	fmt.Println(reinitializePermutation(6))
}
func finalValueAfterOperations(operations []string) int {
	var count int = 0
	for i := 0; i < len(operations); i++ {
		if operations[i] == "X++" || operations[i] == "++X" {
			count++
		}
		if operations[i] == "--X" || operations[i] == "X--" {
			count--
		}
	}
	return count
}

func reinitializePermutation(n int) int {
	if n <= 2 {
		return 1
	}
	var perm = make([]int, n)
	var arr = make([]int, n)
	var count = 0
	for i := 0; i < n; i++ {
		perm[i] = i
		if i%2 == 0 {
			arr[i] = perm[i/2]
		} else {
			arr[i] = perm[n/2+(i-1)/2]
		}
	}

	for i := 0; i < n; i++ {
		if arr[i] != perm[i] {
			count++
		}
	}
	return count
}
