package utils

// LenLongestFibSubseq
// ##################################### //
//       873. 最长的斐波那契子序列的长        //
// ##################################### //
func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}

func LenLongestFibSubseq(arr []int) int {
	index := map[int]int{}
	for i := range arr {
		index[arr[i]] = i
	}

	n := len(arr)
	dp := make([][]int, n)
	for i := range dp {
		dp[i] = make([]int, n)
	}

	res := 0
	// 从TLE的DFS写法转写的DP解法
	for i := n - 1; i >= 0; i-- {
		for j := n - 1; j >= i+1; j-- {
			dp[i][j] = 2
			if idx, ok := index[arr[i]+arr[j]]; ok {
				dp[i][j] += dp[j][idx] - 1
			}
			res = max(res, dp[i][j])
		}
	}

	if res == 2 {
		return 0
	}

	return res
}
