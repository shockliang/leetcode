package solution

func containsDuplicate(nums []int) bool {
	numsMap := make(map[int]int)

	for i := 0; i < len(nums); i++ {
		_, exists := numsMap[nums[i]]
		if !exists {
			numsMap[nums[i]] = nums[i]
		} else {
			return true
		}
	}

	return false
}
