package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := titleToNumber("A")

	assert.Equal(t, 1, actual)
}

func Test2(t *testing.T) {
	actual := titleToNumber("AB")

	assert.Equal(t, 28, actual)
}

func Test3(t *testing.T) {
	actual := titleToNumber("ZY")

	assert.Equal(t, 701, actual)
}

func Test4(t *testing.T) {
	actual := titleToNumber("AZ")

	assert.Equal(t, 52, actual)
}

func Test5(t *testing.T) {
	actual := titleToNumber("FXSHRXW")

	assert.Equal(t, 2147483647, actual)
}
