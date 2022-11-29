package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := isIsomorphic("egg", "add")

	assert.Equal(t, true, actual)
}

func Test2(t *testing.T) {
	actual := isIsomorphic("foo", "bar")

	assert.Equal(t, false, actual)
}

func Test3(t *testing.T) {
	actual := isIsomorphic("paper", "title")

	assert.Equal(t, true, actual)
}
