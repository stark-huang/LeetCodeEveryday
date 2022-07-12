package main

import (
	"fmt"
	"go-LeetCode/utils"
)

//["MagicDictionary", "buildDict", "search", "search", "search", "search", "search"]
//[[], [["hello","hallo","leetcode","judge"]], ["hello"], ["hallo"], ["hell"], ["leetcodd"], ["juage"]]
func main() {
	a := []int{0, 1}
	b := []int{1, 1}
	c := [][]int{a, b}
	fmt.Println(utils.OddCells(2, 3, c))

}
