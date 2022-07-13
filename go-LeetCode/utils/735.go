package utils

// AsteroidCollision
// ##################################### //
//             735. 行星碰撞              //
// ##################################### //
func AsteroidCollision(asteroids []int) (res []int) {
	// 当入参行星长小于1时则直接返回
	if len(asteroids) < 1 {
		return asteroids
	}
	// 循环入参行星
	for _, v := range asteroids {
		b := true // 给定一个值是否添加到出参中
		// 当行星满足一下条件时进行处理
		// 1.行星为负值，负值需要往前移动，才会产生碰撞
		// 2.出参长度大于0，出参有值，才会产生碰撞
		// 3.出参第一个值大于0，才会产生碰撞
		for b && v < 0 && len(res) > 0 && res[len(res)-1] > 0 { // 用for确保当出参行星最后一位爆炸之后，与下一位进行比较
			// 当前行星与出参行星第一个值进行比价 ，-v表示把v变成正数
			b = res[len(res)-1] < -v
			if res[len(res)-1] <= -v {
				res = res[:len(res)-1]
			}
		}
		if b {
			res = append(res, v)
		}
	}
	return res
}
