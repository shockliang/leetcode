package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	nums := []int{2, 7, 11, 15}
	target := 9
	actual := twoSum(nums, target)
	expect := []int{0, 1}
	assert.ElementsMatch(t, expect, actual)
}

func Test2(t *testing.T) {
	nums := []int{3, 2, 4}
	target := 6
	actual := twoSum(nums, target)
	expect := []int{1, 2}
	assert.ElementsMatch(t, expect, actual)
}

func Test3(t *testing.T) {
	nums := []int{3, 3}
	target := 6
	actual := twoSum(nums, target)
	expect := []int{0, 1}
	assert.ElementsMatch(t, expect, actual)
}

func Test4(t *testing.T) {
	nums := []int{3, 2, 3}
	target := 6
	actual := twoSum(nums, target)
	expect := []int{0, 2}
	assert.ElementsMatch(t, expect, actual)
}
