package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	strs := []string{"flower", "flow", "flight"}

	actual := longestCommonPrefix(strs)

	assert.Equal(t, "fl", actual)
}

func Test2(t *testing.T) {
	strs := []string{"dog", "racecar", "car"}

	actual := longestCommonPrefix(strs)

	assert.Equal(t, "", actual)
}

func Test3(t *testing.T) {
	strs := []string{"reflower", "flow", "flight"}

	actual := longestCommonPrefix(strs)

	assert.Equal(t, "", actual)
}
