package solution

import "math"

func titleToNumber(columnTitle string) int {
	max := 26
	mapping := make(map[uint8]float64)
	for i := 0; i < max; i++ {
		mapping[uint8(65+i)] = float64(i + 1)
	}

	var sum float64 = 0
	var pow float64 = 0
	for i := len(columnTitle) - 1; i >= 0; i-- {
		value := mapping[columnTitle[i]] * math.Pow(float64(max), pow)

		sum += value
		pow++
	}

	return int(sum)
}
