package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := isPowerOfTwo(1)

	assert.Equal(t, true, actual)
}

func Test2(t *testing.T) {
	actual := isPowerOfTwo(16)

	assert.Equal(t, true, actual)
}

func Test3(t *testing.T) {
	actual := isPowerOfTwo(3)

	assert.Equal(t, false, actual)
}

func Test4(t *testing.T) {
	actual := isPowerOfTwo(52)

	assert.Equal(t, false, actual)
}

func Test5(t *testing.T) {
	actual := isPowerOfTwo(1073741825)

	assert.Equal(t, false, actual)
}

func Test6(t *testing.T) {
	actual := isPowerOfTwo(2147483646)

	assert.Equal(t, false, actual)
}

func Test7(t *testing.T) {
	actual := isPowerOfTwo(1073741824)

	assert.Equal(t, true, actual)
}

func Test8(t *testing.T) {
	actual := isPowerOfTwo(-16)

	assert.Equal(t, false, actual)
}
