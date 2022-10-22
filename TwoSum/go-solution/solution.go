package solution

func twoSum(nums []int, target int) []int {
	for i := 0; i < len(nums); i++ {
		for j := 0; j < len(nums); j++ {
			if i == j {
				continue
			}
			if nums[i]+nums[j] == target {
				indexes := make([]int, 2)
				indexes[0] = i
				indexes[1] = j
				return indexes
			}
		}
	}
	return make([]int, 0)
}
