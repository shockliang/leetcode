package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := containsDuplicate([]int{1, 2, 3, 1})

	assert.True(t, actual)
}

func Test2(t *testing.T) {
	actual := containsDuplicate([]int{1, 2, 3, 4})

	assert.False(t, actual)
}

func Test3(t *testing.T) {
	actual := containsDuplicate([]int{1, 1, 1, 3, 3, 4, 3, 2, 4, 2})

	assert.True(t, actual)
}
