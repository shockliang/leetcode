package solution

func pivotIndex(nums []int) int {
	sumToLeft := make([]int, len(nums))
	sumToRight := make([]int, len(nums))

	current := nums[0]
	sumToRight[0] = current
	for i := 1; i < len(nums); i++ {
		current += nums[i]
		sumToRight[i] = current
	}

	current = nums[len(nums)-1]
	sumToLeft[len(nums)-1] = current
	for i := len(nums) - 2; i >= 0; i-- {
		current += nums[i]
		sumToLeft[i] = current
	}

	for i := 0; i < len(nums); i++ {
		if sumToLeft[i] == sumToRight[i] {
			return i
		}
	}
	return -1
}
