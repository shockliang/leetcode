package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := isPalindrome("A man, a plan, a canal: Panama")

	assert.True(t, actual)
}

func Test2(t *testing.T) {
	actual := isPalindrome("race a car")

	assert.False(t, actual)
}

func Test3(t *testing.T) {
	actual := isPalindrome(" ")

	assert.True(t, actual)
}

func Test4(t *testing.T) {
	actual := isPalindrome("ab@a")

	assert.True(t, actual)
}

func Test5(t *testing.T) {
	actual := isPalindrome("0P")

	assert.False(t, actual)
}
