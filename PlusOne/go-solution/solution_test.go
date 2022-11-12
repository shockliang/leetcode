package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := plusOne([]int{1, 2, 3})

	assert.Equal(t, []int{1, 2, 4}, actual)
}

func Test2(t *testing.T) {
	actual := plusOne([]int{4, 3, 2, 1})

	assert.Equal(t, []int{4, 3, 2, 2}, actual)
}

func Test3(t *testing.T) {
	actual := plusOne([]int{9})

	assert.Equal(t, []int{1, 0}, actual)
}

func Test4(t *testing.T) {
	actual := plusOne([]int{9, 9, 9, 9, 9})

	assert.Equal(t, []int{1, 0, 0, 0, 0, 0}, actual)
}

func Test5(t *testing.T) {
	actual := plusOne([]int{3, 2, 9, 9, 9})

	assert.Equal(t, []int{3, 3, 0, 0, 0}, actual)
}
