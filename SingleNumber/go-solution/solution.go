package solution

func singleNumber(nums []int) int {
	mapping := make(map[int]int)

	for _, num := range nums {
		if _, ok := mapping[num]; ok {
			mapping[num]++
		} else {
			mapping[num] = 1
		}
	}

	singleNum := 0

	for k, v := range mapping {
		if v == 1 {
			singleNum = k
		}
	}

	return singleNum
}
