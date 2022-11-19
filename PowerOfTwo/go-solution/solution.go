package solution

func isPowerOfTwo(n int) bool {
	if n < 0 {
		return false
	}
	mapping := make(map[int]int)

	for i := 0; i < 31; i++ {
		key := 1 << i
		mapping[key] = i
	}

	_, ok := mapping[n]

	return ok
}
