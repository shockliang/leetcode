package solution

func twoSum(nums []int, target int) []int {
	numsMap := make(map[int]int)

	for i := 0; i < len(nums); i++ {
		numsMap[nums[i]] = i
	}

	for i := 0; i < len(nums); i++ {
		complement := target - nums[i]

		if idx, ok := numsMap[complement]; ok && idx != i {
			indexes := make([]int, 2)
			indexes[0] = i
			indexes[1] = idx
			return indexes
		}
	}

	return make([]int, 0)
}
