package utils

// oddCells
// ##################################### //
//       1252. 奇数值单元格的数目        //
// ##################################### //
func OddCells(m int, n int, indices [][]int) int {
	x := make([]int, m) // 表示行
	y := make([]int, n) // 表示列
	// 遍历数据源 : 只会是2维数组，所以直接判定0是行，1是列
	for _, v := range indices {
		x[v[0]]++ // 对应行+1
		y[v[1]]++ // 对应列+1
	}
	count := 0
	for _, a := range x { // 循环行
		for _, b := range y { // 循环列
			count += (a + b) % 2 // 行值+列值 判定是否为奇数 奇数=1 偶数=0
		}
	}
	return count
}
