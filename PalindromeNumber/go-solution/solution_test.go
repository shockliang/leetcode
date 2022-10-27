package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := isPalindrome(123)

	assert.False(t, actual)
}

func Test2(t *testing.T) {
	actual := isPalindrome(121)

	assert.True(t, actual)
}

func Test3(t *testing.T) {
	actual := isPalindrome(10)

	assert.False(t, actual)
}

func Test4(t *testing.T) {
	actual := isPalindrome(-123)

	assert.False(t, actual)
}

func Test5(t *testing.T) {
	actual := isPalindrome(12321)

	assert.True(t, actual)
}
