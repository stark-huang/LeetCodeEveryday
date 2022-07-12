package utils

//实例化一个map 用于存储设置的源
type MagicDictionary struct {
	dictionary map[int][]string
}

// 初始化源长度
func Constructor() MagicDictionary {
	return MagicDictionary{
		dictionary: make(map[int][]string, 0),
	}
}

// 设置源数据
func (this *MagicDictionary) BuildDict(dictionary []string) {
	// 循环把入参根据长度分别放到对应的map中
	for _, v := range dictionary {
		this.dictionary[len(v)] = append(this.dictionary[len(v)], v)
	}
}

func (this *MagicDictionary) Search(searchWord string) bool {
	// 用于判断字符串中字符不同的个数
	count := 0
	// 获取入参的长度
	n := len(searchWord)
	// 根据长度获取数据源
	strList := this.dictionary[n]
	// 当长度为0时，认为源中没有一个字符串与入参相同
	if len(strList) < 1 {
		return false
	}
	// 循环源数据
	for _, str := range strList {
		// 每一个源数据都要把计数重置
		count = 0
		for k, v := range str {
			// 判断对应位数的字符串是否相同，不同则计数加1
			if v != int32(searchWord[k]) {
				count++
			}
			// 当计数大于1时则判断为false
			if count > 1 {
				break
			}
		}
		// 一个源字符串循环结束时，判断计数，计数为1则是满足条件
		if count == 1 {
			return true
		}
	}

	return false

}
