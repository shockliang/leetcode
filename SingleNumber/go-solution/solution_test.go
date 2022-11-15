package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	nums := []int{2, 2, 1}
	actual := singleNumber(nums)

	assert.Equal(t, 1, actual)
}

func Test2(t *testing.T) {
	nums := []int{4, 1, 2, 1, 2}
	actual := singleNumber(nums)

	assert.Equal(t, 4, actual)
}

func Test3(t *testing.T) {
	nums := []int{1}
	actual := singleNumber(nums)

	assert.Equal(t, 1, actual)
}
