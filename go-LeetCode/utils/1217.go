package utils

// MinCostToMoveChips
// ##################################### //
//            1217. 玩筹码                //
// ##################################### //
func MinCostToMoveChips(position []int) (count int) {
	dataMap := make(map[int]int, 0)
	for _, p := range position {
		dataMap[p%2]++
	}

	if dataMap[0] > dataMap[1] {
		count = dataMap[1]
	} else {
		count = dataMap[0]
	}
	return
}
