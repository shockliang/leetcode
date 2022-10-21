package main

import "fmt"

func main() {
	nums := []int{3, 2, 3}
	target := 6
	result := twoSum(nums, target)
	fmt.Println(result)
}

func twoSum(nums []int, target int) []int {
	for i := 0; i < len(nums); i++ {
		for j := 0; j < len(nums); j++ {
			if i == j {
				continue
			}
			if nums[i]+nums[j] == target {
				//indexes := make([]int, 2)
				indexes := []int{i, j}
				return indexes
			}
		}
	}
	return make([]int, 0)
}

