package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := isValid("()")

	assert.True(t, actual)
}

func Test2(t *testing.T) {
	actual := isValid("()[]{}")

	assert.True(t, actual)
}

func Test3(t *testing.T) {
	actual := isValid("(]")

	assert.False(t, actual)
}

func Test4(t *testing.T) {
	actual := isValid("(([{}]))")

	assert.True(t, actual)
}

func Test5(t *testing.T) {
	actual := isValid("([)]")

	assert.False(t, actual)
}

func Test6(t *testing.T) {
	actual := isValid("]")

	assert.False(t, actual)
}

func Test7(t *testing.T) {
	actual := isValid(")(){}")

	assert.False(t, actual)
}
