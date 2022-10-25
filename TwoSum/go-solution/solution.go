package solution

func twoSum(nums []int, target int) []int {
	numsMap := make(map[int]int)

	for i := 0; i < len(nums); i++ {
		complement := target - nums[i]

		if idx, ok := numsMap[complement]; ok {
			indexes := make([]int, 2)
			indexes[0] = idx
			indexes[1] = i
			return indexes
		}

		numsMap[nums[i]] = i
	}

	return make([]int, 0)
}
