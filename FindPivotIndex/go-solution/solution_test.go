package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	nums := []int{1, 7, 3, 6, 5, 6}
	actual := pivotIndex(nums)

	assert.Equal(t, 3, actual)
}
