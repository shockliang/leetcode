package solution

import "strconv"

func hammingWeight(num uint32) int {
	binary := strconv.FormatUint(uint64(num), 2)

	count := 0
	for i := 0; i < len(binary); i++ {
		if binary[i] == '1' {
			count++
		}
	}

	return count
}
