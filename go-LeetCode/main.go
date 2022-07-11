package main

import (
	"fmt"
	"go-LeetCode/utils"
)

//["MagicDictionary", "buildDict", "search", "search", "search", "search", "search"]
//[[], [["hello","hallo","leetcode","judge"]], ["hello"], ["hallo"], ["hell"], ["leetcodd"], ["juage"]]
func main() {
	magicDictionary := utils.Constructor()
	magicDictionary.BuildDict([]string{"hello", "hallo", "leetcode", "judge"})
	fmt.Println(magicDictionary.Search("juage"))     // 返回 False
	fmt.Println(magicDictionary.Search("hhllo"))     // 将第二个 'h' 替换为 'e' 可以匹配 "hello" ，所以返回 True
	fmt.Println(magicDictionary.Search("hell"))      // 返回 False
	fmt.Println(magicDictionary.Search("leetcoded")) // 返回 False
}
